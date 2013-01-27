namespace RncManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CambioDataTypeFecha : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.RNCs", "FechaConstitucion", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.RNCs", "FechaConstitucion", c => c.String());
        }
    }
}
