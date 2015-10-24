namespace Hotel_Ext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        reservationNo = c.String(),
                        reservationStartDate = c.DateTime(nullable: false),
                        reservationEndDate = c.DateTime(nullable: false),
                        checkInTime = c.DateTime(nullable: false),
                        checkOutTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Bedrooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        bedroomNumber = c.String(),
                        availabilityStatus = c.Int(nullable: false),
                        bedroomType_Id = c.Int(),
                        Reservation_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.BedRoomTypes", t => t.bedroomType_Id)
                .ForeignKey("dbo.Reservations", t => t.Reservation_Id)
                .Index(t => t.bedroomType_Id)
                .Index(t => t.Reservation_Id);
            
            CreateTable(
                "dbo.BedRoomTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        bedRoomTypeCode = c.String(),
                        bedRoomName = c.String(),
                        imageBedroom = c.String(),
                        sizeRoom = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bedrooms", "Reservation_Id", "dbo.Reservations");
            DropForeignKey("dbo.Bedrooms", "bedroomType_Id", "dbo.BedRoomTypes");
            DropIndex("dbo.Bedrooms", new[] { "Reservation_Id" });
            DropIndex("dbo.Bedrooms", new[] { "bedroomType_Id" });
            DropTable("dbo.BedRoomTypes");
            DropTable("dbo.Bedrooms");
            DropTable("dbo.Reservations");
        }
    }
}
