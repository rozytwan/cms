namespace cms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AddBlogs", newName: "Blogs");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.Blogs", newName: "AddBlogs");
        }
    }
}
