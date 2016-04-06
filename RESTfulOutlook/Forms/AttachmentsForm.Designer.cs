namespace RESTfulOutlook.Forms
{
    partial class AttachmentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttachmentsForm));
            this.dgFileAttachments = new System.Windows.Forms.DataGridView();
            this.bytes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastmodified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalfiledata = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dgItemAttachments = new System.Windows.Forms.DataGridView();
            this.contenttype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isinline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalitemdata = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgRefAttachments = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.additionalrefdata = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileAttachments)).BeginInit();
            this.mnuContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgItemAttachments)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRefAttachments)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFileAttachments
            // 
            this.dgFileAttachments.AllowUserToAddRows = false;
            this.dgFileAttachments.AllowUserToDeleteRows = false;
            this.dgFileAttachments.AllowUserToResizeRows = false;
            this.dgFileAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bytes,
            this.cid,
            this.location,
            this.type,
            this.lastmodified,
            this.id,
            this.inline,
            this.name,
            this.size,
            this.additionalfiledata});
            this.dgFileAttachments.Location = new System.Drawing.Point(12, 31);
            this.dgFileAttachments.MultiSelect = false;
            this.dgFileAttachments.Name = "dgFileAttachments";
            this.dgFileAttachments.ReadOnly = true;
            this.dgFileAttachments.Size = new System.Drawing.Size(809, 132);
            this.dgFileAttachments.TabIndex = 0;
            this.dgFileAttachments.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgFileAttachments_CellContentDoubleClick);
            this.dgFileAttachments.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAttachments_CellMouseDown);
            // 
            // bytes
            // 
            this.bytes.ContextMenuStrip = this.mnuContextMenu;
            this.bytes.HeaderText = "ContentBytes";
            this.bytes.Name = "bytes";
            this.bytes.ReadOnly = true;
            // 
            // mnuContextMenu
            // 
            this.mnuContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem});
            this.mnuContextMenu.Name = "mnuContextMenu";
            this.mnuContextMenu.Size = new System.Drawing.Size(153, 48);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // cid
            // 
            this.cid.ContextMenuStrip = this.mnuContextMenu;
            this.cid.HeaderText = "ContentId";
            this.cid.Name = "cid";
            this.cid.ReadOnly = true;
            // 
            // location
            // 
            this.location.ContextMenuStrip = this.mnuContextMenu;
            this.location.HeaderText = "ContentLocation";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // type
            // 
            this.type.ContextMenuStrip = this.mnuContextMenu;
            this.type.HeaderText = "ContentType";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // lastmodified
            // 
            this.lastmodified.ContextMenuStrip = this.mnuContextMenu;
            this.lastmodified.HeaderText = "LastModifiedDateTime";
            this.lastmodified.Name = "lastmodified";
            this.lastmodified.ReadOnly = true;
            // 
            // id
            // 
            this.id.ContextMenuStrip = this.mnuContextMenu;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // inline
            // 
            this.inline.ContextMenuStrip = this.mnuContextMenu;
            this.inline.HeaderText = "IsInline";
            this.inline.Name = "inline";
            this.inline.ReadOnly = true;
            // 
            // name
            // 
            this.name.ContextMenuStrip = this.mnuContextMenu;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // size
            // 
            this.size.ContextMenuStrip = this.mnuContextMenu;
            this.size.HeaderText = "Size";
            this.size.Name = "size";
            this.size.ReadOnly = true;
            // 
            // additionalfiledata
            // 
            this.additionalfiledata.HeaderText = "AdditionalData";
            this.additionalfiledata.Name = "additionalfiledata";
            this.additionalfiledata.ReadOnly = true;
            // 
            // dgItemAttachments
            // 
            this.dgItemAttachments.AllowUserToAddRows = false;
            this.dgItemAttachments.AllowUserToDeleteRows = false;
            this.dgItemAttachments.AllowUserToResizeRows = false;
            this.dgItemAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgItemAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.contenttype,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.item,
            this.isinline,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.additionalitemdata});
            this.dgItemAttachments.Location = new System.Drawing.Point(12, 182);
            this.dgItemAttachments.MultiSelect = false;
            this.dgItemAttachments.Name = "dgItemAttachments";
            this.dgItemAttachments.ReadOnly = true;
            this.dgItemAttachments.Size = new System.Drawing.Size(809, 133);
            this.dgItemAttachments.TabIndex = 1;
            this.dgItemAttachments.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgItemAttachments_CellContentDoubleClick);
            // 
            // contenttype
            // 
            this.contenttype.ContextMenuStrip = this.contextMenuStrip1;
            this.contenttype.HeaderText = "ContentType";
            this.contenttype.Name = "contenttype";
            this.contenttype.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 26);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem1.Text = "Copy";
            this.copyToolStripMenuItem1.Click += new System.EventHandler(this.copyToolStripMenuItem1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTextBoxColumn1.HeaderText = "LastModifiedDateTime";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTextBoxColumn2.HeaderText = "Id";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // item
            // 
            this.item.ContextMenuStrip = this.contextMenuStrip1;
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.ReadOnly = true;
            // 
            // isinline
            // 
            this.isinline.ContextMenuStrip = this.contextMenuStrip1;
            this.isinline.HeaderText = "IsInline";
            this.isinline.Name = "isinline";
            this.isinline.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTextBoxColumn3.HeaderText = "Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTextBoxColumn4.HeaderText = "Size";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // additionalitemdata
            // 
            this.additionalitemdata.HeaderText = "AdditionalData";
            this.additionalitemdata.Name = "additionalitemdata";
            this.additionalitemdata.ReadOnly = true;
            this.additionalitemdata.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.additionalitemdata.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "File Attachments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Item Attachments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reference Attachments";
            // 
            // dgRefAttachments
            // 
            this.dgRefAttachments.AllowUserToAddRows = false;
            this.dgRefAttachments.AllowUserToDeleteRows = false;
            this.dgRefAttachments.AllowUserToResizeRows = false;
            this.dgRefAttachments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRefAttachments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.additionalrefdata});
            this.dgRefAttachments.Location = new System.Drawing.Point(12, 334);
            this.dgRefAttachments.MultiSelect = false;
            this.dgRefAttachments.Name = "dgRefAttachments";
            this.dgRefAttachments.ReadOnly = true;
            this.dgRefAttachments.Size = new System.Drawing.Size(809, 133);
            this.dgRefAttachments.TabIndex = 5;
            this.dgRefAttachments.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRefAttachments_CellContentDoubleClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridViewTextBoxColumn5.HeaderText = "ContentType";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(145, 26);
            // 
            // copyToolStripMenuItem2
            // 
            this.copyToolStripMenuItem2.Name = "copyToolStripMenuItem2";
            this.copyToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem2.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem2.Text = "Copy";
            this.copyToolStripMenuItem2.Click += new System.EventHandler(this.copyToolStripMenuItem2_Click);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTextBoxColumn6.HeaderText = "LastModifiedDateTime";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTextBoxColumn7.HeaderText = "Id";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTextBoxColumn9.HeaderText = "IsInline";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTextBoxColumn10.HeaderText = "Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridViewTextBoxColumn11.HeaderText = "Size";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // additionalrefdata
            // 
            this.additionalrefdata.HeaderText = "AdditionalData";
            this.additionalrefdata.Name = "additionalrefdata";
            this.additionalrefdata.ReadOnly = true;
            // 
            // AttachmentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 481);
            this.Controls.Add(this.dgRefAttachments);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgItemAttachments);
            this.Controls.Add(this.dgFileAttachments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AttachmentsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AttachmentsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgFileAttachments)).EndInit();
            this.mnuContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgItemAttachments)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRefAttachments)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgFileAttachments;
        private System.Windows.Forms.ContextMenuStrip mnuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgItemAttachments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgRefAttachments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem2;
        private System.Windows.Forms.DataGridViewButtonColumn additionalfiledata;
        private System.Windows.Forms.DataGridViewButtonColumn additionalitemdata;
        private System.Windows.Forms.DataGridViewButtonColumn additionalrefdata;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn isinline;
        private System.Windows.Forms.DataGridViewTextBoxColumn item;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn contenttype;
        private System.Windows.Forms.DataGridViewTextBoxColumn size;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn inline;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastmodified;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn cid;
        private System.Windows.Forms.DataGridViewTextBoxColumn bytes;
    }
}