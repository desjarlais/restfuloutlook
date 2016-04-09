namespace RESTfulOutlook.Forms
{
    partial class GraphAPI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphAPI));
            this.label1 = new System.Windows.Forms.Label();
            this.btnRunQuery = new System.Windows.Forms.Button();
            this.cbRESTQuery = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoV2 = new System.Windows.Forms.RadioButton();
            this.rdoBeta = new System.Windows.Forms.RadioButton();
            this.rdoV1 = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tbRequest = new System.Windows.Forms.TextBox();
            this.cmbHttpMethod = new System.Windows.Forms.ComboBox();
            this.tvw = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddRequestHeader = new System.Windows.Forms.Button();
            this.dgRequestHeaders = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteHeader = new System.Windows.Forms.Button();
            this.lnkQueryParams = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lnkErrors = new System.Windows.Forms.LinkLabel();
            this.lnkCallAPI = new System.Windows.Forms.LinkLabel();
            this.lnkPaging = new System.Windows.Forms.LinkLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnClearResponse = new System.Windows.Forms.Button();
            this.btnGraphLog = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbRequestBody = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRequestHeaders)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select a predefined REST Query :";
            // 
            // btnRunQuery
            // 
            this.btnRunQuery.Location = new System.Drawing.Point(485, 173);
            this.btnRunQuery.Name = "btnRunQuery";
            this.btnRunQuery.Size = new System.Drawing.Size(89, 46);
            this.btnRunQuery.TabIndex = 2;
            this.btnRunQuery.Text = "Run Query ==>";
            this.btnRunQuery.UseVisualStyleBackColor = true;
            this.btnRunQuery.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbRESTQuery
            // 
            this.cbRESTQuery.FormattingEnabled = true;
            this.cbRESTQuery.Items.AddRange(new object[] {
            "OutlookMail-ListMessages",
            "OutlookMail-ListMailFolders",
            "OutlookMail-SearchInbox",
            "OutlookMail-GetImportanUnreadMessages",
            "OutlookMail-SendTestMessage",
            "OutlookCalendar-ListCalendars",
            "OutlookCalendar-CreateTestEvent",
            "OutlookCalendar-ListCalendarGroups",
            "OutlookCalendar-ListCalendarView",
            "OutlookContacts-ListContacts",
            "OutlookContacts-CreateTestContact",
            "OutlookContacts-ListContactFolders",
            "OutlookGroups-ListGroups",
            "OutlookGroups-ListMemberOf",
            "Graph-Metadata"});
            this.cbRESTQuery.Location = new System.Drawing.Point(180, 11);
            this.cbRESTQuery.Name = "cbRESTQuery";
            this.cbRESTQuery.Size = new System.Drawing.Size(419, 21);
            this.cbRESTQuery.TabIndex = 4;
            this.cbRESTQuery.SelectedValueChanged += new System.EventHandler(this.cbRESTQuery_SelectedValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoV2);
            this.groupBox1.Controls.Add(this.rdoBeta);
            this.groupBox1.Controls.Add(this.rdoV1);
            this.groupBox1.Location = new System.Drawing.Point(6, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 53);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "API Version";
            // 
            // rdoV2
            // 
            this.rdoV2.AutoSize = true;
            this.rdoV2.Enabled = false;
            this.rdoV2.Location = new System.Drawing.Point(110, 19);
            this.rdoV2.Name = "rdoV2";
            this.rdoV2.Size = new System.Drawing.Size(46, 17);
            this.rdoV2.TabIndex = 3;
            this.rdoV2.TabStop = true;
            this.rdoV2.Text = "v2.0";
            this.rdoV2.UseVisualStyleBackColor = true;
            // 
            // rdoBeta
            // 
            this.rdoBeta.AutoSize = true;
            this.rdoBeta.Location = new System.Drawing.Point(58, 19);
            this.rdoBeta.Name = "rdoBeta";
            this.rdoBeta.Size = new System.Drawing.Size(46, 17);
            this.rdoBeta.TabIndex = 2;
            this.rdoBeta.Text = "beta";
            this.rdoBeta.UseVisualStyleBackColor = true;
            // 
            // rdoV1
            // 
            this.rdoV1.AutoSize = true;
            this.rdoV1.Checked = true;
            this.rdoV1.Location = new System.Drawing.Point(6, 19);
            this.rdoV1.Name = "rdoV1";
            this.rdoV1.Size = new System.Drawing.Size(46, 17);
            this.rdoV1.TabIndex = 1;
            this.rdoV1.TabStop = true;
            this.rdoV1.Text = "v1.0";
            this.rdoV1.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1122, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(48, 17);
            this.toolStripStatusLabel1.Text = "Status : ";
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatus.Text = "Ready";
            // 
            // tbRequest
            // 
            this.tbRequest.Location = new System.Drawing.Point(109, 53);
            this.tbRequest.MaxLength = 2083;
            this.tbRequest.Name = "tbRequest";
            this.tbRequest.Size = new System.Drawing.Size(490, 20);
            this.tbRequest.TabIndex = 9;
            // 
            // cmbHttpMethod
            // 
            this.cmbHttpMethod.FormattingEnabled = true;
            this.cmbHttpMethod.Items.AddRange(new object[] {
            "GET",
            "PUT",
            "POST",
            "DELETE",
            "HEAD",
            "OPTIONS"});
            this.cmbHttpMethod.Location = new System.Drawing.Point(9, 52);
            this.cmbHttpMethod.Name = "cmbHttpMethod";
            this.cmbHttpMethod.Size = new System.Drawing.Size(94, 21);
            this.cmbHttpMethod.TabIndex = 10;
            this.cmbHttpMethod.Text = "GET";
            // 
            // tvw
            // 
            this.tvw.ContextMenuStrip = this.contextMenuStrip1;
            this.tvw.Location = new System.Drawing.Point(6, 19);
            this.tvw.Name = "tvw";
            this.tvw.Size = new System.Drawing.Size(491, 483);
            this.tvw.TabIndex = 11;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(103, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // btnAddRequestHeader
            // 
            this.btnAddRequestHeader.Image = global::RESTfulOutlook.Properties.Resources.AddMark_10580;
            this.btnAddRequestHeader.Location = new System.Drawing.Point(6, 19);
            this.btnAddRequestHeader.Name = "btnAddRequestHeader";
            this.btnAddRequestHeader.Size = new System.Drawing.Size(37, 23);
            this.btnAddRequestHeader.TabIndex = 14;
            this.btnAddRequestHeader.UseVisualStyleBackColor = true;
            this.btnAddRequestHeader.Click += new System.EventHandler(this.btnAddRequestHeader_Click);
            // 
            // dgRequestHeaders
            // 
            this.dgRequestHeaders.AllowUserToAddRows = false;
            this.dgRequestHeaders.AllowUserToDeleteRows = false;
            this.dgRequestHeaders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRequestHeaders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.value});
            this.dgRequestHeaders.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgRequestHeaders.Location = new System.Drawing.Point(49, 19);
            this.dgRequestHeaders.MultiSelect = false;
            this.dgRequestHeaders.Name = "dgRequestHeaders";
            this.dgRequestHeaders.Size = new System.Drawing.Size(525, 138);
            this.dgRequestHeaders.TabIndex = 15;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // value
            // 
            this.value.HeaderText = "Value";
            this.value.Name = "value";
            this.value.Width = 350;
            // 
            // btnDeleteHeader
            // 
            this.btnDeleteHeader.Image = global::RESTfulOutlook.Properties.Resources.Clearallrequests_8816;
            this.btnDeleteHeader.Location = new System.Drawing.Point(6, 48);
            this.btnDeleteHeader.Name = "btnDeleteHeader";
            this.btnDeleteHeader.Size = new System.Drawing.Size(37, 23);
            this.btnDeleteHeader.TabIndex = 16;
            this.btnDeleteHeader.UseVisualStyleBackColor = true;
            this.btnDeleteHeader.Click += new System.EventHandler(this.btnDeleteHeader_Click);
            // 
            // lnkQueryParams
            // 
            this.lnkQueryParams.AutoSize = true;
            this.lnkQueryParams.Location = new System.Drawing.Point(6, 22);
            this.lnkQueryParams.Name = "lnkQueryParams";
            this.lnkQueryParams.Size = new System.Drawing.Size(91, 13);
            this.lnkQueryParams.TabIndex = 17;
            this.lnkQueryParams.TabStop = true;
            this.lnkQueryParams.Text = "Query Parameters";
            this.lnkQueryParams.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkQueryParams_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.dgRequestHeaders);
            this.groupBox2.Controls.Add(this.btnDeleteHeader);
            this.groupBox2.Controls.Add(this.btnAddRequestHeader);
            this.groupBox2.Controls.Add(this.btnRunQuery);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(587, 225);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Request Headers";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lnkErrors);
            this.groupBox4.Controls.Add(this.lnkCallAPI);
            this.groupBox4.Controls.Add(this.lnkPaging);
            this.groupBox4.Controls.Add(this.lnkQueryParams);
            this.groupBox4.Location = new System.Drawing.Point(175, 166);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 54);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Help Documentation";
            // 
            // lnkErrors
            // 
            this.lnkErrors.AutoSize = true;
            this.lnkErrors.Location = new System.Drawing.Point(263, 22);
            this.lnkErrors.Name = "lnkErrors";
            this.lnkErrors.Size = new System.Drawing.Size(34, 13);
            this.lnkErrors.TabIndex = 22;
            this.lnkErrors.TabStop = true;
            this.lnkErrors.Text = "Errors";
            this.lnkErrors.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkErrors_LinkClicked);
            // 
            // lnkCallAPI
            // 
            this.lnkCallAPI.AutoSize = true;
            this.lnkCallAPI.Location = new System.Drawing.Point(149, 22);
            this.lnkCallAPI.Name = "lnkCallAPI";
            this.lnkCallAPI.Size = new System.Drawing.Size(108, 13);
            this.lnkCallAPI.TabIndex = 21;
            this.lnkCallAPI.TabStop = true;
            this.lnkCallAPI.Text = "Calling the Graph API";
            this.lnkCallAPI.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkCallAPI_LinkClicked);
            // 
            // lnkPaging
            // 
            this.lnkPaging.AutoSize = true;
            this.lnkPaging.Location = new System.Drawing.Point(103, 22);
            this.lnkPaging.Name = "lnkPaging";
            this.lnkPaging.Size = new System.Drawing.Size(40, 13);
            this.lnkPaging.TabIndex = 20;
            this.lnkPaging.TabStop = true;
            this.lnkPaging.Text = "Paging";
            this.lnkPaging.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkPaging_LinkClicked);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnClearResponse);
            this.groupBox3.Controls.Add(this.btnGraphLog);
            this.groupBox3.Controls.Add(this.tvw);
            this.groupBox3.Location = new System.Drawing.Point(607, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(503, 544);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Response";
            // 
            // btnClearResponse
            // 
            this.btnClearResponse.Location = new System.Drawing.Point(260, 507);
            this.btnClearResponse.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearResponse.Name = "btnClearResponse";
            this.btnClearResponse.Size = new System.Drawing.Size(118, 31);
            this.btnClearResponse.TabIndex = 13;
            this.btnClearResponse.Text = "Clear Response Data";
            this.btnClearResponse.UseVisualStyleBackColor = true;
            this.btnClearResponse.Click += new System.EventHandler(this.btnClearResponse_Click);
            // 
            // btnGraphLog
            // 
            this.btnGraphLog.Location = new System.Drawing.Point(382, 507);
            this.btnGraphLog.Margin = new System.Windows.Forms.Padding(2);
            this.btnGraphLog.Name = "btnGraphLog";
            this.btnGraphLog.Size = new System.Drawing.Size(114, 31);
            this.btnGraphLog.TabIndex = 12;
            this.btnGraphLog.Text = "Graph Explorer Log";
            this.btnGraphLog.UseVisualStyleBackColor = true;
            this.btnGraphLog.Click += new System.EventHandler(this.btnGraphLog_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Http Method :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Request Url :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbRequestBody);
            this.groupBox5.Location = new System.Drawing.Point(12, 310);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(587, 239);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Request Body";
            // 
            // tbRequestBody
            // 
            this.tbRequestBody.Location = new System.Drawing.Point(12, 19);
            this.tbRequestBody.Multiline = true;
            this.tbRequestBody.Name = "tbRequestBody";
            this.tbRequestBody.Size = new System.Drawing.Size(562, 214);
            this.tbRequestBody.TabIndex = 0;
            // 
            // GraphAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1122, 574);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.cmbHttpMethod);
            this.Controls.Add(this.tbRequest);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.cbRESTQuery);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GraphAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Graph Explorer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GraphAPI_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRequestHeaders)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRunQuery;
        private System.Windows.Forms.ComboBox cbRESTQuery;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBeta;
        private System.Windows.Forms.RadioButton rdoV1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.TextBox tbRequest;
        private System.Windows.Forms.ComboBox cmbHttpMethod;
        private System.Windows.Forms.TreeView tvw;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.RadioButton rdoV2;
        private System.Windows.Forms.Button btnAddRequestHeader;
        private System.Windows.Forms.DataGridView dgRequestHeaders;
        private System.Windows.Forms.Button btnDeleteHeader;
        private System.Windows.Forms.LinkLabel lnkQueryParams;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel lnkPaging;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel lnkErrors;
        private System.Windows.Forms.LinkLabel lnkCallAPI;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox tbRequestBody;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.Button btnGraphLog;
        private System.Windows.Forms.Button btnClearResponse;
    }
}