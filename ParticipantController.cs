
using System.Collections.Generic;
using System.Linq;
using WCPClasses.Models;
using System.Web.Mvc;

namespace WCPClasses.Controllers
{
    public class ParticipantController : Controller
    {
        public static List<Participant> Participant = new List<Participant>
                {
                    new Participant { ParticipantId = 1, LastName = "Halpert", FirstName = "Jim", ParticipantEmail = "email1@domain.com" },
                    new Participant { ParticipantId = 2, LastName = "Beesly", FirstName = "Pam", ParticipantEmail = "email2@domain.com" },
                    new Participant { ParticipantId = 3, LastName = "Scott", FirstName = "Michael", ParticipantEmail = "email3@domain.com"},
                    new Participant { ParticipantId = 4, LastName = "Schrute", FirstName = "Dwight", ParticipantEmail = "email4@domain.com" },
                    new Participant { ParticipantId = 5, LastName = "Martin", FirstName = "Angela", ParticipantEmail = "email5@domain.com" },
                    new Participant { ParticipantId = 6, LastName = "Bernard", FirstName = "Andy", ParticipantEmail = "email6@domain.com" },
                    new Participant { ParticipantId = 7, LastName = "Malone", FirstName = "Kevin", ParticipantEmail = "email7@domain.com" },
                    new Participant { ParticipantId = 8, LastName = "Kapoor", FirstName = "Kelly", ParticipantEmail = "email8@domain.com" },
                    new Participant { ParticipantId = 9, LastName = "Palmer", FirstName = "Meredith", ParticipantEmail = "email9@domain.com" },
                    new Participant { ParticipantId = 10, LastName = "Flenderson", FirstName = "Toby", ParticipantEmail = "email10@domain.com" },
                    new Participant { ParticipantId = 11, LastName = "Hudson", FirstName = "Stanley", ParticipantEmail = "email11@domain.com" },
                    new Participant { ParticipantId = 12, LastName = "Bratton", FirstName = "Creed", ParticipantEmail = "email12@domain.com" },
                    new Participant { ParticipantId = 13, LastName = "Vance", FirstName = "Phyllis", ParticipantEmail = "email13@domain.com" },
                    new Participant { ParticipantId = 14, LastName = "Howard", FirstName = "Ryan", ParticipantEmail = "email14@domain.com" },
                    new Participant { ParticipantId = 15, LastName = "Philbin", FirstName = "Darryl", ParticipantEmail = "email15@domain.com" }
                };

        public ActionResult Index()
        {
            var participantList = new ParticipantListView
            {
                //Convert each Person to a ParticipantView
                Participants = Participant.Select(p => new ParticipantView
                {
                    ParticipantId = p.ParticipantId,
                    LastName = p.LastName,
                    FirstName = p.FirstName
                }).ToList()
            };

            participantList.TotalParticipants = participantList.Participants.Count;

            return View(participantList);
        }
        public ActionResult ParticipantDetail(int id)
        {
            var person = Participant.SingleOrDefault(p => p.ParticipantId == id);
            if (Participant != null)
            {
                var participantView = Participant.Select(p => new ParticipantView
                {
                    ParticipantId = p.ParticipantId,
                    LastName = p.LastName,
                    FirstName = p.FirstName,
                    EmailAddress = p.ParticipantEmail
                });

                return View(participantView);
            }

            return new HttpNotFoundResult();
        }


    }
}
