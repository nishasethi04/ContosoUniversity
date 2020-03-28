using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class alteremployeeseeddataagain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstMidName", "LastName" },
                values: new object[] { "Nisha", "Sethi" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstMidName", "LastName" },
                values: new object[] { "John", "Smith" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "FirstMidName", "LastName" },
                values: new object[] { "Sally", "Jones" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "FirstMidName", "LastName" },
                values: new object[] { "Carson", "Alexander" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "FirstMidName", "LastName" },
                values: new object[] { "Meredith", "Alonso" });

            migrationBuilder.UpdateData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "FirstMidName", "LastName" },
                values: new object[] { "Arturo", "Anand" });
        }
    }
}
