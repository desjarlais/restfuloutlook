namespace RESTfulOutlook
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoGraphAPI = new System.Windows.Forms.RadioButton();
            this.mskPassword = new System.Windows.Forms.MaskedTextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoBasic = new System.Windows.Forms.RadioButton();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnLoginLogout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnUserPhotoAPI = new System.Windows.Forms.Button();
            this.btnMailAPI = new System.Windows.Forms.Button();
            this.btnCalendarAPI = new System.Windows.Forms.Button();
            this.btnContactsAPI = new System.Windows.Forms.Button();
            this.btnGraphAPI = new System.Windows.Forms.Button();
            this.btnReportingService = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnScopes = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoGraphAPI);
            this.groupBox1.Controls.Add(this.mskPassword);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdoBasic);
            this.groupBox1.Location = new System.Drawing.Point(191, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 136);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "App Authentication / Authorization";
            // 
            // rdoGraphAPI
            // 
            this.rdoGraphAPI.AutoSize = true;
            this.rdoGraphAPI.Checked = true;
            this.rdoGraphAPI.Location = new System.Drawing.Point(6, 112);
            this.rdoGraphAPI.Name = "rdoGraphAPI";
            this.rdoGraphAPI.Size = new System.Drawing.Size(155, 17);
            this.rdoGraphAPI.TabIndex = 8;
            this.rdoGraphAPI.TabStop = true;
            this.rdoGraphAPI.Text = "OAuth 2.0 (Graph API Only)";
            this.rdoGraphAPI.UseVisualStyleBackColor = true;
            this.rdoGraphAPI.CheckedChanged += new System.EventHandler(this.rdoGraphAPI_CheckedChanged);
            // 
            // mskPassword
            // 
            this.mskPassword.Enabled = false;
            this.mskPassword.Location = new System.Drawing.Point(84, 74);
            this.mskPassword.Name = "mskPassword";
            this.mskPassword.Size = new System.Drawing.Size(265, 20);
            this.mskPassword.TabIndex = 7;
            this.mskPassword.UseSystemPasswordChar = true;
            // 
            // tbUsername
            // 
            this.tbUsername.Enabled = false;
            this.tbUsername.Location = new System.Drawing.Point(84, 45);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(265, 20);
            this.tbUsername.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // rdoBasic
            // 
            this.rdoBasic.AutoSize = true;
            this.rdoBasic.Location = new System.Drawing.Point(6, 22);
            this.rdoBasic.Name = "rdoBasic";
            this.rdoBasic.Size = new System.Drawing.Size(246, 17);
            this.rdoBasic.TabIndex = 2;
            this.rdoBasic.Text = "Basic Authentication - (Reporting Service Only)";
            this.rdoBasic.UseVisualStyleBackColor = true;
            this.rdoBasic.CheckedChanged += new System.EventHandler(this.rdoBasic_CheckedChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(16, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 13);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "No User Logged In";
            // 
            // btnLoginLogout
            // 
            this.btnLoginLogout.Location = new System.Drawing.Point(273, 19);
            this.btnLoginLogout.Name = "btnLoginLogout";
            this.btnLoginLogout.Size = new System.Drawing.Size(76, 23);
            this.btnLoginLogout.TabIndex = 11;
            this.btnLoginLogout.Text = "Login";
            this.btnLoginLogout.UseVisualStyleBackColor = true;
            this.btnLoginLogout.Click += new System.EventHandler(this.btnLoginLogout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNotifications);
            this.groupBox2.Controls.Add(this.btnUserPhotoAPI);
            this.groupBox2.Controls.Add(this.btnMailAPI);
            this.groupBox2.Controls.Add(this.btnCalendarAPI);
            this.groupBox2.Controls.Add(this.btnContactsAPI);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(173, 163);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Microsoft Graph SDK";
            // 
            // btnNotifications
            // 
            this.btnNotifications.Location = new System.Drawing.Point(12, 135);
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(145, 23);
            this.btnNotifications.TabIndex = 16;
            this.btnNotifications.Text = "Notification API";
            this.btnNotifications.UseVisualStyleBackColor = true;
            // 
            // btnUserPhotoAPI
            // 
            this.btnUserPhotoAPI.Location = new System.Drawing.Point(12, 106);
            this.btnUserPhotoAPI.Name = "btnUserPhotoAPI";
            this.btnUserPhotoAPI.Size = new System.Drawing.Size(145, 23);
            this.btnUserPhotoAPI.TabIndex = 17;
            this.btnUserPhotoAPI.Text = "User Photo API";
            this.btnUserPhotoAPI.UseVisualStyleBackColor = true;
            // 
            // btnMailAPI
            // 
            this.btnMailAPI.Location = new System.Drawing.Point(12, 77);
            this.btnMailAPI.Name = "btnMailAPI";
            this.btnMailAPI.Size = new System.Drawing.Size(145, 23);
            this.btnMailAPI.TabIndex = 8;
            this.btnMailAPI.Text = "Mail API";
            this.btnMailAPI.UseVisualStyleBackColor = true;
            this.btnMailAPI.Click += new System.EventHandler(this.btnMailAPI_Click);
            // 
            // btnCalendarAPI
            // 
            this.btnCalendarAPI.Location = new System.Drawing.Point(12, 48);
            this.btnCalendarAPI.Name = "btnCalendarAPI";
            this.btnCalendarAPI.Size = new System.Drawing.Size(145, 23);
            this.btnCalendarAPI.TabIndex = 7;
            this.btnCalendarAPI.Text = "Calendar API";
            this.btnCalendarAPI.UseVisualStyleBackColor = true;
            this.btnCalendarAPI.Click += new System.EventHandler(this.btnCalendarAPI_Click);
            // 
            // btnContactsAPI
            // 
            this.btnContactsAPI.Location = new System.Drawing.Point(12, 19);
            this.btnContactsAPI.Name = "btnContactsAPI";
            this.btnContactsAPI.Size = new System.Drawing.Size(145, 23);
            this.btnContactsAPI.TabIndex = 0;
            this.btnContactsAPI.Text = "Contacts API";
            this.btnContactsAPI.UseVisualStyleBackColor = true;
            this.btnContactsAPI.Click += new System.EventHandler(this.btnContactsAPI_Click);
            // 
            // btnGraphAPI
            // 
            this.btnGraphAPI.Location = new System.Drawing.Point(6, 19);
            this.btnGraphAPI.Name = "btnGraphAPI";
            this.btnGraphAPI.Size = new System.Drawing.Size(151, 23);
            this.btnGraphAPI.TabIndex = 10;
            this.btnGraphAPI.Text = "MS Graph API Explorer";
            this.btnGraphAPI.UseVisualStyleBackColor = true;
            this.btnGraphAPI.Click += new System.EventHandler(this.btnGraphAPI_Click);
            // 
            // btnReportingService
            // 
            this.btnReportingService.Location = new System.Drawing.Point(6, 48);
            this.btnReportingService.Name = "btnReportingService";
            this.btnReportingService.Size = new System.Drawing.Size(151, 23);
            this.btnReportingService.TabIndex = 7;
            this.btnReportingService.Text = "Office365 Reporting Service";
            this.btnReportingService.UseVisualStyleBackColor = true;
            this.btnReportingService.Click += new System.EventHandler(this.btnReportingService_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnScopes);
            this.groupBox3.Controls.Add(this.btnSettings);
            this.groupBox3.Controls.Add(this.btnUserInfo);
            this.groupBox3.Controls.Add(this.btnLoginLogout);
            this.groupBox3.Location = new System.Drawing.Point(191, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 51);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Application Options";
            // 
            // btnScopes
            // 
            this.btnScopes.Location = new System.Drawing.Point(6, 19);
            this.btnScopes.Name = "btnScopes";
            this.btnScopes.Size = new System.Drawing.Size(95, 23);
            this.btnScopes.TabIndex = 16;
            this.btnScopes.Text = "App Scopes";
            this.btnScopes.UseVisualStyleBackColor = true;
            this.btnScopes.Click += new System.EventHandler(this.btnScopes_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(107, 19);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(75, 23);
            this.btnSettings.TabIndex = 17;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Location = new System.Drawing.Point(188, 19);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(79, 23);
            this.btnUserInfo.TabIndex = 16;
            this.btnUserInfo.Text = "User Info";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGraphAPI);
            this.groupBox4.Controls.Add(this.btnReportingService);
            this.groupBox4.Location = new System.Drawing.Point(12, 181);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(173, 85);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Office365 REST APIs";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblUsername);
            this.groupBox5.Location = new System.Drawing.Point(191, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(355, 52);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "User Information";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 274);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESTfulOutlook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnContactsAPI;
        private System.Windows.Forms.Button btnMailAPI;
        private System.Windows.Forms.Button btnCalendarAPI;
        private System.Windows.Forms.Button btnReportingService;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoBasic;
        private System.Windows.Forms.MaskedTextBox mskPassword;
        private System.Windows.Forms.Button btnGraphAPI;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnLoginLogout;
        private System.Windows.Forms.RadioButton rdoGraphAPI;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnScopes;
        private System.Windows.Forms.Button btnUserPhotoAPI;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}

