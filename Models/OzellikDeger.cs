namespace MerilTicaret.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OzellikDeger")]
    public partial class OzellikDeger
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OzellikDeger()
        {
            UrunOzellik = new HashSet<UrunOzellik>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Adi { get; set; }

        [StringLength(500)]
        public string Aciklama { get; set; }

        public int OzellikTipID { get; set; }

        public virtual OzellikTip OzellikTip { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UrunOzellik> UrunOzellik { get; set; }
    }
}
