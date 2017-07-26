using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCMMVC.Models
{
    public class EncounterCharacter
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int EncounterId { get; set; }

        public int BaseBody { get; set; }
        public int TempBody { get; set; }
        public int Body { get { return BaseBody + TempBody; } }

        public int BaseAgility { get; set; }
        public int TempAgility { get; set; }
        public int Agility { get { return BaseAgility + TempAgility; } }

        public int BaseReaction { get; set; }
        public int TempReaction { get; set; }
        public int Reaction { get { return BaseReaction + TempReaction; } }

        public int BaseStrength { get; set; }
        public int TempStrength { get; set; }
        public int Strength { get { return BaseStrength + TempStrength; } }

        public int BaseWillpower { get; set; }
        public int TempWillpower { get; set; }
        public int Willpower { get { return BaseWillpower + TempWillpower; } }

        public int BaseLogic { get; set; }
        public int TempLogic { get; set; }
        public int Logic { get { return BaseLogic + TempLogic; } }

        public int BaseIntuition { get; set; }
        public int TempIntuition { get; set; }
        public int Intuition { get { return BaseIntuition + TempIntuition; } }

        public int BaseCharisma { get; set; }
        public int TempCharisma { get; set; }
        public int Charisma { get { return BaseCharisma + TempCharisma; } }

        public int BaseEdge { get; set; }
        public int TempEdge { get; set; }
        public int Edge { get { return BaseEdge + TempEdge; } }

        public int BasePhysicalInitBonus { get; set; }
        public int TempPhysicalInitBonus { get; set; }
        public int PhysicalInitBonus { get { return BasePhysicalInitBonus + TempPhysicalInitBonus; } }
        public int PhysicalInitiative
        {
            get
            {
                return Intuition + Reaction + PhysicalInitBonus - NetPenalty;
            }
        }
        public int BasePhysicalInitDice { get; set; }
        public int TempPhysicalInitDice { get; set; }
        public int PhysicalInitDice { get { return 1 + BasePhysicalInitDice + TempPhysicalInitDice; } }

        public int BaseAstralInitBonus { get; set; }
        public int TempAstralInitBonus { get; set; }
        public int AstralInitBonus { get { return BaseAstralInitBonus + TempAstralInitBonus; } }
        public int AstralInitiative
        {
            get
            {
                return Intuition*2 + AstralInitBonus - NetPenalty;
            }
        }
        public int BaseAstralInitDice { get; set; }
        public int TempAstralInitDice { get; set; }
        public int AstralInitDice { get { return 2 + BaseAstralInitDice + TempAstralInitDice; } }

        public int BaseMatixInitBonus { get; set; }
        public int TempMatixInitBonus { get; set; }
        public int MatixInitBonus { get { return BaseMatixInitBonus + TempMatixInitBonus; } }
        public int MatrixInitiative
        {
            get
            {
                return Intuition + Reaction + PhysicalInitBonus - NetPenalty;
            }
        }
        public int BaseMatrixInitDice { get; set; }
        public int TempMatrixInitDice { get; set; }
        public int MatrixInitDice { get { return 1 + BaseMatrixInitDice + TempMatrixInitDice; } }

        public int PhysicalTrackBonus { get; set; }
        public int PhysicalTrackOffset { get; set; }
        public int PhysicalTrack { get { return (Body +1) / 2 + PhysicalTrackOffset; } }
        public int PhysicalDamage { get; set; }

        public int StunTrackBonus { get; set; }
        public int StunTrackOffset { get; set; }
        public int StunTrack { get { return (Willpower + 1) / 2 + StunTrackOffset; } }
        public int StunDamage { get; set; }

        public int NetPenalty
        {
            get
            {
                return (PhysicalDamage - PhysicalTrackOffset / 3)
                     + (StunDamage - StunTrackOffset / 3);
            }
        }
    }
}
