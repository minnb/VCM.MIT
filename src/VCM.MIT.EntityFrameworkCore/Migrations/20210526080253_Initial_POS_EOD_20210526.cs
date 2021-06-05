using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VCM.MIT.Migrations
{
    public partial class Initial_POS_EOD_20210526 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_Item",
                columns: table => new
                {
                    ItemNo = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    AppCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PluCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ItemName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    SearchDescription = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    LongDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 65536, nullable: true),
                    Blocked = table.Column<int>(type: "int", nullable: false),
                    Critical = table.Column<int>(type: "int", nullable: false),
                    VAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxGroupCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BaseUOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    SalesUOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaximumInventory = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinimumOrderQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaximumOrderQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SafetyStockQuantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderMultiple = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VendorNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    VendorItemNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ManufacturerCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemCategoryCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ServiceItemGroup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemTrackingCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ProductionBOMNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ItemGroupCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_M_Item", x => new { x.AppCode, x.ItemNo });
                });

            migrationBuilder.CreateTable(
                name: "M_ItemGroup",
                columns: table => new
                {
                    AppCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    GroupCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Profit1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Profit2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Profit3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtCode1 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExtCode2 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExtCode3 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExtCode4 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExtCode5 = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExtValue1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtValue2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtValue3 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtValue4 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ExtValue5 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_M_ItemGroup", x => new { x.AppCode, x.GroupCode });
                });

            migrationBuilder.CreateTable(
                name: "M_ItemTaxGroup",
                columns: table => new
                {
                    AppCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    TaxCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VATPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
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
                    table.PrimaryKey("PK_M_ItemTaxGroup", x => new { x.AppCode, x.TaxCode });
                });

            migrationBuilder.CreateTable(
                name: "M_POSCashDeposit",
                columns: table => new
                {
                    AppCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StoreNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    PosCashId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LineNo = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DenominationCode = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Denomination = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    table.PrimaryKey("PK_M_POSCashDeposit", x => new { x.AppCode, x.StoreNo, x.PosCashId, x.LineNo });
                });

            migrationBuilder.CreateTable(
                name: "M_POSEndOfDay",
                columns: table => new
                {
                    AppCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StoreNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MerchandiseSalesCust = table.Column<int>(type: "int", nullable: false),
                    MerchandiseSalesQty = table.Column<int>(type: "int", nullable: false),
                    MerchandiseSalesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxablesSalesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonTaxSalesQty = table.Column<int>(type: "int", nullable: false),
                    NonTaxSalesAmoun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnMerchandiseCust = table.Column<int>(type: "int", nullable: false),
                    ReturnMerchandiseQty = table.Column<int>(type: "int", nullable: false),
                    ReturnMerchandiseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RetunTaxablesQty = table.Column<int>(type: "int", nullable: false),
                    RetunTaxablesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnNonTaxQty = table.Column<int>(type: "int", nullable: false),
                    ReturnNonTaxAmoun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeginingCashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnVouche = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Voucher = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MemberPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PayExceed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QRPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrepaidCard = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_M_POSEndOfDay", x => new { x.StoreNo, x.AppCode, x.EntryDate });
                });

            migrationBuilder.CreateTable(
                name: "M_POSEndOfUser",
                columns: table => new
                {
                    AppCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StoreNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    StaffID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    ShiftNo = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MerchandiseSalesCust = table.Column<int>(type: "int", nullable: false),
                    MerchandiseSalesQty = table.Column<int>(type: "int", nullable: false),
                    MerchandiseSalesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxablesSalesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NonTaxSalesQty = table.Column<int>(type: "int", nullable: false),
                    NonTaxSalesAmoun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnMerchandiseCust = table.Column<int>(type: "int", nullable: false),
                    ReturnMerchandiseQty = table.Column<int>(type: "int", nullable: false),
                    ReturnMerchandiseAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    RetunTaxablesQty = table.Column<int>(type: "int", nullable: false),
                    RetunTaxablesAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnNonTaxQty = table.Column<int>(type: "int", nullable: false),
                    ReturnNonTaxAmoun = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BeginingCashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReturnVouche = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Voucher = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MemberPoint = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PayExceed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QRPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PrepaidCard = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Drawfoat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LogicalCash = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OverShort = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_M_POSEndOfUser", x => new { x.AppCode, x.StoreNo, x.StaffID, x.ShiftNo });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Item");

            migrationBuilder.DropTable(
                name: "M_ItemGroup");

            migrationBuilder.DropTable(
                name: "M_ItemTaxGroup");

            migrationBuilder.DropTable(
                name: "M_POSCashDeposit");

            migrationBuilder.DropTable(
                name: "M_POSEndOfDay");

            migrationBuilder.DropTable(
                name: "M_POSEndOfUser");
        }
    }
}
