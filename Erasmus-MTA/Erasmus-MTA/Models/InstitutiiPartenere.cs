namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InstitutiiPartenere")]
    public partial class InstitutiiPartenere
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InstitutiiPartenere()
        {
            DepartamentePartenere = new HashSet<DepartamentePartenere>();
            MobilitateIncoming = new HashSet<MobilitateIncoming>();
            MobilitateOutgoing = new HashSet<MobilitateOutgoing>();
        }

        public int ID { get; set; }

        [Required]
        public string Nume { get; set; }

        public string NumeRomana { get; set; }

        public string NumeEngleza { get; set; }

        public int Oras { get; set; }

        public int TipPartener { get; set; }

        [Required]
        public string Acronim { get; set; }

        public string AdresaPostala { get; set; }

        public string AdresaWeb { get; set; }

        public string CodErasmus { get; set; }

        public string CodPIC { get; set; }

        public string CartaErasmus { get; set; }

        public string AcordErasmus { get; set; }

        public string Descriere { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartamentePartenere> DepartamentePartenere { get; set; }

        public virtual Oras Oras1 { get; set; }

        public virtual TipPartener TipPartener1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateIncoming> MobilitateIncoming { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateOutgoing> MobilitateOutgoing { get; set; }
    }
}
