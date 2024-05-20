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
                keyValue: new Guid("69803133-ba00-4fe8-9e6d-e986be75c9fc"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("7af0a0f8-ba48-4997-852c-4e5599dd28d4"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("8775bed2-3a46-4617-973d-5046dd393b7a"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("893c1862-eea6-4146-a6bd-11fa0f26fd38"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("ab9c8bb1-166e-491a-908d-0d57e3285961"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("b2475cfd-eb69-43a7-b728-b9ce576f56af"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "57b07601-5744-4c92-89ba-b6880964119c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                column: "ConcurrencyStamp",
                value: "85b25dc2-df28-45d7-ada8-6b227a15dd2f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252"),
                column: "ConcurrencyStamp",
                value: "a76ba9f9-08e2-4c5b-857d-0b17458ba864");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "66ae2d42-df89-4153-aaa6-6d29dbed54c7", "AQAAAAIAAYagAAAAEJyFLedJal4qmueSyQJnPojEpKx8MVRR37MknPpGpSuCfHL3UKa/Khfiue9ppZdwnQ==", "6d5b47b8-c285-40af-94e8-00ac7d4d843a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bb999521-b4d7-4efc-9d08-95d4631469d5", "AQAAAAIAAYagAAAAEKpQy5oyornHsZ+BOWKq8G8gMF45iun0HJCUHSTLregBtEVRT1Yl9o/Hts0N2r8LBg==", "93d06d87-f09f-44c3-b8ac-3f8d52368097" });

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "Advert", "CategoryId", "CreatedBy", "CreatedDate", "Deadline", "ImageId", "Imagge", "IsDeleted", "JobDeadline", "JobDescription", "JobLocation", "JobType", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("69803133-ba00-4fe8-9e6d-e986be75c9fc"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("7af0a0f8-ba48-4997-852c-4e5599dd28d4"), "Geleceğini Şekillendir", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "Cumhurbaşkanlığı Finans Ofisi", "19-04-2024", "02-04-2024", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "/JobIn-Post/img/ilan/ilan1.png", false, "19-04-2024", "Kullanıcı arayüzü tasarımı ve angular kullanarak.....", "Ankara", "Yüz yüze", "Yarı zamanlı/ stajyer", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("8775bed2-3a46-4617-973d-5046dd393b7a"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "13-05-2024", "13-06-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "23 Haziran", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("893c1862-eea6-4146-a6bd-11fa0f26fd38"), "Medipol Üniversitesi Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "İstanbul Medipol Üniversitesi", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan2.png", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("ab9c8bb1-166e-491a-908d-0d57e3285961"), "Çanakkale İli Üniversite Öğrencilerine Yönelik Siber Güvenlik Atölyesi 2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Btk Akademi", "24-05-2024", "16-04-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan3.png", false, "24-05-2024", "C#, .NetCore, Mvc tercihen React...", "Çanakkale", "Yüzyüze", "Siber Güvenlik Atolyesi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("b2475cfd-eb69-43a7-b728-b9ce576f56af"), "Sky Experience", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Türk Havacılık ve Uzay Sanayii", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan5.jpg", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "SKY Global Türk Programı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }
    }
}
