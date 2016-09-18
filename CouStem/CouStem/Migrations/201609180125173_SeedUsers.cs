namespace CouStem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'439bcbba-5849-4336-9979-6f118298bbd6', N'admin@coustem.com', 0, N'ANNDwXNbWIkP+d+oDG60wBo8gum+kNberRFNqCXu7qxtCvv9xB5n3cz7scvB/gLlkg==', N'fad8cd11-f0bd-4df8-81b5-f9183b101351', NULL, 0, 0, NULL, 1, 0, N'admin')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'e5a0c18b-7c17-4984-b73d-16a0a4a87757', N'CanManageClients')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3c8d7027-0975-4296-a008-d7b99d901070', N'CanManageCourses')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4d879f21-c7ca-4b69-8900-1ffb812061f2', N'CanManageUsers')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'439bcbba-5849-4336-9979-6f118298bbd6', N'3c8d7027-0975-4296-a008-d7b99d901070')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'439bcbba-5849-4336-9979-6f118298bbd6', N'4d879f21-c7ca-4b69-8900-1ffb812061f2')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'439bcbba-5849-4336-9979-6f118298bbd6', N'e5a0c18b-7c17-4984-b73d-16a0a4a87757')

                ");
        }
        
        public override void Down()
        {
        }
    }
}
