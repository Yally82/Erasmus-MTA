namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Mobilitate")]
    public partial class Mobilitate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Mobilitate()
        {
            MobilitateIncoming = new HashSet<MobilitateIncoming>();
            MobilitateOutgoing = new HashSet<MobilitateOutgoing>();
        }

        public int ID { get; set; }

        public int? IdNivelStudii { get; set; }

        public int IdCategorie { get; set; }

        public virtual CategorieMobilitate CategorieMobilitate { get; set; }

        public virtual NivelStudii NivelStudii { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateIncoming> MobilitateIncoming { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateOutgoing> MobilitateOutgoing { get; set; }
    }
}
