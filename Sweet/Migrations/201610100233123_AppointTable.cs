namespace Sweet.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AppointTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Date = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        Subject = c.Int(nullable: false),
                        messgae = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Appointments");
        }
    }
}
