using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using SCMMVC.Models;

namespace SCMMVC.Configuration
{
    public class EncounterCharacterEntityConfiguration : EntityTypeConfiguration<EncounterCharacter>
    {
        public EncounterCharacterEntityConfiguration()
        {
            ToTable("EncounterCharacters");
            HasKey(ec => ec.Id);
            Property(ec => ec.Id).HasColumnName("EncounterId");

            Property(ec => ec.BaseBody)
                
            Property(ec => ec.TempBody)
                .HasColumnName("TempBody");
        }
    }
}
