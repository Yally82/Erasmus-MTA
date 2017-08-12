namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonalATM")]
    public partial class PersonalATM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PersonalATM()
        {
            MobilitateIncoming = new HashSet<MobilitateIncoming>();
            MobilitateOutgoing = new HashSet<MobilitateOutgoing>();
            MobilitateOutgoing1 = new HashSet<MobilitateOutgoing>();
            ProiecteMobilitati = new HashSet<ProiecteMobilitati>();
        }

        public int ID { get; set; }

        [Required]
        public string Nume { get; set; }

        [Required]
        public string Prenume { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataNasterii { get; set; }

        public int DepartamentATM { get; set; }

        public int SituatieActuala { get; set; }

        public int SituatieErasmus { get; set; }

        [Required]
        public string Functie { get; set; }

        [Required]
        public string Email { get; set; }

        public string Telefon { get; set; }

        public string Descriere { get; set; }

        public virtual DepartamenteATM DepartamenteATM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateIncoming> MobilitateIncoming { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateOutgoing> MobilitateOutgoing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateOutgoing> MobilitateOutgoing1 { get; set; }

        public virtual SituatieActuala SituatieActuala1 { get; set; }

        public virtual SituatieErasmus SituatieErasmus1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProiecteMobilitati> ProiecteMobilitati { get; set; }
    }
}
