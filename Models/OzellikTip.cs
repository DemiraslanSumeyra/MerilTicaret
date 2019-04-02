namespace MerilTicaret.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OzellikTip")]
    public partial class OzellikTip
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OzellikTip()
        {
            OzellikDeger = new HashSet<OzellikDeger>();
            UrunOzellik = new HashSet<UrunOzellik>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Adi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public int KategoriID { get; set; }

        public virtual Kategori Kategori { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OzellikDeger> OzellikDeger { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunOzellik> UrunOzellik { get; set; }
    }
}
