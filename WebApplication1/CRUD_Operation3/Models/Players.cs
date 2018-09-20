using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUD_Operation3.Models
{
    //Domain-specific object(POCO)
    public class Players
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Country { get; set; }
        public String Sport { get; set; }
        public int MedalWon { get; set; }
        public int MatchPlayed { get; set; }

    }
}