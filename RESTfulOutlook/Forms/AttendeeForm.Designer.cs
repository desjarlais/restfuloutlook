namespace RESTfulOutlook.Forms
{
    partial class AttendeeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendeeForm));
            this.dgAttendee = new System.Windows.Forms.DataGridView();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendeetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailaddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgAttendee)).BeginInit();
            this.mnuContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgAttendee
            // 
            this.dgAttendee.AllowUserToAddRows = false;
            this.dgAttendee.AllowUserToDeleteRows = false;
            this.dgAttendee.AllowUserToResizeRows = false;
            this.dgAttendee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAttendee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.status,
            this.attendeetype,
            this.emailaddress,
            this.name,
            this.responsetime});
            this.dgAttendee.Location = new System.Drawing.Point(12, 12);
            this.dgAttendee.MultiSelect = false;
            this.dgAttendee.Name = "dgAttendee";
            this.dgAttendee.ReadOnly = true;
            this.dgAttendee.Size = new System.Drawing.Size(766, 130);
            this.dgAttendee.TabIndex = 0;
            this.dgAttendee.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgAttendee_CellMouseDown);
            // 
            // status
            // 
            this.status.ContextMenuStrip = this.mnuContextMenu;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
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
            // attendeetype
            // 
            this.attendeetype.ContextMenuStrip = this.mnuContextMenu;
            this.attendeetype.HeaderText = "AttendeeType";
            this.attendeetype.Name = "attendeetype";
            this.attendeetype.ReadOnly = true;
            // 
            // emailaddress
            // 
            this.emailaddress.ContextMenuStrip = this.mnuContextMenu;
            this.emailaddress.HeaderText = "EmailAddress";
            this.emailaddress.Name = "emailaddress";
            this.emailaddress.ReadOnly = true;
            this.emailaddress.Width = 200;
            // 
            // name
            // 
            this.name.ContextMenuStrip = this.mnuContextMenu;
            this.name.HeaderText = "Name";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 200;
            // 
            // responsetime
            // 
            this.responsetime.ContextMenuStrip = this.mnuContextMenu;
            this.responsetime.HeaderText = "ResponseTime";
            this.responsetime.Name = "responsetime";
            this.responsetime.ReadOnly = true;
            // 
            // AttendeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 164);
            this.Controls.Add(this.dgAttendee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AttendeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Attendee";
            ((System.ComponentModel.ISupportInitialize)(this.dgAttendee)).EndInit();
            this.mnuContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgAttendee;
        private System.Windows.Forms.ContextMenuStrip mnuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailaddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn attendeetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}