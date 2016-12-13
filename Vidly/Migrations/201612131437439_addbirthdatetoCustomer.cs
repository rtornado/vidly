namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbirthdatetoCustomer : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "birthdate", c => c.DateTime());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "birthdate");
        }
    }
}
