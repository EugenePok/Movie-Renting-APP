namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'8dd83526-3b06-4573-9c1a-d258592ce0f9', N'guest@vidly.com', 0, N'AA/xXa8fLQkEJPjjzDlpdb5uvjIQYVaDeLd7XL8DZUNrHgyKpPENPT4O5mS9ha+WJQ==', N'a676b0e3-da65-4983-a45c-aa2edd76c1fb', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9501b45e-4531-48d1-b8c7-9fa59ea6226a', N'admin@vidly.com', 0, N'AHVhjuaR9yDePb2J02275FO84wh0PZgYkpLojkpvQXt6uf8CxQpxRNt/1BnyPaZKjQ==', N'4f865719-0469-45db-ac76-1a85f726c0b5', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
            
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2b86c3b6-069c-492f-a303-80f70a615092', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9501b45e-4531-48d1-b8c7-9fa59ea6226a', N'2b86c3b6-069c-492f-a303-80f70a615092')

");
        }
        
        public override void Down()
        {
        }
    }
}
