namespace ProjetoEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EntityF03 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Produtos", "Descricao", c => c.String(nullable: false, maxLength: 70, unicode: false));
            AlterColumn("dbo.Produtos", "Unitario", c => c.Decimal(nullable: false, precision: 10, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Produtos", "Unitario", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Produtos", "Descricao", c => c.String());
        }
    }
}
