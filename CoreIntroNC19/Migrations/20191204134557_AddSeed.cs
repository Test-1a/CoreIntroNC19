using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreIntroNC19.Migrations
{
    public partial class AddSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Person",
                columns: new[] { "Id", "Age", "Name", "Salary" },
                values: new object[,]
                {
                    { 1, 20, "Kalle", 20000 },
                    { 2, 45, "Anna", 15000 },
                    { 3, 62, "Nisse", 65000 },
                    { 4, 23, "Pelle", 10000 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Person",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
