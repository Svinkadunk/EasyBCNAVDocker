namespace EasyBCNAVDocker
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.btnCreateContainer = new System.Windows.Forms.Button();
            this.cbImageSelector = new System.Windows.Forms.ComboBox();
            this.cbLocalization = new System.Windows.Forms.ComboBox();
            this.cbVersion = new System.Windows.Forms.ComboBox();
            this.lblImageSelector = new System.Windows.Forms.Label();
            this.lblLocalization = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.pnlNotification = new System.Windows.Forms.Panel();
            this.lblNotificationTxt = new System.Windows.Forms.Label();
            this.lblContainerName = new System.Windows.Forms.Label();
            this.txtBoxContainerName = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.fdlgDatabase = new System.Windows.Forms.OpenFileDialog();
            this.txtBoxDatabase = new System.Windows.Forms.TextBox();
            this.btnAdvanced = new System.Windows.Forms.Button();
            this.pHackerman = new System.Windows.Forms.PictureBox();
            this.pnlNotification.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHackerman)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateContainer
            // 
            this.btnCreateContainer.BackColor = System.Drawing.Color.Black;
            this.btnCreateContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateContainer.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnCreateContainer.Location = new System.Drawing.Point(253, 329);
            this.btnCreateContainer.Name = "btnCreateContainer";
            this.btnCreateContainer.Size = new System.Drawing.Size(147, 23);
            this.btnCreateContainer.TabIndex = 0;
            this.btnCreateContainer.Text = "Create Container!";
            this.btnCreateContainer.UseVisualStyleBackColor = false;
            this.btnCreateContainer.Click += new System.EventHandler(this.btnCreateContainer_Click);
            // 
            // cbImageSelector
            // 
            this.cbImageSelector.BackColor = System.Drawing.Color.Black;
            this.cbImageSelector.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbImageSelector.FormattingEnabled = true;
            this.cbImageSelector.Items.AddRange(new object[] {
            "Business Central On-premises",
            "Business Central Cloud",
            "NAV"});
            this.cbImageSelector.Location = new System.Drawing.Point(157, 73);
            this.cbImageSelector.Name = "cbImageSelector";
            this.cbImageSelector.Size = new System.Drawing.Size(217, 22);
            this.cbImageSelector.TabIndex = 1;
            // 
            // cbLocalization
            // 
            this.cbLocalization.BackColor = System.Drawing.Color.Black;
            this.cbLocalization.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbLocalization.FormattingEnabled = true;
            this.cbLocalization.Items.AddRange(new object[] {
            "DK",
            "NO",
            "US",
            "UK"});
            this.cbLocalization.Location = new System.Drawing.Point(157, 121);
            this.cbLocalization.Name = "cbLocalization";
            this.cbLocalization.Size = new System.Drawing.Size(217, 22);
            this.cbLocalization.TabIndex = 2;
            // 
            // cbVersion
            // 
            this.cbVersion.BackColor = System.Drawing.Color.Black;
            this.cbVersion.ForeColor = System.Drawing.Color.DarkOrange;
            this.cbVersion.FormattingEnabled = true;
            this.cbVersion.Location = new System.Drawing.Point(157, 169);
            this.cbVersion.Name = "cbVersion";
            this.cbVersion.Size = new System.Drawing.Size(217, 22);
            this.cbVersion.TabIndex = 3;
            // 
            // lblImageSelector
            // 
            this.lblImageSelector.AutoSize = true;
            this.lblImageSelector.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblImageSelector.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblImageSelector.Location = new System.Drawing.Point(68, 75);
            this.lblImageSelector.Name = "lblImageSelector";
            this.lblImageSelector.Size = new System.Drawing.Size(72, 17);
            this.lblImageSelector.TabIndex = 4;
            this.lblImageSelector.Text = "Base app";
            // 
            // lblLocalization
            // 
            this.lblLocalization.AutoSize = true;
            this.lblLocalization.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblLocalization.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblLocalization.Location = new System.Drawing.Point(36, 123);
            this.lblLocalization.Name = "lblLocalization";
            this.lblLocalization.Size = new System.Drawing.Size(104, 17);
            this.lblLocalization.TabIndex = 5;
            this.lblLocalization.Text = "Localization";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblVersion.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblVersion.Location = new System.Drawing.Point(76, 171);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(64, 17);
            this.lblVersion.TabIndex = 6;
            this.lblVersion.Text = "Version";
            // 
            // pnlNotification
            // 
            this.pnlNotification.BackColor = System.Drawing.Color.Red;
            this.pnlNotification.Controls.Add(this.lblNotificationTxt);
            this.pnlNotification.ForeColor = System.Drawing.Color.White;
            this.pnlNotification.Location = new System.Drawing.Point(0, 358);
            this.pnlNotification.Name = "pnlNotification";
            this.pnlNotification.Size = new System.Drawing.Size(428, 25);
            this.pnlNotification.TabIndex = 7;
            this.pnlNotification.Visible = false;
            // 
            // lblNotificationTxt
            // 
            this.lblNotificationTxt.AutoSize = true;
            this.lblNotificationTxt.Location = new System.Drawing.Point(9, 5);
            this.lblNotificationTxt.Name = "lblNotificationTxt";
            this.lblNotificationTxt.Size = new System.Drawing.Size(63, 14);
            this.lblNotificationTxt.TabIndex = 0;
            this.lblNotificationTxt.Text = "dummytxt";
            // 
            // lblContainerName
            // 
            this.lblContainerName.AutoSize = true;
            this.lblContainerName.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblContainerName.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblContainerName.Location = new System.Drawing.Point(100, 31);
            this.lblContainerName.Name = "lblContainerName";
            this.lblContainerName.Size = new System.Drawing.Size(40, 17);
            this.lblContainerName.TabIndex = 9;
            this.lblContainerName.Text = "Name";
            // 
            // txtBoxContainerName
            // 
            this.txtBoxContainerName.BackColor = System.Drawing.Color.Black;
            this.txtBoxContainerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxContainerName.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtBoxContainerName.Location = new System.Drawing.Point(157, 29);
            this.txtBoxContainerName.Name = "txtBoxContainerName";
            this.txtBoxContainerName.Size = new System.Drawing.Size(217, 20);
            this.txtBoxContainerName.TabIndex = 2;
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Courier New", 10F);
            this.lblDatabase.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblDatabase.Location = new System.Drawing.Point(76, 214);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(72, 17);
            this.lblDatabase.TabIndex = 11;
            this.lblDatabase.Text = "Database";
            // 
            // fdlgDatabase
            // 
            this.fdlgDatabase.FileName = "bakDatabase";
            // 
            // txtBoxDatabase
            // 
            this.txtBoxDatabase.BackColor = System.Drawing.Color.Black;
            this.txtBoxDatabase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxDatabase.ForeColor = System.Drawing.Color.DarkOrange;
            this.txtBoxDatabase.Location = new System.Drawing.Point(157, 213);
            this.txtBoxDatabase.Name = "txtBoxDatabase";
            this.txtBoxDatabase.Size = new System.Drawing.Size(217, 20);
            this.txtBoxDatabase.TabIndex = 12;
            this.txtBoxDatabase.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtBoxDatabase_MouseDown);
            // 
            // btnAdvanced
            // 
            this.btnAdvanced.BackColor = System.Drawing.Color.Black;
            this.btnAdvanced.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdvanced.ForeColor = System.Drawing.Color.DarkOrange;
            this.btnAdvanced.Location = new System.Drawing.Point(21, 329);
            this.btnAdvanced.Name = "btnAdvanced";
            this.btnAdvanced.Size = new System.Drawing.Size(84, 23);
            this.btnAdvanced.TabIndex = 13;
            this.btnAdvanced.Text = "Advanced";
            this.btnAdvanced.UseVisualStyleBackColor = false;
            // 
            // pHackerman
            // 
            this.pHackerman.Image = ((System.Drawing.Image)(resources.GetObject("pHackerman.Image")));
            this.pHackerman.Location = new System.Drawing.Point(0, 226);
            this.pHackerman.Name = "pHackerman";
            this.pHackerman.Size = new System.Drawing.Size(428, 157);
            this.pHackerman.TabIndex = 14;
            this.pHackerman.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(15)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(428, 383);
            this.Controls.Add(this.btnAdvanced);
            this.Controls.Add(this.txtBoxDatabase);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.txtBoxContainerName);
            this.Controls.Add(this.lblContainerName);
            this.Controls.Add(this.pnlNotification);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblLocalization);
            this.Controls.Add(this.lblImageSelector);
            this.Controls.Add(this.cbVersion);
            this.Controls.Add(this.cbLocalization);
            this.Controls.Add(this.cbImageSelector);
            this.Controls.Add(this.btnCreateContainer);
            this.Controls.Add(this.pHackerman);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Font = new System.Drawing.Font("Courier New", 8F);
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EasyBCNAVDocker";
            this.Load += new System.EventHandler(this.main_Load);
            this.pnlNotification.ResumeLayout(false);
            this.pnlNotification.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pHackerman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateContainer;
        private System.Windows.Forms.ComboBox cbImageSelector;
        private System.Windows.Forms.ComboBox cbLocalization;
        private System.Windows.Forms.ComboBox cbVersion;
        private System.Windows.Forms.Label lblImageSelector;
        private System.Windows.Forms.Label lblLocalization;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Panel pnlNotification;
        private System.Windows.Forms.Label lblNotificationTxt;
        private System.Windows.Forms.Label lblContainerName;
        private System.Windows.Forms.TextBox txtBoxContainerName;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.OpenFileDialog fdlgDatabase;
        private System.Windows.Forms.TextBox txtBoxDatabase;
        private System.Windows.Forms.Button btnAdvanced;
        private System.Windows.Forms.PictureBox pHackerman;
    }
}

