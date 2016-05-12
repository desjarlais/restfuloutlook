namespace RESTfulOutlook.Forms
{
    partial class NewMessageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewMessageForm));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxImportance = new System.Windows.Forms.ComboBox();
            this.tbCC = new System.Windows.Forms.TextBox();
            this.tbBcc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.tbSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbToRecipients = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgAttachments = new System.Windows.Forms.DataGridView();
            this.colFilePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContentType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colFileSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInline = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.odatatype = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btnRemoveAttachment = new System.Windows.Forms.Button();
            this.btnAddAttachment = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAttachments)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "To...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxImportance);
            this.groupBox1.Controls.Add(this.tbCC);
            this.groupBox1.Controls.Add(this.tbBcc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.rtbBody);
            this.groupBox1.Controls.Add(this.btnSendEmail);
            this.groupBox1.Controls.Add(this.tbSubject);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbToRecipients);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 353);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Message Details";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(640, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Importance:";
            // 
            // cbxImportance
            // 
            this.cbxImportance.FormattingEnabled = true;
            this.cbxImportance.Items.AddRange(new object[] {
            "Normal",
            "High",
            "Low"});
            this.cbxImportance.Location = new System.Drawing.Point(709, 20);
            this.cbxImportance.Name = "cbxImportance";
            this.cbxImportance.Size = new System.Drawing.Size(84, 21);
            this.cbxImportance.TabIndex = 6;
            this.cbxImportance.Text = "Normal";
            // 
            // tbCC
            // 
            this.tbCC.Location = new System.Drawing.Point(118, 45);
            this.tbCC.Name = "tbCC";
            this.tbCC.Size = new System.Drawing.Size(359, 20);
            this.tbCC.TabIndex = 2;
            // 
            // tbBcc
            // 
            this.tbBcc.Location = new System.Drawing.Point(524, 46);
            this.tbBcc.Name = "tbBcc";
            this.tbBcc.Size = new System.Drawing.Size(269, 20);
            this.tbBcc.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Bcc...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cc...";
            // 
            // rtbBody
            // 
            this.rtbBody.Location = new System.Drawing.Point(9, 104);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.Size = new System.Drawing.Size(784, 236);
            this.rtbBody.TabIndex = 4;
            this.rtbBody.Text = "";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Image = ((System.Drawing.Image)(resources.GetObject("btnSendEmail.Image")));
            this.btnSendEmail.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSendEmail.Location = new System.Drawing.Point(9, 19);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(68, 46);
            this.btnSendEmail.TabIndex = 4;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // tbSubject
            // 
            this.tbSubject.Location = new System.Drawing.Point(58, 78);
            this.tbSubject.Name = "tbSubject";
            this.tbSubject.Size = new System.Drawing.Size(735, 20);
            this.tbSubject.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subject:";
            // 
            // tbToRecipients
            // 
            this.tbToRecipients.Location = new System.Drawing.Point(118, 19);
            this.tbToRecipients.Name = "tbToRecipients";
            this.tbToRecipients.Size = new System.Drawing.Size(516, 20);
            this.tbToRecipients.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgAttachments);
            this.groupBox2.Controls.Add(this.btnRemoveAttachment);
            this.groupBox2.Controls.Add(this.btnAddAttachment);
            this.groupBox2.Location = new System.Drawing.Point(12, 371);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(799, 182);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message Attachments";
            // 
            // dgAttachments
            // 
            this.dgAttachments.AllowUserToAddRows = false;
            this.dgAttachments.AllowUserToDeleteRows = false;
            this.dgAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFilePath,
            this.name,
            this.colContentType,
            this.colFileSize,
            this.colContentId,
            this.colInline,
            this.odatatype});
            this.dgAttachments.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgAttachments.Location = new System.Drawing.Point(9, 19);
            this.dgAttachments.MultiSelect = false;
            this.dgAttachments.Name = "dgAttachments";
            this.dgAttachments.Size = new System.Drawing.Size(732, 157);
            this.dgAttachments.TabIndex = 26;
            // 
            // colFilePath
            // 
            this.colFilePath.HeaderText = "File Path";
            this.colFilePath.Name = "colFilePath";
            this.colFilePath.ReadOnly = true;
            this.colFilePath.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            // 
            // colContentType
            // 
            this.colContentType.AutoComplete = false;
            this.colContentType.HeaderText = "Content Type";
            this.colContentType.Items.AddRange(new object[] {
            "Octet",
            "Pdf",
            "Rtf",
            "Soap",
            "Zip",
            "Gif",
            "Jpeg",
            "Tiff",
            "Html",
            "Plain",
            "RichText",
            "Xml"});
            this.colContentType.Name = "colContentType";
            this.colContentType.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colContentType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // colFileSize
            // 
            this.colFileSize.HeaderText = "Size";
            this.colFileSize.Name = "colFileSize";
            this.colFileSize.Width = 75;
            // 
            // colContentId
            // 
            this.colContentId.HeaderText = "Content Id";
            this.colContentId.Name = "colContentId";
            // 
            // colInline
            // 
            this.colInline.HeaderText = "Inline";
            this.colInline.Items.AddRange(new object[] {
            "True",
            "False"});
            this.colInline.Name = "colInline";
            this.colInline.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colInline.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colInline.Width = 50;
            // 
            // odatatype
            // 
            this.odatatype.HeaderText = "ODataType";
            this.odatatype.Items.AddRange(new object[] {
            "#Microsoft.OutlookServices.FileAttachment",
            "#Microsoft.OutlookServices.ItemAttachment",
            "#Microsoft.OutlookServices.ReferenceAttachment"});
            this.odatatype.Name = "odatatype";
            this.odatatype.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.odatatype.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnRemoveAttachment
            // 
            this.btnRemoveAttachment.Image = global::RESTfulOutlook.Properties.Resources.Clearallrequests_8816;
            this.btnRemoveAttachment.Location = new System.Drawing.Point(747, 48);
            this.btnRemoveAttachment.Name = "btnRemoveAttachment";
            this.btnRemoveAttachment.Size = new System.Drawing.Size(46, 23);
            this.btnRemoveAttachment.TabIndex = 2;
            this.btnRemoveAttachment.UseVisualStyleBackColor = true;
            this.btnRemoveAttachment.Click += new System.EventHandler(this.btnRemoveAttachment_Click);
            // 
            // btnAddAttachment
            // 
            this.btnAddAttachment.Image = global::RESTfulOutlook.Properties.Resources.AddMark_10580;
            this.btnAddAttachment.Location = new System.Drawing.Point(747, 19);
            this.btnAddAttachment.Name = "btnAddAttachment";
            this.btnAddAttachment.Size = new System.Drawing.Size(46, 23);
            this.btnAddAttachment.TabIndex = 1;
            this.btnAddAttachment.UseVisualStyleBackColor = true;
            this.btnAddAttachment.Click += new System.EventHandler(this.btnAddAttachment_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NewMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 565);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Message";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAttachments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbToRecipients;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxImportance;
        private System.Windows.Forms.TextBox tbCC;
        private System.Windows.Forms.TextBox tbBcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRemoveAttachment;
        private System.Windows.Forms.Button btnAddAttachment;
        private System.Windows.Forms.DataGridView dgAttachments;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFilePath;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewComboBoxColumn colContentType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContentId;
        private System.Windows.Forms.DataGridViewComboBoxColumn colInline;
        private System.Windows.Forms.DataGridViewComboBoxColumn odatatype;
    }
}