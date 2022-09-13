using Academic_Hub.Models.TestModels;
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
        public string GetAnnouncerName(int announcer)
        {
            var a = UserList.GetUsers().Find(x => x.Id == announcer);
            if (!(a == null))
            {
                switch (a.Role)
                {
                    case "Parent":
                        var u = UserList.GetParents().Find(x => x.ParentId == a.Id);
                        return u.FirstName + " " + u.LastName;
                    case "Hod": return "";
                    default: return "Unknown";
                }
            }
            return "Unknown";
        }
    }
}
