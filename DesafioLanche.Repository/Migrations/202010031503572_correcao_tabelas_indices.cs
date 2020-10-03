namespace DesafioLanche.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class correcao_tabelas_indices : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.PEDIDOxLANCHExINGREDIENTE", "Pedido_Id", "dbo.PEDIDO");
            DropIndex("dbo.PEDIDOxLANCHExINGREDIENTE", new[] { "Pedido_Id" });
            RenameColumn(table: "dbo.PEDIDOxLANCHExINGREDIENTE", name: "Pedido_Id", newName: "PliPedidoId");
            AlterColumn("dbo.PEDIDOxLANCHExINGREDIENTE", "PliPedidoId", c => c.Long(nullable: false));
            CreateIndex("dbo.PEDIDOxLANCHExINGREDIENTE", "PliPedidoId");
            AddForeignKey("dbo.PEDIDOxLANCHExINGREDIENTE", "PliPedidoId", "dbo.PEDIDO", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PEDIDOxLANCHExINGREDIENTE", "PliPedidoId", "dbo.PEDIDO");
            DropIndex("dbo.PEDIDOxLANCHExINGREDIENTE", new[] { "PliPedidoId" });
            AlterColumn("dbo.PEDIDOxLANCHExINGREDIENTE", "PliPedidoId", c => c.Long());
            RenameColumn(table: "dbo.PEDIDOxLANCHExINGREDIENTE", name: "PliPedidoId", newName: "Pedido_Id");
            CreateIndex("dbo.PEDIDOxLANCHExINGREDIENTE", "Pedido_Id");
            AddForeignKey("dbo.PEDIDOxLANCHExINGREDIENTE", "Pedido_Id", "dbo.PEDIDO", "Id");
        }
    }
}
