using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobIn.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_Categories_CategoryId",
                table: "JobPostings");

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("e2eac459-f1c3-49be-9df6-db6c7bb057e2"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("f52507bd-fd8c-46c3-9468-f65556eb6467"));

            migrationBuilder.AlterColumn<string>(
                name: "JobDescription",
                table: "JobPostings",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "JobPostings",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Categories",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"),
                column: "IsDeleted",
                value: false);

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "Deadline", "ImageId", "IsDeleted", "JobDescription", "JobLocation", "JobType", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("190e2cae-b06b-464f-b252-8f1e6c9cd722"), new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Sabancı", new DateTime(2024, 5, 17, 19, 10, 29, 95, DateTimeKind.Local).AddTicks(7519), "2024 Mart", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), false, "C#, .NetCore, Mvc tercihen React...", "Ankara", "Hibrit", "Sabancı Full-Stack Developer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("c49a615c-e6fe-4973-8a01-de3b2f75776e"), new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "Aselsa", new DateTime(2024, 5, 17, 19, 10, 29, 95, DateTimeKind.Local).AddTicks(7498), "2024 Mart", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), false, "Kullanıcı arayüzü tasarımı ve angular kullanarak.....", "Ankara", "Remote", "Asels Part-Time iş ilanı", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_Categories_CategoryId",
                table: "JobPostings",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_JobPostings_Categories_CategoryId",
                table: "JobPostings");

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("190e2cae-b06b-464f-b252-8f1e6c9cd722"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("c49a615c-e6fe-4973-8a01-de3b2f75776e"));

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Categories");

            migrationBuilder.AlterColumn<string>(
                name: "JobDescription",
                table: "JobPostings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "CategoryId",
                table: "JobPostings",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("348a28d8-f597-4e02-8304-cd0308af29b2"),
                column: "ConcurrencyStamp",
                value: "2f450baf-d099-48aa-9013-6abba664f9e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                column: "ConcurrencyStamp",
                value: "3c8fba30-63ed-439f-8a26-5ebb7918e785");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252"),
                column: "ConcurrencyStamp",
                value: "b1b539e5-6e13-457b-82eb-0b9a68bef5f9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d6dde17-f50a-4fb1-a136-526a8b977625", "AQAAAAIAAYagAAAAEF8sVAcCQi6LG/vb54SQLDoRNsR4jgv6Tng7PsYt2xjzSTBYiQtkDDZdNOIE84BdfQ==", "a7c9999a-1699-459a-818d-0e0ff5cd9641" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54933304-f0b3-43f4-836b-bea5a1e9b77a", "AQAAAAIAAYagAAAAEPvEcepCexRF4uKoDxCbOtonInsCLuwQHpCm5n6TiRCU2TEqBJ57xW1nis1e9ZwZFQ==", "80b47efb-9a5b-4701-8c02-ca3c3ee67194" });

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "Deadline", "ImageId", "IsDeleted", "JobDescription", "JobLocation", "JobType", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("e2eac459-f1c3-49be-9df6-db6c7bb057e2"), new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Sabancı", new DateTime(2024, 5, 15, 23, 0, 23, 233, DateTimeKind.Local).AddTicks(3007), "2024 Mart", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), false, "C#, .NetCore, Mvc tercihen React...", "Ankara", "Hibrit", "Sabancı Full-Stack Developer", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("f52507bd-fd8c-46c3-9468-f65556eb6467"), new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "Aselsa", new DateTime(2024, 5, 15, 23, 0, 23, 233, DateTimeKind.Local).AddTicks(2996), "2024 Mart", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), false, "Kullanıcı arayüzü tasarımı ve angular kullanarak.....", "Ankara", "Remote", "Asels Part-Time iş ilanı", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_JobPostings_Categories_CategoryId",
                table: "JobPostings",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
