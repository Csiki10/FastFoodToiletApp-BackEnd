using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToiletApp.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ddc2320-ecb0-48d0-bbaf-4a77c02bd820");

            migrationBuilder.DropColumn(
                name: "ContentType",
                table: "Toilets");

            migrationBuilder.DropColumn(
                name: "Data",
                table: "Toilets");

            migrationBuilder.DropColumn(
                name: "ImageFileName",
                table: "Toilets");

            migrationBuilder.CreateTable(
                name: "AppFileData",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToiletUid = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppFileData", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppFileData_Toilets_ToiletUid",
                        column: x => x.ToiletUid,
                        principalTable: "Toilets",
                        principalColumn: "Uid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a5753636-4d30-4421-a86d-ffa85efb16cf", 0, "247a2080-b512-4437-97a9-79a6880d7c67", null, null, "SiteUser", "csiki@gmail.com", true, "Benedek", "Csikós", false, null, null, "CSIKI", "AQAAAAEAACcQAAAAEBEALcMoykWeEpOro8W8mOT3Jlry48xUSlLOJroMNf7I6yq0t2b8uTh/i5ayEqqZEg==", null, false, "f7fb4a07-693b-4c29-99ae-03a624913413", false, "csiki" });

            migrationBuilder.CreateIndex(
                name: "IX_AppFileData_ToiletUid",
                table: "AppFileData",
                column: "ToiletUid",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppFileData");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5753636-4d30-4421-a86d-ffa85efb16cf");

            migrationBuilder.AddColumn<string>(
                name: "ContentType",
                table: "Toilets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Data",
                table: "Toilets",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageFileName",
                table: "Toilets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5ddc2320-ecb0-48d0-bbaf-4a77c02bd820", 0, "efd904b2-bc37-4847-a548-b71615d3cc80", null, null, "SiteUser", "csiki@gmail.com", true, "Benedek", "Csikós", false, null, null, "CSIKI", "AQAAAAEAACcQAAAAEPq3TazzzDDF4453HxgR7RACqBwe70T/fXnjmpVFmmAWtc6jQbjDVUHLbmJA567AqQ==", null, false, "2dc5bb77-cebe-4dff-b321-1ca536ab2553", false, "csiki" });
        }
    }
}
