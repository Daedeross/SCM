using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCMMVC.Models
{
    public class Encounter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GMId { get; set; }
        public bool Active { get; set; }


        public ICollection<Character> Characters { get; set; }
    }
}