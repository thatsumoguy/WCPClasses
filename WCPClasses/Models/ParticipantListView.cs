using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCPClasses.Models
{
    public class ParticipantListView
    {
        public List<ParticipantView> Participants { get; set; }
        public int TotalParticipants { get; set; }
    }
}

