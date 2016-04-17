namespace RESTfulOutlook.Forms
{
    partial class CalendarAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalendarAPI));
            this.btnGetEvents = new System.Windows.Forms.Button();
            this.dgEvents = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mnuContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendees = new System.Windows.Forms.DataGridViewButtonColumn();
            this.organizer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attachments = new System.Windows.Forms.DataGridViewButtonColumn();
            this.body = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bodypreview = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calendar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categories = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.changekey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createddatetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastmodified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hasattachments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.instances = new System.Windows.Forms.DataGridViewButtonColumn();
            this.icaluid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isallday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iscancelled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isorganizer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalendtimezone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.originalstarttimezone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recurrence = new System.Windows.Forms.DataGridViewButtonColumn();
            this.responserequested = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.responsestatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seriesmasterid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.showas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weblink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.nudEvents = new System.Windows.Forms.NumericUpDown();
            this.cmbCalendars = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewMeeting = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).BeginInit();
            this.mnuContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetEvents
            // 
            this.btnGetEvents.Location = new System.Drawing.Point(12, 12);
            this.btnGetEvents.Name = "btnGetEvents";
            this.btnGetEvents.Size = new System.Drawing.Size(105, 23);
            this.btnGetEvents.TabIndex = 0;
            this.btnGetEvents.Text = "Get Events";
            this.btnGetEvents.UseVisualStyleBackColor = true;
            this.btnGetEvents.Click += new System.EventHandler(this.btnGetEvents_Click);
            // 
            // dgEvents
            // 
            this.dgEvents.AllowUserToAddRows = false;
            this.dgEvents.AllowUserToDeleteRows = false;
            this.dgEvents.AllowUserToResizeRows = false;
            this.dgEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.subject,
            this.location,
            this.attendees,
            this.organizer,
            this.attachments,
            this.body,
            this.bodypreview,
            this.calendar,
            this.categories,
            this.changekey,
            this.createddatetime,
            this.lastmodified,
            this.start,
            this.end,
            this.hasattachments,
            this.importance,
            this.instances,
            this.icaluid,
            this.isallday,
            this.iscancelled,
            this.isorganizer,
            this.originalendtimezone,
            this.originalstarttimezone,
            this.recurrence,
            this.responserequested,
            this.responsestatus,
            this.seriesmasterid,
            this.showas,
            this.type,
            this.weblink});
            this.dgEvents.Location = new System.Drawing.Point(12, 41);
            this.dgEvents.MultiSelect = false;
            this.dgEvents.Name = "dgEvents";
            this.dgEvents.ReadOnly = true;
            this.dgEvents.Size = new System.Drawing.Size(1033, 427);
            this.dgEvents.TabIndex = 1;
            this.dgEvents.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgEvents_CellContentDoubleClick);
            this.dgEvents.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgEvents_CellMouseDown);
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
            // location
            // 
            this.location.ContextMenuStrip = this.mnuContextMenu;
            this.location.HeaderText = "Location";
            this.location.Name = "location";
            this.location.ReadOnly = true;
            // 
            // attendees
            // 
            this.attendees.HeaderText = "Attendees";
            this.attendees.Name = "attendees";
            this.attendees.ReadOnly = true;
            this.attendees.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attendees.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // organizer
            // 
            this.organizer.ContextMenuStrip = this.mnuContextMenu;
            this.organizer.HeaderText = "Organizer";
            this.organizer.Name = "organizer";
            this.organizer.ReadOnly = true;
            // 
            // attachments
            // 
            this.attachments.ContextMenuStrip = this.mnuContextMenu;
            this.attachments.HeaderText = "Attachments";
            this.attachments.Name = "attachments";
            this.attachments.ReadOnly = true;
            this.attachments.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.attachments.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // body
            // 
            this.body.HeaderText = "Body";
            this.body.Name = "body";
            this.body.ReadOnly = true;
            // 
            // bodypreview
            // 
            this.bodypreview.ContextMenuStrip = this.mnuContextMenu;
            this.bodypreview.HeaderText = "BodyPreview";
            this.bodypreview.Name = "bodypreview";
            this.bodypreview.ReadOnly = true;
            // 
            // calendar
            // 
            this.calendar.ContextMenuStrip = this.mnuContextMenu;
            this.calendar.HeaderText = "Calendar";
            this.calendar.Name = "calendar";
            this.calendar.ReadOnly = true;
            // 
            // categories
            // 
            this.categories.ContextMenuStrip = this.mnuContextMenu;
            this.categories.HeaderText = "Categories";
            this.categories.Name = "categories";
            this.categories.ReadOnly = true;
            // 
            // changekey
            // 
            this.changekey.ContextMenuStrip = this.mnuContextMenu;
            this.changekey.HeaderText = "ChangeKey";
            this.changekey.Name = "changekey";
            this.changekey.ReadOnly = true;
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
            // start
            // 
            this.start.ContextMenuStrip = this.mnuContextMenu;
            this.start.HeaderText = "Start";
            this.start.Name = "start";
            this.start.ReadOnly = true;
            // 
            // end
            // 
            this.end.ContextMenuStrip = this.mnuContextMenu;
            this.end.HeaderText = "End";
            this.end.Name = "end";
            this.end.ReadOnly = true;
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
            // instances
            // 
            this.instances.HeaderText = "Instances";
            this.instances.Name = "instances";
            this.instances.ReadOnly = true;
            this.instances.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.instances.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // icaluid
            // 
            this.icaluid.ContextMenuStrip = this.mnuContextMenu;
            this.icaluid.HeaderText = "iCalUID";
            this.icaluid.Name = "icaluid";
            this.icaluid.ReadOnly = true;
            // 
            // isallday
            // 
            this.isallday.ContextMenuStrip = this.mnuContextMenu;
            this.isallday.HeaderText = "IsAllDay";
            this.isallday.Name = "isallday";
            this.isallday.ReadOnly = true;
            // 
            // iscancelled
            // 
            this.iscancelled.ContextMenuStrip = this.mnuContextMenu;
            this.iscancelled.HeaderText = "IsCancelled";
            this.iscancelled.Name = "iscancelled";
            this.iscancelled.ReadOnly = true;
            // 
            // isorganizer
            // 
            this.isorganizer.ContextMenuStrip = this.mnuContextMenu;
            this.isorganizer.HeaderText = "IsOrganizer";
            this.isorganizer.Name = "isorganizer";
            this.isorganizer.ReadOnly = true;
            // 
            // originalendtimezone
            // 
            this.originalendtimezone.ContextMenuStrip = this.mnuContextMenu;
            this.originalendtimezone.HeaderText = "OriginalEndTimeZone";
            this.originalendtimezone.Name = "originalendtimezone";
            this.originalendtimezone.ReadOnly = true;
            // 
            // originalstarttimezone
            // 
            this.originalstarttimezone.ContextMenuStrip = this.mnuContextMenu;
            this.originalstarttimezone.HeaderText = "OriginalStartTimeZone";
            this.originalstarttimezone.Name = "originalstarttimezone";
            this.originalstarttimezone.ReadOnly = true;
            // 
            // recurrence
            // 
            this.recurrence.HeaderText = "Recurrence";
            this.recurrence.Name = "recurrence";
            this.recurrence.ReadOnly = true;
            this.recurrence.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.recurrence.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // responserequested
            // 
            this.responserequested.ContextMenuStrip = this.mnuContextMenu;
            this.responserequested.HeaderText = "ResponseRequested";
            this.responserequested.Name = "responserequested";
            this.responserequested.ReadOnly = true;
            // 
            // responsestatus
            // 
            this.responsestatus.ContextMenuStrip = this.mnuContextMenu;
            this.responsestatus.HeaderText = "ResponseStatus";
            this.responsestatus.Name = "responsestatus";
            this.responsestatus.ReadOnly = true;
            // 
            // seriesmasterid
            // 
            this.seriesmasterid.ContextMenuStrip = this.mnuContextMenu;
            this.seriesmasterid.HeaderText = "SeriesMasterId";
            this.seriesmasterid.Name = "seriesmasterid";
            this.seriesmasterid.ReadOnly = true;
            // 
            // showas
            // 
            this.showas.ContextMenuStrip = this.mnuContextMenu;
            this.showas.HeaderText = "ShowAs";
            this.showas.Name = "showas";
            this.showas.ReadOnly = true;
            // 
            // type
            // 
            this.type.ContextMenuStrip = this.mnuContextMenu;
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // weblink
            // 
            this.weblink.ContextMenuStrip = this.mnuContextMenu;
            this.weblink.HeaderText = "WebLink";
            this.weblink.Name = "weblink";
            this.weblink.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(767, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Double-Click Cell to open collection objects like recipients";
            // 
            // nudEvents
            // 
            this.nudEvents.Location = new System.Drawing.Point(123, 15);
            this.nudEvents.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nudEvents.Name = "nudEvents";
            this.nudEvents.Size = new System.Drawing.Size(55, 20);
            this.nudEvents.TabIndex = 5;
            this.nudEvents.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cmbCalendars
            // 
            this.cmbCalendars.FormattingEnabled = true;
            this.cmbCalendars.Location = new System.Drawing.Point(881, 12);
            this.cmbCalendars.Name = "cmbCalendars";
            this.cmbCalendars.Size = new System.Drawing.Size(164, 21);
            this.cmbCalendars.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(821, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Calendars";
            // 
            // btnNewMeeting
            // 
            this.btnNewMeeting.Location = new System.Drawing.Point(12, 474);
            this.btnNewMeeting.Name = "btnNewMeeting";
            this.btnNewMeeting.Size = new System.Drawing.Size(105, 23);
            this.btnNewMeeting.TabIndex = 8;
            this.btnNewMeeting.Text = "New Meeting";
            this.btnNewMeeting.UseVisualStyleBackColor = true;
            this.btnNewMeeting.Click += new System.EventHandler(this.btnNewMeeting_Click);
            // 
            // CalendarAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 508);
            this.Controls.Add(this.btnNewMeeting);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbCalendars);
            this.Controls.Add(this.nudEvents);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgEvents);
            this.Controls.Add(this.btnGetEvents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CalendarAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Calendar";
            ((System.ComponentModel.ISupportInitialize)(this.dgEvents)).EndInit();
            this.mnuContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudEvents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetEvents;
        private System.Windows.Forms.DataGridView dgEvents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip mnuContextMenu;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn weblink;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn showas;
        private System.Windows.Forms.DataGridViewTextBoxColumn seriesmasterid;
        private System.Windows.Forms.DataGridViewTextBoxColumn responsestatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn responserequested;
        private System.Windows.Forms.DataGridViewButtonColumn recurrence;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalstarttimezone;
        private System.Windows.Forms.DataGridViewTextBoxColumn originalendtimezone;
        private System.Windows.Forms.DataGridViewTextBoxColumn isorganizer;
        private System.Windows.Forms.DataGridViewTextBoxColumn iscancelled;
        private System.Windows.Forms.DataGridViewTextBoxColumn isallday;
        private System.Windows.Forms.DataGridViewTextBoxColumn icaluid;
        private System.Windows.Forms.DataGridViewButtonColumn instances;
        private System.Windows.Forms.DataGridViewTextBoxColumn importance;
        private System.Windows.Forms.DataGridViewTextBoxColumn hasattachments;
        private System.Windows.Forms.DataGridViewTextBoxColumn end;
        private System.Windows.Forms.DataGridViewTextBoxColumn start;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastmodified;
        private System.Windows.Forms.DataGridViewTextBoxColumn createddatetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn changekey;
        private System.Windows.Forms.DataGridViewTextBoxColumn categories;
        private System.Windows.Forms.DataGridViewTextBoxColumn calendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn bodypreview;
        private System.Windows.Forms.DataGridViewButtonColumn body;
        private System.Windows.Forms.DataGridViewButtonColumn attachments;
        private System.Windows.Forms.DataGridViewTextBoxColumn organizer;
        private System.Windows.Forms.DataGridViewButtonColumn attendees;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.NumericUpDown nudEvents;
        private System.Windows.Forms.ComboBox cmbCalendars;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewMeeting;
    }
}