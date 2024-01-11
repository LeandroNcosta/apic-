using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace viageMais.Migrations
{
    /// <inheritdoc />
    public partial class thirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "mainName",
                table: "hotel",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 1,
                columns: new[] { "mainName", "name" },
                values: new object[] { "Grand Hotel Plaza", "grand-hotel-plaza" });

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "mainName", "name" },
                values: new object[] { "Montanha Lodge", "montanha-lodge" });

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 3,
                columns: new[] { "mainName", "name" },
                values: new object[] { "Seaside Resort", "seaside-resort" });

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 4,
                columns: new[] { "mainName", "name" },
                values: new object[] { "Chalé do Bosque", "chale-do-bosque" });

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 5,
                columns: new[] { "mainName", "name" },
                values: new object[] { "Hotel Aconchego", "hotel-aconchego" });

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 6,
                columns: new[] { "mainName", "name" },
                values: new object[] { "Resort Paradisíaco", "resort-paradisiaco" });

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 7,
                columns: new[] { "mainName", "name" },
                values: new object[] { "Pousada das Flores", "pousada-das-flores" });

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 8,
                columns: new[] { "mainName", "name" },
                values: new object[] { "Luxury Suites", "luxury-suite" });

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 9,
                columns: new[] { "mainName", "name" },
                values: new object[] { "Hostel Viajante", "hostel-viajante" });

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 10,
                columns: new[] { "mainName", "name" },
                values: new object[] { "Riverside Lodge", "riverside-lodge" });

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 11,
                columns: new[] { "mainName", "name" },
                values: new object[] { "Chalé do Bosque", "chale-do-bosque" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mainName",
                table: "hotel");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 1,
                column: "name",
                value: "Grand Hotel Plaza");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 2,
                column: "name",
                value: "Montanha Lodge");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 3,
                column: "name",
                value: "Seaside Resort");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 4,
                column: "name",
                value: "Chalé do Bosque");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 5,
                column: "name",
                value: "Hotel Aconchego");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 6,
                column: "name",
                value: "Resort Paradisíaco");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 7,
                column: "name",
                value: "Pousada das Flores");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 8,
                column: "name",
                value: "Luxury Suites");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 9,
                column: "name",
                value: "Hostel Viajante");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 10,
                column: "name",
                value: "Riverside Lodge");

            migrationBuilder.UpdateData(
                table: "hotel",
                keyColumn: "id",
                keyValue: 11,
                column: "name",
                value: "Chalé do Bosque");
        }
    }
}
