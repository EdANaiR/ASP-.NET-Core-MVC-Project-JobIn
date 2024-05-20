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
            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("078d3b69-abe3-458a-b654-5a1efc72924e"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("3974a6a1-c7f7-464e-a5e2-ad2f400142a6"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("5ed6ab53-c2e1-4214-ace6-b057dfccf647"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("62c05954-2df6-43d2-acf7-a19ff64fbb61"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("920c3d6b-79da-49c9-bdda-5c7bc4290965"));

            migrationBuilder.DeleteData(
                table: "JobPostings",
                keyColumn: "Id",
                keyValue: new Guid("fc7241af-e206-4b40-95a5-768a30239b0d"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                value: "ef8e0492-937c-41f0-a625-25a3c10a10a7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("4b66714c-4bae-4695-be71-c612af8b84b9"),
                column: "ConcurrencyStamp",
                value: "5f5cc538-14d9-46a6-b37c-5b28436c8bad");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: new Guid("e9e89340-b3fe-441d-97ac-bbb5351f4252"),
                column: "ConcurrencyStamp",
                value: "d8da2b19-5cae-4447-b872-2954dc0dc47a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfabcce6-3b99-4f71-a70c-227067b03e25", "AQAAAAIAAYagAAAAENIXip1jqEO7NfJcJvd0oIG0CGgNdo+P3KVFFaEm67kGpCe49kUkA2Tz4ek22sOLJg==", "72ccd0ef-7c27-4d71-861f-fba187619fce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70026802-1975-4fe8-8685-c760197f0282", "AQAAAAIAAYagAAAAEE/kgf5oYS+Eleczg64dfqePRFbk704YaqTsUT9ocBChRA5lPgBK/YjaFAm+5tjiPQ==", "13b849a5-101c-45a3-ae83-a9a7312b02c5" });

            migrationBuilder.InsertData(
                table: "JobPostings",
                columns: new[] { "Id", "Advert", "CategoryId", "CreatedBy", "CreatedDate", "Deadline", "ImageId", "Imagge", "IsDeleted", "JobDeadline", "JobDescription", "JobLocation", "JobType", "Title", "UserId" },
                values: new object[,]
                {
                    { new Guid("078d3b69-abe3-458a-b654-5a1efc72924e"), "Sky Experience", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Türk Havacılık ve Uzay Sanayii", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan5.jpg", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "SKY Global Türk Programı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("3974a6a1-c7f7-464e-a5e2-ad2f400142a6"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "13-05-2024", "13-06-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "23 Haziran", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("5ed6ab53-c2e1-4214-ace6-b057dfccf647"), "Fark’lı ailemizde yer almak istiyorsan hemen başvur!", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Farplas", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan4.png", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "FARK'a Ortak Ol! Uzun Dönem Staj Programı 2024", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("62c05954-2df6-43d2-acf7-a19ff64fbb61"), "Geleceğini Şekillendir", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "Cumhurbaşkanlığı Finans Ofisi", "19-04-2024", "02-04-2024", new Guid("6a010829-35ba-4c29-ace0-bcea7718672f"), "/JobIn-Post/img/ilan/ilan1.png", false, "19-04-2024", "Kullanıcı arayüzü tasarımı ve angular kullanarak.....", "Ankara", "Yüz yüze", "Yarı zamanlı/ stajyer", new Guid("cb94223b-ccb8-4f2f-93d7-0df96a7f065c") },
                    { new Guid("920c3d6b-79da-49c9-bdda-5c7bc4290965"), "Çanakkale İli Üniversite Öğrencilerine Yönelik Siber Güvenlik Atölyesi 2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "Btk Akademi", "24-05-2024", "16-04-2024", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan3.png", false, "24-05-2024", "C#, .NetCore, Mvc tercihen React...", "Çanakkale", "Yüzyüze", "Siber Güvenlik Atolyesi", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") },
                    { new Guid("fc7241af-e206-4b40-95a5-768a30239b0d"), "Medipol Üniversitesi Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "İstanbul Medipol Üniversitesi", "", "", new Guid("b4224b04-73b7-4077-af1e-81e16a37de65"), "/JobIn-Post/img/ilan/ilan2.png", false, "", "C#, .NetCore, Mvc tercihen React...", "İstanbul", "Yüzyüze", "Teknoloji Transfer Ofisi-Stajyer İlanı", new Guid("3aa42229-1c0f-4630-8c1a-db879ecd0427") }
                });
        }
    }
}
