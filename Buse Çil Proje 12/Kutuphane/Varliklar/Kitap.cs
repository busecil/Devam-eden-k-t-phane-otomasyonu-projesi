using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varliklar
{
    [Table("Kitaplar")]
    public class Kitap
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KitapID { get; set; }
        [MaxLength(100)]
        public string KitapAdi { get; set; }
        [MaxLength(100)]
        public string YayinEvi { get; set; }
        [MaxLength(100)]
        public string BarkodNo { get; set; }
        public int SayfaSayisi { get; set; }
        public string KitapAciklama { get; set; }
        public DateTime KayitTarihi { get; set; }
        
        public int? YazarID { get; set; }
        public  Yazar Yazar { get; set; }
        public int? KitapTuruID { get; set; }
        public virtual KitapTuru KitapTuru { get; set; }

    }
}
