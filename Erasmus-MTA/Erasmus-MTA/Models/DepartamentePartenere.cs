namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepartamentePartenere")]
    public partial class DepartamentePartenere
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepartamentePartenere()
        {
            MobilitateIncoming = new HashSet<MobilitateIncoming>();
            ParticipantiStraini = new HashSet<ParticipantiStraini>();
        }

        public int ID { get; set; }

        [Required]
        public string Nume { get; set; }

        [Required]
        public string NumeRomana { get; set; }

        [Required]
        public string NumeEngleza { get; set; }

        public int InstitutiePartenera { get; set; }

        public int Oras { get; set; }

        [Required]
        public string Acronim { get; set; }

        public string AdresaPostala { get; set; }

        public string AdresaWeb { get; set; }

        public string Descriere { get; set; }

        public virtual InstitutiiPartenere InstitutiiPartenere { get; set; }

        public virtual Oras Oras1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateIncoming> MobilitateIncoming { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ParticipantiStraini> ParticipantiStraini { get; set; }
    }
}
