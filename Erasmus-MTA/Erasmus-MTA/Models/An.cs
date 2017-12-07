namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("An")]
    public partial class An
    {
        public int ID { get; set; }

        public int? Valoare { get; set; }
    }
}
