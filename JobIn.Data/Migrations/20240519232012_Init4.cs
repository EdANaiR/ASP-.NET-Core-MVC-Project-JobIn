using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobIn.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("17fc53a7-2419-43be-b02a-1590c9feb473"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("324de0d3-6b03-40c2-aeb9-03df1c532f80"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("41c30935-8d1c-449a-a99c-bf9a45459ef2"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("d75338ae-291a-4367-af70-8a6f6b5b9c05"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("eda14ab8-0ed4-4113-8531-8301eedd30f6"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("f339e0cf-0600-49ac-a3f7-ea6a9873ac6a"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("348a28d8-f597-4e02-8304-cd0308af29b2"),
                column: "ConcurrencyStamp",
                value: "cd1964a2-ce09-46ab-a4ce-9d20cc7014c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                column: "ConcurrencyStamp",
                value: "b0eb5da1-0beb-4629-a455-94d332ab9117");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252"),
                column: "ConcurrencyStamp",
                value: "d2404cd3-2b66-459c-8b6b-e6c4dce4505d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "486ad370-7f91-48d6-a194-e8aab476c2a0", "AQAAAAIAAYagAAAAEBqjkyJ1548noSvfWKJ3XwYQWhbfh3u3lwiIbyGc/BDYx/UgB9jAX5nUIxhTO60fJA==", "9f6ae943-7dc6-4b4c-b58b-c57633f69809" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "828b89e2-140d-4292-8c45-2aa8a50fdde9", "AQAAAAIAAYagAAAAEPQROcxTgAEN2NyX2VpNiBhBut4q5LN9ibU5N+0L4LULjtWwW3xWMkgiTatS147TQA==", "a2b0a747-d8c9-4300-84ef-6de38fd1e41f" });

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "Advert", "CategoryId", "CreatedBy", "CreatedDate", "Deadline", "ImageId", "Imagge", "IsDeleted", "JobDeadline", "JobDescription", "JobLocation", "JobType", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("43d0bcac-2192-4caa-b5e8-4e1ace53250d"), "Çanakkale İli Üniversite Öğrencilerine Yönelik Siber Güvenlik Atölyesi 2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Btk Akademi", "24-05-2024", "16-04-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan3.png", false, "24-05-2024", "C#, .NetCore, Mvc tercihen React...", "Çanakkale", "Yüzyüze", "Siber Güvenlik Atolyesi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("515497dc-9583-4acd-bb8e-980b4605b93a"), "Geleceğini Şekillendir", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "Cumhurbaşkanlığı Finans Ofisi", "19-04-2024", "02-04-2024", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "/JobIn-Post/img/ilan/ilan1.png", false, "19-04-2024", "Kullanıcı arayüzü tasarımı ve angular kullanarak.....", "Ankara", "Yüz yüze", "Yarı zamanlı/ stajyer", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("752be834-37fa-4ee3-8e21-62949a69119c"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "13-05-2024", "13-06-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "23 Haziran", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("a857b482-4e4d-4095-b8de-d830197f13c3"), "Medipol Üniversitesi Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "İstanbul Medipol Üniversitesi", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan2.png", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("ad315c50-c069-437d-8e3a-52d66406ccf8"), "Sky Experience", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Türk Havacılık ve Uzay Sanayii", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan5.jpg", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "SKY Global Türk Programı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("fbdc64fd-3daf-4c6b-ac9b-5881da556c06"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("43d0bcac-2192-4caa-b5e8-4e1ace53250d"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("515497dc-9583-4acd-bb8e-980b4605b93a"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("752be834-37fa-4ee3-8e21-62949a69119c"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("a857b482-4e4d-4095-b8de-d830197f13c3"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("ad315c50-c069-437d-8e3a-52d66406ccf8"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("fbdc64fd-3daf-4c6b-ac9b-5881da556c06"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("348a28d8-f597-4e02-8304-cd0308af29b2"),
                column: "ConcurrencyStamp",
                value: "043bb542-ca9d-4612-9300-89eeff5503e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                column: "ConcurrencyStamp",
                value: "08c3434a-1b45-4cd3-b676-c2d44c69d43a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252"),
                column: "ConcurrencyStamp",
                value: "80e70daa-12d7-4585-ad99-d23e9cca5e32");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45c1c4aa-aebd-48eb-99c1-8a4e18598187", "AQAAAAIAAYagAAAAEOVSFl/ofQ2gX0lF6+3kQR9bULJHh9Ch2LaSR6gfEvwkI4Pph7pL4loqA6aZ67rKQg==", "b6dbaf2c-fafa-4f23-929c-ba518983273e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4322e462-e06b-473b-b45a-00a393ccafd6", "AQAAAAIAAYagAAAAEBvHsYiVzCZtzjCg8gO9YK1xUaNtZwiEuiZy7FOAIKATqn6E0x9Za+ArCfixJ+C5Sg==", "9046ed1a-db9f-4f45-9503-52c60bde8e04" });

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "Advert", "CategoryId", "CreatedBy", "CreatedDate", "Deadline", "ImageId", "Imagge", "IsDeleted", "JobDeadline", "JobDescription", "JobLocation", "JobType", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("17fc53a7-2419-43be-b02a-1590c9feb473"), "Medipol Üniversitesi Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "İstanbul Medipol Üniversitesi", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan2.png", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("324de0d3-6b03-40c2-aeb9-03df1c532f80"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("41c30935-8d1c-449a-a99c-bf9a45459ef2"), "Çanakkale İli Üniversite Öğrencilerine Yönelik Siber Güvenlik Atölyesi 2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Btk Akademi", "24-05-2024", "16-04-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan3.png", false, "24-05-2024", "C#, .NetCore, Mvc tercihen React...", "Çanakkale", "Yüzyüze", "Siber Güvenlik Atolyesi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("d75338ae-291a-4367-af70-8a6f6b5b9c05"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "13-05-2024", "13-06-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "23 Haziran", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("eda14ab8-0ed4-4113-8531-8301eedd30f6"), "Geleceğini Şekillendir", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "Cumhurbaşkanlığı Finans Ofisi", "19-04-2024", "02-04-2024", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "/JobIn-Post/img/ilan/ilan1.png", false, "19-04-2024", "Kullanıcı arayüzü tasarımı ve angular kullanarak.....", "Ankara", "Yüz yüze", "Yarı zamanlı/ stajyer", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("f339e0cf-0600-49ac-a3f7-ea6a9873ac6a"), "Sky Experience", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Türk Havacılık ve Uzay Sanayii", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan5.jpg", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "SKY Global Türk Programı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }
    }
}
