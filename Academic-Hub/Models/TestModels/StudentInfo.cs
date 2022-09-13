using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academic_Hub.Models.TestModels
{
    public class StudentInfo
    {
        private static List<Student> _students = new List<Student>()
        {
            new Student()
            {
                StudentId = 3001,
                ParentId = 1001,
                FirstName = "Asenathi",
                LastName = "Mfikanye",
                DOB = Convert.ToDateTime("11/08/2007"),
                Grade = 10,
            },
            new Student()
            {
                StudentId = 3002,
                ParentId = 1002,
                FirstName = "Babalwa",
                LastName = "Gwayi",
                DOB = Convert.ToDateTime("10/16/2006"),
                Grade = 10,
            },new Student()
            {
                StudentId = 3003,
                FirstName = "Buhle",
                LastName = "Nkosi",
                DOB = Convert.ToDateTime("09/01/2008"),
                Grade = 10,
            },
        };
        private static List<Student_Subject> _stud_subj = new List<Student_Subject>()
        {
            new Student_Subject()
            {
                Id = 20101,
                StudentId = 3001,
                SubjectId = 10101,
                Mark1 = 63,
                Mark2 = 50,
                Mark3 = 0
            },
            new Student_Subject()
            {
                Id = 20101,
                StudentId = 3001,
                SubjectId = 10102,
                Mark1 = 81,
                Mark2 = 77,
                Mark3 = 0
            },
        };
        private static List<Subject> _subjects = new List<Subject>()
        {
            new Subject()
            {
                SubjectId = 10101,
                SubjectName = "Mathematics",
                SubjectTeacherId = 2001,
            },
            new Subject()
            {
                SubjectId = 10102,
                SubjectName = "Physical Science",
                SubjectTeacherId = 2002
            },
            new Subject()
            {
                SubjectId = 10103,
                SubjectName = "Geography",
                SubjectTeacherId = 2003
            },new Subject()
            {
                SubjectId = 10104,
                SubjectName = "Life Orientation",
                SubjectTeacherId = 2003
            },
            new Subject()
            {
                SubjectId = 10105,
                SubjectName = "Home Language",
                SubjectTeacherId = 2002
            },
            new Subject()
            {
                SubjectId = 10106,
                SubjectName = "English",
                SubjectTeacherId = 2001
            },
            new Subject()
            {
                SubjectId = 10107,
                SubjectName = "Life Science",
                SubjectTeacherId = 2004
            },
        };
        private static List<Meeting> _meetings = new List<Meeting>();
        private static List<SubjectEvent> _assessments = new List<SubjectEvent>()
        {
            new SubjectEvent()
            {
                EventId = 7091,
                EventName = "Assessment 1",
                EventTime = DateTime.Today.AddDays(1).AddHours(12),
                EventMessage = "A Mathematics Test has been made available in Content Area: Test 2",
                SubjectId = 10101,
                EventType = "Test"
            },
            new SubjectEvent()
            {
                EventId = 7092,
                EventName = "Assignment 2",
                EventTime = DateTime.Today.AddDays(1).AddHours(10),
                EventMessage = "Assignment 1 is due",
                SubjectId = 10101,
                EventType = "Assignment"

            },
            new SubjectEvent()
            {
                EventId = 7093,
                EventName = "Quiz 2",
                EventTime = DateTime.Today.AddDays(1).AddHours(11),
                EventMessage = "Attempt Quiz 2 before it closes",
                SubjectId = 10101,
                EventType = "Quiz",
            },
        };
        private static List<Announcement> _announcements = new List<Announcement>()
        {
            new Announcement()
            {
                AnnouncementId = 4570,
                Subject = "Parents Meeting",
                Message = "Parents are required to attend the first meeting " +
                "of the year to get things off with how things will be done throughout" +
                " the year",
                Created = DateTime.Today.AddDays(-50),
                Announcer = 1
            },
            new Announcement()
            {
                AnnouncementId = 4571,
                Subject = "Parents event for learners doing Physical Sciences",
                Message = "Parents are required to attend the Mathematics " +
                "orientation event students enrolled for Physical Sciences",
                Created = DateTime.Now.AddDays(-15),
            }
        };
        private static List<MeetingRequest> _requests = new List<MeetingRequest>()
        {
            new MeetingRequest()
            {
                RequestId = 1560,
                Subject = "",
                Body = "Student complaints regarding",
                CreatedDate = DateTime.Now.AddMonths(-2),
                Requester = 1001,
            },
            new MeetingRequest()
            {
                RequestId = 1561,
                Subject = "",
                Body = "Student complainants",
                CreatedDate= DateTime.Now.AddDays(-2),
                Requester = 1001,
            }
        };
        static StudentInfo()
        {
                
        }
        public static List<Announcement> GetAnnouncements()
        {
            return _announcements;
        }
        public static List<MeetingRequest> GetRequests()
        {
            return _requests;
        }
        public static List<Student_Subject> GetStudentsSubjects(int studentId)
        {
            return _stud_subj.FindAll(x => x.StudentId == studentId);
        }
        public static List<Student_Subject> GetStudentsSubjects()
        {
            return _stud_subj;
        }
        public static Student GetStudent(int id)
        {
            return _students.Find(x => x.ParentId == id);
        }
        public static List<Student> GetStudents()
        {
            return _students;
        }
        public static Subject GetSubject(int id)
        {
            return _subjects.Find(x => x.SubjectId == id);
        }
        public static void AddMeeting(MeetingRequest request)
        {
            _requests.Add(request);
        }
        public static List<Meeting> GetMeetings()
        {
            return _meetings;
        }
        public static List<SubjectEvent> GetAssessments()
        {
            return _assessments;
        }
    }
}
