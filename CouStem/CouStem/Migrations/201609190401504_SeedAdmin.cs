namespace CouStem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdmin : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                SET IDENTITY_INSERT [dbo].[People] ON
INSERT INTO [dbo].[People] ([Id], [Name], [SecondName], [LastName], [Birthdate]) VALUES (1, N'Admin', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[People] OFF
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [PeopleId]) VALUES (N'bcfb3be5-3d19-4368-a082-23cae220fedd', N'admin@coustem.com', 0, N'AJn5LY4Viah7dUCmQSHbBQlHH6UQWUk6Ucwbj7+Y3X2+N9MyI5UNuhRiwkSHseAaaw==', N'18cb6241-29c4-4c37-8017-e7fe1e330870', NULL, 0, 0, NULL, 1, 0, N'admin', 1)

                ");
        }
        
        public override void Down()
        {
        }
    }
}
