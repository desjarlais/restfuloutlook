namespace RESTfulOutlook.Forms
{
    partial class MailAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailAPI));
            this.btnGetMessages = new System.Windows.Forms.Button();
            this.dgMessages = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewButtonColumn();
            this.attachments = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bcc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.body = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cc = new System.Windows.Forms.DataGridViewButtonColumn();
            this.replyto = new System.Windows.Forms.DataGridViewButtonColumn();
            this.categories = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bodypreview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changekey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conversationid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastmodified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiveddatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sentdatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasattachments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isdeliveryrequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isdraft = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isread = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isreadreceiptrequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parentfolderid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniquebody = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weblink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMessages = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbFolders = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgMessages)).BeginInit();
            this.mnuContextMenu.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetMessages
            // 
            this.btnGetMessages.Location = new System.Drawing.Point(16, 15);
            this.btnGetMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetMessages.Name = "btnGetMessages";
            this.btnGetMessages.Size = new System.Drawing.Size(153, 28);
            this.btnGetMessages.TabIndex = 0;
            this.btnGetMessages.Text = "Get Messages";
            this.btnGetMessages.UseVisualStyleBackColor = true;
            this.btnGetMessages.Click += new System.EventHandler(this.btnGetMessages_Click);
            // 
            // dgMessages
            // 
            this.dgMessages.AllowUserToAddRows = false;
            this.dgMessages.AllowUserToDeleteRows = false;
            this.dgMessages.AllowUserToResizeRows = false;
            this.dgMessages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMessages.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subject,
            this.sender,
            this.to,
            this.attachments,
            this.bcc,
            this.body,
            this.cc,
            this.replyto,
            this.categories,
            this.bodypreview,
            this.changekey,
            this.conversationid,
            this.createddatetime,
            this.lastmodified,
            this.receiveddatetime,
            this.sentdatetime,
            this.from,
            this.hasattachments,
            this.importance,
            this.isdeliveryrequested,
            this.isdraft,
            this.isread,
            this.isreadreceiptrequested,
            this.parentfolderid,
            this.uniquebody,
            this.weblink});
            this.dgMessages.Location = new System.Drawing.Point(16, 50);
            this.dgMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgMessages.MultiSelect = false;
            this.dgMessages.Name = "dgMessages";
            this.dgMessages.ReadOnly = true;
            this.dgMessages.Size = new System.Drawing.Size(1297, 546);
            this.dgMessages.TabIndex = 1;
            this.dgMessages.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMessages_CellContentDoubleClick);
            this.dgMessages.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgMessages_CellMouseDown);
            // 
            // id
            // 
            this.id.ContextMenuStrip = this.mnuContextMenu;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // mnuContextMenu
            // 
            this.mnuContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.mnuContextMenu.Name = "mnuContextMenu";
            this.mnuContextMenu.Size = new System.Drawing.Size(145, 26);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // subject
            // 
            this.subject.ContextMenuStrip = this.mnuContextMenu;
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            // 
            // sender
            // 
            this.sender.ContextMenuStrip = this.mnuContextMenu;
            this.sender.HeaderText = "Sender";
            this.sender.Name = "sender";
            this.sender.ReadOnly = true;
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.Name = "to";
            this.to.ReadOnly = true;
            this.to.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.to.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.to.Text = "";
            this.to.ToolTipText = "Double-Click to view recipients";
            // 
            // attachments
            // 
            this.attachments.HeaderText = "Attachments";
            this.attachments.Name = "attachments";
            this.attachments.ReadOnly = true;
            this.attachments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attachments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.attachments.Text = "";
            // 
            // bcc
            // 
            this.bcc.HeaderText = "Bcc";
            this.bcc.Name = "bcc";
            this.bcc.ReadOnly = true;
            this.bcc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bcc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bcc.Text = "";
            // 
            // body
            // 
            this.body.HeaderText = "Body";
            this.body.Name = "body";
            this.body.ReadOnly = true;
            this.body.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.body.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cc
            // 
            this.cc.HeaderText = "Cc";
            this.cc.Name = "cc";
            this.cc.ReadOnly = true;
            this.cc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cc.Text = "";
            // 
            // replyto
            // 
            this.replyto.HeaderText = "ReplyTo";
            this.replyto.Name = "replyto";
            this.replyto.ReadOnly = true;
            this.replyto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.replyto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.replyto.Text = "";
            // 
            // categories
            // 
            this.categories.HeaderText = "Categories";
            this.categories.Name = "categories";
            this.categories.ReadOnly = true;
            this.categories.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categories.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categories.Text = "";
            // 
            // bodypreview
            // 
            this.bodypreview.ContextMenuStrip = this.mnuContextMenu;
            this.bodypreview.HeaderText = "BodyPreview";
            this.bodypreview.Name = "bodypreview";
            this.bodypreview.ReadOnly = true;
            // 
            // changekey
            // 
            this.changekey.ContextMenuStrip = this.mnuContextMenu;
            this.changekey.HeaderText = "ChangeKey";
            this.changekey.Name = "changekey";
            this.changekey.ReadOnly = true;
            // 
            // conversationid
            // 
            this.conversationid.ContextMenuStrip = this.mnuContextMenu;
            this.conversationid.HeaderText = "ConversationId";
            this.conversationid.Name = "conversationid";
            this.conversationid.ReadOnly = true;
            // 
            // createddatetime
            // 
            this.createddatetime.ContextMenuStrip = this.mnuContextMenu;
            this.createddatetime.HeaderText = "CreatedDateTime";
            this.createddatetime.Name = "createddatetime";
            this.createddatetime.ReadOnly = true;
            // 
            // lastmodified
            // 
            this.lastmodified.ContextMenuStrip = this.mnuContextMenu;
            this.lastmodified.HeaderText = "LastModifiedDateTime";
            this.lastmodified.Name = "lastmodified";
            this.lastmodified.ReadOnly = true;
            // 
            // receiveddatetime
            // 
            this.receiveddatetime.ContextMenuStrip = this.mnuContextMenu;
            this.receiveddatetime.HeaderText = "ReceivedDateTime";
            this.receiveddatetime.Name = "receiveddatetime";
            this.receiveddatetime.ReadOnly = true;
            // 
            // sentdatetime
            // 
            this.sentdatetime.ContextMenuStrip = this.mnuContextMenu;
            this.sentdatetime.HeaderText = "SentDateTime";
            this.sentdatetime.Name = "sentdatetime";
            this.sentdatetime.ReadOnly = true;
            // 
            // from
            // 
            this.from.ContextMenuStrip = this.mnuContextMenu;
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // hasattachments
            // 
            this.hasattachments.ContextMenuStrip = this.mnuContextMenu;
            this.hasattachments.HeaderText = "HasAttachments";
            this.hasattachments.Name = "hasattachments";
            this.hasattachments.ReadOnly = true;
            // 
            // importance
            // 
            this.importance.ContextMenuStrip = this.mnuContextMenu;
            this.importance.HeaderText = "Importance";
            this.importance.Name = "importance";
            this.importance.ReadOnly = true;
            // 
            // isdeliveryrequested
            // 
            this.isdeliveryrequested.ContextMenuStrip = this.mnuContextMenu;
            this.isdeliveryrequested.HeaderText = "IsDeliveryReceiptRequested";
            this.isdeliveryrequested.Name = "isdeliveryrequested";
            this.isdeliveryrequested.ReadOnly = true;
            // 
            // isdraft
            // 
            this.isdraft.ContextMenuStrip = this.mnuContextMenu;
            this.isdraft.HeaderText = "IsDraft";
            this.isdraft.Name = "isdraft";
            this.isdraft.ReadOnly = true;
            // 
            // isread
            // 
            this.isread.ContextMenuStrip = this.mnuContextMenu;
            this.isread.HeaderText = "IsRead";
            this.isread.Name = "isread";
            this.isread.ReadOnly = true;
            // 
            // isreadreceiptrequested
            // 
            this.isreadreceiptrequested.ContextMenuStrip = this.mnuContextMenu;
            this.isreadreceiptrequested.HeaderText = "IsReadReceiptRequested";
            this.isreadreceiptrequested.Name = "isreadreceiptrequested";
            this.isreadreceiptrequested.ReadOnly = true;
            // 
            // parentfolderid
            // 
            this.parentfolderid.ContextMenuStrip = this.mnuContextMenu;
            this.parentfolderid.HeaderText = "ParentFolderId";
            this.parentfolderid.Name = "parentfolderid";
            this.parentfolderid.ReadOnly = true;
            // 
            // uniquebody
            // 
            this.uniquebody.ContextMenuStrip = this.mnuContextMenu;
            this.uniquebody.HeaderText = "UniqueBody";
            this.uniquebody.Name = "uniquebody";
            this.uniquebody.ReadOnly = true;
            // 
            // weblink
            // 
            this.weblink.ContextMenuStrip = this.mnuContextMenu;
            this.weblink.HeaderText = "WebLink";
            this.weblink.Name = "weblink";
            this.weblink.ReadOnly = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1329, 22);
            this.statusStrip1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(943, 601);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Double-Click Cell to open collection objects like recipients";
            // 
            // nudMessages
            // 
            this.nudMessages.Location = new System.Drawing.Point(177, 18);
            this.nudMessages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudMessages.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudMessages.Name = "nudMessages";
            this.nudMessages.Size = new System.Drawing.Size(69, 22);
            this.nudMessages.TabIndex = 4;
            this.nudMessages.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(255, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(265, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of messages to return (default = 10)";
            // 
            // cmbFolders
            // 
            this.cmbFolders.FormattingEnabled = true;
            this.cmbFolders.Location = new System.Drawing.Point(1119, 17);
            this.cmbFolders.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFolders.Name = "cmbFolders";
            this.cmbFolders.Size = new System.Drawing.Size(193, 24);
            this.cmbFolders.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1063, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Folder";
            // 
            // MailAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 660);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbFolders);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMessages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgMessages);
            this.Controls.Add(this.btnGetMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MailAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MailAPI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MailAPI_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgMessages)).EndInit();
            this.mnuContextMenu.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetMessages;
        private System.Windows.Forms.DataGridView dgMessages;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip mnuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn weblink;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniquebody;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentfolderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn isreadreceiptrequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn isread;
        private System.Windows.Forms.DataGridViewTextBoxColumn isdraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn isdeliveryrequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn importance;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasattachments;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentdatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveddatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastmodified;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn conversationid;
        private System.Windows.Forms.DataGridViewTextBoxColumn changekey;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodypreview;
        private System.Windows.Forms.DataGridViewButtonColumn categories;
        private System.Windows.Forms.DataGridViewButtonColumn replyto;
        private System.Windows.Forms.DataGridViewButtonColumn cc;
        private System.Windows.Forms.DataGridViewButtonColumn body;
        private System.Windows.Forms.DataGridViewButtonColumn bcc;
        private System.Windows.Forms.DataGridViewButtonColumn attachments;
        private System.Windows.Forms.DataGridViewButtonColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.NumericUpDown nudMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbFolders;
        private System.Windows.Forms.Label label3;
    }
}