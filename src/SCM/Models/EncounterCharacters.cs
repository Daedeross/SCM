using System;
using System.Collections.Generic;

namespace SCM.Models
{
    public partial class EncounterCharacters
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int EncounterId { get; set; }
        public int? TempBody { get; set; }
        public int? TempAgility { get; set; }
        public int? TempReaction { get; set; }
        public int? TempStrength { get; set; }
        public int? TempWillpower { get; set; }
        public int? TempLogic { get; set; }
        public int? TempIntuition { get; set; }
        public int? TempCharisma { get; set; }
        public int? TempEdge { get; set; }
        public int? TempPhysicalInitBonus { get; set; }
        public int? TempAstralalInitBonus { get; set; }
        public int? TempMatrixInitBonus { get; set; }
        public int? TempPhysicalDiceBonus { get; set; }
        public int? TempAstralalDiceBonus { get; set; }
        public int? TempMatrixDiceBonus { get; set; }
        public int? PhysicalDamage { get; set; }
        public int? StunDamage { get; set; }

        public virtual Characters Character { get; set; }
        public virtual Encounters Encounter { get; set; }
    }
}
