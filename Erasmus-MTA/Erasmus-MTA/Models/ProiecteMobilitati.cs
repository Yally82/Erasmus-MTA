namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ProiecteMobilitati")]
    public partial class ProiecteMobilitati
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProiecteMobilitati()
        {
            DetaliiMobilitatiProiect = new HashSet<DetaliiMobilitatiProiect>();
            MobilitateIncoming = new HashSet<MobilitateIncoming>();
            MobilitateOutgoing = new HashSet<MobilitateOutgoing>();
        }

        public int ID { get; set; }

        [Required]
        public string DenumireProiect { get; set; }

        public int ProgramMobilitati { get; set; }

        public int DirectorProiect { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataInceputProiect { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataFinalProiect { get; set; }

        public int? NrInstitutiiPartenere { get; set; }

        public int? NrDepartementePartenere { get; set; }

        public string Descriere { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetaliiMobilitatiProiect> DetaliiMobilitatiProiect { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateIncoming> MobilitateIncoming { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateOutgoing> MobilitateOutgoing { get; set; }

        public virtual PersonalATM PersonalATM { get; set; }

        public virtual ProgramMobilitati ProgramMobilitati1 { get; set; }
    }
}
