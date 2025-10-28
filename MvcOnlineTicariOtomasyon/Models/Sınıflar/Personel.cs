using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcOnlineTicariOtomasyon.Models.Sınıflar
{
    public class Personel
    {
        [Key]
        public int PersonelId { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string PersonelAd { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string PersonelSoyad { get; set; }

        [Column(TypeName = "Varchar")]
        [StringLength(500)]
        public string PersonelGörsel { get; set; }

        public SatisHareket SatisHareket { get; set; }
        public Departman Departman { get; set; }
    }
}