using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Academic_Hub.Models
{
    public class MeetingRequest
    {
        public int RequestId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public int Requester { get; set; }
    }
}
