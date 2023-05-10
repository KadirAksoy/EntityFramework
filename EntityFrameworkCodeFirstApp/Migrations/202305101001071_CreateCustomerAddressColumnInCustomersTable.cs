namespace EntityFrameworkCodeFirstApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateCustomerAddressColumnInCustomersTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerAddress", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerAddress");
        }
    }
}
