using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academic_Hub.Models
{
    public class Meeting
    {
        public int MeetingId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
    }
}
