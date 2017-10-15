namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Oras
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Oras()
        {
            DepartamentePartenere = new HashSet<DepartamentePartenere>();
            InstitutiiPartenere = new HashSet<InstitutiiPartenere>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Nume { get; set; }

        [StringLength(20)]
        public string NumeRomana { get; set; }

        [StringLength(20)]
        public string NumeEngleza { get; set; }

        public int Tara { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartamentePartenere> DepartamentePartenere { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstitutiiPartenere> InstitutiiPartenere { get; set; }

        public virtual Tara Tara1 { get; set; }
    }
}
