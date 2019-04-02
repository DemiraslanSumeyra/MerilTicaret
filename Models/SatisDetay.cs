namespace MerilTicaret.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SatisDetay")]
    public partial class SatisDetay
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SatisID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UrunID { get; set; }

        public int? Adet { get; set; }

        [Column(TypeName = "money")]
        public decimal? Fiyat { get; set; }

        public double? Indirim { get; set; }

        public virtual Satis Satis { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
