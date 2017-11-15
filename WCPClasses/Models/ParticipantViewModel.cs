using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCPClasses.Models
{
    public class ParticipantViewModel
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ParticipantEmail { get; set; }
    }
}