using System;
using System.Collections.Generic;

namespace SCM.Models
{
    public partial class Encounters
    {
        public Encounters()
        {
            EncounterCharacters = new HashSet<EncounterCharacters>();
            EncounterPlayers = new HashSet<EncounterPlayers>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string GMId { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<EncounterCharacters> EncounterCharacters { get; set; }
        public virtual ICollection<EncounterPlayers> EncounterPlayers { get; set; }
        public virtual ApplicationUser GM { get; set; }
    }
}
