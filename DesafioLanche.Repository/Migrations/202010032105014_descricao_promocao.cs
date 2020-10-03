namespace DesafioLanche.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class descricao_promocao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PROMOCAO", "ProDescricao", c => c.String(nullable: false, maxLength: 1024));
        }
        
        public override void Down()
        {
            DropColumn("dbo.PROMOCAO", "ProDescricao");
        }
    }
}
