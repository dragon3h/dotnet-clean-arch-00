using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CleanApp.Persistence.Migrations
{
    public partial class InitialModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Street = table.Column<string>(maxLength: 200, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    PostalCode = table.Column<string>(maxLength: 10, nullable: true),
                    Country = table.Column<string>(maxLength: 100, nullable: true),
                    ProvinceState = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BuyOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Shipper = table.Column<string>(maxLength: 100, nullable: true),
                    ShippingPrice = table.Column<decimal>(type: "money", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ShippingDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyOrders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ClientID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(maxLength: 100, nullable: true),
                    LastName = table.Column<string>(maxLength: 100, nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Messenger = table.Column<string>(maxLength: 50, nullable: true),
                    AddressID = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ClientID);
                    table.ForeignKey(
                        name: "FK_Clients_Address",
                        column: x => x.AddressID,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Makes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Code = table.Column<string>(maxLength: 20, nullable: true),
                    AddressId = table.Column<int>(nullable: false),
                    Phone = table.Column<string>(maxLength: 20, nullable: true),
                    Email = table.Column<string>(maxLength: 200, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Makes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Makes_Addresses",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RentOrders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FromDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ShippingPrice = table.Column<decimal>(type: "money", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    ClientId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentOrders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentOrders_Clients",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ClientID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mascots",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    Code = table.Column<string>(maxLength: 20, nullable: true),
                    MakeId = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mascots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Mascots_Make",
                        column: x => x.MakeId,
                        principalTable: "Makes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BuyOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BuyOrderId = table.Column<int>(nullable: false),
                    MascotId = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false),
                    Quantity = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuyOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BuyOrderDetails_BuyOrder",
                        column: x => x.BuyOrderId,
                        principalTable: "BuyOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BuyOrderDetails_Mascot",
                        column: x => x.MascotId,
                        principalTable: "Mascots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RentOrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RentOrderId = table.Column<int>(nullable: false),
                    MascotId = table.Column<int>(nullable: false),
                    UnitPrice = table.Column<decimal>(type: "money", nullable: false),
                    Deposit = table.Column<decimal>(type: "money", nullable: false),
                    Quantity = table.Column<int>(nullable: false, defaultValueSql: "((1))"),
                    Discount = table.Column<decimal>(type: "money", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RentOrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RentOrderDetails_Mascot",
                        column: x => x.MascotId,
                        principalTable: "Mascots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RentOrderDetails_RentOrder",
                        column: x => x.RentOrderId,
                        principalTable: "RentOrders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BuyOrderDetails_BuyOrderId",
                table: "BuyOrderDetails",
                column: "BuyOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BuyOrderDetails_MascotId",
                table: "BuyOrderDetails",
                column: "MascotId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_AddressID",
                table: "Clients",
                column: "AddressID");

            migrationBuilder.CreateIndex(
                name: "IX_Makes_AddressId",
                table: "Makes",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Mascots_MakeId",
                table: "Mascots",
                column: "MakeId");

            migrationBuilder.CreateIndex(
                name: "IX_RentOrderDetails_MascotId",
                table: "RentOrderDetails",
                column: "MascotId");

            migrationBuilder.CreateIndex(
                name: "IX_RentOrderDetails_RentOrderId",
                table: "RentOrderDetails",
                column: "RentOrderId");

            migrationBuilder.CreateIndex(
                name: "IX_RentOrders_ClientId",
                table: "RentOrders",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BuyOrderDetails");

            migrationBuilder.DropTable(
                name: "RentOrderDetails");

            migrationBuilder.DropTable(
                name: "BuyOrders");

            migrationBuilder.DropTable(
                name: "Mascots");

            migrationBuilder.DropTable(
                name: "RentOrders");

            migrationBuilder.DropTable(
                name: "Makes");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Addresses");
        }
    }
}
