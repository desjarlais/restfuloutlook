namespace RESTfulOutlook.Forms
{
    partial class ReportingService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingService));
            this.label1 = new System.Windows.Forms.Label();
            this.txtO365ReportingServiceEndpoint = new System.Windows.Forms.TextBox();
            this.btnCheckEndpoint = new System.Windows.Forms.Button();
            this.cmbReportList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRange = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoAtom = new System.Windows.Forms.RadioButton();
            this.rdoJSON = new System.Windows.Forms.RadioButton();
            this.btnGenerateRESTURL = new System.Windows.Forms.Button();
            this.btnCopyRESTURL = new System.Windows.Forms.Button();
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.btnCopyResults = new System.Windows.Forms.Button();
            this.txtResults = new System.Windows.Forms.TextBox();
            this.btnAppendToLog = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripFormStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtRESTUrl = new System.Windows.Forms.TextBox();
            this.btnEditRESTURL = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Office 365 Reporting Web Service Endpoint";
            // 
            // txtO365ReportingServiceEndpoint
            // 
            this.txtO365ReportingServiceEndpoint.Location = new System.Drawing.Point(233, 11);
            this.txtO365ReportingServiceEndpoint.Name = "txtO365ReportingServiceEndpoint";
            this.txtO365ReportingServiceEndpoint.ReadOnly = true;
            this.txtO365ReportingServiceEndpoint.Size = new System.Drawing.Size(324, 20);
            this.txtO365ReportingServiceEndpoint.TabIndex = 1;
            this.txtO365ReportingServiceEndpoint.Text = "reports.office365.com";
            // 
            // btnCheckEndpoint
            // 
            this.btnCheckEndpoint.Location = new System.Drawing.Point(563, 9);
            this.btnCheckEndpoint.Name = "btnCheckEndpoint";
            this.btnCheckEndpoint.Size = new System.Drawing.Size(103, 23);
            this.btnCheckEndpoint.TabIndex = 2;
            this.btnCheckEndpoint.Text = "Check Endpoint";
            this.btnCheckEndpoint.UseVisualStyleBackColor = true;
            this.btnCheckEndpoint.Click += new System.EventHandler(this.btnCheckEndpoint_Click);
            // 
            // cmbReportList
            // 
            this.cmbReportList.FormattingEnabled = true;
            this.cmbReportList.Items.AddRange(new object[] {
            "ConnectionbyClientTypeDetailDaily",
            "ConnectionbyClientTypeDetailWeekly",
            "ConnectionbyClientTypeDetailMonthly",
            "ConnectionbyClientTypeDetailYearly",
            "ConnectionbyClientTypeDaily",
            "ConnectionbyClientTypeWeekly",
            "ConnectionbyClientTypeMonthly",
            "ConnectionbyClientTypeYearly",
            "GroupActivityDaily",
            "GroupActivityWeekly",
            "GroupActivityMonthly",
            "GroupActivityYearly",
            "MailboxActivityDaily",
            "MailboxActivityWeekly",
            "MailboxActivityMonthly",
            "MailboxActivityYearly",
            "MailboxUsage",
            "MailboxUsageDetail",
            "MailDetailDlpPolicy",
            "MailDetailMalware",
            "MailDetailSpam",
            "MailDetailTransportRule (inbound)",
            "MailDetailTransportRule (outbound)",
            "MailFilterList",
            "MailTraffic (inbound)",
            "MailTraffic (outbound)",
            "MailTrafficPolicy (inbound)",
            "MailTrafficPolicy (outbound)",
            "MailTrafficSummary (TopMailSender)",
            "MailTrafficSummary (TopMalware)",
            "MailTrafficTop (inbound)",
            "MailTrafficTop (outbound)",
            "MessageTrace",
            "MessageTraceDetail",
            "MxRecordReport",
            "OutboundConnectorReport",
            "ServiceDeliveryReport",
            "StaleMailbox",
            "StaleMailboxDetail"});
            this.cmbReportList.Location = new System.Drawing.Point(15, 41);
            this.cmbReportList.Name = "cmbReportList";
            this.cmbReportList.Size = new System.Drawing.Size(651, 21);
            this.cmbReportList.TabIndex = 3;
            this.cmbReportList.SelectedValueChanged += new System.EventHandler(this.cmbReportList_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Query Parameters, use one per line";
            // 
            // txtRange
            // 
            this.txtRange.Location = new System.Drawing.Point(15, 97);
            this.txtRange.Multiline = true;
            this.txtRange.Name = "txtRange";
            this.txtRange.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtRange.Size = new System.Drawing.Size(651, 136);
            this.txtRange.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoAtom);
            this.groupBox1.Controls.Add(this.rdoJSON);
            this.groupBox1.Location = new System.Drawing.Point(15, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 41);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Results Format:";
            // 
            // rdoAtom
            // 
            this.rdoAtom.AutoSize = true;
            this.rdoAtom.Location = new System.Drawing.Point(65, 19);
            this.rdoAtom.Name = "rdoAtom";
            this.rdoAtom.Size = new System.Drawing.Size(49, 17);
            this.rdoAtom.TabIndex = 1;
            this.rdoAtom.Text = "Atom";
            this.rdoAtom.UseVisualStyleBackColor = true;
            // 
            // rdoJSON
            // 
            this.rdoJSON.AutoSize = true;
            this.rdoJSON.Checked = true;
            this.rdoJSON.Location = new System.Drawing.Point(6, 19);
            this.rdoJSON.Name = "rdoJSON";
            this.rdoJSON.Size = new System.Drawing.Size(53, 17);
            this.rdoJSON.TabIndex = 0;
            this.rdoJSON.TabStop = true;
            this.rdoJSON.Text = "JSON";
            this.rdoJSON.UseVisualStyleBackColor = true;
            // 
            // btnGenerateRESTURL
            // 
            this.btnGenerateRESTURL.Location = new System.Drawing.Point(155, 257);
            this.btnGenerateRESTURL.Name = "btnGenerateRESTURL";
            this.btnGenerateRESTURL.Size = new System.Drawing.Size(156, 23);
            this.btnGenerateRESTURL.TabIndex = 2;
            this.btnGenerateRESTURL.Text = "Generate REST URL";
            this.btnGenerateRESTURL.UseVisualStyleBackColor = true;
            this.btnGenerateRESTURL.Click += new System.EventHandler(this.btnGenerateRESTURL_Click);
            // 
            // btnCopyRESTURL
            // 
            this.btnCopyRESTURL.Location = new System.Drawing.Point(317, 258);
            this.btnCopyRESTURL.Name = "btnCopyRESTURL";
            this.btnCopyRESTURL.Size = new System.Drawing.Size(117, 23);
            this.btnCopyRESTURL.TabIndex = 3;
            this.btnCopyRESTURL.Text = "Copy REST URL";
            this.btnCopyRESTURL.UseVisualStyleBackColor = true;
            this.btnCopyRESTURL.Click += new System.EventHandler(this.btnCopyRESTURL_Click);
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.Location = new System.Drawing.Point(549, 258);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(117, 23);
            this.btnSendRequest.TabIndex = 9;
            this.btnSendRequest.Text = "Send Request";
            this.btnSendRequest.UseVisualStyleBackColor = true;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // btnCopyResults
            // 
            this.btnCopyResults.Location = new System.Drawing.Point(12, 578);
            this.btnCopyResults.Name = "btnCopyResults";
            this.btnCopyResults.Size = new System.Drawing.Size(117, 23);
            this.btnCopyResults.TabIndex = 10;
            this.btnCopyResults.Text = "Copy Full Results";
            this.btnCopyResults.UseVisualStyleBackColor = true;
            this.btnCopyResults.Click += new System.EventHandler(this.btnCopyResults_Click);
            // 
            // txtResults
            // 
            this.txtResults.Location = new System.Drawing.Point(15, 312);
            this.txtResults.Multiline = true;
            this.txtResults.Name = "txtResults";
            this.txtResults.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResults.Size = new System.Drawing.Size(651, 260);
            this.txtResults.TabIndex = 11;
            // 
            // btnAppendToLog
            // 
            this.btnAppendToLog.Location = new System.Drawing.Point(135, 578);
            this.btnAppendToLog.Name = "btnAppendToLog";
            this.btnAppendToLog.Size = new System.Drawing.Size(159, 23);
            this.btnAppendToLog.TabIndex = 12;
            this.btnAppendToLog.Text = "Append results to log file";
            this.btnAppendToLog.UseVisualStyleBackColor = true;
            this.btnAppendToLog.Click += new System.EventHandler(this.btnAppendToLog_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatus,
            this.toolStripStatusLabel1,
            this.toolStripFormStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(678, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(45, 17);
            this.toolStripStatusLabel1.Text = "Status :";
            // 
            // toolStripFormStatus
            // 
            this.toolStripFormStatus.Name = "toolStripFormStatus";
            this.toolStripFormStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // txtRESTUrl
            // 
            this.txtRESTUrl.Location = new System.Drawing.Point(15, 286);
            this.txtRESTUrl.Name = "txtRESTUrl";
            this.txtRESTUrl.ReadOnly = true;
            this.txtRESTUrl.Size = new System.Drawing.Size(651, 20);
            this.txtRESTUrl.TabIndex = 14;
            // 
            // btnEditRESTURL
            // 
            this.btnEditRESTURL.Location = new System.Drawing.Point(440, 258);
            this.btnEditRESTURL.Name = "btnEditRESTURL";
            this.btnEditRESTURL.Size = new System.Drawing.Size(103, 23);
            this.btnEditRESTURL.TabIndex = 15;
            this.btnEditRESTURL.Text = "Edit REST URL";
            this.btnEditRESTURL.UseVisualStyleBackColor = true;
            this.btnEditRESTURL.Click += new System.EventHandler(this.btnEditRESTURL_Click);
            // 
            // ReportingService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 634);
            this.Controls.Add(this.btnEditRESTURL);
            this.Controls.Add(this.txtRESTUrl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnAppendToLog);
            this.Controls.Add(this.txtResults);
            this.Controls.Add(this.btnCopyResults);
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.btnGenerateRESTURL);
            this.Controls.Add(this.btnCopyRESTURL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtRange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbReportList);
            this.Controls.Add(this.btnCheckEndpoint);
            this.Controls.Add(this.txtO365ReportingServiceEndpoint);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ReportingService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReportingService";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtO365ReportingServiceEndpoint;
        private System.Windows.Forms.Button btnCheckEndpoint;
        private System.Windows.Forms.ComboBox cmbReportList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRange;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoAtom;
        private System.Windows.Forms.RadioButton rdoJSON;
        private System.Windows.Forms.Button btnGenerateRESTURL;
        private System.Windows.Forms.Button btnCopyRESTURL;
        private System.Windows.Forms.Button btnSendRequest;
        private System.Windows.Forms.Button btnCopyResults;
        private System.Windows.Forms.TextBox txtResults;
        private System.Windows.Forms.Button btnAppendToLog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.TextBox txtRESTUrl;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripFormStatus;
        private System.Windows.Forms.Button btnEditRESTURL;
    }
}