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

        private void btnLoadCM_Click(object sender, EventArgs e)
        {
            this.ColumnContentManagement.Visible = true;

            using (var entities = new Entities.ConfigData())
            {
                var siteFolder = this.txtSitePath.Text;

                if (string.IsNullOrEmpty(siteFolder))
                    return;

                var list = entities.SiteConfigs.Where(s => s.SiteFolder == siteFolder).ToList();
                if (list == null || list.Count == 0) //load intial 
                {
                    var standards = entities.Standard826_827.Where(s => s.FilePath != @"\website\");

                    foreach(var s in standards)
                    {
                        SiteConfigs site = new SiteConfigs();
                        site.ProductName = s.ProductName;
                        site.FilePath = s.FilePath;
                        site.CM_And_Processing = s.CM_And_Processing;
                        site.ConfigFileName = s.ConfigFileName;
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
                
         
                foreach (var config in list)
                {
                    string fileName = GetConfigFileFullName(config, siteFolder);

                    if (!File.Exists(fileName))
                    {
                        config.StatusInSite = "Different";

                        if (config.SearchProviderUsed == "Lucene is used" || config.SearchProviderUsed == "Azure is used")
                            config.IsVerified = true;
                    }
                    else
                    {
                        config.StatusInSite = "Same";
                        config.IsVerified = true;
                    }
                }

                this.dgSiteConfig.AutoGenerateColumns = false;
                this.dgSiteConfig.DataSource = list;

            }
        }

        private void btnLoadFileInSite_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var siteFolder = this.txtSitePath.Text;
            if (string.IsNullOrEmpty(siteFolder))
                return;

            using (var entities = new Entities.ConfigData())
            {
                var allFilesInSite = FileExtension.GetFiles(siteFolder + @"\website\App_Config\");

                var list = entities.SiteConfigs.Where(s => s.SiteFolder == siteFolder).ToList();
                foreach(var s in list)
                {
                    string fileName = GetConfigFileFullName(s, siteFolder);

                    string fileToSearch = fileName.RemoveFileExtension();

                    var fileList = allFilesInSite.Where(f => f.StartsWith(fileToSearch, StringComparison.InvariantCultureIgnoreCase)).ToList();

                    if (fileList.Count() > 1)
                    {
                        s.HasMultipleFileInSite = true;
                    }
                    s.FileInSite = string.Join(", ", fileList);
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

    }
}
