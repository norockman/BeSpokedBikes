using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BeSpokedBikesWeb.Migrations
{
    public partial class appContextToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeginDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountPercentage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchasePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    QtyOnHand = table.Column<int>(type: "int", nullable: false),
                    CommissionPercentage = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salesperson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Salespersons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salespersons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Phone", "StartDate" },
                values: new object[,]
                {
                    { 1, "4697 Robinson Lane Worthington, OH 43085", "Jeffery", "Petties", "740-337-9500", new DateTime(2020, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "2345 Beech Street Concord, CA 94520", "Barbara", "Weiss", "925-825-6717", new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "2436 Kessla Way Hardeeville, SC 29927", "Thomas", "Kearney", "843-288-0173", new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "BeginDate", "DiscountPercentage", "EndDate", "Product" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 1, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aventon 2022 Soltera 7 Speed Electric Road Bike" },
                    { 2, new DateTime(2021, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Specialized 2021 Turbo Creo SL E5 Comp Electric Road Bike" },
                    { 3, new DateTime(2022, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, new DateTime(2021, 2, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cervelo 2022 Aspero Apex 1 Gravel Road Bike" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CommissionPercentage", "Manufacturer", "Name", "PurchasePrice", "QtyOnHand", "SalePrice", "Style" },
                values: new object[,]
                {
                    { 1, 1, "Aventon", "Aventon 2022 Soltera 7 Speed Electric Road Bike", 2499.99m, 10, 2799.99m, "Sport" },
                    { 2, 2, "Specialized", "Specialized 2021 Turbo Creo SL E5 Comp Electric Road Bike", 1499.99m, 16, 1799.99m, "Sport" },
                    { 3, 3, "Cervelo", "Cervelo 2022 Aspero Apex 1 Gravel Road Bike", 499.99m, 4, 799.99m, "Sport" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Customer", "Product", "SalesDate", "Salesperson" },
                values: new object[] { 1, "Jeffery Petties", "Cervelo 2022 Aspero Apex 1 Gravel Road Bike", new DateTime(2021, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amanda Barber" });

            migrationBuilder.InsertData(
                table: "Salespersons",
                columns: new[] { "Id", "Address", "FirstName", "LastName", "Manager", "Phone", "StartDate", "TerminationDate" },
                values: new object[,]
                {
                    { 1, "3029 Duck Creek Road Palo Alto, CA 94306", "Amanda", "Barber", "", "650-846-2128", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 2, "683 Medical Center Drive Venice, FL 34285", "Jim", "Mayfield", "Amanda Barber", "941-496-1012", new DateTime(2021, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { 3, "2450 Poco Mas Drive Dallas, TX 75247", "James", "Lawson", "Amanda Barber", "214-454-1619", new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Salespersons");
        }
    }
}
