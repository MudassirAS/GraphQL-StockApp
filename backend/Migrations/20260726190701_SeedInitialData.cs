using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace StockApp.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Portfolios",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Tech Portfolio" },
                    { 2, "Growth Portfolio" }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "Id", "Company", "PortfolioId", "Price", "Symbol" },
                values: new object[,]
                {
                    { 1, "Apple", 1, 210.45m, "AAPL" },
                    { 2, "Microsoft", 1, 520.35m, "MSFT" },
                    { 3, "Advanced Micro Devices", 2, 182.65m, "AMD" },
                    { 4, "NVIDIA", 2, 178.20m, "NVDA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Portfolios",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
