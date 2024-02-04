namespace SistemaEstacionamento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transacoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Placa = c.String(maxLength: 8),
                        Fabricante = c.String(),
                        NumVaga = c.Int(nullable: false),
                        MetodoPagamento = c.String(maxLength: 20),
                        DataEntrada = c.DateTime(nullable: false),
                        DataSaida = c.DateTime(),
                        Valor = c.Double(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Transacoes");
        }
    }
}
