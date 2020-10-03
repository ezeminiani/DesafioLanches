namespace DesafioLanche.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CLIENTE",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        CliNome = c.String(nullable: false, maxLength: 255),
                        CliApelido = c.String(maxLength: 255),
                        CliDtCadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ENDERECO",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        EndClienteId = c.Long(nullable: false),
                        EndTipo = c.String(nullable: false, maxLength: 255),
                        EndLogradouro = c.String(nullable: false, maxLength: 1024),
                        EndComplemento = c.String(maxLength: 1024),
                        EndBairro = c.String(nullable: false, maxLength: 255),
                        EndCidade = c.String(nullable: false, maxLength: 255),
                        EndEstado = c.String(nullable: false, maxLength: 255),
                        EndCep = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CLIENTE", t => t.EndClienteId, cascadeDelete: true)
                .Index(t => t.EndClienteId);
            
            CreateTable(
                "dbo.PEDIDO",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PedClienteId = c.Long(nullable: false),
                        PedDtEmissao = c.DateTime(nullable: false),
                        PedSubTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PedDescontoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PedTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CLIENTE", t => t.PedClienteId, cascadeDelete: true)
                .Index(t => t.PedClienteId);
            
            CreateTable(
                "dbo.PEDIDOxLANCHExINGREDIENTE",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PliLancheId = c.Long(nullable: false),
                        PliIngredienteId = c.Long(nullable: false),
                        PliQuantidade = c.Int(nullable: false),
                        PliValor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Pedido_Id = c.Long(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.INGREDIENTE", t => t.PliIngredienteId, cascadeDelete: true)
                .ForeignKey("dbo.LANCHE", t => t.PliLancheId, cascadeDelete: true)
                .ForeignKey("dbo.PEDIDO", t => t.Pedido_Id)
                .Index(t => t.PliLancheId)
                .Index(t => t.PliIngredienteId)
                .Index(t => t.Pedido_Id);
            
            CreateTable(
                "dbo.INGREDIENTE",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        IngNome = c.String(nullable: false, maxLength: 255),
                        IngDescricao = c.String(nullable: false, maxLength: 1024),
                        IngPreco = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IngStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.LanchexIngrediente",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        LxiLancheId = c.Long(nullable: false),
                        LxiIngredienteId = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.INGREDIENTE", t => t.LxiIngredienteId, cascadeDelete: true)
                .ForeignKey("dbo.LANCHE", t => t.LxiLancheId, cascadeDelete: true)
                .Index(t => t.LxiLancheId)
                .Index(t => t.LxiIngredienteId);
            
            CreateTable(
                "dbo.LANCHE",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        LchNome = c.String(nullable: false, maxLength: 255),
                        LchDescricao = c.String(nullable: false, maxLength: 1024),
                        LchStatus = c.Int(nullable: false),
                        LchFixo = c.Boolean(nullable: false),
                        LchEpromocao = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PROMOCAO",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ProLancheId = c.Long(nullable: false),
                        ProNome = c.String(nullable: false, maxLength: 255),
                        ProDesconto = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ProStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.LANCHE", t => t.ProLancheId, cascadeDelete: true)
                .Index(t => t.ProLancheId);
            
            CreateTable(
                "dbo.PROMOCAOxINGREDIENTE",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        PxiPromocaoId = c.Long(nullable: false),
                        PxiIngredienteId = c.Long(nullable: false),
                        PxiQuantidade = c.Int(nullable: false),
                        PxiContem = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.INGREDIENTE", t => t.PxiIngredienteId, cascadeDelete: true)
                .ForeignKey("dbo.PROMOCAO", t => t.PxiPromocaoId, cascadeDelete: true)
                .Index(t => t.PxiPromocaoId)
                .Index(t => t.PxiIngredienteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PEDIDOxLANCHExINGREDIENTE", "Pedido_Id", "dbo.PEDIDO");
            DropForeignKey("dbo.PEDIDOxLANCHExINGREDIENTE", "PliLancheId", "dbo.LANCHE");
            DropForeignKey("dbo.PEDIDOxLANCHExINGREDIENTE", "PliIngredienteId", "dbo.INGREDIENTE");
            DropForeignKey("dbo.PROMOCAOxINGREDIENTE", "PxiPromocaoId", "dbo.PROMOCAO");
            DropForeignKey("dbo.PROMOCAOxINGREDIENTE", "PxiIngredienteId", "dbo.INGREDIENTE");
            DropForeignKey("dbo.PROMOCAO", "ProLancheId", "dbo.LANCHE");
            DropForeignKey("dbo.LanchexIngrediente", "LxiLancheId", "dbo.LANCHE");
            DropForeignKey("dbo.LanchexIngrediente", "LxiIngredienteId", "dbo.INGREDIENTE");
            DropForeignKey("dbo.PEDIDO", "PedClienteId", "dbo.CLIENTE");
            DropForeignKey("dbo.ENDERECO", "EndClienteId", "dbo.CLIENTE");
            DropIndex("dbo.PROMOCAOxINGREDIENTE", new[] { "PxiIngredienteId" });
            DropIndex("dbo.PROMOCAOxINGREDIENTE", new[] { "PxiPromocaoId" });
            DropIndex("dbo.PROMOCAO", new[] { "ProLancheId" });
            DropIndex("dbo.LanchexIngrediente", new[] { "LxiIngredienteId" });
            DropIndex("dbo.LanchexIngrediente", new[] { "LxiLancheId" });
            DropIndex("dbo.PEDIDOxLANCHExINGREDIENTE", new[] { "Pedido_Id" });
            DropIndex("dbo.PEDIDOxLANCHExINGREDIENTE", new[] { "PliIngredienteId" });
            DropIndex("dbo.PEDIDOxLANCHExINGREDIENTE", new[] { "PliLancheId" });
            DropIndex("dbo.PEDIDO", new[] { "PedClienteId" });
            DropIndex("dbo.ENDERECO", new[] { "EndClienteId" });
            DropTable("dbo.PROMOCAOxINGREDIENTE");
            DropTable("dbo.PROMOCAO");
            DropTable("dbo.LANCHE");
            DropTable("dbo.LanchexIngrediente");
            DropTable("dbo.INGREDIENTE");
            DropTable("dbo.PEDIDOxLANCHExINGREDIENTE");
            DropTable("dbo.PEDIDO");
            DropTable("dbo.ENDERECO");
            DropTable("dbo.CLIENTE");
        }
    }
}
