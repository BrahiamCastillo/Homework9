using Microsoft.EntityFrameworkCore.Migrations;

namespace Homework9.Migrations
{
    public partial class seed_bloods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Sangre",
                columns: new[] { "id", "tipo_sangre" },
                values: new object[,]
                {
                    { 1, "O+" },
                    { 2, "O-" },
                    { 3, "A+" },
                    { 4, "A-" },
                    { 5, "B+" },
                    { 6, "B-" },
                    { 7, "AB+" },
                    { 8, "AB-" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sangre",
                keyColumn: "id",
                keyValue: 8);
        }
    }
}
