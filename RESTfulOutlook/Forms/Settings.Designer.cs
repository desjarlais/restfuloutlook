namespace RESTfulOutlook.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAll = new System.Windows.Forms.RadioButton();
            this.rdoActivity = new System.Windows.Forms.RadioButton();
            this.rdoCritical = new System.Windows.Forms.RadioButton();
            this.rdoVerbose = new System.Windows.Forms.RadioButton();
            this.rdoError = new System.Windows.Forms.RadioButton();
            this.rdoWarning = new System.Windows.Forms.RadioButton();
            this.rdoInfo = new System.Windows.Forms.RadioButton();
            this.rdoOff = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkFeedback = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGraphLog = new System.Windows.Forms.Button();
            this.btnAppLog = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdoRefresh = new System.Windows.Forms.RadioButton();
            this.rdoNever = new System.Windows.Forms.RadioButton();
            this.rdoAuto = new System.Windows.Forms.RadioButton();
            this.rdoAlways = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdoFileCache = new System.Windows.Forms.RadioButton();
            this.rdoAdalCache = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnResetRegistration = new System.Windows.Forms.Button();
            this.linkRegistration = new System.Windows.Forms.LinkLabel();
            this.txtTenantId = new System.Windows.Forms.TextBox();
            this.txtAuthority = new System.Windows.Forms.TextBox();
            this.txtClientId = new System.Windows.Forms.TextBox();
            this.txtRedirectUri = new System.Windows.Forms.TextBox();
            this.chkEditAppRegistration = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ckOutlookDiag = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAll);
            this.groupBox1.Controls.Add(this.rdoActivity);
            this.groupBox1.Controls.Add(this.rdoCritical);
            this.groupBox1.Controls.Add(this.rdoVerbose);
            this.groupBox1.Controls.Add(this.rdoError);
            this.groupBox1.Controls.Add(this.rdoWarning);
            this.groupBox1.Controls.Add(this.rdoInfo);
            this.groupBox1.Controls.Add(this.rdoOff);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 215);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adal Trace Level";
            // 
            // rdoAll
            // 
            this.rdoAll.AutoSize = true;
            this.rdoAll.Location = new System.Drawing.Point(12, 180);
            this.rdoAll.Name = "rdoAll";
            this.rdoAll.Size = new System.Drawing.Size(36, 17);
            this.rdoAll.TabIndex = 7;
            this.rdoAll.Text = "All";
            this.rdoAll.UseVisualStyleBackColor = true;
            // 
            // rdoActivity
            // 
            this.rdoActivity.AutoSize = true;
            this.rdoActivity.Location = new System.Drawing.Point(12, 157);
            this.rdoActivity.Name = "rdoActivity";
            this.rdoActivity.Size = new System.Drawing.Size(95, 17);
            this.rdoActivity.TabIndex = 8;
            this.rdoActivity.Text = "ActivityTracing";
            this.rdoActivity.UseVisualStyleBackColor = true;
            // 
            // rdoCritical
            // 
            this.rdoCritical.AutoSize = true;
            this.rdoCritical.Location = new System.Drawing.Point(12, 134);
            this.rdoCritical.Name = "rdoCritical";
            this.rdoCritical.Size = new System.Drawing.Size(56, 17);
            this.rdoCritical.TabIndex = 7;
            this.rdoCritical.Text = "Critical";
            this.rdoCritical.UseVisualStyleBackColor = true;
            // 
            // rdoVerbose
            // 
            this.rdoVerbose.AutoSize = true;
            this.rdoVerbose.Location = new System.Drawing.Point(12, 111);
            this.rdoVerbose.Name = "rdoVerbose";
            this.rdoVerbose.Size = new System.Drawing.Size(64, 17);
            this.rdoVerbose.TabIndex = 4;
            this.rdoVerbose.Text = "Verbose";
            this.rdoVerbose.UseVisualStyleBackColor = true;
            // 
            // rdoError
            // 
            this.rdoError.AutoSize = true;
            this.rdoError.Location = new System.Drawing.Point(12, 88);
            this.rdoError.Name = "rdoError";
            this.rdoError.Size = new System.Drawing.Size(47, 17);
            this.rdoError.TabIndex = 3;
            this.rdoError.Text = "Error";
            this.rdoError.UseVisualStyleBackColor = true;
            // 
            // rdoWarning
            // 
            this.rdoWarning.AutoSize = true;
            this.rdoWarning.Location = new System.Drawing.Point(12, 65);
            this.rdoWarning.Name = "rdoWarning";
            this.rdoWarning.Size = new System.Drawing.Size(65, 17);
            this.rdoWarning.TabIndex = 2;
            this.rdoWarning.Text = "Warning";
            this.rdoWarning.UseVisualStyleBackColor = true;
            // 
            // rdoInfo
            // 
            this.rdoInfo.AutoSize = true;
            this.rdoInfo.Location = new System.Drawing.Point(12, 42);
            this.rdoInfo.Name = "rdoInfo";
            this.rdoInfo.Size = new System.Drawing.Size(77, 17);
            this.rdoInfo.TabIndex = 1;
            this.rdoInfo.Text = "Information";
            this.rdoInfo.UseVisualStyleBackColor = true;
            // 
            // rdoOff
            // 
            this.rdoOff.AutoSize = true;
            this.rdoOff.Checked = true;
            this.rdoOff.Location = new System.Drawing.Point(12, 19);
            this.rdoOff.Name = "rdoOff";
            this.rdoOff.Size = new System.Drawing.Size(39, 17);
            this.rdoOff.TabIndex = 0;
            this.rdoOff.TabStop = true;
            this.rdoOff.Text = "Off";
            this.rdoOff.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(468, 414);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "Save";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(387, 414);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkFeedback);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblVersion);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(289, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 97);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "App Info";
            // 
            // linkFeedback
            // 
            this.linkFeedback.AutoSize = true;
            this.linkFeedback.Location = new System.Drawing.Point(6, 69);
            this.linkFeedback.Name = "linkFeedback";
            this.linkFeedback.Size = new System.Drawing.Size(0, 13);
            this.linkFeedback.TabIndex = 3;
            this.linkFeedback.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFeedback_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Submit Feedback :";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(54, 18);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(40, 13);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "1.0.0.0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Version : ";
            // 
            // btnGraphLog
            // 
            this.btnGraphLog.Location = new System.Drawing.Point(134, 414);
            this.btnGraphLog.Name = "btnGraphLog";
            this.btnGraphLog.Size = new System.Drawing.Size(116, 23);
            this.btnGraphLog.TabIndex = 10;
            this.btnGraphLog.Text = "Graph SDK Log";
            this.btnGraphLog.UseVisualStyleBackColor = true;
            this.btnGraphLog.Click += new System.EventHandler(this.btnGraphLog_Click);
            // 
            // btnAppLog
            // 
            this.btnAppLog.Location = new System.Drawing.Point(12, 414);
            this.btnAppLog.Name = "btnAppLog";
            this.btnAppLog.Size = new System.Drawing.Size(116, 23);
            this.btnAppLog.TabIndex = 8;
            this.btnAppLog.Text = "Application Log";
            this.btnAppLog.UseVisualStyleBackColor = true;
            this.btnAppLog.Click += new System.EventHandler(this.btnAppLog_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdoRefresh);
            this.groupBox3.Controls.Add(this.rdoNever);
            this.groupBox3.Controls.Add(this.rdoAuto);
            this.groupBox3.Controls.Add(this.rdoAlways);
            this.groupBox3.Location = new System.Drawing.Point(130, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(153, 128);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Auth Prompt Behavior";
            // 
            // rdoRefresh
            // 
            this.rdoRefresh.AutoSize = true;
            this.rdoRefresh.Location = new System.Drawing.Point(9, 92);
            this.rdoRefresh.Name = "rdoRefresh";
            this.rdoRefresh.Size = new System.Drawing.Size(99, 17);
            this.rdoRefresh.TabIndex = 3;
            this.rdoRefresh.Text = "RefreshSession";
            this.rdoRefresh.UseVisualStyleBackColor = true;
            // 
            // rdoNever
            // 
            this.rdoNever.AutoSize = true;
            this.rdoNever.Location = new System.Drawing.Point(9, 69);
            this.rdoNever.Name = "rdoNever";
            this.rdoNever.Size = new System.Drawing.Size(54, 17);
            this.rdoNever.TabIndex = 2;
            this.rdoNever.Text = "Never";
            this.rdoNever.UseVisualStyleBackColor = true;
            // 
            // rdoAuto
            // 
            this.rdoAuto.AutoSize = true;
            this.rdoAuto.Location = new System.Drawing.Point(9, 46);
            this.rdoAuto.Name = "rdoAuto";
            this.rdoAuto.Size = new System.Drawing.Size(47, 17);
            this.rdoAuto.TabIndex = 1;
            this.rdoAuto.Text = "Auto";
            this.rdoAuto.UseVisualStyleBackColor = true;
            // 
            // rdoAlways
            // 
            this.rdoAlways.AutoSize = true;
            this.rdoAlways.Checked = true;
            this.rdoAlways.Location = new System.Drawing.Point(9, 23);
            this.rdoAlways.Name = "rdoAlways";
            this.rdoAlways.Size = new System.Drawing.Size(58, 17);
            this.rdoAlways.TabIndex = 0;
            this.rdoAlways.TabStop = true;
            this.rdoAlways.Text = "Always";
            this.rdoAlways.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdoFileCache);
            this.groupBox4.Controls.Add(this.rdoAdalCache);
            this.groupBox4.Location = new System.Drawing.Point(130, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(153, 81);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Token Cache";
            // 
            // rdoFileCache
            // 
            this.rdoFileCache.AutoSize = true;
            this.rdoFileCache.Location = new System.Drawing.Point(9, 42);
            this.rdoFileCache.Name = "rdoFileCache";
            this.rdoFileCache.Size = new System.Drawing.Size(75, 17);
            this.rdoFileCache.TabIndex = 1;
            this.rdoFileCache.Text = "File Cache";
            this.rdoFileCache.UseVisualStyleBackColor = true;
            // 
            // rdoAdalCache
            // 
            this.rdoAdalCache.AutoSize = true;
            this.rdoAdalCache.Checked = true;
            this.rdoAdalCache.Location = new System.Drawing.Point(9, 19);
            this.rdoAdalCache.Name = "rdoAdalCache";
            this.rdoAdalCache.Size = new System.Drawing.Size(87, 17);
            this.rdoAdalCache.TabIndex = 0;
            this.rdoAdalCache.TabStop = true;
            this.rdoAdalCache.Text = "ADAL Cache";
            this.rdoAdalCache.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnResetRegistration);
            this.groupBox5.Controls.Add(this.linkRegistration);
            this.groupBox5.Controls.Add(this.txtTenantId);
            this.groupBox5.Controls.Add(this.txtAuthority);
            this.groupBox5.Controls.Add(this.txtClientId);
            this.groupBox5.Controls.Add(this.txtRedirectUri);
            this.groupBox5.Controls.Add(this.chkEditAppRegistration);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Location = new System.Drawing.Point(12, 233);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(531, 175);
            this.groupBox5.TabIndex = 13;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "App Registration (must be completed first)";
            // 
            // btnResetRegistration
            // 
            this.btnResetRegistration.Enabled = false;
            this.btnResetRegistration.Location = new System.Drawing.Point(12, 146);
            this.btnResetRegistration.Name = "btnResetRegistration";
            this.btnResetRegistration.Size = new System.Drawing.Size(136, 23);
            this.btnResetRegistration.TabIndex = 15;
            this.btnResetRegistration.Text = "Reset App Registration";
            this.btnResetRegistration.UseVisualStyleBackColor = true;
            this.btnResetRegistration.Click += new System.EventHandler(this.btnResetRegistration_Click);
            // 
            // linkRegistration
            // 
            this.linkRegistration.AutoSize = true;
            this.linkRegistration.Location = new System.Drawing.Point(371, 151);
            this.linkRegistration.Name = "linkRegistration";
            this.linkRegistration.Size = new System.Drawing.Size(163, 13);
            this.linkRegistration.TabIndex = 15;
            this.linkRegistration.TabStop = true;
            this.linkRegistration.Text = "Microsoft Graph App Registration";
            this.linkRegistration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkRegistration_LinkClicked);
            // 
            // txtTenantId
            // 
            this.txtTenantId.Enabled = false;
            this.txtTenantId.Location = new System.Drawing.Point(85, 116);
            this.txtTenantId.Name = "txtTenantId";
            this.txtTenantId.Size = new System.Drawing.Size(440, 20);
            this.txtTenantId.TabIndex = 22;
            // 
            // txtAuthority
            // 
            this.txtAuthority.Enabled = false;
            this.txtAuthority.Location = new System.Drawing.Point(85, 90);
            this.txtAuthority.Name = "txtAuthority";
            this.txtAuthority.Size = new System.Drawing.Size(440, 20);
            this.txtAuthority.TabIndex = 21;
            // 
            // txtClientId
            // 
            this.txtClientId.Enabled = false;
            this.txtClientId.Location = new System.Drawing.Point(85, 63);
            this.txtClientId.Name = "txtClientId";
            this.txtClientId.Size = new System.Drawing.Size(440, 20);
            this.txtClientId.TabIndex = 20;
            // 
            // txtRedirectUri
            // 
            this.txtRedirectUri.Enabled = false;
            this.txtRedirectUri.Location = new System.Drawing.Point(85, 36);
            this.txtRedirectUri.Name = "txtRedirectUri";
            this.txtRedirectUri.Size = new System.Drawing.Size(440, 20);
            this.txtRedirectUri.TabIndex = 19;
            // 
            // chkEditAppRegistration
            // 
            this.chkEditAppRegistration.AutoSize = true;
            this.chkEditAppRegistration.Location = new System.Drawing.Point(12, 19);
            this.chkEditAppRegistration.Name = "chkEditAppRegistration";
            this.chkEditAppRegistration.Size = new System.Drawing.Size(103, 17);
            this.chkEditAppRegistration.TabIndex = 18;
            this.chkEditAppRegistration.Text = "Edit Registration";
            this.chkEditAppRegistration.UseVisualStyleBackColor = true;
            this.chkEditAppRegistration.CheckedChanged += new System.EventHandler(this.chkEditAppRegistration_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tenant Id :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Authority :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Client Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "RedirectUri :";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ckOutlookDiag);
            this.groupBox6.Location = new System.Drawing.Point(289, 115);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(248, 112);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Diagnostics";
            // 
            // ckOutlookDiag
            // 
            this.ckOutlookDiag.AutoSize = true;
            this.ckOutlookDiag.Location = new System.Drawing.Point(8, 18);
            this.ckOutlookDiag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckOutlookDiag.Name = "ckOutlookDiag";
            this.ckOutlookDiag.Size = new System.Drawing.Size(190, 17);
            this.ckOutlookDiag.TabIndex = 0;
            this.ckOutlookDiag.Text = "Enable Graph Explorer Diagnostics";
            this.ckOutlookDiag.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 449);
            this.Controls.Add(this.btnGraphLog);
            this.Controls.Add(this.btnAppLog);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoVerbose;
        private System.Windows.Forms.RadioButton rdoError;
        private System.Windows.Forms.RadioButton rdoWarning;
        private System.Windows.Forms.RadioButton rdoInfo;
        private System.Windows.Forms.RadioButton rdoOff;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rdoAll;
        private System.Windows.Forms.RadioButton rdoActivity;
        private System.Windows.Forms.RadioButton rdoCritical;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGraphLog;
        private System.Windows.Forms.Button btnAppLog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoRefresh;
        private System.Windows.Forms.RadioButton rdoNever;
        private System.Windows.Forms.RadioButton rdoAuto;
        private System.Windows.Forms.RadioButton rdoAlways;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdoFileCache;
        private System.Windows.Forms.RadioButton rdoAdalCache;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenantId;
        private System.Windows.Forms.TextBox txtAuthority;
        private System.Windows.Forms.TextBox txtClientId;
        private System.Windows.Forms.TextBox txtRedirectUri;
        private System.Windows.Forms.CheckBox chkEditAppRegistration;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkFeedback;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.LinkLabel linkRegistration;
        private System.Windows.Forms.Button btnResetRegistration;
        private System.Windows.Forms.CheckBox ckOutlookDiag;
    }
}