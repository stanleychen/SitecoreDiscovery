namespace ConfigComparison
{
    partial class userControlStandardCM
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgSiteConfig = new System.Windows.Forms.DataGridView();
            this.btnInitCM = new System.Windows.Forms.Button();
            this.btnUpdateFileInSite = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.checkBoxHideVerified = new System.Windows.Forms.CheckBox();
            this.txtSitePath = new System.Windows.Forms.TextBox();
            this.btnLoadCM = new System.Windows.Forms.Button();
            this.lblSiteConfigPath = new System.Windows.Forms.Label();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgSiteConfig)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSiteConfig
            // 
            this.dgSiteConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSiteConfig.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgSiteConfig.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSiteConfig.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSiteConfig.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgSiteConfig.Location = new System.Drawing.Point(12, 84);
            this.dgSiteConfig.Name = "dgSiteConfig";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSiteConfig.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSiteConfig.Size = new System.Drawing.Size(1334, 521);
            this.dgSiteConfig.TabIndex = 4;
            // 
            // btnInitCM
            // 
            this.btnInitCM.Location = new System.Drawing.Point(634, 10);
            this.btnInitCM.Name = "btnInitCM";
            this.btnInitCM.Size = new System.Drawing.Size(91, 23);
            this.btnInitCM.TabIndex = 14;
            this.btnInitCM.Text = "Init CM";
            this.btnInitCM.UseVisualStyleBackColor = true;
            this.btnInitCM.Click += new System.EventHandler(this.btnInitCM_Click);
            // 
            // btnUpdateFileInSite
            // 
            this.btnUpdateFileInSite.Location = new System.Drawing.Point(748, 10);
            this.btnUpdateFileInSite.Name = "btnUpdateFileInSite";
            this.btnUpdateFileInSite.Size = new System.Drawing.Size(110, 23);
            this.btnUpdateFileInSite.TabIndex = 13;
            this.btnUpdateFileInSite.Text = "Update File In Site";
            this.btnUpdateFileInSite.UseVisualStyleBackColor = true;
            this.btnUpdateFileInSite.Click += new System.EventHandler(this.btnUpdateFileInSite_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(879, 9);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 23);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // checkBoxHideVerified
            // 
            this.checkBoxHideVerified.AutoSize = true;
            this.checkBoxHideVerified.Location = new System.Drawing.Point(144, 61);
            this.checkBoxHideVerified.Name = "checkBoxHideVerified";
            this.checkBoxHideVerified.Size = new System.Drawing.Size(86, 17);
            this.checkBoxHideVerified.TabIndex = 11;
            this.checkBoxHideVerified.Text = "Hide Verified";
            this.checkBoxHideVerified.UseVisualStyleBackColor = true;
            this.checkBoxHideVerified.CheckedChanged += new System.EventHandler(this.checkBoxHideVerified_CheckedChanged);
            // 
            // txtSitePath
            // 
            this.txtSitePath.Location = new System.Drawing.Point(98, 12);
            this.txtSitePath.Name = "txtSitePath";
            this.txtSitePath.Size = new System.Drawing.Size(402, 20);
            this.txtSitePath.TabIndex = 10;
            this.txtSitePath.Text = "D:\\ForestersSiteConfigs\\CMUAT";
            // 
            // btnLoadCM
            // 
            this.btnLoadCM.Location = new System.Drawing.Point(12, 55);
            this.btnLoadCM.Name = "btnLoadCM";
            this.btnLoadCM.Size = new System.Drawing.Size(96, 23);
            this.btnLoadCM.TabIndex = 8;
            this.btnLoadCM.Text = "Load CM";
            this.btnLoadCM.UseVisualStyleBackColor = true;
            this.btnLoadCM.Click += new System.EventHandler(this.btnLoadCM_Click);
            // 
            // lblSiteConfigPath
            // 
            this.lblSiteConfigPath.AutoSize = true;
            this.lblSiteConfigPath.Location = new System.Drawing.Point(9, 15);
            this.lblSiteConfigPath.Name = "lblSiteConfigPath";
            this.lblSiteConfigPath.Size = new System.Drawing.Size(83, 13);
            this.lblSiteConfigPath.TabIndex = 9;
            this.lblSiteConfigPath.Text = "Site Config Path";
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = false;
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
            this.ColumnFileInSite.Width = 600;
            // 
            // ColumnHasMultipleFileInSite
            // 
            this.ColumnHasMultipleFileInSite.DataPropertyName = "HasMultipleFileInSite";
            this.ColumnHasMultipleFileInSite.HeaderText = "MultiFile";
            this.ColumnHasMultipleFileInSite.Name = "ColumnHasMultipleFileInSite";
            this.ColumnHasMultipleFileInSite.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnHasMultipleFileInSite.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnHasMultipleFileInSite.Width = 60;
            // 
            // userControlStandardCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInitCM);
            this.Controls.Add(this.btnUpdateFileInSite);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkBoxHideVerified);
            this.Controls.Add(this.txtSitePath);
            this.Controls.Add(this.btnLoadCM);
            this.Controls.Add(this.lblSiteConfigPath);
            this.Controls.Add(this.dgSiteConfig);
            this.Name = "userControlStandardCM";
            this.Size = new System.Drawing.Size(1349, 621);
            this.Load += new System.EventHandler(this.userControlStandardCM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSiteConfig)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSiteConfig;
        private System.Windows.Forms.Button btnInitCM;
        private System.Windows.Forms.Button btnUpdateFileInSite;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox checkBoxHideVerified;
        private System.Windows.Forms.TextBox txtSitePath;
        private System.Windows.Forms.Button btnLoadCM;
        private System.Windows.Forms.Label lblSiteConfigPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
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
