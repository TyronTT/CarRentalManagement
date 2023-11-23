using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Server.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultDataAndUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "135fb624-877f-44c0-930f-e7740ac8d81d", "admin@localhost.com", false, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEN+fZvD5TVTCziql/ADQ+v1cdkNgIBg6RQss09Ie+9jRMKqmOUvTTaQIJ2Cq6A1zlA==", null, false, "d086c516-3b92-491c-a6f2-0a14d0239697", false, "admin@localhost.com" });

            migrationBuilder.InsertData(
                table: "Colours",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6100), new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6114), "Black", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6116), new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6117), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Makes",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6378), new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6379), "BMW", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6380), new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6381), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6522), new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6522), "3 Series", "System" },
                    { 2, "System", new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6524), new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6524), "X5", "System" },
                    { 3, "System", new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6525), new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6526), "Prius", "System" },
                    { 4, "System", new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6527), new DateTime(2023, 11, 23, 14, 36, 36, 944, DateTimeKind.Local).AddTicks(6527), "Rav4", "System" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colours",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Makes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");
        }
    }
}
