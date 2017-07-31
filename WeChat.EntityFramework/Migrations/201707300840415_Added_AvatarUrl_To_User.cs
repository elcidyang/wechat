namespace WeChat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Added_AvatarUrl_To_User : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbpUsers", "AvatarUrl", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AbpUsers", "AvatarUrl");
        }
    }
}
