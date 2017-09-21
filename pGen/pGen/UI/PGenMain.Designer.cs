namespace pGen
{
    partial class PGenMain
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
            this.txtGeneratedPassword = new System.Windows.Forms.TextBox();
            this.msPGen = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chkCapitalize = new System.Windows.Forms.CheckBox();
            this.cboNumberWords = new System.Windows.Forms.ComboBox();
            this.cboNumberDigits = new System.Windows.Forms.ComboBox();
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.lblNumberWords = new System.Windows.Forms.Label();
            this.lblNumberDigits = new System.Windows.Forms.Label();
            this.msPGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGeneratedPassword
            // 
            this.txtGeneratedPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneratedPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratedPassword.Location = new System.Drawing.Point(12, 42);
            this.txtGeneratedPassword.Name = "txtGeneratedPassword";
            this.txtGeneratedPassword.Size = new System.Drawing.Size(410, 32);
            this.txtGeneratedPassword.TabIndex = 0;
            // 
            // msPGen
            // 
            this.msPGen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.msPGen.Location = new System.Drawing.Point(0, 0);
            this.msPGen.Name = "msPGen";
            this.msPGen.Size = new System.Drawing.Size(434, 24);
            this.msPGen.TabIndex = 1;
            this.msPGen.Text = "stripMenu";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.SettingsToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.InfoToolStripMenuItem_Click);
            // 
            // chkCapitalize
            // 
            this.chkCapitalize.AutoSize = true;
            this.chkCapitalize.Location = new System.Drawing.Point(12, 135);
            this.chkCapitalize.Name = "chkCapitalize";
            this.chkCapitalize.Size = new System.Drawing.Size(71, 17);
            this.chkCapitalize.TabIndex = 2;
            this.chkCapitalize.Text = "Capitalize";
            this.chkCapitalize.UseVisualStyleBackColor = true;
            // 
            // cboNumberWords
            // 
            this.cboNumberWords.FormattingEnabled = true;
            this.cboNumberWords.Location = new System.Drawing.Point(12, 80);
            this.cboNumberWords.Name = "cboNumberWords";
            this.cboNumberWords.Size = new System.Drawing.Size(121, 21);
            this.cboNumberWords.TabIndex = 3;
            // 
            // cboNumberDigits
            // 
            this.cboNumberDigits.FormattingEnabled = true;
            this.cboNumberDigits.Location = new System.Drawing.Point(12, 108);
            this.cboNumberDigits.Name = "cboNumberDigits";
            this.cboNumberDigits.Size = new System.Drawing.Size(121, 21);
            this.cboNumberDigits.TabIndex = 4;
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(160, 189);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(115, 37);
            this.BtnGenerate.TabIndex = 5;
            this.BtnGenerate.Text = "Generate";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // lblNumberWords
            // 
            this.lblNumberWords.AutoSize = true;
            this.lblNumberWords.Location = new System.Drawing.Point(139, 84);
            this.lblNumberWords.Name = "lblNumberWords";
            this.lblNumberWords.Size = new System.Drawing.Size(87, 13);
            this.lblNumberWords.TabIndex = 6;
            this.lblNumberWords.Text = "Number of words";
            // 
            // lblNumberDigits
            // 
            this.lblNumberDigits.AutoSize = true;
            this.lblNumberDigits.Location = new System.Drawing.Point(139, 113);
            this.lblNumberDigits.Name = "lblNumberDigits";
            this.lblNumberDigits.Size = new System.Drawing.Size(83, 13);
            this.lblNumberDigits.TabIndex = 7;
            this.lblNumberDigits.Text = "Number of digits";
            // 
            // PGenMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.lblNumberDigits);
            this.Controls.Add(this.lblNumberWords);
            this.Controls.Add(this.BtnGenerate);
            this.Controls.Add(this.cboNumberDigits);
            this.Controls.Add(this.cboNumberWords);
            this.Controls.Add(this.chkCapitalize);
            this.Controls.Add(this.txtGeneratedPassword);
            this.Controls.Add(this.msPGen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msPGen;
            this.MaximizeBox = false;
            this.Name = "PGenMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PGen";
            this.msPGen.ResumeLayout(false);
            this.msPGen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtGeneratedPassword;
        private System.Windows.Forms.MenuStrip msPGen;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkCapitalize;
        private System.Windows.Forms.ComboBox cboNumberWords;
        private System.Windows.Forms.ComboBox cboNumberDigits;
        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Label lblNumberWords;
        private System.Windows.Forms.Label lblNumberDigits;
    }
}

