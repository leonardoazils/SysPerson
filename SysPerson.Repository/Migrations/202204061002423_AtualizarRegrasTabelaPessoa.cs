namespace SysPerson.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AtualizarRegrasTabelaPessoa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoa", "TipoEmpresaId", c => c.Guid());
            AlterColumn("dbo.Pessoa", "TipoEmpresaPjId", c => c.Guid());
            AlterColumn("dbo.Pessoa", "GeneroId", c => c.Guid());
            AlterColumn("dbo.Pessoa", "PorteId", c => c.Guid());
            AlterColumn("dbo.Pessoa", "Nascimento", c => c.DateTime());
            AlterColumn("dbo.Pessoa", "CapitalSocial", c => c.Decimal(precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoa", "CapitalSocial", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Pessoa", "Nascimento", c => c.String());
            AlterColumn("dbo.Pessoa", "PorteId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Pessoa", "GeneroId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Pessoa", "TipoEmpresaPjId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Pessoa", "TipoEmpresaId", c => c.Guid(nullable: false));
        }
    }
}
