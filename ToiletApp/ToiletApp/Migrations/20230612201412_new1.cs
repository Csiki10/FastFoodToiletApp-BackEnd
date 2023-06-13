using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ToiletApp.Migrations
{
    public partial class new1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ddc2320-ecb0-48d0-bbaf-4a77c02bd820");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e5977350-616f-4f52-8375-5711cc91bc0b", 0, "0be7df58-56fe-49ac-b41f-8bd73856a270", null, null, "SiteUser", "csiki@gmail.com", true, "Benedek", "Csikós", false, null, null, "CSIKI", "AQAAAAEAACcQAAAAEBubHNSRXdeU5b3uWVH+FZrltLSrRACEEExzncHKwbDK9qSLSHeCW/nEPpbmO17Row==", null, false, "d050f738-252b-47f8-9f7f-9a2270a65e2b", false, "csiki" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5977350-616f-4f52-8375-5711cc91bc0b");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "ContentType", "Data", "Discriminator", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "5ddc2320-ecb0-48d0-bbaf-4a77c02bd820", 0, "efd904b2-bc37-4847-a548-b71615d3cc80", null, null, "SiteUser", "csiki@gmail.com", true, "Benedek", "Csikós", false, null, null, "CSIKI", "AQAAAAEAACcQAAAAEPq3TazzzDDF4453HxgR7RACqBwe70T/fXnjmpVFmmAWtc6jQbjDVUHLbmJA567AqQ==", null, false, "2dc5bb77-cebe-4dff-b321-1ca536ab2553", false, "csiki" });
        }
    }
}
