namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ac7b2925-62f1-40a8-89d4-7a637cd9f941', N'admin@vidly.com', 0, N'ALMqTxEhzEMZlYdehVGp6qPH2rWf43wiYh09N1SD5ep0Jjh/HQ6T7wuhnO98/4jEVg==', N'ce388a1d-ad27-4f1e-bed6-d71e920640e8', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'b51f2198-f4d9-4209-ab59-1de4dd88df9e', N'guest@vidley.com', 0, N'AGByfTnJIyQuWDpjQ87i40GmYLwav5Nmfg6Hz0zeFx7Y5y+e5pw7XdGZEFQQ3q94BA==', N'09356c09-db2b-49a8-b80c-d3449d3eaf90', NULL, 0, 0, NULL, 1, 0, N'guest@vidley.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1a5ff2ef-7aa9-4b2c-8456-c9da9ec416f7', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ac7b2925-62f1-40a8-89d4-7a637cd9f941', N'1a5ff2ef-7aa9-4b2c-8456-c9da9ec416f7')

                ");

        }
        
        public override void Down()
        {
        }
    }
}
