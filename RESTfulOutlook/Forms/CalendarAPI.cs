using System;
using Microsoft.IdentityModel.Clients.ActiveDirectory;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Graph;
using System.Linq;
using RESTfulOutlook.Utils;

namespace RESTfulOutlook.Forms
{
    public partial class CalendarAPI : Form
    {
        GraphServiceClient graphClient;
        public Dictionary<string, List<ItemBody>> dItemBody;
        public Dictionary<string, List<Attendee>> dAttendees;
        public Dictionary<string, List<string>> dCategories;
        public Dictionary<string, RecurrencePattern> dRecurrencePattern;
        public Dictionary<string, RecurrenceRange> dRecurrenceRange;
        public Dictionary<string, List<FileAttachment>> dFileAttachments;
        public Dictionary<string, List<ItemAttachment>> dItemAttachments;
        public Dictionary<string, List<ReferenceAttachment>> dReferenceAttachments;
        public Dictionary<string, string> dCalendarIds;

        ClassLogger applogger = null;
        ClassLogger sdklogger = null;

        public CalendarAPI(ref GraphServiceClient client, ref ClassLogger appLogger, ref ClassLogger sdkLogger)
        {
            InitializeComponent();
            graphClient = client;
            applogger = appLogger;
            sdklogger = sdkLogger;

            dItemBody = new Dictionary<string, List<ItemBody>>();
            dAttendees = new Dictionary<string, List<Attendee>>();
            dCategories = new Dictionary<string, List<string>>();
            dRecurrencePattern = new Dictionary<string, RecurrencePattern>();
            dRecurrenceRange = new Dictionary<string, RecurrenceRange>();
            dFileAttachments = new Dictionary<string, List<FileAttachment>>();
            dItemAttachments = new Dictionary<string, List<ItemAttachment>>();
            dReferenceAttachments = new Dictionary<string, List<ReferenceAttachment>>();
            dCalendarIds = new Dictionary<string, string>();

            #pragma warning disable 4014
            GetFoldersAsync();
            #pragma warning restore 4014
        }

