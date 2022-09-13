using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academic_Hub.Models;
using Academic_Hub.Models.TestModels;

namespace Academic_Hub.Areas.Parent.Models
{
    public class ReportViewModel
    {
        public ParentUser Parent { get; set; }
        public List<Student> Students = new List<Student>();
        public List<Student_Subject> Students_Subjects = new List<Student_Subject>();
        public List<MeetingRequest> Requests { get; set; }
        public ReportViewModel(int ParentId)
        {
            this.Parent = UserList.GetParents().Find(x => x.ParentId == ParentId);
            this.Students = StudentInfo.GetStudents().FindAll(x => x.ParentId == ParentId);
            foreach (var s in this.Students)
            {
                Students_Subjects.AddRange(StudentInfo.GetStudentsSubjects().FindAll(x => x.StudentId == s.StudentId));
            }
            this.Requests = StudentInfo.GetRequests().FindAll(x => x.Requester == ParentId);
        }
    }
}
