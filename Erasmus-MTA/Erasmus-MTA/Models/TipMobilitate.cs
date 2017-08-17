namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TipMobilitate")]
    public partial class TipMobilitate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TipMobilitate()
        {
            CategorieMobilitate = new HashSet<CategorieMobilitate>();
        }

        public int ID { get; set; }

        [Required]
        public string Cheie { get; set; }

        public bool InOutMobilitate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CategorieMobilitate> CategorieMobilitate { get; set; }
    }
}
