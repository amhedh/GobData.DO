namespace RncManagement.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CargaInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RNCs",
                c => new
                    {
                        NumeroRnc = c.String(nullable: false, maxLength: 128),
                        RazonSocial = c.String(),
                        NombreComercial = c.String(),
                        ActividadPrincipal = c.String(),
                        DireccionCalle = c.String(),
                        DireccionNumero = c.String(),
                        DireccionSector = c.String(),
                        Telefono = c.String(),
                        FechaConstitucion = c.String(),
                        RegimenPago = c.String(),
                        Estado = c.String(),
                    })
                .PrimaryKey(t => t.NumeroRnc);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RNCs");
        }
    }
}
