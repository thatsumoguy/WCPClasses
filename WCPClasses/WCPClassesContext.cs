using WCPClasses.Models;
using System.Data.Entity;

namespace WCPClasses
{
    public class WCPClassesContext : DbContext
    {
        public WCPClassesContext() : base("name=WCPClassesContext") { }
        public virtual DbSet<Participant> Participants { get; set; }
    
             
    }

}


