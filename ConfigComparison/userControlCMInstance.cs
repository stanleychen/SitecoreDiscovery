using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfigComparison.Entities;
using System.IO;
using ClosedXML.Excel;

using CsvHelper.Excel;
using CsvHelper;
using ConfigComparison.ViewModel;

namespace ConfigComparison
{
    public partial class userControlCMInstance : UserControl
    {
        public userControlCMInstance()
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

                var cmConfigs = entities.SiteConfigs.Where(s => s.SiteFolder == siteFolder).ToList();

                var files = FileExtension.GetFiles(siteFolder);

                var list = entities.SiteInstanceConfigs.Where(s => s.SiteFolder == siteFolder).ToList();
                if (list == null || list.Count == 0) //load intial 
                {
                    foreach(var file in files)
                    {
                        var config = new SiteInstanceConfigs();
                        config.Role = Constants.CM_ROLE;
                        config.SiteFolder = siteFolder;
                        config.ConfigFileFullName = file;

                        config.FilePath = file.Substring(siteFolder.Length, file.LastIndexOf(@"\") + 1 - siteFolder.Length);
                        config.ConfigFileName = file.Substring(file.LastIndexOf(@"\") + 1);

                        var cmConfig = cmConfigs.Where(c=>c.FileInSite.Equals(file,StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();

                        if(cmConfig != null)
                        {
                            config.ProductName = cmConfig.ProductName;
                        }

                        if (file.EndsWith(".config"))
                        {
                            if(cmConfig != null)
                            {
                                config.Type = "Standard Config";
                            }
                            else
                            {
                                config.Type = "Extended Config";
                            }
                        }
                        else
                        {
                            config.Type = "Disabled";
                        }
                      
                        list.Add(config);
                    }

                    var context = new Entities.ConfigData();
                    context.SiteInstanceConfigs.AddRange(list);
                    context.SaveChanges();
                }
                else
                {
                    if(files.Count() > list.Count())
                    {
                        foreach(var fileName in files)
                        {
                            var config = entities.SiteInstanceConfigs.Where(s => s.ConfigFileFullName == fileName).FirstOrDefault() ;
                            if(config == null)
                            {
                                using (var context = new Entities.ConfigData())
                                {
                                    var newConfig = new SiteInstanceConfigs();

                                    newConfig.Role = Constants.CM_ROLE;
                                    newConfig.SiteFolder = siteFolder;
                                    newConfig.ConfigFileFullName = fileName;
                                    newConfig.FilePath = fileName.Substring(siteFolder.Length, fileName.LastIndexOf(@"\") + 1 - siteFolder.Length);
                                    newConfig.ConfigFileName = fileName.Substring(fileName.LastIndexOf(@"\") + 1);

                                    var cmConfig = cmConfigs.Where(c => c.FileInSite.Equals(fileName, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();

                                    if (cmConfig != null)
                                    {
                                        config.ProductName = cmConfig.ProductName;
                                    }

                                    if (fileName.EndsWith(".config"))
                                    {
                                        if (cmConfig != null)
                                        {
                                            config.Type = "Standard Config";
                                        }
                                        else
                                        {
                                            config.Type = "Custom Config";
                                        }
                                    }
                                    else
                                    {
                                        config.Type = "Disabled";
                                    }

                                    context.SiteInstanceConfigs.Add(newConfig);
                                    context.SaveChanges();
                                }
                            }
                        }
                        
                    }
                }
                
            }


            this.LoadGrid();
        }


        #region Helper Method 

        private void LoadGrid()
        {
            var siteFolder = this.txtSitePath.Text;

            using (var entities = new ConfigData())
            {
                var data = entities.SiteInstanceConfigs.Where(s=>s.SiteFolder == siteFolder);

                if (this.chkHideDisabled.Checked)
                {
                    data = data.Where(d => d.Type != Constants.DISABLED);
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

                    //if (fileName.Contains("Sitecore.Commerce.ExperienceAnalytics.config"))
                    //    Console.Write(fileName);

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            var list = this.dgSiteConfig.DataSource as List<SiteConfigs>;

            if (list == null)
                return;

            using (var context = new ConfigData())
            {
                foreach (var row in list)
                {
                    var config = context.SiteConfigs.Where(s => s.ID == row.ID).FirstOrDefault();

                    if (config != null)
                        config.IsVerified = row.IsVerified;

                }

                context.SaveChanges();
            }

            this.LoadGrid();
        }

        private void btnLoadCM_Click(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void checkBoxHideVerified_CheckedChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }

        private void userControlStandardCM_Load(object sender, EventArgs e)
        {
            this.dgSiteConfig.AutoGenerateColumns = false;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            var list = this.dgSiteConfig.DataSource as List<SiteConfigs>;
            if (list == null)
                return;

            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var cmList = new List<CMConfig>();

                foreach (var s in list)
                {
                    cmList.Add(new CMConfig()
                    {
                        ProductName = s.ProductName,
                        ContentManagement = s.ContentManagement,
                        ConfigFileName = s.ConfigFileName,
                        FileInSite = s.FileInSite,
                        FilePath = s.FilePath,
                        SiteFolder = s.SiteFolder
                    });
                }

                string fileName = saveFileDialog.FileName;

                using (var workbook = new XLWorkbook(XLEventTracking.Disabled))
                {
                    // do stuff with the workbook
                  
                    using (var writer = new CsvWriter(new ExcelSerializer(workbook)))
                    {
                        writer.WriteRecords(cmList);
                    }
                    // do other stuff with workbook
                    workbook.SaveAs(fileName);
                }

            }
        }

        private void chkHideDisabled_CheckedChanged(object sender, EventArgs e)
        {
            this.LoadGrid();
        }
    }
}
