namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Institutie")]
    public partial class Institutie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Institutie()
        {
            DepartamenteATM = new HashSet<DepartamenteATM>();
        }

        public int ID { get; set; }

        [Required]
        public string Nume { get; set; }

        public string NumeEngleza { get; set; }

        [Required]
        public string Acronim { get; set; }

        public string AdresaPostala { get; set; }

        public string AdresaWeb { get; set; }

        public string CodErasmus { get; set; }

        public string CodPIC { get; set; }

        public string Descriere { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DepartamenteATM> DepartamenteATM { get; set; }
    }
}
