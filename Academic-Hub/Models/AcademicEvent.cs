using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Academic_Hub.Models
{
    public class AcademicEvent
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public DateTime EventTime { get; set; }
    }
    public class SubjectEvent : AcademicEvent
    {
        public int SubjectId { get; set; }
        public string EventType { get; set; }
        public string EventMessage { get; set; }
    }
}
