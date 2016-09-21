namespace CouStem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedAdmin1 : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                SET IDENTITY_INSERT [dbo].[People] ON
INSERT INTO [dbo].[People] ([Id], [Name], [SecondName], [LastName], [Birthdate]) VALUES (1, N'Admin', NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[People] OFF
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName], [PeopleId]) VALUES (N'7a26e096-cf55-4767-8b13-ddd5e0996d61', N'admin@coustem.com', 0, N'AMB8A0hojnR0IgDwb4gI0zy2lUMS6PSqdco9qoKjGAMQhQgxqPdXp0GDPBgsA7EDTw==', N'5fce6b4f-39e6-4f34-9c0f-2bf2eb18fcec', NULL, 0, 0, NULL, 1, 0, N'admin', 1)
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7a26e096-cf55-4767-8b13-ddd5e0996d61', N'3c8d7027-0975-4296-a008-d7b99d901070')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7a26e096-cf55-4767-8b13-ddd5e0996d61', N'4d879f21-c7ca-4b69-8900-1ffb812061f2')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7a26e096-cf55-4767-8b13-ddd5e0996d61', N'e5a0c18b-7c17-4984-b73d-16a0a4a87757')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
