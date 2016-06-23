using System;
using System.Collections.Generic;

namespace SCM.Models
{
    public partial class EncounterPlayers
    {
        public int EncounterId { get; set; }
        public string UserId { get; set; }

        public virtual Encounters Encounter { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
