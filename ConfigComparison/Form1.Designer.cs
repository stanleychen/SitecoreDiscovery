namespace ConfigComparison
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadCM = new System.Windows.Forms.Button();
            this.lblSiteConfigPath = new System.Windows.Forms.Label();
            this.txtSitePath = new System.Windows.Forms.TextBox();
            this.dgSiteConfig = new System.Windows.Forms.DataGridView();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConfigFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSearchProviderUsed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContentDelivery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnContentManagement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProcessing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCM_And_Processing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReporting = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDifferentWithSite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.IsVerified = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColumnFileInSite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHasMultipleFileInSite = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabStandard = new System.Windows.Forms.TabPage();
            this.btnInitCM = new System.Windows.Forms.Button();
            this.btnUpdateFileInSite = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkBoxHideVerified = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgSiteConfig)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tabStandard.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadCM
            // 
            this.btnLoadCM.Location = new System.Drawing.Point(15, 48);
            this.btnLoadCM.Name = "btnLoadCM";
            this.btnLoadCM.Size = new System.Drawing.Size(96, 23);
            this.btnLoadCM.TabIndex = 0;
            this.btnLoadCM.Text = "Load CM";
            this.btnLoadCM.UseVisualStyleBackColor = true;
            this.btnLoadCM.Click += new System.EventHandler(this.btnLoadCM_Click);
            // 
            // lblSiteConfigPath
            // 
            this.lblSiteConfigPath.AutoSize = true;
            this.lblSiteConfigPath.Location = new System.Drawing.Point(12, 8);
            this.lblSiteConfigPath.Name = "lblSiteConfigPath";
            this.lblSiteConfigPath.Size = new System.Drawing.Size(83, 13);
            this.lblSiteConfigPath.TabIndex = 1;
            this.lblSiteConfigPath.Text = "Site Config Path";
            // 
            // txtSitePath
            // 
            this.txtSitePath.Location = new System.Drawing.Point(101, 5);
            this.txtSitePath.Name = "txtSitePath";
            this.txtSitePath.Size = new System.Drawing.Size(402, 20);
            this.txtSitePath.TabIndex = 2;
            this.txtSitePath.Text = "D:\\ForestersSiteConfigs\\CMUAT";
            // 
            // dgSiteConfig
            // 
            this.dgSiteConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgSiteConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSiteConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnProductName,
            this.ColumnFilePath,
            this.ColumnConfigFileName,
            this.ColumnType,
            this.ColumnSearchProviderUsed,
            this.ColumnContentDelivery,
            this.ColumnContentManagement,
            this.ColumnProcessing,
            this.ColumnCM_And_Processing,
            this.ColumnReporting,
            this.ColumnDifferentWithSite,
            this.IsVerified,
            this.ColumnFileInSite,
            this.ColumnHasMultipleFileInSite});
            this.dgSiteConfig.Location = new System.Drawing.Point(15, 77);
            this.dgSiteConfig.Name = "dgSiteConfig";
            this.dgSiteConfig.Size = new System.Drawing.Size(1146, 339);
            this.dgSiteConfig.TabIndex = 3;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.DataPropertyName = "ProductName";
            this.ColumnProductName.HeaderText = "ProductName";
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.Width = 150;
            // 
            // ColumnFilePath
            // 
            this.ColumnFilePath.DataPropertyName = "FilePath";
            this.ColumnFilePath.HeaderText = "FilePath";
            this.ColumnFilePath.Name = "ColumnFilePath";
            this.ColumnFilePath.Width = 250;
            // 
            // ColumnConfigFileName
            // 
            this.ColumnConfigFileName.DataPropertyName = "ConfigFileName";
            this.ColumnConfigFileName.HeaderText = "ConfigFileName";
            this.ColumnConfigFileName.Name = "ColumnConfigFileName";
            this.ColumnConfigFileName.Width = 400;
            // 
            // ColumnType
            // 
            this.ColumnType.DataPropertyName = "Type";
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.Width = 60;
            // 
            // ColumnSearchProviderUsed
            // 
            this.ColumnSearchProviderUsed.DataPropertyName = "SearchProviderUsed";
            this.ColumnSearchProviderUsed.HeaderText = "Search Provider";
            this.ColumnSearchProviderUsed.Name = "ColumnSearchProviderUsed";
            this.ColumnSearchProviderUsed.Width = 120;
            // 
            // ColumnContentDelivery
            // 
            this.ColumnContentDelivery.DataPropertyName = "ContentDelivery";
            this.ColumnContentDelivery.HeaderText = "CD";
            this.ColumnContentDelivery.Name = "ColumnContentDelivery";
            this.ColumnContentDelivery.Visible = false;
            // 
            // ColumnContentManagement
            // 
            this.ColumnContentManagement.DataPropertyName = "ContentManagement";
            this.ColumnContentManagement.HeaderText = "CM";
            this.ColumnContentManagement.Name = "ColumnContentManagement";
            this.ColumnContentManagement.Visible = false;
            this.ColumnContentManagement.Width = 60;
            // 
            // ColumnProcessing
            // 
            this.ColumnProcessing.DataPropertyName = "Processing";
            this.ColumnProcessing.HeaderText = "Processing";
            this.ColumnProcessing.Name = "ColumnProcessing";
            this.ColumnProcessing.Visible = false;
            // 
            // ColumnCM_And_Processing
            // 
            this.ColumnCM_And_Processing.DataPropertyName = "CM_And_Processing";
            this.ColumnCM_And_Processing.HeaderText = "CM+Processing";
            this.ColumnCM_And_Processing.Name = "ColumnCM_And_Processing";
            this.ColumnCM_And_Processing.Visible = false;
            // 
            // ColumnReporting
            // 
            this.ColumnReporting.DataPropertyName = "Reporting";
            this.ColumnReporting.HeaderText = "Reporting";
            this.ColumnReporting.Name = "ColumnReporting";
            this.ColumnReporting.Visible = false;
            // 
            // ColumnDifferentWithSite
            // 
            this.ColumnDifferentWithSite.DataPropertyName = "DifferentWithSite";
            this.ColumnDifferentWithSite.HeaderText = "Different";
            this.ColumnDifferentWithSite.Name = "ColumnDifferentWithSite";
            this.ColumnDifferentWithSite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnDifferentWithSite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnDifferentWithSite.Width = 60;
            // 
            // IsVerified
            // 
            this.IsVerified.DataPropertyName = "IsVerified";
            this.IsVerified.HeaderText = "IsVerified";
            this.IsVerified.Name = "IsVerified";
            this.IsVerified.Width = 60;
            // 
            // ColumnFileInSite
            // 
            this.ColumnFileInSite.DataPropertyName = "FileInSite";
            this.ColumnFileInSite.HeaderText = "FileInSite";
            this.ColumnFileInSite.Name = "ColumnFileInSite";
            this.ColumnFileInSite.Width = 500;
            // 
            // ColumnHasMultipleFileInSite
            // 
            this.ColumnHasMultipleFileInSite.DataPropertyName = "HasMultipleFileInSite";
            this.ColumnHasMultipleFileInSite.HeaderText = "Multi File";
            this.ColumnHasMultipleFileInSite.Name = "ColumnHasMultipleFileInSite";
            this.ColumnHasMultipleFileInSite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnHasMultipleFileInSite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStandard);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1177, 450);
            this.tabControl.TabIndex = 4;
            // 
            // tabStandard
            // 
            this.tabStandard.Controls.Add(this.btnInitCM);
            this.tabStandard.Controls.Add(this.btnUpdateFileInSite);
            this.tabStandard.Controls.Add(this.btnSave);
            this.tabStandard.Controls.Add(this.checkBoxHideVerified);
            this.tabStandard.Controls.Add(this.dgSiteConfig);
            this.tabStandard.Controls.Add(this.txtSitePath);
            this.tabStandard.Controls.Add(this.btnLoadCM);
            this.tabStandard.Controls.Add(this.lblSiteConfigPath);
            this.tabStandard.Location = new System.Drawing.Point(4, 22);
            this.tabStandard.Name = "tabStandard";
            this.tabStandard.Padding = new System.Windows.Forms.Padding(3);
            this.tabStandard.Size = new System.Drawing.Size(1169, 424);
            this.tabStandard.TabIndex = 0;
            this.tabStandard.Text = "Standard";
            this.tabStandard.UseVisualStyleBackColor = true;
            this.tabStandard.Click += new System.EventHandler(this.tabStandard_Click);
            // 
            // btnInitCM
            // 
            this.btnInitCM.Location = new System.Drawing.Point(776, 5);
            this.btnInitCM.Name = "btnInitCM";
            this.btnInitCM.Size = new System.Drawing.Size(91, 23);
            this.btnInitCM.TabIndex = 7;
            this.btnInitCM.Text = "Init CM";
            this.btnInitCM.UseVisualStyleBackColor = true;
            this.btnInitCM.Click += new System.EventHandler(this.btnInitCM_Click);
            // 
            // btnUpdateFileInSite
            // 
            this.btnUpdateFileInSite.Location = new System.Drawing.Point(890, 5);
            this.btnUpdateFileInSite.Name = "btnUpdateFileInSite";
            this.btnUpdateFileInSite.Size = new System.Drawing.Size(110, 23);
            this.btnUpdateFileInSite.TabIndex = 6;
            this.btnUpdateFileInSite.Text = "Update File In Site";
            this.btnUpdateFileInSite.UseVisualStyleBackColor = true;
            this.btnUpdateFileInSite.Click += new System.EventHandler(this.btnUpdateFileInSite_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1021, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // checkBoxHighVerified
            // 
            this.checkBoxHideVerified.AutoSize = true;
            this.checkBoxHideVerified.Location = new System.Drawing.Point(147, 54);
            this.checkBoxHideVerified.Name = "checkBoxHighVerified";
            this.checkBoxHideVerified.Size = new System.Drawing.Size(86, 17);
            this.checkBoxHideVerified.TabIndex = 4;
            this.checkBoxHideVerified.Text = "Hide Verified";
            this.checkBoxHideVerified.UseVisualStyleBackColor = true;
            this.checkBoxHideVerified.CheckedChanged += new System.EventHandler(this.checkBoxHighVerified_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Sitecore Configuration";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSiteConfig)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tabStandard.ResumeLayout(false);
            this.tabStandard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCM;
        private System.Windows.Forms.Label lblSiteConfigPath;
        private System.Windows.Forms.TextBox txtSitePath;
        private System.Windows.Forms.DataGridView dgSiteConfig;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStandard;
        private System.Windows.Forms.CheckBox checkBoxHideVerified;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdateFileInSite;
        private System.Windows.Forms.Button btnInitCM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConfigFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSearchProviderUsed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContentDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnContentManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProcessing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCM_And_Processing;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnReporting;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnDifferentWithSite;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsVerified;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileInSite;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColumnHasMultipleFileInSite;
    }
}

