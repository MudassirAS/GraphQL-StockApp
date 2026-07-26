using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StockApp.Migrations
{
    /// <inheritdoc />
    public partial class AddPortfolio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PortfolioId",
                table: "Stocks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Portfolios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Portfolios", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_PortfolioId",
                table: "Stocks",
                column: "PortfolioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_Portfolios_PortfolioId",
                table: "Stocks",
                column: "PortfolioId",
                principalTable: "Portfolios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_Portfolios_PortfolioId",
                table: "Stocks");

            migrationBuilder.DropTable(
                name: "Portfolios");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_PortfolioId",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "PortfolioId",
                table: "Stocks");
        }
    }
}
