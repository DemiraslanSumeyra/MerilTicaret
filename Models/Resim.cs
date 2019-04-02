namespace MerilTicaret.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Resim")]
    public partial class Resim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Resim()
        {
            Kategori = new HashSet<Kategori>();
            Marka = new HashSet<Marka>();
        }

        public int Id { get; set; }

        [StringLength(250)]
        public string BuyukYol { get; set; }

        [StringLength(250)]
        public string OrtaYol { get; set; }

        [StringLength(250)]
        public string KucukYol { get; set; }

        public bool? Varsayilan { get; set; }

        public int? SiraNo { get; set; }

        public int? UrunID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kategori> Kategori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Marka> Marka { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
