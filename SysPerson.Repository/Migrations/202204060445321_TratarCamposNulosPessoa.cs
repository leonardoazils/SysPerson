namespace SysPerson.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TratarCamposNulosPessoa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoa", "EstadoCivilId", c => c.Guid());
            AlterColumn("dbo.Pessoa", "CaracterizacaoCapitalId", c => c.Guid());
            AlterColumn("dbo.Pessoa", "QuantidadeQuota", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Pessoa", "ValorQuota", c => c.Decimal(precision: 18, scale: 2));
            AlterColumn("dbo.Pessoa", "DataConstituicao", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoa", "DataConstituicao", c => c.String());
            AlterColumn("dbo.Pessoa", "ValorQuota", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Pessoa", "QuantidadeQuota", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Pessoa", "CaracterizacaoCapitalId", c => c.Guid(nullable: false));
            AlterColumn("dbo.Pessoa", "EstadoCivilId", c => c.Guid(nullable: false));
        }
    }
}
