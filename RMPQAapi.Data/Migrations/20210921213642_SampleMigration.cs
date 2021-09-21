using Microsoft.EntityFrameworkCore.Migrations;

namespace RMPQAapi.Data.Migrations
{
    public partial class SampleMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    OwnerId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Image", "Number", "OwnerId" },
                values: new object[] { 1, "lala", "Yura", 123 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Image", "Number", "OwnerId" },
                values: new object[] { 2, "lala2", "Yura2", 321 });

            migrationBuilder.CreateIndex(
                name: "IX_Product_OwnerId",
                table: "Product",
                column: "OwnerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
