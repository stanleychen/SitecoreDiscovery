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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabStandardCM = new System.Windows.Forms.TabPage();
            this.userControlStandardCM1 = new ConfigComparison.userControlStandardCM();
            this.tabControl.SuspendLayout();
            this.tabStandardCM.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabStandardCM);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1177, 450);
            this.tabControl.TabIndex = 4;
            // 
            // tabStandardCM
            // 
            this.tabStandardCM.Controls.Add(this.userControlStandardCM1);
            this.tabStandardCM.Location = new System.Drawing.Point(4, 22);
            this.tabStandardCM.Name = "tabStandardCM";
            this.tabStandardCM.Padding = new System.Windows.Forms.Padding(3);
            this.tabStandardCM.Size = new System.Drawing.Size(1169, 424);
            this.tabStandardCM.TabIndex = 0;
            this.tabStandardCM.Text = "Standard CM";
            this.tabStandardCM.UseVisualStyleBackColor = true;
            // 
            // userControlStandardCM1
            // 
            this.userControlStandardCM1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlStandardCM1.Location = new System.Drawing.Point(3, 3);
            this.userControlStandardCM1.Name = "userControlStandardCM1";
            this.userControlStandardCM1.Size = new System.Drawing.Size(1163, 418);
            this.userControlStandardCM1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 450);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Sitecore Configuration";
            this.tabControl.ResumeLayout(false);
            this.tabStandardCM.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabStandardCM;
        private userControlStandardCM userControlStandardCM1;
    }
}

