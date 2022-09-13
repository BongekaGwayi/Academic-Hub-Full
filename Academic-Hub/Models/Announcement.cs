using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Academic_Hub.Models
{
    public class Announcement
    {
        public int AnnouncementId { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
        public int Announcer { get; set; }
    }
}
