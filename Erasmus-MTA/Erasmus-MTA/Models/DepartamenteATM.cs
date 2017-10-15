namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DepartamenteATM")]
    public partial class DepartamenteATM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DepartamenteATM()
        {
            MobilitateIncoming = new HashSet<MobilitateIncoming>();
            MobilitateOutgoing = new HashSet<MobilitateOutgoing>();
            PersonalATM = new HashSet<PersonalATM>();
        }

        public int ID { get; set; }

        [Required]
        public string Nume { get; set; }

        [Required]
        public string NumeEngleza { get; set; }

        public int Institutie { get; set; }

        [Required]
        public string Acronim { get; set; }

        public string AdresaPostala { get; set; }

        public string AdresaWeb { get; set; }

        public string Descriere { get; set; }

        public virtual Institutie Institutie1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateIncoming> MobilitateIncoming { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MobilitateOutgoing> MobilitateOutgoing { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonalATM> PersonalATM { get; set; }
    }
}
