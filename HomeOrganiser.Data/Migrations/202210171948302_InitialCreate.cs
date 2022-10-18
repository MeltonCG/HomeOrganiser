namespace HomeOrganiser.Data.Migrations
{
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class InitialCreate : Migration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilities",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UtilityType = c.Int(nullable: false),
                        Provider = c.String(nullable: false, maxLength: 50),
                        ContractLength = c.Int(nullable: false),
                        ContractEndDate = c.DateTime(nullable: false),
                        CurrentPrice = c.Single(nullable: false),
                        NotificationTime = c.Int(),
                        ModifiedOn = c.DateTime(),
                        CreatedOn = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Utilities");
        }
    }
}
