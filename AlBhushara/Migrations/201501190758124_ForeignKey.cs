namespace AlBhushara.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ForeignKey : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Products", "Invoice_InvoiceID", "dbo.Invoices");
            DropIndex("dbo.Products", new[] { "Invoice_InvoiceID" });
            RenameColumn(table: "dbo.Products", name: "Invoice_InvoiceID", newName: "InvoiceID");
            AddForeignKey("dbo.Products", "InvoiceID", "dbo.Invoices", "InvoiceID", cascadeDelete: true);
            CreateIndex("dbo.Products", "InvoiceID");
            DropColumn("dbo.Invoices", "ProductID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Invoices", "ProductID", c => c.Int(nullable: false));
            DropIndex("dbo.Products", new[] { "InvoiceID" });
            DropForeignKey("dbo.Products", "InvoiceID", "dbo.Invoices");
            RenameColumn(table: "dbo.Products", name: "InvoiceID", newName: "Invoice_InvoiceID");
            CreateIndex("dbo.Products", "Invoice_InvoiceID");
            AddForeignKey("dbo.Products", "Invoice_InvoiceID", "dbo.Invoices", "InvoiceID");
        }
    }
}
