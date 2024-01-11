using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace viageMais.Migrations
{
    /// <inheritdoc />
    public partial class secondMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "hotel",
                columns: new[] { "id", "assessments", "imgUrl", "name", "price", "stars" },
                values: new object[,]
                {
                    { 1, 110, "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-rio.webp", "Grand Hotel Plaza", 1799, 5 },
                    { 2, 65, "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-londres.webp", "Montanha Lodge", 749, 3 },
                    { 3, 88, "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-dubai.jpg", "Seaside Resort", 1299, 4 },
                    { 4, 50, "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-salvador.jpg", "Chalé do Bosque", 499, 3 },
                    { 5, 92, "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-1.jpg", "Hotel Aconchego", 899, 4 },
                    { 6, 120, "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-2.jpg", "Resort Paradisíaco", 1499, 5 },
                    { 7, 60, "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-3.jpg", "Pousada das Flores", 599, 3 },
                    { 8, 105, "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-4.jpg", "Luxury Suites", 1999, 5 },
                    { 9, 30, "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-5.jpg", "Hostel Viajante", 299, 2 },
                    { 10, 80, "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-6.jpg", "Riverside Lodge", 899, 4 },
                    { 11, 50, "https://raw.githubusercontent.com/LeandroNcosta/ViageMais/main/images/hotel-7.jpg", "Chalé do Bosque", 499, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 11);
        }
    }
}
