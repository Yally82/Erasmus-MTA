namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GrantSiMobilitati")]
    public partial class GrantSiMobilitati
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GrantSiMobilitati()
        {
            DetaliiMobilitatiProiect = new HashSet<DetaliiMobilitatiProiect>();
        }

        public int ID { get; set; }

        [Required]
        public string Cheie { get; set; }

        [Required]
        public string Valoare { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetaliiMobilitatiProiect> DetaliiMobilitatiProiect { get; set; }
    }
}
