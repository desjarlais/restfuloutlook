using Microsoft.Graph;
using RESTfulOutlook.Utils;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESTfulOutlook.Forms
{
    public partial class NewEventForm : Form
    {
        GraphServiceClient graphClient;
        ClassLogger applogger = null;
        ClassLogger sdklogger = null;

        public NewEventForm(ref GraphServiceClient olClient, ref ClassLogger appLogger, ref ClassLogger sdkLogger)
        {
            InitializeComponent();
            graphClient = olClient;
            applogger = appLogger;
            sdklogger = sdkLogger;

            // add 1/2 hour to the dtpend time
            dtpEndTime.Value = dtpEndTime.Value.AddMinutes(30);
        }

        public async Task CreateNewMeeting()
        {
            try
            {
                Microsoft.Graph.Event evt = new Microsoft.Graph.Event();

                Location location = new Location();
                location.DisplayName = tbLocation.Text;

                ItemBody body = new ItemBody();
                body.Content = tbBody.Text;
                body.ContentType = BodyType.Html;

                List<Attendee> attendees = new List<Attendee>();
                Attendee attendee = new Attendee();
                EmailAddress email = new EmailAddress();
                email.Address = tbToRecipients.Text;
                attendee.EmailAddress = email;
                attendee.Type = AttendeeType.Required;
                attendees.Add(attendee);
                                
                evt.Subject = tbSubject.Text;
                evt.Body = body;
                evt.Location = location;
                evt.Attendees = attendees;

                DateTimeTimeZone dtStart = new DateTimeTimeZone();
                dtStart.TimeZone = TimeZoneInfo.Local.Id;
                DateTime dts = dtpStartDate.Value.Date + dtpStartTime.Value.TimeOfDay;
                dtStart.DateTime = dts.ToString();
                
                DateTimeTimeZone dtEnd = new DateTimeTimeZone();
                dtEnd.TimeZone = TimeZoneInfo.Local.Id;
                DateTime dte = dtpEndDate.Value.Date + dtpEndTime.Value.TimeOfDay;
                dtEnd.DateTime = dte.ToString();

                evt.Start = dtStart;
                evt.End = dtEnd;

                // log the request info
                sdklogger.Log(graphClient.Me.Events.Request().GetHttpRequestMessage().Headers.ToString());
                sdklogger.Log(graphClient.Me.Events.Request().GetHttpRequestMessage().RequestUri.ToString());

                // send the new message
                var createdEvent = await graphClient.Me.Events.Request().AddAsync(evt);

                // log the send and associated id
                sdklogger.Log("Meeting Sent : Id = " + createdEvent.Id);
            }
            catch (Exception ex)
            {
                sdklogger.Log("NewMeetingSend Failed: " + ex.Message);
                sdklogger.Log(ex.Message);
            }
            finally
            {
                // close the form
                Close();
            }
        }

        private async void btnSendEmail_Click(object sender, EventArgs e)
        {
            await CreateNewMeeting();
        }
    }
}
