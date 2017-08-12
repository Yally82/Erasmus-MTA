namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DomeniuMobilitate")]
    public partial class DomeniuMobilitate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DomeniuMobilitate()
        {
            MobilitateIncoming = new HashSet<MobilitateIncoming>();
            MobilitateOutgoing = new HashSet<MobilitateOutgoing>();
        }

        public int ID { get; set; }

        [Required]
        public string Nume { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateIncoming> MobilitateIncoming { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateOutgoing> MobilitateOutgoing { get; set; }
    }
}