        private async Task GetFoldersAsync()
        {
            try
            {
                // adjust UI so user knows work is happening
                Cursor = Cursors.WaitCursor;

                // log the request
                sdklogger.Log("REQUEST");
                sdklogger.Log(graphClient.Me.Calendars.Request().GetHttpRequestMessage().ToString());
                sdklogger.Log(graphClient.Me.Calendars.Request().GetHttpRequestMessage().RequestUri.ToString());

                // get the folders
                var calFolders = await graphClient.Me.Calendars.Request().GetAsync();

                // loop parent folders
                foreach (var cal in calFolders.CurrentPage)
                {
                    // populate folder ids in the local dictionary
                    // any requests for a specific folder need to use Id, not display name
                    dCalendarIds.Add(cal.Name, cal.Id);
                    cmbCalendars.Items.Add(cal.Name);
                    cmbCalendars.SelectedIndex = 0;
                }
            }
            catch (ServiceException se)
            {
                sdklogger.Log("Calendar:GetFoldersAsync ServiceException:");
                sdklogger.Log(se.Message);
                sdklogger.Log(se.StackTrace);
            }
            catch (Exception ex)
            {
                sdklogger.Log("Calendar:GetFoldersAsync Exception:");
                sdklogger.Log(ex.Message);
                sdklogger.Log(ex.StackTrace);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private async void btnGetEvents_Click(object sender, EventArgs e)
        {
            await GetEventsAsync();
        }

        private async Task GetEventsAsync()
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                dgCleanup();

                int mLimit = (Int32)nudEvents.Value;                
                
                // get folder name from selected dropdown item and convert to folder id
                string folderName = cmbCalendars.SelectedItem.ToString();
                string folderId = null;

                foreach (KeyValuePair<string, string> pair in dCalendarIds)
                {
                    if (pair.Key == folderName)
                    {
                        folderId = pair.Value;
                    }
                }

                sdklogger.Log("REQUEST");
                sdklogger.Log(graphClient.Me.Calendars[folderId].Events.Request().GetHttpRequestMessage().ToString());
                sdklogger.Log(graphClient.Me.Calendars[folderId].Events.Request().GetHttpRequestMessage().RequestUri.ToString());

                var calEvents = await graphClient.Me.Calendars[folderId].Events.Request()
                    .Expand("attachments")
                    .Top(mLimit)
                    .GetAsync();
                
                foreach (var calEvent in calEvents.CurrentPage)
                {
                    // populate the grid view
                    int n = dgEvents.Rows.Add();
                    dgEvents.Rows[n].Cells[(int)columns.Id].Value = calEvent.Id;
                    dgEvents.Rows[n].Cells[(int)columns.Subject].Value = calEvent.Subject;
                    dgEvents.Rows[n].Cells[(int)columns.Location].Value = calEvent.Location.DisplayName;
                    dgEvents.Rows[n].Cells[(int)columns.Organizer].Value = calEvent.Organizer.EmailAddress.Address;
                    dgEvents.Rows[n].Cells[(int)columns.BodyPreview].Value = calEvent.BodyPreview;
                    dgEvents.Rows[n].Cells[(int)columns.ChangeKey].Value = calEvent.ChangeKey;
                    dgEvents.Rows[n].Cells[(int)columns.CreatedDateTime].Value = calEvent.CreatedDateTime;
                    dgEvents.Rows[n].Cells[(int)columns.LastModifiedDateTime].Value = calEvent.LastModifiedDateTime;
                    dgEvents.Rows[n].Cells[(int)columns.Start].Value = calEvent.Start.DateTime + " : " + calEvent.Start.TimeZone;
                    dgEvents.Rows[n].Cells[(int)columns.End].Value = calEvent.End.DateTime + " : "  + calEvent.End.TimeZone;
                    dgEvents.Rows[n].Cells[(int)columns.HasAttachments].Value = calEvent.HasAttachments;
                    dgEvents.Rows[n].Cells[(int)columns.Importance].Value = calEvent.Importance;
                    dgEvents.Rows[n].Cells[(int)columns.iCalUID].Value = calEvent.ICalUId;
                    dgEvents.Rows[n].Cells[(int)columns.IsAllDay].Value = calEvent.IsAllDay;
                    dgEvents.Rows[n].Cells[(int)columns.IsCancelled].Value = calEvent.IsCancelled;
                    dgEvents.Rows[n].Cells[(int)columns.IsOrganizer].Value = calEvent.IsOrganizer;
                    dgEvents.Rows[n].Cells[(int)columns.OriginalEndTimeZone].Value = calEvent.OriginalEndTimeZone;
                    dgEvents.Rows[n].Cells[(int)columns.OriginalStartTimeZone].Value = calEvent.OriginalStartTimeZone;
                    dgEvents.Rows[n].Cells[(int)columns.ResponseRequested].Value = calEvent.ResponseRequested;
                    dgEvents.Rows[n].Cells[(int)columns.ResponseStatus].Value = calEvent.ResponseStatus.Response + " : " + calEvent.ResponseStatus.Time;
                    dgEvents.Rows[n].Cells[(int)columns.SeriesMasterId].Value = calEvent.SeriesMasterId;
                    dgEvents.Rows[n].Cells[(int)columns.ShowAs].Value = calEvent.ShowAs;
                    dgEvents.Rows[n].Cells[(int)columns.Type].Value = calEvent.Type;
                    dgEvents.Rows[n].Cells[(int)columns.WebLink].Value = calEvent.WebLink;

                    if (calEvent.Recurrence != null)
                    {
                        dgEvents.Rows[n].Cells[(int)columns.Recurrence].Value = "View Recurrence";
                        dRecurrencePattern.Add(calEvent.Id, calEvent.Recurrence.Pattern);
                        dRecurrenceRange.Add(calEvent.Id, calEvent.Recurrence.Range);
                    }

                    if (calEvent.Attendees.Count() > 0)
                    {
                        dgEvents.Rows[n].Cells[(int)columns.Attendees].Value = "View Attendees";
                        List<Attendee> iAttendee = new List<Attendee>();
                        foreach (var item in calEvent.Attendees)
                        {
                            iAttendee.Add(item);
                            
                        }
                        dAttendees.Add(calEvent.Id, iAttendee);
                    }

                    if (calEvent.HasAttachments == true)
                    {
                        var attachments = calEvent.Attachments.CurrentPage;
                        List<FileAttachment> tempFileAttachment = new List<FileAttachment>();
                        List<ItemAttachment> tempItemAttachment = new List<ItemAttachment>();
                        List<ReferenceAttachment> tempReferenceAttachment = new List<ReferenceAttachment>();

                        foreach (var attachment in attachments)
                        {
                            if (attachment.GetType().ToString() == "Microsoft.Graph.FileAttachment")
                            {
                                tempFileAttachment.Add((FileAttachment)attachment);
                            }
                            else if (attachment.GetType().ToString() == "Microsoft.Graph.ReferenceAttachment")
                            {
                                tempReferenceAttachment.Add((ReferenceAttachment)attachment);
                            }
                            else
                            {
                                tempItemAttachment.Add((ItemAttachment)attachment);
                            }
                        }

                        if (attachments.Count > 0)
                        {
                            dgEvents.Rows[n].Cells[(int)columns.Attachments].Value = "View Attachments";
                            if (tempFileAttachment.Count > 0)
                            {
                                dFileAttachments.Add(calEvent.Id, tempFileAttachment);
                            }
                            if (tempItemAttachment.Count > 0)
                            {
                                dItemAttachments.Add(calEvent.Id, tempItemAttachment);
                            }
                            if (tempReferenceAttachment.Any())
                            {
                                dReferenceAttachments.Add(calEvent.Id, tempReferenceAttachment);
                            }
                        }
                    }
                    else
                    {
                        dgEvents.Rows[n].Cells[(int)columns.Attachments].Value = "";
                    }

                    if (calEvent.Body != null)
                    {
                        dgEvents.Rows[n].Cells[(int)columns.Body].Value = "View Body";
                        List<ItemBody> iBody = new List<ItemBody>();
                        iBody.Add(calEvent.Body);
                        dItemBody.Add(calEvent.Id, iBody);
                    }

                    if (calEvent.Categories.Any())
                    {
                        List<string> tempCategories = new List<string>();
                        foreach (var item in calEvent.Categories)
                        {
                            tempCategories.Add(item);
                        }
                        dgEvents.Rows[n].Cells[(int)columns.Categories].Value = "View Categories";
                        dCategories.Add(calEvent.Id, tempCategories);
                    }

                    if (calEvent.Instances != null)
                    {
                        dgEvents.Rows[n].Cells[(int)columns.Categories].Value = "View Instances";
                    }
                }
            }
            catch (ServiceException se)
            {
                sdklogger.Log("Calendar:GetEventsAsync GraphServiceException:");
                sdklogger.Log(se.Message);
            }
            catch (NullReferenceException nre)
            {
                sdklogger.Log("Calendar:GetEventsAsync NullReferenceException:");
                sdklogger.Log(nre.Message);
            }
            catch (ArgumentOutOfRangeException aor)
            {
                sdklogger.Log("Calendar:GetEventsAsync ArgumentOutOfRangeException:");
                sdklogger.Log(aor.Message);
            }
            catch (AdalException ae)
            {
                sdklogger.Log("Calendar:GetEventsAsync AdalException:");
                sdklogger.Log(ae.Message);
            }
            catch (Exception ex)
            {
                sdklogger.Log("Calendar:GetEventsAsync Exception:");
                sdklogger.Log(ex.Message);
            }
            finally
            {                
                Cursor = Cursors.Default;
            }
        }

