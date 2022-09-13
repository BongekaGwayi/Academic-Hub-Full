using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Academic_Hub.Models;
using Academic_Hub.Models.TestModels;

namespace Academic_Hub.Areas.Parent.Models
{
    public class DashboardViewModel
    {
        public Student student { get; set; }
        public List<SubjectEvent> events = new List<SubjectEvent>();
        public List<Student_Subject> stud_sub { get; set; }
        public DashboardViewModel(int parentId)
        {
            this.student = StudentInfo.GetStudent(parentId);
            this.stud_sub = StudentInfo.GetStudentsSubjects(student.StudentId);
            foreach (var s in stud_sub)
            {
                this.events.AddRange(StudentInfo.GetAssessments().FindAll(x => x.SubjectId == s.SubjectId));
            }
            this.events = events.OrderBy(x => x.EventTime).ToList();
        }
        
    }
}
