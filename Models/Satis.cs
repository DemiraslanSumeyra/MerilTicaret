namespace MerilTicaret.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Satis
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Satis()
        {
            SatisDetay = new HashSet<SatisDetay>();
        }

        public int Id { get; set; }

        public Guid? MusteriID { get; set; }

        public DateTime SatisTarihi { get; set; }

        [Column(TypeName = "money")]
        public decimal ToplamTutar { get; set; }

        public bool SepetteMi { get; set; }

        public int? KargoID { get; set; }

        public int? SiparisDurumID { get; set; }

        [StringLength(20)]
        public string KargoTakipNo { get; set; }

        public virtual Kargo Kargo { get; set; }

        public virtual Musteri Musteri { get; set; }

        public virtual SiparisDurum SiparisDurum { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SatisDetay> SatisDetay { get; set; }
    }
}
