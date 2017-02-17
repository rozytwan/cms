namespace cms.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddBlogs",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        fileName = c.String(),
                        Content = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.AddBlogs");
        }
    }
}
