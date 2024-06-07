namespace ExampleGridProduct.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedproduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Product_Type = c.String(),
                        Glass_Type = c.String(),
                        Thickness = c.String(),
                        Color = c.String(),
                        PartNo = c.String(),
                        IsSurface = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Products");
        }
    }
}
