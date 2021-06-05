using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VCM.MIT.Migrations
{
    public partial class Init_MasterData_20210427 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_ItemUOM",
                columns: table => new
                {
                    ItemNo = table.Column<string>(type: "nvarchar(18)", maxLength: 18, nullable: false),
                    BaseUOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesUOM = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    QtyPerUOM = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Length = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cubage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                    table.PrimaryKey("PK_M_ItemUOM", x => new { x.ItemNo, x.BaseUOM });
                });

           
            migrationBuilder.CreateTable(
                name: "M_TenderType",
                columns: table => new
                {
                    StoreNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Function = table.Column<int>(type: "int", nullable: false),
                    ChangeTenderCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Rounding = table.Column<int>(type: "int", nullable: false),
                    RoundingTo = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinAmountEntered = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxAmountEntered = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinAmountAllowed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxAmountAllowed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Used = table.Column<bool>(type: "bit", nullable: false),
                    ManagerKeyControl = table.Column<bool>(type: "bit", nullable: false),
                    KeyboardEntryAllowed = table.Column<bool>(type: "bit", nullable: false),
                    OvertenderAllowed = table.Column<bool>(type: "bit", nullable: false),
                    OvertenderMaxAmt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DrawerOpens = table.Column<bool>(type: "bit", nullable: false),
                    CardAccountNo = table.Column<bool>(type: "bit", nullable: false),
                    AskForDate = table.Column<bool>(type: "bit", nullable: false),
                    ForeignCurrency = table.Column<bool>(type: "bit", nullable: false),
                    FloatAllowed = table.Column<bool>(type: "bit", nullable: false),
                    BankAccountType = table.Column<int>(type: "int", nullable: false),
                    BankAccountNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BankAccountName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ReturnVoucher = table.Column<bool>(type: "bit", nullable: false),
                    AccountNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_M_TenderType", x => new { x.Code, x.StoreNo });
                });

            migrationBuilder.CreateTable(
                name: "M_TenderTypeSetup",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DefaultFunction = table.Column<bool>(type: "bit", nullable: false),
                    DefaultCardTender = table.Column<bool>(type: "bit", nullable: false),
                    DefaultCurrencyTender = table.Column<bool>(type: "bit", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    SeqOnPOS = table.Column<int>(type: "int", nullable: false),
                    IsInstallmentSell = table.Column<bool>(type: "bit", nullable: false),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    RefKey1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RefKey2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CurrencyCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
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
                    table.PrimaryKey("PK_M_TenderTypeSetup", x => x.Code);
                });

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
                name: "M_TransHeader",
                columns: table => new
                {
                    OrderNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AppCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CompanyCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    StoreNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    PosNo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ShiftCode = table.Column<int>(type: "int", nullable: false),
                    CashierID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    DiscountAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountInclVAT = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CustCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CustName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    CustPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    MemberCardNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeliveringMethod = table.Column<int>(type: "int", nullable: false),
                    DeliveryToName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DeliveryToPhone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    DeliveryToProvince = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeliveryToDistrict = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeliveryToWard = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeliveryToAddress = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    DeliveryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveryTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PrintedNumber = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    PrintedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Returned = table.Column<int>(type: "int", nullable: false),
                    ReferenceNo = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    IsInvoice = table.Column<bool>(type: "bit", nullable: false),
                    InvoiceInfo = table.Column<string>(type: "nvarchar(max)", maxLength: 65536, nullable: true),
                    StartingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndingTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BillNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RefKey1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RefKey2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_M_TransHeader", x => x.OrderNo);
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
                name: "M_TransPaymentEntry",
                columns: table => new
                {
                    OrderNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    PosNo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    ShiftCode = table.Column<int>(type: "int", nullable: false),
                    CashierID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TenderType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountTendered = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountInCurrency = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CardPaymentType = table.Column<int>(type: "int", nullable: false),
                    CardValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReferenceNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PayForOrderNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransactionNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
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
                    table.PrimaryKey("PK_M_TransPaymentEntry", x => new { x.OrderNo, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "M_TransRaw",
                columns: table => new
                {
                    CompanyCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    AppCode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    StoreNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    TranNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EntryDate = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    PosNo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    DateInsert = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RawData = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateFlg = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: true),
                    IPAddress = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    MACAddress = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
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
                    table.PrimaryKey("PK_M_TransRaw", x => new { x.TranNo, x.StoreNo, x.CompanyCode, x.AppCode });
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_Item");

            migrationBuilder.DropTable(
                name: "M_ItemUOM");

            migrationBuilder.DropTable(
                name: "M_Store");

            migrationBuilder.DropTable(
                name: "M_TenderType");

            migrationBuilder.DropTable(
                name: "M_TenderTypeSetup");

            migrationBuilder.DropTable(
                name: "M_TransRaw");
        }
    }
}
