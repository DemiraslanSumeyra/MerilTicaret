namespace MerilTicaret.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MerilContext : DbContext
    {
        public MerilContext()
            : base("name=Model1")
        {
        }

        public virtual DbSet<aspnet_Applications> aspnet_Applications { get; set; }
        public virtual DbSet<aspnet_Paths> aspnet_Paths { get; set; }
        public virtual DbSet<aspnet_PersonalizationAllUsers> aspnet_PersonalizationAllUsers { get; set; }
        public virtual DbSet<aspnet_PersonalizationPerUser> aspnet_PersonalizationPerUser { get; set; }
        public virtual DbSet<aspnet_Profile> aspnet_Profile { get; set; }
        public virtual DbSet<aspnet_Roles> aspnet_Roles { get; set; }
        public virtual DbSet<aspnet_SchemaVersions> aspnet_SchemaVersions { get; set; }
        public virtual DbSet<aspnet_Users> aspnet_Users { get; set; }
        public virtual DbSet<aspnet_WebEvent_Events> aspnet_WebEvent_Events { get; set; }
        public virtual DbSet<Kargo> Kargo { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }
        public virtual DbSet<Marka> Marka { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<MusteriAdres> MusteriAdres { get; set; }
        public virtual DbSet<OzellikDeger> OzellikDeger { get; set; }
        public virtual DbSet<OzellikTip> OzellikTip { get; set; }
        public virtual DbSet<Resim> Resim { get; set; }
        public virtual DbSet<Satis> Satis { get; set; }
        public virtual DbSet<SatisDetay> SatisDetay { get; set; }
        public virtual DbSet<SiparisDurum> SiparisDurum { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Urun> Urun { get; set; }
        public virtual DbSet<UrunOzellik> UrunOzellik { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Paths)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Roles)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Applications>()
                .HasMany(e => e.aspnet_Users)
                .WithRequired(e => e.aspnet_Applications)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<aspnet_Paths>()
                .HasOptional(e => e.aspnet_PersonalizationAllUsers)
                .WithRequired(e => e.aspnet_Paths);

            modelBuilder.Entity<aspnet_Roles>()
                .HasMany(e => e.aspnet_Users)
                .WithMany(e => e.aspnet_Roles)
                .Map(m => m.ToTable("aspnet_UsersInRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.aspnet_Profile)
                .WithRequired(e => e.aspnet_Users);

            modelBuilder.Entity<aspnet_Users>()
                .HasOptional(e => e.Musteri)
                .WithRequired(e => e.aspnet_Users);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventId)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventSequence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<aspnet_WebEvent_Events>()
                .Property(e => e.EventOccurrence)
                .HasPrecision(19, 0);

            modelBuilder.Entity<Kargo>()
                .Property(e => e.Telefon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Kategori>()
                .HasMany(e => e.OzellikTip)
                .WithRequired(e => e.Kategori)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Musteri>()
                .Property(e => e.Telefon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Musteri>()
                .HasMany(e => e.MusteriAdres)
                .WithRequired(e => e.Musteri)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OzellikDeger>()
                .HasMany(e => e.UrunOzellik)
                .WithRequired(e => e.OzellikDeger)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OzellikTip>()
                .HasMany(e => e.OzellikDeger)
                .WithRequired(e => e.OzellikTip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<OzellikTip>()
                .HasMany(e => e.UrunOzellik)
                .WithRequired(e => e.OzellikTip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Satis>()
                .Property(e => e.ToplamTutar)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Satis>()
                .HasMany(e => e.SatisDetay)
                .WithRequired(e => e.Satis)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SatisDetay>()
                .Property(e => e.Fiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .Property(e => e.AlisFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .Property(e => e.SatisFiyat)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.SatisDetay)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
                .HasMany(e => e.UrunOzellik)
                .WithRequired(e => e.Urun)
                .WillCascadeOnDelete(false);
        }
    }
}
