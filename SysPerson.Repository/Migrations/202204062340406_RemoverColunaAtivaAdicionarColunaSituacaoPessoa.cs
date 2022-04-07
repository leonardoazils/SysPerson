namespace SysPerson.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoverColunaAtivaAdicionarColunaSituacaoPessoa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoa", "SituacaoPessoa", c => c.Int(nullable: false));
            DropColumn("dbo.Pessoa", "Ativa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pessoa", "Ativa", c => c.Boolean(nullable: false));
            DropColumn("dbo.Pessoa", "SituacaoPessoa");
        }
    }
}
