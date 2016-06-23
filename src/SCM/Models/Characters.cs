using System;
using System.Collections.Generic;

namespace SCM
{
    public partial class Characters
    {
        public Characters()
        {
            CharacterGMs = new HashSet<CharacterGMs>();
            EncounterCharacters = new HashSet<EncounterCharacters>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string OwnerId { get; set; }
        public int? Body { get; set; }
        public int? Agility { get; set; }
        public int? Reaction { get; set; }
        public int? Strength { get; set; }
        public int? Willpower { get; set; }
        public int? Logic { get; set; }
        public int? Intuition { get; set; }
        public int? Charisma { get; set; }
        public int? Edge { get; set; }
        public int? PhysicalInitiativeBonus { get; set; }
        public int? PhysicalInitiativeDice { get; set; }
        public int? AstalInitiativeBonus { get; set; }
        public int? AstalInitiativeDice { get; set; }
        public int? MatrixInitiativeBonus { get; set; }
        public int? MatrixInitiativeDice { get; set; }
        public int? PhysicalTrackBonus { get; set; }
        public int? StunTrackBonus { get; set; }
        public int? PhysicalTrackOffset { get; set; }

        public virtual ICollection<CharacterGMs> CharacterGMs { get; set; }
        public virtual ICollection<EncounterCharacters> EncounterCharacters { get; set; }
        public virtual AspNetUsers Owner { get; set; }
    }
}
