using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varliklar

{
    [Table("KitapTurler")]
    public class KitapTuru
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KitapTuruID { get; set; }
        [MaxLength(100)]
        public string KitapTuruAdi { get; set; }
        public virtual List<Kitap> Kitaplar { get; set; }
    }
}
