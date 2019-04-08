using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanApp.Persistence.Migrations
{
    public partial class AddFluentAPIForAddressAndClient : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deposit",
                table: "RentOrders");

            migrationBuilder.DropColumn(
                name: "MascotId",
                table: "RentOrders");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "RentOrders");

            migrationBuilder.DropColumn(
                name: "MakeId",
                table: "BuyOrders");

            migrationBuilder.DropColumn(
                name: "MascotId",
                table: "BuyOrders");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BuyOrders");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Clients",
                newName: "AddressID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Clients",
                newName: "ClientID");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Addresses",
                newName: "AddressID");

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Clients",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Clients",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Messenger",
                table: "Clients",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Clients",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Clients",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Clients",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Addresses",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceState",
                table: "Addresses",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Addresses",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                type: "datetime",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "BuyOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BuyOrderId = table.Column<int>(nullable: false),
                    MascotId = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<short>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuyOrderDetails_BuyOrders_BuyOrderId",
                        column: x => x.BuyOrderId,
                        principalTable: "BuyOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BuyOrderDetails_Mascots_MascotId",
                        column: x => x.MascotId,
                        principalTable: "Mascots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RentOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RentOrderId = table.Column<int>(nullable: false),
                    MascotId = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(nullable: false),
                    Deposit = table.Column<decimal>(nullable: false),
                    Quantity = table.Column<short>(nullable: false),
                    Discount = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentOrderDetails_Mascots_MascotId",
                        column: x => x.MascotId,
                        principalTable: "Mascots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RentOrderDetails_RentOrders_RentOrderId",
                        column: x => x.RentOrderId,
                        principalTable: "RentOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Mascots_MakeId",
                table: "Mascots",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AddressID",
                table: "Clients",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_BuyOrderDetails_BuyOrderId",
                table: "BuyOrderDetails",
                column: "BuyOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyOrderDetails_MascotId",
                table: "BuyOrderDetails",
                column: "MascotId");

            migrationBuilder.CreateIndex(
                name: "IX_RentOrderDetails_MascotId",
                table: "RentOrderDetails",
                column: "MascotId");

            migrationBuilder.CreateIndex(
                name: "IX_RentOrderDetails_RentOrderId",
                table: "RentOrderDetails",
                column: "RentOrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Address",
                table: "Clients",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mascots_Makes_MakeId",
                table: "Mascots",
                column: "MakeId",
                principalTable: "Makes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Address",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Mascots_Makes_MakeId",
                table: "Mascots");

            migrationBuilder.DropTable(
                name: "BuyOrderDetails");

            migrationBuilder.DropTable(
                name: "RentOrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Mascots_MakeId",
                table: "Mascots");

            migrationBuilder.DropIndex(
                name: "IX_Clients_AddressID",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "AddressID",
                table: "Clients",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "ClientID",
                table: "Clients",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "AddressID",
                table: "Addresses",
                newName: "Id");

            migrationBuilder.AddColumn<decimal>(
                name: "Deposit",
                table: "RentOrders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "MascotId",
                table: "RentOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "RentOrders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 20,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Messenger",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MakeId",
                table: "BuyOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MascotId",
                table: "BuyOrders",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "BuyOrders",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "UpdatedDate",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProvinceState",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Addresses",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
