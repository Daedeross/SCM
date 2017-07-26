using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMMVC.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }
        public int Body { get; set; }

        public ICollection<Encounter> Encounters { get; set; }
    }
}
