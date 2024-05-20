using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace JobIn.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("1f32306f-bf06-4252-98fc-d89189c676ed"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("24a312c6-2b80-4c04-8a7e-e35a190152eb"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("41dab1a5-914d-4603-a57f-89794f411177"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("95258802-b233-403e-8e15-a24d83ad030c"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("d8f4b1d9-5cec-45ab-9613-f4e2b182521f"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("e3448a12-e8a1-4772-80a8-08fd441d8151"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("348a28d8-f597-4e02-8304-cd0308af29b2"),
                column: "ConcurrencyStamp",
                value: "2cb55acf-51b3-4f8f-b4d3-0d24df3160a3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                column: "ConcurrencyStamp",
                value: "f8e9a679-9db5-4fd3-8b40-90bf1f302e6d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252"),
                column: "ConcurrencyStamp",
                value: "0b2defee-0b70-450a-906f-9aa3fac53bdd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94260f07-1da3-403a-98e8-55787631ebea", "AQAAAAIAAYagAAAAEIjjHz8aqqpqR7TpfBtxFkR3gw7lvVCvHw6io0RaUNJ1jPmmSLiIwTYDFML6Z+lhww==", "02ba4758-0582-4ace-b786-1da57f9c7ef7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "51c5b342-abb0-495f-81b8-308195d234d1", "AQAAAAIAAYagAAAAEAuBfdVbINBkzS29LWjno+EnF0JaELC2V9kHkGPSrMZe9rb3/RD5k+CiW7tyeM3v2Q==", "76cb7013-f69f-4592-93d6-f9ccd96b7060" });

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "Advert", "CategoryId", "CreatedBy", "CreatedDate", "Deadline", "ImageId", "Imagge", "IsDeleted", "JobDeadline", "JobDescription", "JobLocation", "JobType", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("0a8e6352-1be4-42e4-b68a-19317b5b0cfc"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "13-05-2024", "13-06-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "23 Haziran", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("1efc84e9-0bc5-4976-9b48-8375409fca7c"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "13-06-2024", "13-05-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "23 Haziran", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("546a351b-f409-47c9-bdd3-df4be5b6176b"), "Çanakkale İli Üniversite Öğrencilerine Yönelik Siber Güvenlik Atölyesi 2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Btk Akademi", "24-05-2024", "16-04-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan3.png", false, "24 Mayıs", "C#, .NetCore, Mvc tercihen React...", "Çanakkale", "Yüzyüze", "Siber Güvenlik Atolyesi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("646c6856-cdf2-4eeb-a4b2-ec226bf5e288"), "Geleceğini Şekillendir", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "Cumhurbaşkanlığı Finans Ofisi", "19-04-2024", "02-04-2024", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "/JobIn-Post/img/ilan/ilan1.png", false, "19 Nisan", "Kullanıcı arayüzü tasarımı ve angular kullanarak.....", "Ankara", "Yüz yüze", "Yarı zamanlı/ stajyer", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("b5d48045-dd9c-47d7-a9fa-072b61230429"), "Medipol Üniversitesi Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "İstanbul Medipol Üniversitesi", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan2.png", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("e977ab43-87d6-4e01-931d-22365a80b272"), "Sky Experience", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Türk Havacılık ve Uzay Sanayii", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan5.jpg", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "SKY Global Türk Programı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("0a8e6352-1be4-42e4-b68a-19317b5b0cfc"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("1efc84e9-0bc5-4976-9b48-8375409fca7c"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("546a351b-f409-47c9-bdd3-df4be5b6176b"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("646c6856-cdf2-4eeb-a4b2-ec226bf5e288"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("b5d48045-dd9c-47d7-a9fa-072b61230429"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("e977ab43-87d6-4e01-931d-22365a80b272"));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("348a28d8-f597-4e02-8304-cd0308af29b2"),
                column: "ConcurrencyStamp",
                value: "8f567d9b-66aa-492d-98ec-937c4fe16f56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                column: "ConcurrencyStamp",
                value: "aea4d3c3-d383-4f4b-97d4-8fe1147ce6f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252"),
                column: "ConcurrencyStamp",
                value: "12cdc08c-e4ca-4ae5-a70c-d51137bca47a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0be9841-3349-4afd-a54f-6ff1980ad974", "AQAAAAIAAYagAAAAEJ9Sm3nYbdHN9zSMKclbPrce3Bakg1w18RsCdlKblw45w5LOp8G4bZCwcYTZZjbrDw==", "c051df49-9dc2-4de9-bedc-ef2043359063" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c73147d7-8dd6-47f1-86ad-7decc3010603", "AQAAAAIAAYagAAAAEMgKuzEgJgNsemDA1aoSZRHTfcxCPhLf+2VCutCefp4Mk4CLiWvQqm+an1MF656cLg==", "fcd1dcd9-399e-44b0-abdb-e8e295c08d6e" });

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "Advert", "CategoryId", "CreatedBy", "CreatedDate", "Deadline", "ImageId", "Imagge", "IsDeleted", "JobDeadline", "JobDescription", "JobLocation", "JobType", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("1f32306f-bf06-4252-98fc-d89189c676ed"), "Sky Experience", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Türk Havacılık ve Uzay Sanayii", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan5.jpg", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "SKY Global Türk Programı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("24a312c6-2b80-4c04-8a7e-e35a190152eb"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "13-06-2024", "13-05-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "23 Haziran", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("41dab1a5-914d-4603-a57f-89794f411177"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "13-05-2024", "13-06-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "23 Haziran", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("95258802-b233-403e-8e15-a24d83ad030c"), "Medipol Üniversitesi Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "İstanbul Medipol Üniversitesi", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan2.png", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("d8f4b1d9-5cec-45ab-9613-f4e2b182521f"), "Geleceğini Şekillendir", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "Cumhurbaşkanlığı Finans Ofisi", "19-04-2024", "02-04-2024", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "/JobIn-Post/img/ilan/ilan1.png", false, "19 Nisan", "Kullanıcı arayüzü tasarımı ve angular kullanarak.....", "Ankara", "Yüz yüze", "Yarı zamanlı/ stajyer", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("e3448a12-e8a1-4772-80a8-08fd441d8151"), "Çanakkale İli Üniversite Öğrencilerine Yönelik Siber Güvenlik Atölyesi 2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Btk Akademi", "24-05-2024", "16-04-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan3.png", false, "24 Mayıs", "C#, .NetCore, Mvc tercihen React...", "Çanakkale", "Yüzyüze", "Siber Güvenlik Atolyesi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }
    }
}
