namespace MerilTicaret.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Musteri")]
    public partial class Musteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Musteri()
        {
            MusteriAdres = new HashSet<MusteriAdres>();
            Satis = new HashSet<Satis>();
        }

        public Guid Id { get; set; }

        [StringLength(50)]
        public string Adi { get; set; }

        [StringLength(50)]
        public string Soyadi { get; set; }

        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [StringLength(50)]
        public string EMail { get; set; }

        [StringLength(15)]
        public string Telefon { get; set; }

        public virtual aspnet_Users aspnet_Users { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MusteriAdres> MusteriAdres { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
