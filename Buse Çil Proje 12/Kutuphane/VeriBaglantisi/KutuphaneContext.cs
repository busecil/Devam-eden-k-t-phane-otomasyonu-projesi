using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.Infrastructure.Interception;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Varliklar;

namespace VeriBaglantisi
{
    
    public class KutuphaneContext : DbContext
    {
      
        DbSet<Yazar> Yazarlar { get; set; }
        DbSet<Kitap> Kitaplar  { get; set; }
        DbSet<KitapTuru> KitapTurler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<Kitap>()
                .HasRequired(b => b.KitapTuru) 
                .WithMany(bt => bt.Kitaplar) 
                .HasForeignKey(b => b.KitapTuruID) 
                .WillCascadeOnDelete(false);  

            // bu özelliğin tabloya yansıması için tekrar migration attık 

         
        }

    }
}
