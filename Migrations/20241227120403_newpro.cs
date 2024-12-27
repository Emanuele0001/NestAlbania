using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NestAlbania.Migrations
{
    /// <inheritdoc />
    public partial class newpro : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "89e318c4-3c83-4399-9c16-f7ffb50dde34", "AQAAAAIAAYagAAAAEDrri0sV9JJCoFLKlFFCut6EjT43kxsJflmjv4ctoQ+FGg4/qbwlpSR+yoSv0YT1sA==" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a18be9c0-aa65-4af8-bd17-00bd9344e575",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72251903-cf07-4516-84c6-ee9b11290f19", "AQAAAAIAAYagAAAAELBPHOXD1OGxZ9h8UKw5O3xlNpaFHVCwRUydVea4rwccMGRSVLt8/x8gaCKgwQKClg==" });
        }
    }
}
