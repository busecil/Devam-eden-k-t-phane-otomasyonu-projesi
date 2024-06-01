namespace VeriBaglantisi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Kitaplar", "KitapTuruID", "dbo.KitapTurler");
            DropForeignKey("dbo.Kitaplar", "YazarID", "dbo.Yazarlar");
            DropIndex("dbo.Kitaplar", new[] { "YazarID" });
            AlterColumn("dbo.Kitaplar", "YazarID", c => c.Int());
            CreateIndex("dbo.Kitaplar", "YazarID");
            AddForeignKey("dbo.Kitaplar", "KitapTuruID", "dbo.KitapTurler", "KitapTuruID");
            AddForeignKey("dbo.Kitaplar", "YazarID", "dbo.Yazarlar", "YazarID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Kitaplar", "YazarID", "dbo.Yazarlar");
            DropForeignKey("dbo.Kitaplar", "KitapTuruID", "dbo.KitapTurler");
            DropIndex("dbo.Kitaplar", new[] { "YazarID" });
            AlterColumn("dbo.Kitaplar", "YazarID", c => c.Int(nullable: false));
            CreateIndex("dbo.Kitaplar", "YazarID");
            AddForeignKey("dbo.Kitaplar", "YazarID", "dbo.Yazarlar", "YazarID", cascadeDelete: true);
            AddForeignKey("dbo.Kitaplar", "KitapTuruID", "dbo.KitapTurler", "KitapTuruID", cascadeDelete: true);
        }
    }
}
