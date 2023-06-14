using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToiletApp.Migrations
{
    public partial class pics1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a5753636-4d30-4421-a86d-ffa85efb16cf");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "260c2b4c-b828-4eae-8659-eb94f55603cd", 0, "a9ef834e-1bdb-4329-a2c5-5ef3245c4848", null, null, "SiteUser", "csiki@gmail.com", true, "Benedek", "Csikós", false, null, null, "CSIKI", "AQAAAAEAACcQAAAAECWKoG8VbMcjKtpmif13xI5NLyRrGtZNzozWlDLV1GlwBeBiR9h81MeicJ2icTHJvA==", null, false, "d6a90e42-aa84-40a2-9e7b-8c3d6bb13be7", false, "csiki" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "260c2b4c-b828-4eae-8659-eb94f55603cd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a5753636-4d30-4421-a86d-ffa85efb16cf", 0, "247a2080-b512-4437-97a9-79a6880d7c67", null, null, "SiteUser", "csiki@gmail.com", true, "Benedek", "Csikós", false, null, null, "CSIKI", "AQAAAAEAACcQAAAAEBEALcMoykWeEpOro8W8mOT3Jlry48xUSlLOJroMNf7I6yq0t2b8uTh/i5ayEqqZEg==", null, false, "f7fb4a07-693b-4c29-99ae-03a624913413", false, "csiki" });
        }
    }
}
