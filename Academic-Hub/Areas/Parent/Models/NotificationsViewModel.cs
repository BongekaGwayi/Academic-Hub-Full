using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Academic_Hub.Models;
using Academic_Hub.Models.TestModels;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Academic_Hub.Areas.Parent.Models
{
    public class NotificationsViewModel
    {
        public List<Announcement> announcements = new List<Announcement>();
        public List<Meeting> meetings = new List<Meeting>();
        public List<SubjectEvent> subjectEvents = new List<SubjectEvent>();
        public List<MeetingRequest> meetingRequests = new List<MeetingRequest>();
        public NotificationsViewModel()
        {
            this.announcements = StudentInfo.GetAnnouncements();
            this.meetings = StudentInfo.GetMeetings();
            this.subjectEvents = StudentInfo.GetAssessments();
            this.meetingRequests = StudentInfo.GetRequests();
        }
    }
}
