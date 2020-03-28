using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ContosoUniversity.Migrations
{
    public partial class alteremployeeseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "CourseID", "Credits", "Title" },
                values: new object[,]
                {
                    { 4022, 3, "Microeconomics" },
                    { 4041, 3, "Macroeconomics" },
                    { 1045, 4, "Calculus" },
                    { 3141, 4, "Trigonometry" },
                    { 2021, 3, "Composition" },
                    { 2042, 4, "Literature" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentID", "CourseID", "Grade", "StudentID" },
                values: new object[] { 102, 1050, 0, 1 });

            migrationBuilder.InsertData(
                table: "Student",
                columns: new[] { "ID", "EnrollmentDate", "FirstMidName", "LastName" },
                values: new object[,]
                {
                    { 2, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meredith", "Alonso" },
                    { 3, new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Arturo", "Anand" },
                    { 4, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gytis", "Barzdukas" },
                    { 5, new DateTime(2002, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Yan", "Li" },
                    { 6, new DateTime(2001, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Peggy", "Justice" },
                    { 7, new DateTime(2003, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laura", "Norman" },
                    { 8, new DateTime(2005, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nino", "Olivetto" }
                });

            migrationBuilder.InsertData(
                table: "Enrollment",
                columns: new[] { "EnrollmentID", "CourseID", "Grade", "StudentID" },
                values: new object[,]
                {
                    { 103, 4022, 2, 1 },
                    { 104, 4041, 1, 1 },
                    { 105, 1045, 1, 2 },
                    { 106, 3141, 4, 2 },
                    { 107, 2021, 4, 2 },
                    { 108, 1050, null, 3 },
                    { 109, 1050, null, 4 },
                    { 110, 4022, 4, 4 },
                    { 111, 4041, 2, 5 },
                    { 112, 1045, null, 6 },
                    { 113, 3141, 0, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2042);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Enrollment",
                keyColumn: "EnrollmentID",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 2021);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 3141);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4022);

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "CourseID",
                keyValue: 4041);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Student",
                keyColumn: "ID",
                keyValue: 7);
        }
    }
}
