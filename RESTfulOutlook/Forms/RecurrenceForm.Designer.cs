namespace RESTfulOutlook.Forms
{
    partial class RecurrenceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecurrenceForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgRecurrencePattern = new System.Windows.Forms.DataGridView();
            this.mnuContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgRecurrenceRange = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interval = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayofmonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.month = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysofweek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstdayofweek = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rangetype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enddate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numrecurrences = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recurtimezone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecurrencePattern)).BeginInit();
            this.mnuContextMenu.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecurrenceRange)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgRecurrencePattern);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(801, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RecurrencePattern";
            // 
            // dgRecurrencePattern
            // 
            this.dgRecurrencePattern.AllowUserToAddRows = false;
            this.dgRecurrencePattern.AllowUserToDeleteRows = false;
            this.dgRecurrencePattern.AllowUserToResizeRows = false;
            this.dgRecurrencePattern.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecurrencePattern.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.type,
            this.interval,
            this.dayofmonth,
            this.month,
            this.daysofweek,
            this.firstdayofweek,
            this.index});
            this.dgRecurrencePattern.ContextMenuStrip = this.mnuContextMenu;
            this.dgRecurrencePattern.Location = new System.Drawing.Point(6, 19);
            this.dgRecurrencePattern.MultiSelect = false;
            this.dgRecurrencePattern.Name = "dgRecurrencePattern";
            this.dgRecurrencePattern.ReadOnly = true;
            this.dgRecurrencePattern.Size = new System.Drawing.Size(789, 123);
            this.dgRecurrencePattern.TabIndex = 0;
            this.dgRecurrencePattern.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgRecurrencePattern_CellMouseDown);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgRecurrenceRange);
            this.groupBox2.Location = new System.Drawing.Point(12, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(801, 152);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RecurrenceRange";
            // 
            // dgRecurrenceRange
            // 
            this.dgRecurrenceRange.AllowUserToAddRows = false;
            this.dgRecurrenceRange.AllowUserToDeleteRows = false;
            this.dgRecurrenceRange.AllowUserToResizeRows = false;
            this.dgRecurrenceRange.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecurrenceRange.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rangetype,
            this.startdate,
            this.enddate,
            this.numrecurrences,
            this.recurtimezone});
            this.dgRecurrenceRange.ContextMenuStrip = this.contextMenuStrip1;
            this.dgRecurrenceRange.Location = new System.Drawing.Point(3, 16);
            this.dgRecurrenceRange.MultiSelect = false;
            this.dgRecurrenceRange.Name = "dgRecurrenceRange";
            this.dgRecurrenceRange.ReadOnly = true;
            this.dgRecurrenceRange.Size = new System.Drawing.Size(792, 130);
            this.dgRecurrenceRange.TabIndex = 0;
            this.dgRecurrenceRange.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgRecurrenceRange_CellMouseDown);
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
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // interval
            // 
            this.interval.HeaderText = "Inteval";
            this.interval.Name = "interval";
            this.interval.ReadOnly = true;
            this.interval.Width = 50;
            // 
            // dayofmonth
            // 
            this.dayofmonth.HeaderText = "DayOfMonth";
            this.dayofmonth.Name = "dayofmonth";
            this.dayofmonth.ReadOnly = true;
            // 
            // month
            // 
            this.month.HeaderText = "Month";
            this.month.Name = "month";
            this.month.ReadOnly = true;
            this.month.Width = 50;
            // 
            // daysofweek
            // 
            this.daysofweek.HeaderText = "DaysOfWeek";
            this.daysofweek.Name = "daysofweek";
            this.daysofweek.ReadOnly = true;
            // 
            // firstdayofweek
            // 
            this.firstdayofweek.HeaderText = "FirstDayOfWeek";
            this.firstdayofweek.Name = "firstdayofweek";
            this.firstdayofweek.ReadOnly = true;
            // 
            // index
            // 
            this.index.HeaderText = "WeekIndex";
            this.index.Name = "index";
            this.index.ReadOnly = true;
            // 
            // rangetype
            // 
            this.rangetype.HeaderText = "Type";
            this.rangetype.Name = "rangetype";
            this.rangetype.ReadOnly = true;
            // 
            // startdate
            // 
            this.startdate.HeaderText = "StartDate";
            this.startdate.Name = "startdate";
            this.startdate.ReadOnly = true;
            this.startdate.Width = 200;
            // 
            // enddate
            // 
            this.enddate.HeaderText = "EndDate";
            this.enddate.Name = "enddate";
            this.enddate.ReadOnly = true;
            this.enddate.Width = 200;
            // 
            // numrecurrences
            // 
            this.numrecurrences.HeaderText = "NumberOfRecurrences";
            this.numrecurrences.Name = "numrecurrences";
            this.numrecurrences.ReadOnly = true;
            this.numrecurrences.Width = 120;
            // 
            // recurtimezone
            // 
            this.recurtimezone.HeaderText = "RecurrenceTimeZone";
            this.recurtimezone.Name = "recurtimezone";
            this.recurtimezone.ReadOnly = true;
            // 
            // RecurrenceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 333);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RecurrenceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RecurrenceForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecurrencePattern)).EndInit();
            this.mnuContextMenu.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecurrenceRange)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgRecurrencePattern;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgRecurrenceRange;
        private System.Windows.Forms.ContextMenuStrip mnuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn recurtimezone;
        private System.Windows.Forms.DataGridViewTextBoxColumn numrecurrences;
        private System.Windows.Forms.DataGridViewTextBoxColumn enddate;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rangetype;
        private System.Windows.Forms.DataGridViewTextBoxColumn index;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstdayofweek;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysofweek;
        private System.Windows.Forms.DataGridViewTextBoxColumn month;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayofmonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn interval;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
    }
}