using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varliklar
{

    [Table("Yazarlar")]
    public class Yazar
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int YazarID { get; set; }
        [MaxLength(100)]
        public string YazarAdSoyad { get; set; }
        public virtual List<Kitap> Kitaplar { get; set; }
    }
}
