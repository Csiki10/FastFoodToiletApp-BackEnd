using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToiletApp.Migrations
{
    public partial class base12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3fcbc38-e389-4282-932d-538c1c3656d2");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Toilets",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ToiletUid",
                table: "Opinions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ToiletUid",
                table: "Addresses",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5ddc2320-ecb0-48d0-bbaf-4a77c02bd820", 0, "efd904b2-bc37-4847-a548-b71615d3cc80", null, null, "SiteUser", "csiki@gmail.com", true, "Benedek", "Csikós", false, null, null, "CSIKI", "AQAAAAEAACcQAAAAEPq3TazzzDDF4453HxgR7RACqBwe70T/fXnjmpVFmmAWtc6jQbjDVUHLbmJA567AqQ==", null, false, "2dc5bb77-cebe-4dff-b321-1ca536ab2553", false, "csiki" });

            migrationBuilder.CreateIndex(
                name: "IX_Toilets_UserId",
                table: "Toilets",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Opinions_ToiletUid",
                table: "Opinions",
                column: "ToiletUid");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_ToiletUid",
                table: "Addresses",
                column: "ToiletUid",
                unique: true,
                filter: "[ToiletUid] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Toilets_ToiletUid",
                table: "Addresses",
                column: "ToiletUid",
                principalTable: "Toilets",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Opinions_Toilets_ToiletUid",
                table: "Opinions",
                column: "ToiletUid",
                principalTable: "Toilets",
                principalColumn: "Uid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Toilets_AspNetUsers_UserId",
                table: "Toilets",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Toilets_ToiletUid",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Opinions_Toilets_ToiletUid",
                table: "Opinions");

            migrationBuilder.DropForeignKey(
                name: "FK_Toilets_AspNetUsers_UserId",
                table: "Toilets");

            migrationBuilder.DropIndex(
                name: "IX_Toilets_UserId",
                table: "Toilets");

            migrationBuilder.DropIndex(
                name: "IX_Opinions_ToiletUid",
                table: "Opinions");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_ToiletUid",
                table: "Addresses");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ddc2320-ecb0-48d0-bbaf-4a77c02bd820");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Toilets",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ToiletUid",
                table: "Opinions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "ToiletUid",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b3fcbc38-e389-4282-932d-538c1c3656d2", 0, "642f91e8-e6bc-4059-a7f0-e69fcd2cfde5", null, null, "SiteUser", "csiki@gmail.com", true, "Benedek", "Csikós", false, null, null, "CSIKI", "AQAAAAEAACcQAAAAEHObGZlpwPPl0DGjPETkgfqDKv+8zuV0A6kK4OeKODywUUBGoQlrsVbawrBr1crFYQ==", null, false, "6a49c649-3072-423d-823b-bea634e5cbfd", false, "csiki" });
        }
    }
}
