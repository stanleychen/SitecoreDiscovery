using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using ConfigComparison.Entities;

namespace ConfigComparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInitCM_Click(object sender, EventArgs e)
        {
            var siteFolder = this.txtSitePath.Text;

            using (var entities = new Entities.ConfigData())
            {
                if (string.IsNullOrEmpty(siteFolder))
                    return;

                var list = entities.SiteConfigs.Where(s => s.SiteFolder == siteFolder).ToList();
                if (list == null || list.Count == 0) //load intial 
                {
                    var standards = entities.Standard826_827.Where(s => s.FilePath != @"\website\");

                    foreach (var s in standards)
                    {
                        SiteConfigs site = new SiteConfigs();
                        site.ProductName = s.ProductName;
                        site.FilePath = s.FilePath;
                        site.CM_And_Processing = s.CM_And_Processing;

                        var configFileName = s.ConfigFileName;

                        if(s.SearchProviderUsed == "Solr is used" && s.ContentManagement == "Enable")
                        {
                            if(configFileName.EndsWith(".example"))
                            {
                                configFileName = configFileName.Substring(0, configFileName.LastIndexOf(".example"));
                            }

                            if(configFileName.EndsWith(".disabled"))
                            {
                                configFileName = configFileName.Substring(0, configFileName.LastIndexOf(".disabled"));
                            }

                        }

                        site.ConfigFileName = configFileName;
                        site.ContentDelivery = s.ContentDelivery;
                        site.ContentManagement = s.ContentManagement;
                        site.Processing = s.Processing;
                        site.Reporting = s.Reporting;
                        site.SearchProviderUsed = s.SearchProviderUsed;
                        site.Type = s.Type;
                        site.SiteFolder = this.txtSitePath.Text;

                        list.Add(site);
                    }

                    var context = new Entities.ConfigData();
                    context.SiteConfigs.AddRange(list);
                    context.SaveChanges();

                }
            }
           

            this.LoadCMGrid();
        }


        private void btnLoadCM_Click(object sender, EventArgs e)
        {

            this.LoadCMGrid();
        }

        private void btnUpdateFileInSite_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var siteFolder = this.txtSitePath.Text;
            if (string.IsNullOrEmpty(siteFolder))
                return;

            using (var context = new ConfigData())
            {
                foreach (var config in context.SiteConfigs)
                {
                    #region Keep this in Last
                    string fileName = GetConfigFileFullName(config, siteFolder);

                    if (!File.Exists(fileName))
                    {
                        config.DifferentWithSite = true;

                        if (config.SearchProviderUsed == "Lucene is used" || config.SearchProviderUsed == "Azure is used")
                            config.IsVerified = true;

                    }
                    else
                    {
                        config.DifferentWithSite = false;
                        config.IsVerified = true;
                    }

                    #endregion

                }
                context.SaveChanges();
            }

            using (var entities = new Entities.ConfigData())
            {
                var allFilesInSite = FileExtension.GetFiles(siteFolder + @"\website\App_Config\");

                var list = entities.SiteConfigs.Where(s => s.SiteFolder == siteFolder).ToList();
                foreach (var s in list)
                {
                    string fileName = GetConfigFileFullName(s, siteFolder);

                    string fileToSearch = fileName;
                    if (s.DifferentWithSite)
                    {
                        fileToSearch = fileToSearch.RemoveFileExtension();
                        var fileList = allFilesInSite.Where(f => f.StartsWith(fileToSearch, StringComparison.InvariantCultureIgnoreCase)).ToList();
                        if (fileList.Count() > 1)
                        {
                            s.HasMultipleFileInSite = true;
                        }
                        s.FileInSite = string.Join(", ", fileList);
                    }
                    else
                    {
                        s.FileInSite = allFilesInSite.Where(f => f.Equals(fileToSearch, StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
                    }

                }

                entities.SaveChanges();
            }

            this.Cursor = Cursors.Default;

            MessageBox.Show("Done");
        }

        private void tabStandard_Click(object sender, EventArgs e)
        {

        }


        #region Helper Method 

        private void LoadCMGrid()
        {
            this.ColumnContentManagement.Visible = true;
            var siteFolder = this.txtSitePath.Text;

            using (var entities = new ConfigData())
            {
                var data = entities.SiteConfigs.Where(s => s.SiteFolder == siteFolder);

                if(this.checkBoxHideVerified.Checked)
                {
                    data = data.Where(s => s.IsVerified == false);
                }
                this.dgSiteConfig.DataSource = data.ToList();

            }
        }
    
        private string GetConfigFileFullName(SiteConfigs config, string siteFolder)
        {
            var fileName = string.Format("{0}{1}", siteFolder, config.FilePath);

            if (fileName.EndsWith(@"\"))
                fileName = fileName + config.ConfigFileName;
            else
                fileName = fileName + @"\" + config.ConfigFileName;

            return fileName;

        }

        #endregion

  
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgSiteConfig.AutoGenerateColumns = false;
        }

        private void checkBoxHighVerified_CheckedChanged(object sender, EventArgs e)
        {
            this.LoadCMGrid();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var list = this.dgSiteConfig.DataSource;
        }
    }
}
