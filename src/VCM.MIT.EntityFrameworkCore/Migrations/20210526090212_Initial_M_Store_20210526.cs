using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VCM.MIT.Migrations
{
    public partial class Initial_M_Store_20210526 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_Store",
                columns: table => new
                {
                    StoreNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LocationCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    City = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Address1 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Address2 = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegionCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    NoOfPOSConnected = table.Column<int>(type: "int", nullable: false),
                    MerchCd = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    TaxID = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Blocked = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Store", x => x.StoreNo);
                });

            migrationBuilder.CreateTable(
                name: "M_StoreWareHouse",
                columns: table => new
                {
                    AppCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    WareHouseCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WareHouseName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    StoreNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Blocked = table.Column<bool>(type: "bit", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorUserId = table.Column<long>(type: "bigint", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierUserId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeleterUserId = table.Column<long>(type: "bigint", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_StoreWareHouse", x => new { x.AppCode, x.WareHouseCode });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Store");

            migrationBuilder.DropTable(
                name: "M_StoreWareHouse");
        }
    }
}
