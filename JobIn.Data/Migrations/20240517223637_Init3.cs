using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobIn.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("190e2cae-b06b-464f-b252-8f1e6c9cd722"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("c49a615c-e6fe-4973-8a01-de3b2f75776e"));

            migrationBuilder.AlterColumn<string>(
                name: "Deadline",
                table: "JobPostings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                columns: new[] { "CreatedBy", "Name" },
                values: new object[] { "Undefined", "İş İlanı" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                columns: new[] { "CreatedBy", "Name" },
                values: new object[] { "Undefined", "Staj İlanı" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Deadline",
                table: "JobPostings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("348a28d8-f597-4e02-8304-cd0308af29b2"),
                column: "ConcurrencyStamp",
                value: "08a2880b-6f38-4241-8300-918458fb658d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                column: "ConcurrencyStamp",
                value: "c7216d2f-0637-4cf1-83fd-2df75eef7c6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252"),
                column: "ConcurrencyStamp",
                value: "d37dac25-8e6a-42cb-82d5-5e981a70034d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "988a3f9d-cc46-495d-9428-b0e7abfc5501", "AQAAAAIAAYagAAAAEMusMoGPUbyaqVOqaHRMn/2jEKON5j0aspEnryCzhWR6V1OMmuc0UH6NjV8bYOvQQA==", "15124846-20e5-45a8-9016-17867e68d558" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0de3faec-0d1f-48a9-82de-ac5a21fb70ab", "AQAAAAIAAYagAAAAECxPdGUZTNx6eREQylsh7TMdYnqeFCulv80YJyW4a/JwI4im6beMSGfQRLgkc+kq9A==", "984f92f8-5606-45d9-af10-77fac2c34f43" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"),
                column: "Name",
                value: "İş İlanları");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                column: "Name",
                value: "İş İlanları");

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "Deadline", "ImageId", "IsDeleted", "JobDescription", "JobLocation", "JobType", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("190e2cae-b06b-464f-b252-8f1e6c9cd722"), new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Sabancı", new DateTime(2024, 5, 17, 19, 10, 29, 95, DateTimeKind.Local).AddTicks(7519), "2024 Mart", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), false, "C#, .NetCore, Mvc tercihen React...", "Ankara", "Hibrit", "Sabancı Full-Stack Developer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("c49a615c-e6fe-4973-8a01-de3b2f75776e"), new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "Aselsa", new DateTime(2024, 5, 17, 19, 10, 29, 95, DateTimeKind.Local).AddTicks(7498), "2024 Mart", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), false, "Kullanıcı arayüzü tasarımı ve angular kullanarak.....", "Ankara", "Remote", "Asels Part-Time iş ilanı", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });
        }
    }
}
