namespace EFdemo_migrationDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            //CreateTable(
            //    "dbo.Blogs",
            //    c => new
            //        {
            //            BlogId = c.Int(nullable: false, identity: true),
            //            Name = c.String(),
            //            Url = c.String(),
            //            Rating = c.Int(nullable: false),
            //            Comments = c.String(),
            //            Comments1 = c.String(),
            //        })
            //    .PrimaryKey(t => t.BlogId);
            
            //CreateTable(
            //    "dbo.Posts",
            //    c => new
            //        {
            //            PostId = c.Int(nullable: false, identity: true),
            //            Title = c.String(maxLength: 200),
            //            Content = c.String(),
            //            BlogId = c.Int(nullable: false),
            //            Abstract = c.String(),
            //        })
            //    .PrimaryKey(t => t.PostId)
            //    .ForeignKey("dbo.Blogs", t => t.BlogId, cascadeDelete: true)
            //    .Index(t => t.BlogId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "BlogId", "dbo.Blogs");
            DropIndex("dbo.Posts", new[] { "BlogId" });
            DropTable("dbo.Posts");
            DropTable("dbo.Blogs");
        }
    }
}