        public void dgCleanup()
        {
            // delete all the existing rows
            dgEvents.Rows.Clear();

            // cleanup associated dictionaries
            dItemBody.Clear();
            dAttendees.Clear();
            dCategories.Clear();
            dRecurrencePattern.Clear();
            dRecurrenceRange.Clear();
            dFileAttachments.Clear();
            dItemAttachments.Clear();
        }

        private void dgEvents_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // get the selected items Id
                string mId = dgEvents.Rows[e.RowIndex].Cells[0].Value.ToString();

                // open the associated form based on the selected column
                if (e.ColumnIndex == (int)columns.Body)
                {
                    List<ItemBody> tItemBody = null;

                    foreach (KeyValuePair<string, List<ItemBody>> pair in dItemBody)
                    {
                        if (pair.Key == mId)
                        {
                            tItemBody = pair.Value;
                        }
                    }

                    ItemBodyForm mItemBody = new ItemBodyForm(mId, tItemBody);
                    mItemBody.Owner = this;
                    mItemBody.ShowDialog(this);
                }
                // open the associated form based on the selected column
                if (e.ColumnIndex == (int)columns.Attendees)
                {
                    List<Attendee> tAttendees = null;

                    foreach (KeyValuePair<string, List<Attendee>> pair in dAttendees)
                    {
                        if (pair.Key == mId)
                        {
                            tAttendees = pair.Value;
                        }
                    }

                    AttendeeForm mAttendees = new AttendeeForm(mId, tAttendees);
                    mAttendees.Owner = this;
                    mAttendees.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.Categories)
                {
                    List<string> lCategories = null;
                    foreach (KeyValuePair<string, List<string>> pair in dCategories)
                    {
                        if (pair.Key == mId)
                        {
                            lCategories = pair.Value;
                        }
                    }

                    CategoriesForm mCategories = new CategoriesForm(lCategories);
                    mCategories.Owner = this;
                    mCategories.ShowDialog(this);
                }
                if (e.ColumnIndex == (int)columns.Recurrence)
                {
                    RecurrencePattern tPattern = null;
                    RecurrenceRange tRange = null;
                    foreach (KeyValuePair<string, RecurrencePattern> pair in dRecurrencePattern)
                    {
                        if (pair.Key == mId)
                        {
                            tPattern = pair.Value;
                        }
                    }

                    foreach (KeyValuePair<string, RecurrenceRange> pair in dRecurrenceRange)
                    {
                        if (pair.Key == mId)
                        {
                            tRange = pair.Value;
                        }
                    }

                    RecurrenceForm mRecurrence = new RecurrenceForm(tPattern, tRange);
                    mRecurrence.Owner = this;
                    mRecurrence.ShowDialog(this);
                }

