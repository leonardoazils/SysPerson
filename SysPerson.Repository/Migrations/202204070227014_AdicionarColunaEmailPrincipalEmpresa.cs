namespace SysPerson.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdicionarColunaEmailPrincipalEmpresa : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pessoa", "EmailPrincipalEmpresa", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pessoa", "EmailPrincipalEmpresa");
        }
    }
}
