namespace Sweet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CTicketTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CTickets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Issue = c.String(nullable: false),
                        Description = c.String(),
                        Date = c.String(),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.CTickets");
        }
    }
}
