namespace MerilTicaret.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kargo")]
    public partial class Kargo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kargo()
        {
            Satis = new HashSet<Satis>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string SirketAdi { get; set; }

        [StringLength(500)]
        public string Adres { get; set; }

        [StringLength(15)]
        public string Telefon { get; set; }

        [StringLength(50)]
        public string WebSite { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satis> Satis { get; set; }
    }
}
