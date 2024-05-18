using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobIn.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("83db07fa-e448-4190-b9fc-a1bb2dd43ec5"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("bd14ef68-d950-4ede-a9fc-982874cd57a7"));

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Categories");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Images",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("348a28d8-f597-4e02-8304-cd0308af29b2"),
                column: "ConcurrencyStamp",
                value: "11ffc8fe-6a1e-4f4a-84a1-8f47fcdd3733");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                column: "ConcurrencyStamp",
                value: "b8eeb020-3919-4c1d-9286-a7fa79445176");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252"),
                column: "ConcurrencyStamp",
                value: "237b19d1-e741-4f90-9ee5-174590879e28");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f359b12b-3641-46af-998a-3698c3bfa8fc", "AQAAAAIAAYagAAAAEB4p3PPF4vJgDJxlveWPRuKmXDvZ+AE0lPmTuZmKD+POmyM55rQNCdt6zBGNj41HVQ==", "2f605957-3777-4334-939a-7013a8eb8738" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e2e5cc3-54b1-4b03-896d-ebb26dad6610", "AQAAAAIAAYagAAAAEAtAea2xxY/Y6guWZdyiGxTWQhaJEiw8HmRegBOUIk84dtsEg0LRyBojD/boLz6X9g==", "c2fa2db4-7617-4752-859a-619c63f92e49" });

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "Deadline", "ImageId", "IsDeleted", "JobDescription", "JobLocation", "JobType", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("170b01f8-e121-4751-82a6-b8c818943f81"), new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Sabancı", new DateTime(2024, 5, 18, 3, 31, 18, 776, DateTimeKind.Local).AddTicks(7691), "2024 Mart", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), false, "C#, .NetCore, Mvc tercihen React...", "Ankara", "Hibrit", "Sabancı Full-Stack Developer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("7a5fcf72-9dd4-44db-843b-9d95340967e8"), new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "Aselsa", new DateTime(2024, 5, 18, 3, 31, 18, 776, DateTimeKind.Local).AddTicks(7683), "2024 Mart", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), false, "Kullanıcı arayüzü tasarımı ve angular kullanarak.....", "Ankara", "Remote", "Asels Part-Time iş ilanı", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("170b01f8-e121-4751-82a6-b8c818943f81"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("7a5fcf72-9dd4-44db-843b-9d95340967e8"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Images",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("348a28d8-f597-4e02-8304-cd0308af29b2"),
                column: "ConcurrencyStamp",
                value: "316c0c4d-b63d-4923-8385-042e8a1faa9b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                column: "ConcurrencyStamp",
                value: "98ce0070-e631-4ff1-aa92-6c920e6da514");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252"),
                column: "ConcurrencyStamp",
                value: "9ca16d86-0d89-48f1-bafe-f8b7f1fad558");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a7c5374-855c-42e5-ab7b-821e6bc7ca6c", "AQAAAAIAAYagAAAAEH6pOsF7k3Oeot7PbQ8cNeAQoaeDrAx3I6UWffMlKK+3CRe8FjGOXzh+J/kD4KPkBA==", "0bbb8c79-c59d-4f19-8830-c75e3c1c43bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7294e5b-de7c-48af-90f5-6dbe8b23e56d", "AQAAAAIAAYagAAAAENvDBA4gbcZ7K3HZp/DE9qQWr7ebnlO/Lel9Pj9a4+c/iyjxrY6K431LXtk/4nQmLw==", "dac92f66-6799-43da-8bea-306dc705e909" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                column: "CreatedBy",
                value: "Undefined");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                column: "CreatedBy",
                value: "Undefined");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                column: "CreatedBy",
                value: "Undefined");

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                column: "CreatedBy",
                value: "Undefined");

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "Deadline", "ImageId", "IsDeleted", "JobDescription", "JobLocation", "JobType", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("83db07fa-e448-4190-b9fc-a1bb2dd43ec5"), new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "Aselsa", new DateTime(2024, 5, 18, 1, 36, 35, 922, DateTimeKind.Local).AddTicks(487), "2024 Mart", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), false, "Kullanıcı arayüzü tasarımı ve angular kullanarak.....", "Ankara", "Remote", "Asels Part-Time iş ilanı", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("bd14ef68-d950-4ede-a9fc-982874cd57a7"), new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Sabancı", new DateTime(2024, 5, 18, 1, 36, 35, 922, DateTimeKind.Local).AddTicks(495), "2024 Mart", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), false, "C#, .NetCore, Mvc tercihen React...", "Ankara", "Hibrit", "Sabancı Full-Stack Developer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }
    }
}
