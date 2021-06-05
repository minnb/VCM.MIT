using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VCM.MIT.Migrations
{
    public partial class Initial_Transaction_20210527 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_TransDiscountEntry",
                columns: table => new
                {
                    OrderNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderLineNo = table.Column<int>(type: "int", nullable: false),
                    OfferNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    OfferType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountType = table.Column<int>(type: "int", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ParentLineNo = table.Column<int>(type: "int", nullable: false),
                    ItemNo = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    LineGroup = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_M_TransDiscountEntry", x => new { x.OrderNo, x.LineNo_ });
                });



            migrationBuilder.CreateTable(
                name: "M_TransInfoCodeEntry",
                columns: table => new
                {
                    OrderNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderLineNo = table.Column<int>(type: "int", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    Infocode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Infomation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    TypeOfInput = table.Column<int>(type: "int", nullable: false),
                    TextType = table.Column<int>(type: "int", nullable: false),
                    ItemNo = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    SourceCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SubCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ParentLineNo = table.Column<int>(type: "int", nullable: false),
                    Options = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
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
                    table.PrimaryKey("PK_M_TransInfoCodeEntry", x => new { x.OrderNo, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "M_TransLine",
                columns: table => new
                {
                    OrderNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LineType = table.Column<int>(type: "int", nullable: false),
                    ItemNo = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: true),
                    ItemName = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    UOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Qty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LineAmountExcVat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatGroup = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    VatPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VatAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LineAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BlockedMember = table.Column<bool>(type: "bit", nullable: false),
                    MemberPointsEarn = table.Column<int>(type: "int", nullable: false),
                    MemberPointsRedeem = table.Column<int>(type: "int", nullable: false),
                    BluePointsRedeem = table.Column<int>(type: "int", nullable: false),
                    BluePointsEarn = table.Column<int>(type: "int", nullable: false),
                    AmountCalPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ScanTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    WareHouseCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    LotNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SerialNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DeliveringMethod = table.Column<int>(type: "int", nullable: false),
                    ReturnedQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeliveryQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StoreNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
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
                    table.PrimaryKey("PK_M_TransLine", x => new { x.OrderNo, x.LineNo_ });
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_TransDiscountEntry");

            migrationBuilder.DropTable(
                name: "M_TransInfoCodeEntry");

            migrationBuilder.DropTable(
                name: "M_TransLine");

        }
    }
}
