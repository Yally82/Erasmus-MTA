namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tara")]
    public partial class Tara
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tara()
        {
            Oras = new HashSet<Oras>();
        }

        public int ID { get; set; }

        public string Nume { get; set; }

        [Required]
        public string NumeRomana { get; set; }

        [Required]
        public string NumeEngleza { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Oras> Oras { get; set; }
    }
}
