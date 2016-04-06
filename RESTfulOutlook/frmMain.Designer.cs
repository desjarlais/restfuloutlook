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
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoBasic = new System.Windows.Forms.RadioButton();
            this.btnLoginLogout = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMailAPI = new System.Windows.Forms.Button();
            this.btnCalendarAPI = new System.Windows.Forms.Button();
            this.btnContactsAPI = new System.Windows.Forms.Button();
            this.btnGraphAPI = new System.Windows.Forms.Button();
            this.btnReportingService = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnScopes = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUserInfo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoGraphAPI);
            this.groupBox1.Controls.Add(this.mskPassword);
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.tbUsername);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rdoBasic);
            this.groupBox1.Location = new System.Drawing.Point(255, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(473, 197);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "App Authentication / Authorization";
            // 
            // rdoGraphAPI
            // 
            this.rdoGraphAPI.AutoSize = true;
            this.rdoGraphAPI.Checked = true;
            this.rdoGraphAPI.Location = new System.Drawing.Point(8, 138);
            this.rdoGraphAPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoGraphAPI.Name = "rdoGraphAPI";
            this.rdoGraphAPI.Size = new System.Drawing.Size(184, 20);
            this.rdoGraphAPI.TabIndex = 8;
            this.rdoGraphAPI.TabStop = true;
            this.rdoGraphAPI.Text = "OAuth 2.0 (Graph API Only)";
            this.rdoGraphAPI.UseVisualStyleBackColor = true;
            this.rdoGraphAPI.CheckedChanged += new System.EventHandler(this.rdoGraphAPI_CheckedChanged);
            // 
            // mskPassword
            // 
            this.mskPassword.Enabled = false;
            this.mskPassword.Location = new System.Drawing.Point(112, 91);
            this.mskPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mskPassword.Name = "mskPassword";
            this.mskPassword.Size = new System.Drawing.Size(352, 22);
            this.mskPassword.TabIndex = 7;
            this.mskPassword.UseSystemPasswordChar = true;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(96, 175);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(121, 16);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "No User Logged In";
            // 
            // tbUsername
            // 
            this.tbUsername.Enabled = false;
            this.tbUsername.Location = new System.Drawing.Point(112, 55);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(352, 22);
            this.tbUsername.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "UserName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // rdoBasic
            // 
            this.rdoBasic.AutoSize = true;
            this.rdoBasic.Location = new System.Drawing.Point(8, 27);
            this.rdoBasic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdoBasic.Name = "rdoBasic";
            this.rdoBasic.Size = new System.Drawing.Size(302, 20);
            this.rdoBasic.TabIndex = 2;
            this.rdoBasic.Text = "Basic Authentication - (Reporting Service Only)";
            this.rdoBasic.UseVisualStyleBackColor = true;
            this.rdoBasic.CheckedChanged += new System.EventHandler(this.rdoBasic_CheckedChanged);
            // 
            // btnLoginLogout
            // 
            this.btnLoginLogout.Location = new System.Drawing.Point(364, 23);
            this.btnLoginLogout.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLoginLogout.Name = "btnLoginLogout";
            this.btnLoginLogout.Size = new System.Drawing.Size(101, 28);
            this.btnLoginLogout.TabIndex = 11;
            this.btnLoginLogout.Text = "Login";
            this.btnLoginLogout.UseVisualStyleBackColor = true;
            this.btnLoginLogout.Click += new System.EventHandler(this.btnLoginLogout_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnMailAPI);
            this.groupBox2.Controls.Add(this.btnCalendarAPI);
            this.groupBox2.Controls.Add(this.btnContactsAPI);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(231, 159);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Microsoft Graph SDK";
            // 
            // btnMailAPI
            // 
            this.btnMailAPI.Location = new System.Drawing.Point(16, 95);
            this.btnMailAPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMailAPI.Name = "btnMailAPI";
            this.btnMailAPI.Size = new System.Drawing.Size(193, 28);
            this.btnMailAPI.TabIndex = 8;
            this.btnMailAPI.Text = "Mail API";
            this.btnMailAPI.UseVisualStyleBackColor = true;
            this.btnMailAPI.Click += new System.EventHandler(this.btnMailAPI_Click);
            // 
            // btnCalendarAPI
            // 
            this.btnCalendarAPI.Location = new System.Drawing.Point(16, 59);
            this.btnCalendarAPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCalendarAPI.Name = "btnCalendarAPI";
            this.btnCalendarAPI.Size = new System.Drawing.Size(193, 28);
            this.btnCalendarAPI.TabIndex = 7;
            this.btnCalendarAPI.Text = "Calendar API";
            this.btnCalendarAPI.UseVisualStyleBackColor = true;
            this.btnCalendarAPI.Click += new System.EventHandler(this.btnCalendarAPI_Click);
            // 
            // btnContactsAPI
            // 
            this.btnContactsAPI.Location = new System.Drawing.Point(16, 23);
            this.btnContactsAPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContactsAPI.Name = "btnContactsAPI";
            this.btnContactsAPI.Size = new System.Drawing.Size(193, 28);
            this.btnContactsAPI.TabIndex = 0;
            this.btnContactsAPI.Text = "Contacts API";
            this.btnContactsAPI.UseVisualStyleBackColor = true;
            this.btnContactsAPI.Click += new System.EventHandler(this.btnContactsAPI_Click);
            // 
            // btnGraphAPI
            // 
            this.btnGraphAPI.Location = new System.Drawing.Point(8, 23);
            this.btnGraphAPI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGraphAPI.Name = "btnGraphAPI";
            this.btnGraphAPI.Size = new System.Drawing.Size(201, 28);
            this.btnGraphAPI.TabIndex = 10;
            this.btnGraphAPI.Text = "MS Graph API Explorer";
            this.btnGraphAPI.UseVisualStyleBackColor = true;
            this.btnGraphAPI.Click += new System.EventHandler(this.btnGraphAPI_Click);
            // 
            // btnReportingService
            // 
            this.btnReportingService.Location = new System.Drawing.Point(8, 59);
            this.btnReportingService.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReportingService.Name = "btnReportingService";
            this.btnReportingService.Size = new System.Drawing.Size(201, 28);
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
            this.groupBox3.Location = new System.Drawing.Point(255, 219);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(473, 63);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Application Options";
            // 
            // btnScopes
            // 
            this.btnScopes.Location = new System.Drawing.Point(8, 23);
            this.btnScopes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScopes.Name = "btnScopes";
            this.btnScopes.Size = new System.Drawing.Size(127, 28);
            this.btnScopes.TabIndex = 16;
            this.btnScopes.Text = "App Scopes";
            this.btnScopes.UseVisualStyleBackColor = true;
            this.btnScopes.Click += new System.EventHandler(this.btnScopes_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(143, 23);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(100, 28);
            this.btnSettings.TabIndex = 17;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnUserInfo
            // 
            this.btnUserInfo.Location = new System.Drawing.Point(251, 23);
            this.btnUserInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUserInfo.Name = "btnUserInfo";
            this.btnUserInfo.Size = new System.Drawing.Size(105, 28);
            this.btnUserInfo.TabIndex = 16;
            this.btnUserInfo.Text = "User Info";
            this.btnUserInfo.UseVisualStyleBackColor = true;
            this.btnUserInfo.Click += new System.EventHandler(this.btnUserInfo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 294);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(744, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel2.Text = "Status:";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Ready";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGraphAPI);
            this.groupBox4.Controls.Add(this.btnReportingService);
            this.groupBox4.Location = new System.Drawing.Point(16, 182);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(231, 100);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Office365 REST APIs";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 316);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RESTfulOutlook";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnLoginLogout;
        private System.Windows.Forms.RadioButton rdoGraphAPI;
        private System.Windows.Forms.Button btnUserInfo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnScopes;
    }
}

