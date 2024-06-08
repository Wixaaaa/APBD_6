using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APBD_6.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1999, 6, 8, 23, 47, 55, 271, DateTimeKind.Local).AddTicks(5381));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2003, 6, 8, 23, 47, 55, 271, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1997, 6, 8, 23, 47, 55, 271, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2002, 6, 8, 23, 47, 55, 271, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1974, 6, 8, 23, 47, 55, 271, DateTimeKind.Local).AddTicks(5448));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1995, 6, 8, 23, 47, 55, 271, DateTimeKind.Local).AddTicks(5451));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1970, 6, 8, 23, 47, 55, 271, DateTimeKind.Local).AddTicks(5453));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1957, 6, 8, 23, 47, 55, 271, DateTimeKind.Local).AddTicks(5455));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 47, 55, 272, DateTimeKind.Local).AddTicks(7680), new DateTime(2024, 7, 8, 23, 47, 55, 272, DateTimeKind.Local).AddTicks(7718) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 47, 55, 272, DateTimeKind.Local).AddTicks(7728), new DateTime(2024, 7, 8, 23, 47, 55, 272, DateTimeKind.Local).AddTicks(7730) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 47, 55, 272, DateTimeKind.Local).AddTicks(7733), new DateTime(2024, 7, 8, 23, 47, 55, 272, DateTimeKind.Local).AddTicks(7735) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(1999, 6, 8, 23, 13, 24, 784, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(2003, 6, 8, 23, 13, 24, 784, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1997, 6, 8, 23, 13, 24, 784, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(2002, 6, 8, 23, 13, 24, 784, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1974, 6, 8, 23, 13, 24, 784, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 6,
                column: "BirthDate",
                value: new DateTime(1995, 6, 8, 23, 13, 24, 784, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 7,
                column: "BirthDate",
                value: new DateTime(1970, 6, 8, 23, 13, 24, 784, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Patients",
                keyColumn: "IdPatient",
                keyValue: 8,
                column: "BirthDate",
                value: new DateTime(1957, 6, 8, 23, 13, 24, 784, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 1,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 13, 24, 785, DateTimeKind.Local).AddTicks(8006), new DateTime(2024, 7, 8, 23, 13, 24, 785, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 2,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 13, 24, 785, DateTimeKind.Local).AddTicks(8040), new DateTime(2024, 7, 8, 23, 13, 24, 785, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "Prescriptions",
                keyColumn: "IdPrescription",
                keyValue: 3,
                columns: new[] { "Date", "DueDate" },
                values: new object[] { new DateTime(2024, 6, 8, 23, 13, 24, 785, DateTimeKind.Local).AddTicks(8043), new DateTime(2024, 7, 8, 23, 13, 24, 785, DateTimeKind.Local).AddTicks(8045) });
        }
    }
}