                if (e.ColumnIndex == (int)columns.Attachments)
                {
                    if (dFileAttachments.Count > 0 || dItemAttachments.Count > 0)
                    {
                        List<FileAttachment> tFileAttachments = null;
                        List<ItemAttachment> tItemAttachments = null;
                        List<ReferenceAttachment> tRefAttachments = null;

                        foreach (KeyValuePair<string, List<FileAttachment>> pair in dFileAttachments)
                        {
                            if (pair.Key == mId)
                            {
                                tFileAttachments = pair.Value;
                            }
                        }

                        foreach (KeyValuePair<string, List<ItemAttachment>> pair in dItemAttachments)
                        {
                            if (pair.Key == mId)
                            {
                                tItemAttachments = pair.Value;
                            }
                        }

                        foreach (KeyValuePair<string, List<ReferenceAttachment>> pair in dReferenceAttachments)
                        {
                            if (pair.Key == mId)
                            {
                                tRefAttachments = pair.Value;
                            }
                        }

                        AttachmentsForm mAttachment = new AttachmentsForm(mId, tFileAttachments, tItemAttachments, tRefAttachments, ref applogger);
                        mAttachment.Owner = this;
                        mAttachment.ShowDialog(this);
                    }
                }
            }
            catch (NullReferenceException nre)
            {
                applogger.Log("Double-click Error:");
                applogger.Log(nre.Message);
            }
            catch (Exception ex)
            {
                applogger.Log("Double-click Error:");
                applogger.Log(ex.Message);
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int x = dgEvents.CurrentCell.RowIndex;
                int y = dgEvents.CurrentCell.ColumnIndex;
                Clipboard.SetText(dgEvents.Rows[x].Cells[y].Value.ToString());
            }
            catch (NullReferenceException nre)
            {
                applogger.Log("Copy Error:");
                applogger.Log(nre.Message);
            }
            catch (Exception ex)
            {
                applogger.Log("Copy Error:");
                applogger.Log(ex.Message);
            }
        }

        private void dgEvents_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                dgEvents.CurrentCell = dgEvents[e.ColumnIndex, e.RowIndex];
            }
        }

        // enum for the datagridview columns
        // any changes in the dg column, should only need to be made here
        enum columns
        {
            Id = 0,
            Subject = 1,
            Location = 2,
            Attendees = 3,
            Organizer = 4,
            Attachments = 5,
            Body = 6,
            BodyPreview = 7,
            Calendar = 8,
            Categories = 9,
            ChangeKey = 10,
            CreatedDateTime = 11,
            LastModifiedDateTime = 12,
            Start = 13,
            End = 14,
            HasAttachments = 15,
            Importance = 16,
            Instances = 17,
            iCalUID = 18,
            IsAllDay = 19,
            IsCancelled = 20,
            IsOrganizer = 21,
            OriginalEndTimeZone = 22,
            OriginalStartTimeZone = 23,
            Recurrence = 24,
            ResponseRequested = 25,
            ResponseStatus = 26,
            SeriesMasterId = 27,
            ShowAs = 28,
            Type = 29,
            WebLink = 30
        };

        private void btnNewMeeting_Click(object sender, EventArgs e)
        {
            NewEventForm newEvt = new NewEventForm(ref graphClient, ref applogger, ref sdklogger);
            newEvt.Owner = this;
            newEvt.ShowDialog(this);
        }
    }
}