namespace CouStem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveRequiredFromPeopleLastName : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.People", "LastName", c => c.String(maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.People", "LastName", c => c.String(nullable: false, maxLength: 255));
        }
    }
}
