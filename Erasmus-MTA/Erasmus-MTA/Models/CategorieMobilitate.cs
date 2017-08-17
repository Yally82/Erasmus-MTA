namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CategorieMobilitate")]
    public partial class CategorieMobilitate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CategorieMobilitate()
        {
            Mobilitate = new HashSet<Mobilitate>();
        }

        public int ID { get; set; }

        [Required]
        public string Categorie { get; set; }

        public int TipMobilitate { get; set; }

        public virtual TipMobilitate TipMobilitate1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mobilitate> Mobilitate { get; set; }
    }
}
