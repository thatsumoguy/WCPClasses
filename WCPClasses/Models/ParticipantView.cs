using System.ComponentModel;


namespace WCPClasses.Models
{
    public class ParticipantView
    {
        public int? ParticipantId { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Name")]
        public string FullName => FirstName + " " + LastName;
    }
}
