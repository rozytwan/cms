namespace cms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddBlogs", "title", c => c.String());
            AddColumn("dbo.AddBlogs", "description", c => c.String());
            DropColumn("dbo.AddBlogs", "fileName");
            DropColumn("dbo.AddBlogs", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.AddBlogs", "Content", c => c.String());
            AddColumn("dbo.AddBlogs", "fileName", c => c.String());
            DropColumn("dbo.AddBlogs", "description");
            DropColumn("dbo.AddBlogs", "title");
        }
    }
}
