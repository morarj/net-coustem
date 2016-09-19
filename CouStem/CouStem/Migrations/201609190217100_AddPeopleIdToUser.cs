namespace CouStem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPeopleIdToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "PeopleId", c => c.Int(nullable: false));
            CreateIndex("dbo.AspNetUsers", "PeopleId");
            AddForeignKey("dbo.AspNetUsers", "PeopleId", "dbo.People", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUsers", "PeopleId", "dbo.People");
            DropIndex("dbo.AspNetUsers", new[] { "PeopleId" });
            DropColumn("dbo.AspNetUsers", "PeopleId");
        }
    }
}
