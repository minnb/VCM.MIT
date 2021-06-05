using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VCM.MIT.Migrations
{
    public partial class Initial_TransPaymentEntry_20210527 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "M_TransPaymentEntry",
                columns: table => new
                {
                    OrderNo = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StoreNo = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    PosNo = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShiftCode = table.Column<int>(type: "int", nullable: false),
                    CashierID = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    TenderType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    ExchangeRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AmountTendered = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CurrencyCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: true),
                    AmountInCurrency = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CardPaymentType = table.Column<int>(type: "int", nullable: false),
                    CardValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ReferenceNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    PayForOrderNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    TransactionNo = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "M_TransPaymentEntry");
        }
    }
}
