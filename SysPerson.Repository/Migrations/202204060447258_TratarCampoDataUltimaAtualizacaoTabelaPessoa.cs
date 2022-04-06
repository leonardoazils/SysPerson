namespace SysPerson.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TratarCampoDataUltimaAtualizacaoTabelaPessoa : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Pessoa", "DataUltimaAtualizacao", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Pessoa", "DataUltimaAtualizacao", c => c.String());
        }
    }
}
