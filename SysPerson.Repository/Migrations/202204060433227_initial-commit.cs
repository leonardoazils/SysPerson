namespace SysPerson.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialcommit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pessoa",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        EstadoCivilId = c.Guid(nullable: false),
                        TipoEmpresaId = c.Guid(nullable: false),
                        TipoEmpresaPjId = c.Guid(nullable: false),
                        GeneroId = c.Guid(nullable: false),
                        PorteId = c.Guid(nullable: false),
                        CaracterizacaoCapitalId = c.Guid(nullable: false),
                        TipoPessoaId = c.Int(nullable: false),
                        Cpf = c.String(),
                        Cnpj = c.String(),
                        Nome = c.String(),
                        RazaoSocial = c.String(),
                        NomeFantasia = c.String(),
                        EmailPrincipal = c.String(),
                        Profissao = c.String(),
                        TelefonePrincipal = c.String(),
                        TelefoneSecundario = c.String(),
                        TelefoneReserva = c.String(),
                        TelefonePrincipalEmpresa = c.String(),
                        TelefoneSecundarioEmpresa = c.String(),
                        TelefoneReservaEmpresa = c.String(),
                        Nascimento = c.String(),
                        Nacionalidade = c.String(),
                        Website = c.String(),
                        DataUltimaAtualizacao = c.String(),
                        QuantidadeQuota = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorQuota = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CapitalSocial = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Ativa = c.Boolean(nullable: false),
                        DataConstituicao = c.String(),
                        Nacional = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pessoa");
        }
    }
}
