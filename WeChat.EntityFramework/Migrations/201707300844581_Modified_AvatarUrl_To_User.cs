namespace WeChat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Modified_AvatarUrl_To_User : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AbpUsers", "AvatarUrl", c => c.String(maxLength: 255, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.AbpUsers", "AvatarUrl", c => c.String(unicode: false));
        }
    }
}
