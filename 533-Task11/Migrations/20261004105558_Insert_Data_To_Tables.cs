using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _533_Task11.Migrations
{
    /// <inheritdoc />
    public partial class Insert_Data_To_Tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Patients",
                columns: new[] { "Patient_Id", "DOB", "Gender", "Name" },
                values: new object[,]
                {
                    { 1, new DateOnly(1990, 5, 14), "Male", "Ali" },
                    { 2, new DateOnly(1985, 8, 22), "Female", "Sara" },
                    { 3, new DateOnly(2000, 1, 10), "Male", "Youssef" },
                    { 4, new DateOnly(1995, 11, 5), "Female", "Laila" },
                    { 5, new DateOnly(1980, 3, 30), "Male", "Omar" },
                    { 6, new DateOnly(1992, 7, 18), "Female", "Mariam" }
                });

            migrationBuilder.InsertData(
                table: "Specializations",
                columns: new[] { "Specialization_Id", "Title" },
                values: new object[,]
                {
                    { 1, "Dentistry" },
                    { 2, "Dermatology" },
                    { 3, "ENT" },
                    { 4, "Cardiology" },
                    { 5, "Urology" }
                });

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Doctor_Id", "Image", "Name", "Specialization_Id" },
                values: new object[,]
                {
                    { 1, "doctor1.jpg", "Mohamed", 1 },
                    { 2, "doctor2.jpg", "Ahmed", 2 },
                    { 3, "doctor3.jpg", "Habiba", 1 },
                    { 4, "doctor4.jpg", "Abdullah", 3 },
                    { 5, "doctor5.jpg", "Karim", 2 },
                    { 6, "doctor6.jpg", "Malak", 3 }
                });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Appointment_Id", "Date", "Doctor_Id", "Patient_Id", "Time" },
                values: new object[,]
                {
                    { 1, new DateOnly(2026, 10, 1), 2, 1, new TimeOnly(9, 0, 0) },
                    { 2, new DateOnly(2026, 10, 2), 4, 2, new TimeOnly(10, 30, 0) },
                    { 3, new DateOnly(2026, 10, 2), 1, 3, new TimeOnly(11, 0, 0) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Appointment_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Appointment_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Appointment_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Doctor_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Doctor_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Doctor_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Patient_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Patient_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Patient_Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Specialization_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Specialization_Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Doctor_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Doctor_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Doctor_Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Patient_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Patient_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Patients",
                keyColumn: "Patient_Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Specialization_Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Specialization_Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Specializations",
                keyColumn: "Specialization_Id",
                keyValue: 3);
        }
    }
}
