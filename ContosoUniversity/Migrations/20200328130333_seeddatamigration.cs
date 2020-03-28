using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class seeddatamigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseID", "Credits", "Title" },
                values: new object[] { 1050, 3, "Chemistry" });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "ID", "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[] { 1, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carson", "Alexander" });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentID", "CourseID", "Grade", "StudentID" },
                values: new object[] { 101, 1050, 0, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 1);
        }
    }
}
