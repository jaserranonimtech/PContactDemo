namespace PContactDemo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeagregalaentidaddeTipoContacto : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TipoContacto",
                c => new
                    {
                        IdMedioContacto = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(),
                        Activo = c.Boolean(nullable: false),
                        UsuarioCreacion = c.String(maxLength: 150),
                        FechaCreacion = c.DateTime(nullable: false),
                        UsuarioModificacion = c.String(maxLength: 150),
                        FechaModificacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.IdMedioContacto);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TipoContacto");
        }
    }
}
