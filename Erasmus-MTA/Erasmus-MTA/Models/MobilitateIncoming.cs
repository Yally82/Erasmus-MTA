namespace Erasmus_MTA.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MobilitateIncoming")]
    public partial class MobilitateIncoming
    {
        public int ID { get; set; }

        public int ProiectMobilitate { get; set; }

        public int ParticipantStrain { get; set; }

        public int InstitutiePartenera { get; set; }

        public int DepartamentPartener { get; set; }

        public int PersoanaStrainaContact { get; set; }

        public int DepartamentATM { get; set; }

        public int PersoanaResponsabilaATM { get; set; }

        public int TipMobilitati { get; set; }

        public int DomeniuMobilitate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataInceputMobilitate { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataFinalMobilitate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? NrZileMobilitate { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int? NrLuniMobilitate { get; set; }

        public string Descriere { get; set; }

        public virtual DepartamenteATM DepartamenteATM { get; set; }

        public virtual DepartamentePartenere DepartamentePartenere { get; set; }

        public virtual DomeniuMobilitate DomeniuMobilitate1 { get; set; }

        public virtual InstitutiiPartenere InstitutiiPartenere { get; set; }

        public virtual Mobilitate Mobilitate { get; set; }

        public virtual ParticipantiStraini ParticipantiStraini { get; set; }

        public virtual ParticipantiStraini ParticipantiStraini1 { get; set; }

        public virtual PersonalATM PersonalATM { get; set; }

        public virtual ProiecteMobilitati ProiecteMobilitati { get; set; }
    }
}
