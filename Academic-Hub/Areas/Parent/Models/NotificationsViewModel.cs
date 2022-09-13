using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academic_Hub.Models;
using Academic_Hub.Models.TestModels;

namespace Academic_Hub.Areas.Parent.Models
{
    public class NotificationsViewModel
    {
        public List<Announcement> announcements;
        public List<Meeting> meetings;
        public List<SubjectEvent> subjectEvents;
        public List<MeetingRequest> meetingRequests;
        public NotificationsViewModel(int ParentId)
        {
            this.announcements = StudentInfo.GetAnnouncements();
            this.meetings = StudentInfo.GetMeetings();
            this.subjectEvents = StudentInfo.GetAssessments();
            this.meetingRequests = StudentInfo.GetRequests();
        }
    }
}
