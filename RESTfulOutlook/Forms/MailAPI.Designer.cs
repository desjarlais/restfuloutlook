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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MailAPI));
            this.dgMessages = new System.Windows.Forms.DataGridView();
            this.mnuContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.nudMessages = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateNewMessage = new System.Windows.Forms.Button();
            this.tvwFolders = new System.Windows.Forms.TreeView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgMessages)).BeginInit();
            this.mnuContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // dgMessages
            // 
            this.dgMessages.AllowUserToAddRows = false;
            this.dgMessages.AllowUserToDeleteRows = false;
            this.dgMessages.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMessages.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMessages.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgMessages.Location = new System.Drawing.Point(216, 25);
            this.dgMessages.MultiSelect = false;
            this.dgMessages.Name = "dgMessages";
            this.dgMessages.ReadOnly = true;
            this.dgMessages.Size = new System.Drawing.Size(769, 460);
            this.dgMessages.TabIndex = 1;
            this.dgMessages.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMessages_CellContentDoubleClick);
            this.dgMessages.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgMessages_CellMouseDown);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(707, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Double-Click Cell to open collection objects like recipients";
            // 
            // nudMessages
            // 
            this.nudMessages.Location = new System.Drawing.Point(933, 497);
            this.nudMessages.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudMessages.Name = "nudMessages";
            this.nudMessages.Size = new System.Drawing.Size(52, 20);
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
            this.label2.Location = new System.Drawing.Point(779, 499);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Number of messages to return";
            // 
            // btnCreateNewMessage
            // 
            this.btnCreateNewMessage.Location = new System.Drawing.Point(12, 497);
            this.btnCreateNewMessage.Name = "btnCreateNewMessage";
            this.btnCreateNewMessage.Size = new System.Drawing.Size(115, 23);
            this.btnCreateNewMessage.TabIndex = 8;
            this.btnCreateNewMessage.Text = "New E-mail Message";
            this.btnCreateNewMessage.UseVisualStyleBackColor = true;
            this.btnCreateNewMessage.Click += new System.EventHandler(this.btnCreateNewMessage_Click);
            // 
            // tvwFolders
            // 
            this.tvwFolders.Location = new System.Drawing.Point(12, 25);
            this.tvwFolders.Name = "tvwFolders";
            this.tvwFolders.Size = new System.Drawing.Size(198, 460);
            this.tvwFolders.TabIndex = 9;
            this.tvwFolders.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwFolders_AfterSelect);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Folders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(225, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Messages";
            // 
            // id
            // 
            this.id.ContextMenuStrip = this.mnuContextMenu;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subject.ContextMenuStrip = this.mnuContextMenu;
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.Width = 68;
            // 
            // sender
            // 
            this.sender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sender.ContextMenuStrip = this.mnuContextMenu;
            this.sender.HeaderText = "Sender";
            this.sender.Name = "sender";
            this.sender.ReadOnly = true;
            this.sender.Width = 66;
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
            this.attachments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.attachments.HeaderText = "Attachments";
            this.attachments.Name = "attachments";
            this.attachments.ReadOnly = true;
            this.attachments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attachments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.attachments.Text = "";
            this.attachments.Width = 91;
            // 
            // bcc
            // 
            this.bcc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bcc.HeaderText = "Bcc";
            this.bcc.Name = "bcc";
            this.bcc.ReadOnly = true;
            this.bcc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.bcc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.bcc.Text = "";
            this.bcc.Width = 51;
            // 
            // body
            // 
            this.body.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.body.HeaderText = "Body";
            this.body.Name = "body";
            this.body.ReadOnly = true;
            this.body.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.body.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.body.Width = 56;
            // 
            // cc
            // 
            this.cc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cc.HeaderText = "Cc";
            this.cc.Name = "cc";
            this.cc.ReadOnly = true;
            this.cc.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cc.Text = "";
            this.cc.Width = 45;
            // 
            // replyto
            // 
            this.replyto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.replyto.HeaderText = "ReplyTo";
            this.replyto.Name = "replyto";
            this.replyto.ReadOnly = true;
            this.replyto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.replyto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.replyto.Text = "";
            this.replyto.Width = 72;
            // 
            // categories
            // 
            this.categories.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.categories.HeaderText = "Categories";
            this.categories.Name = "categories";
            this.categories.ReadOnly = true;
            this.categories.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categories.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.categories.Text = "";
            this.categories.Width = 82;
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
            this.createddatetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.createddatetime.ContextMenuStrip = this.mnuContextMenu;
            this.createddatetime.HeaderText = "CreatedDateTime";
            this.createddatetime.Name = "createddatetime";
            this.createddatetime.ReadOnly = true;
            this.createddatetime.Width = 115;
            // 
            // lastmodified
            // 
            this.lastmodified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.lastmodified.ContextMenuStrip = this.mnuContextMenu;
            this.lastmodified.HeaderText = "LastModifiedDateTime";
            this.lastmodified.Name = "lastmodified";
            this.lastmodified.ReadOnly = true;
            this.lastmodified.Width = 138;
            // 
            // receiveddatetime
            // 
            this.receiveddatetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.receiveddatetime.ContextMenuStrip = this.mnuContextMenu;
            this.receiveddatetime.HeaderText = "ReceivedDateTime";
            this.receiveddatetime.Name = "receiveddatetime";
            this.receiveddatetime.ReadOnly = true;
            this.receiveddatetime.Width = 124;
            // 
            // sentdatetime
            // 
            this.sentdatetime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sentdatetime.ContextMenuStrip = this.mnuContextMenu;
            this.sentdatetime.HeaderText = "SentDateTime";
            this.sentdatetime.Name = "sentdatetime";
            this.sentdatetime.ReadOnly = true;
            // 
            // from
            // 
            this.from.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.from.ContextMenuStrip = this.mnuContextMenu;
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            this.from.Width = 55;
            // 
            // hasattachments
            // 
            this.hasattachments.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.hasattachments.ContextMenuStrip = this.mnuContextMenu;
            this.hasattachments.HeaderText = "HasAttachments";
            this.hasattachments.MaxInputLength = 10;
            this.hasattachments.Name = "hasattachments";
            this.hasattachments.ReadOnly = true;
            this.hasattachments.Width = 110;
            // 
            // importance
            // 
            this.importance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.importance.ContextMenuStrip = this.mnuContextMenu;
            this.importance.HeaderText = "Importance";
            this.importance.Name = "importance";
            this.importance.ReadOnly = true;
            this.importance.Width = 85;
            // 
            // isdeliveryrequested
            // 
            this.isdeliveryrequested.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isdeliveryrequested.ContextMenuStrip = this.mnuContextMenu;
            this.isdeliveryrequested.HeaderText = "IsDeliveryReceiptRequested";
            this.isdeliveryrequested.Name = "isdeliveryrequested";
            this.isdeliveryrequested.ReadOnly = true;
            this.isdeliveryrequested.Width = 167;
            // 
            // isdraft
            // 
            this.isdraft.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isdraft.ContextMenuStrip = this.mnuContextMenu;
            this.isdraft.HeaderText = "IsDraft";
            this.isdraft.Name = "isdraft";
            this.isdraft.ReadOnly = true;
            this.isdraft.Width = 63;
            // 
            // isread
            // 
            this.isread.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isread.ContextMenuStrip = this.mnuContextMenu;
            this.isread.HeaderText = "IsRead";
            this.isread.Name = "isread";
            this.isread.ReadOnly = true;
            this.isread.Width = 66;
            // 
            // isreadreceiptrequested
            // 
            this.isreadreceiptrequested.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.isreadreceiptrequested.ContextMenuStrip = this.mnuContextMenu;
            this.isreadreceiptrequested.HeaderText = "IsReadReceiptRequested";
            this.isreadreceiptrequested.Name = "isreadreceiptrequested";
            this.isreadreceiptrequested.ReadOnly = true;
            this.isreadreceiptrequested.Width = 155;
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
            // MailAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 526);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tvwFolders);
            this.Controls.Add(this.btnCreateNewMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudMessages);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgMessages);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MailAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mail";
            ((System.ComponentModel.ISupportInitialize)(this.dgMessages)).EndInit();
            this.mnuContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMessages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip mnuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.NumericUpDown nudMessages;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreateNewMessage;
        private System.Windows.Forms.TreeView tvwFolders;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn sender;
        private System.Windows.Forms.DataGridViewButtonColumn to;
        private System.Windows.Forms.DataGridViewButtonColumn attachments;
        private System.Windows.Forms.DataGridViewButtonColumn bcc;
        private System.Windows.Forms.DataGridViewButtonColumn body;
        private System.Windows.Forms.DataGridViewButtonColumn cc;
        private System.Windows.Forms.DataGridViewButtonColumn replyto;
        private System.Windows.Forms.DataGridViewButtonColumn categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodypreview;
        private System.Windows.Forms.DataGridViewTextBoxColumn changekey;
        private System.Windows.Forms.DataGridViewTextBoxColumn conversationid;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastmodified;
        private System.Windows.Forms.DataGridViewTextBoxColumn receiveddatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn sentdatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasattachments;
        private System.Windows.Forms.DataGridViewTextBoxColumn importance;
        private System.Windows.Forms.DataGridViewTextBoxColumn isdeliveryrequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn isdraft;
        private System.Windows.Forms.DataGridViewTextBoxColumn isread;
        private System.Windows.Forms.DataGridViewTextBoxColumn isreadreceiptrequested;
        private System.Windows.Forms.DataGridViewTextBoxColumn parentfolderid;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniquebody;
        private System.Windows.Forms.DataGridViewTextBoxColumn weblink;
    }
}