using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCPClasses.Models
{
    public class ClassSession
    {
        public int Id { get; set; }
        public int WCPClassId { get; set; }
        public DateTime StartTime { get; set; }
        public string Course { get; set; }
    }
     
}
