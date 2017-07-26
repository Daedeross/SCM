using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using SCMMVC.Models;

namespace SCMMVC.Configuration
{
    public class EncounterEntityConfiguration :  EntityTypeConfiguration<Encounter>
    {
        public EncounterEntityConfiguration()
        {
            ToTable("Encounters");
            HasKey(e => e.Id);
            Property(e => e.Id)
                .HasColumnName("Id")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(e => e.Name)
                .HasColumnName("Name")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsVariableLength();
            Property(e => e.GMId)
                .HasColumnName("GMId");
            HasMany(e => e.Characters)
                .WithMany(c => c.Encounters)
                .Map(l =>
                {
                    l.ToTable("EncounterCharacters");
                    l.MapLeftKey("EncounterId");
                    l.MapRightKey("CharacterId");
                }
                );
                
        }
    }
}
