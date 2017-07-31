namespace WeChat.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Theme_To_User : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AbpUsers", "Theme", c => c.String(maxLength: 32, storeType: "nvarchar"));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AbpUsers", "Theme");
        }
    }
}
