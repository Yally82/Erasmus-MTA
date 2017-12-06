namespace Erasmus_MTA.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ErasmusEntities : DbContext
    {
        public ErasmusEntities()
            : base("name=ErasmusEntities")
        {
        }

        public virtual DbSet<LoginUser> LoginUsers { get; set; }
        public virtual DbSet<CategorieMobilitate> CategorieMobilitate { get; set; }
        public virtual DbSet<DepartamenteATM> DepartamenteATM { get; set; }
        public virtual DbSet<DepartamentePartenere> DepartamentePartenere { get; set; }
        public virtual DbSet<DetaliiMobilitatiProiect> DetaliiMobilitatiProiect { get; set; }
        public virtual DbSet<DomeniuMobilitate> DomeniuMobilitate { get; set; }
        public virtual DbSet<GrantSiMobilitati> GrantSiMobilitati { get; set; }
        public virtual DbSet<Institutie> Institutie { get; set; }
        public virtual DbSet<InstitutiiPartenere> InstitutiiPartenere { get; set; }
        public virtual DbSet<Mobilitate> Mobilitate { get; set; }
        public virtual DbSet<MobilitateIncoming> MobilitateIncoming { get; set; }
        public virtual DbSet<MobilitateOutgoing> MobilitateOutgoing { get; set; }
        public virtual DbSet<NivelStudii> NivelStudii { get; set; }
        public virtual DbSet<Oras> Oras { get; set; }
        public virtual DbSet<ParticipantiStraini> ParticipantiStraini { get; set; }
        public virtual DbSet<PersonalATM> PersonalATM { get; set; }
        public virtual DbSet<ProgramMobilitati> ProgramMobilitati { get; set; }
        public virtual DbSet<ProiecteMobilitati> ProiecteMobilitati { get; set; }
        public virtual DbSet<SituatieActuala> SituatieActuala { get; set; }
        public virtual DbSet<SituatieErasmus> SituatieErasmus { get; set; }
        public virtual DbSet<Tara> Tara { get; set; }
        public virtual DbSet<TipMobilitate> TipMobilitate { get; set; }
        public virtual DbSet<TipPartener> TipPartener { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoginUser>()
                .Property(e => e.PasswordHash)
                .IsFixedLength();
        
            modelBuilder.Entity<CategorieMobilitate>()
                .HasMany(e => e.Mobilitate)
                .WithRequired(e => e.CategorieMobilitate)
                .HasForeignKey(e => e.IdCategorie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartamenteATM>()
                .HasMany(e => e.MobilitateIncoming)
                .WithRequired(e => e.DepartamenteATM)
                .HasForeignKey(e => e.DepartamentATM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartamenteATM>()
                .HasMany(e => e.MobilitateOutgoing)
                .WithRequired(e => e.DepartamenteATM)
                .HasForeignKey(e => e.DepartamentATM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartamenteATM>()
                .HasMany(e => e.PersonalATM)
                .WithRequired(e => e.DepartamenteATM)
                .HasForeignKey(e => e.DepartamentATM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartamentePartenere>()
                .HasMany(e => e.MobilitateIncoming)
                .WithRequired(e => e.DepartamentePartenere)
                .HasForeignKey(e => e.DepartamentPartener)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DepartamentePartenere>()
                .HasMany(e => e.ParticipantiStraini)
                .WithRequired(e => e.DepartamentePartenere)
                .HasForeignKey(e => e.DepartamentPartner)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DetaliiMobilitatiProiect>()
                .Property(e => e.SMS)
                .HasPrecision(10, 4);

            modelBuilder.Entity<DetaliiMobilitatiProiect>()
                .Property(e => e.SMP)
                .HasPrecision(10, 4);

            modelBuilder.Entity<DetaliiMobilitatiProiect>()
                .Property(e => e.SM)
                .HasPrecision(11, 4);

            modelBuilder.Entity<DetaliiMobilitatiProiect>()
                .Property(e => e.STA)
                .HasPrecision(10, 4);

            modelBuilder.Entity<DetaliiMobilitatiProiect>()
                .Property(e => e.STT)
                .HasPrecision(10, 4);

            modelBuilder.Entity<DetaliiMobilitatiProiect>()
                .Property(e => e.ST)
                .HasPrecision(11, 4);

            modelBuilder.Entity<DetaliiMobilitatiProiect>()
                .Property(e => e.SOM)
                .HasPrecision(10, 4);

            modelBuilder.Entity<DetaliiMobilitatiProiect>()
                .Property(e => e.Total)
                .HasPrecision(11, 4);

            modelBuilder.Entity<DomeniuMobilitate>()
                .HasMany(e => e.MobilitateIncoming)
                .WithRequired(e => e.DomeniuMobilitate1)
                .HasForeignKey(e => e.DomeniuMobilitate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<DomeniuMobilitate>()
                .HasMany(e => e.MobilitateOutgoing)
                .WithRequired(e => e.DomeniuMobilitate1)
                .HasForeignKey(e => e.DomeniuMobilitate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<GrantSiMobilitati>()
                .HasMany(e => e.DetaliiMobilitatiProiect)
                .WithRequired(e => e.GrantSiMobilitati)
                .HasForeignKey(e => e.IdGrantSiMobilitati)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Institutie>()
                .HasMany(e => e.DepartamenteATM)
                .WithRequired(e => e.Institutie1)
                .HasForeignKey(e => e.Institutie)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InstitutiiPartenere>()
                .HasMany(e => e.DepartamentePartenere)
                .WithRequired(e => e.InstitutiiPartenere)
                .HasForeignKey(e => e.InstitutiePartenera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InstitutiiPartenere>()
                .HasMany(e => e.MobilitateIncoming)
                .WithRequired(e => e.InstitutiiPartenere)
                .HasForeignKey(e => e.InstitutiePartenera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InstitutiiPartenere>()
                .HasMany(e => e.MobilitateOutgoing)
                .WithRequired(e => e.InstitutiiPartenere)
                .HasForeignKey(e => e.InstitutiePartenera)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mobilitate>()
                .HasMany(e => e.MobilitateIncoming)
                .WithRequired(e => e.Mobilitate)
                .HasForeignKey(e => e.TipMobilitati)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Mobilitate>()
                .HasMany(e => e.MobilitateOutgoing)
                .WithRequired(e => e.Mobilitate)
                .HasForeignKey(e => e.TipMobilitati)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MobilitateOutgoing>()
                .Property(e => e.GrantErasmusUtilizat)
                .HasPrecision(10, 4);

            modelBuilder.Entity<MobilitateOutgoing>()
                .Property(e => e.Descriere)
                .IsUnicode(false);

            modelBuilder.Entity<NivelStudii>()
                .HasMany(e => e.Mobilitate)
                .WithOptional(e => e.NivelStudii)
                .HasForeignKey(e => e.IdNivelStudii);

            modelBuilder.Entity<Oras>()
                .HasMany(e => e.DepartamentePartenere)
                .WithRequired(e => e.Oras1)
                .HasForeignKey(e => e.Oras)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Oras>()
                .HasMany(e => e.InstitutiiPartenere)
                .WithRequired(e => e.Oras1)
                .HasForeignKey(e => e.Oras)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ParticipantiStraini>()
                .HasMany(e => e.MobilitateIncoming)
                .WithRequired(e => e.ParticipantiStraini)
                .HasForeignKey(e => e.ParticipantStrain)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ParticipantiStraini>()
                .HasMany(e => e.MobilitateIncoming1)
                .WithRequired(e => e.ParticipantiStraini1)
                .HasForeignKey(e => e.PersoanaStrainaContact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ParticipantiStraini>()
                .HasMany(e => e.MobilitateOutgoing)
                .WithRequired(e => e.ParticipantiStraini)
                .HasForeignKey(e => e.PersoanaStrainaContact)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonalATM>()
                .HasMany(e => e.MobilitateIncoming)
                .WithRequired(e => e.PersonalATM)
                .HasForeignKey(e => e.PersoanaResponsabilaATM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonalATM>()
                .HasMany(e => e.MobilitateOutgoing)
                .WithRequired(e => e.PersonalATM)
                .HasForeignKey(e => e.PersoanaResponsabilaATM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonalATM>()
                .HasMany(e => e.MobilitateOutgoing1)
                .WithRequired(e => e.PersonalATM1)
                .HasForeignKey(e => e.ParticipantATM)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PersonalATM>()
                .HasMany(e => e.ProiecteMobilitati)
                .WithRequired(e => e.PersonalATM)
                .HasForeignKey(e => e.DirectorProiect)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProgramMobilitati>()
                .HasMany(e => e.ProiecteMobilitati)
                .WithRequired(e => e.ProgramMobilitati1)
                .HasForeignKey(e => e.ProgramMobilitati)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProiecteMobilitati>()
                .HasMany(e => e.DetaliiMobilitatiProiect)
                .WithRequired(e => e.ProiecteMobilitati)
                .HasForeignKey(e => e.ID_Proiect)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProiecteMobilitati>()
                .HasMany(e => e.MobilitateIncoming)
                .WithRequired(e => e.ProiecteMobilitati)
                .HasForeignKey(e => e.ProiectMobilitate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ProiecteMobilitati>()
                .HasMany(e => e.MobilitateOutgoing)
                .WithRequired(e => e.ProiecteMobilitati)
                .HasForeignKey(e => e.ProiectMobilitate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituatieActuala>()
                .HasMany(e => e.ParticipantiStraini)
                .WithRequired(e => e.SituatieActuala1)
                .HasForeignKey(e => e.SituatieActuala)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituatieActuala>()
                .HasMany(e => e.PersonalATM)
                .WithRequired(e => e.SituatieActuala1)
                .HasForeignKey(e => e.SituatieActuala)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituatieErasmus>()
                .HasMany(e => e.ParticipantiStraini)
                .WithRequired(e => e.SituatieErasmus1)
                .HasForeignKey(e => e.SituatieErasmus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SituatieErasmus>()
                .HasMany(e => e.PersonalATM)
                .WithRequired(e => e.SituatieErasmus1)
                .HasForeignKey(e => e.SituatieErasmus)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tara>()
                .HasMany(e => e.Oras)
                .WithRequired(e => e.Tara1)
                .HasForeignKey(e => e.Tara)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipMobilitate>()
                .HasMany(e => e.CategorieMobilitate)
                .WithRequired(e => e.TipMobilitate1)
                .HasForeignKey(e => e.TipMobilitate)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipPartener>()
                .HasMany(e => e.InstitutiiPartenere)
                .WithRequired(e => e.TipPartener1)
                .HasForeignKey(e => e.TipPartener)
                .WillCascadeOnDelete(false);
        }
    }
}
