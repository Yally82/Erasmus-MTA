namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DetaliiMobilitatiProiect")]
    public partial class DetaliiMobilitatiProiect
    {
        public int ID { get; set; }

        public int IdGrantSiMobilitati { get; set; }

        public int ID_Proiect { get; set; }

        public decimal? SMS { get; set; }

        public decimal? SMP { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? SM { get; set; }

        public decimal? STA { get; set; }

        public decimal? STT { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? ST { get; set; }

        public decimal? SOM { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? Total { get; set; }

        public virtual GrantSiMobilitati GrantSiMobilitati { get; set; }

        public virtual ProiecteMobilitati ProiecteMobilitati { get; set; }
    }
}
