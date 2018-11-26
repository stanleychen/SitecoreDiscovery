namespace ConfigComparison
{
    partial class userControlCMInstance
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
            this.btnExport = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.ColumnConfigID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSiteFolder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSiteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConfigFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnConfigFileFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ColumnConfigID,
            this.ColumnSiteFolder,
            this.ColumnSiteName,
            this.ColumnProductName,
            this.ColumnFilePath,
            this.ColumnConfigFileName,
            this.ColumnType,
            this.ColumnConfigFileFullName});
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
            this.checkBoxHideVerified.Location = new System.Drawing.Point(12, 61);
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
            this.btnLoadCM.Location = new System.Drawing.Point(985, 9);
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
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(1106, 9);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "All files|*.*|Excel|*.xlsx|Csv|*.csv";
            // 
            // ColumnConfigID
            // 
            this.ColumnConfigID.DataPropertyName = "ConfigID";
            this.ColumnConfigID.HeaderText = "ConfigID";
            this.ColumnConfigID.Name = "ColumnConfigID";
            this.ColumnConfigID.Visible = false;
            // 
            // ColumnSiteFolder
            // 
            this.ColumnSiteFolder.DataPropertyName = "SiteFolder";
            this.ColumnSiteFolder.HeaderText = "SiteFolder";
            this.ColumnSiteFolder.Name = "ColumnSiteFolder";
            this.ColumnSiteFolder.Visible = false;
            this.ColumnSiteFolder.Width = 250;
            // 
            // ColumnSiteName
            // 
            this.ColumnSiteName.DataPropertyName = "Role";
            this.ColumnSiteName.HeaderText = "Role";
            this.ColumnSiteName.Name = "ColumnSiteName";
            this.ColumnSiteName.Visible = false;
            this.ColumnSiteName.Width = 150;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.DataPropertyName = "ProductName";
            this.ColumnProductName.HeaderText = "ProductName";
            this.ColumnProductName.Name = "ColumnProductName";
            // 
            // ColumnFilePath
            // 
            this.ColumnFilePath.DataPropertyName = "FilePath";
            this.ColumnFilePath.HeaderText = "FilePath";
            this.ColumnFilePath.Name = "ColumnFilePath";
            this.ColumnFilePath.Width = 200;
            // 
            // ColumnConfigFileName
            // 
            this.ColumnConfigFileName.DataPropertyName = "ConfigFileName";
            this.ColumnConfigFileName.HeaderText = "ConfigFileName";
            this.ColumnConfigFileName.Name = "ColumnConfigFileName";
            this.ColumnConfigFileName.Width = 200;
            // 
            // ColumnType
            // 
            this.ColumnType.DataPropertyName = "Type";
            this.ColumnType.HeaderText = "Type";
            this.ColumnType.Name = "ColumnType";
            // 
            // ColumnConfigFileFullName
            // 
            this.ColumnConfigFileFullName.DataPropertyName = "ConfigFileFullName";
            this.ColumnConfigFileFullName.HeaderText = "FullName";
            this.ColumnConfigFileFullName.Name = "ColumnConfigFileFullName";
            this.ColumnConfigFileFullName.Width = 500;
            // 
            // userControlCMInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnInitCM);
            this.Controls.Add(this.btnUpdateFileInSite);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.checkBoxHideVerified);
            this.Controls.Add(this.txtSitePath);
            this.Controls.Add(this.btnLoadCM);
            this.Controls.Add(this.lblSiteConfigPath);
            this.Controls.Add(this.dgSiteConfig);
            this.Name = "userControlCMInstance";
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
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConfigID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSiteFolder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSiteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConfigFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnConfigFileFullName;
    }
}
