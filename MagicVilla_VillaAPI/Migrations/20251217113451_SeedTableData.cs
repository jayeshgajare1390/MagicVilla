using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedTableData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2025, 12, 17, 17, 4, 50, 416, DateTimeKind.Local).AddTicks(5201), "This is the Royal Villa", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR8B54qX_P4gtYm1bY9U0cCdUVMy7-HEBKF3g&s", "Royal Villa", 4, 200.0, 550, new DateTime(2025, 12, 17, 17, 4, 50, 418, DateTimeKind.Local).AddTicks(3498) },
                    { 2, "", new DateTime(2025, 12, 17, 17, 4, 50, 418, DateTimeKind.Local).AddTicks(4224), "This is the Premium Pool Villa", "https://assets.cntraveller.in/photos/682d9d2b926cedc77ed0792f/1:1/w_1816,h_1816,c_limit/Malibu%20Villa.png", "Premium Pool Villa", 4, 300.0, 550, new DateTime(2025, 12, 17, 17, 4, 50, 418, DateTimeKind.Local).AddTicks(4230) },
                    { 3, "", new DateTime(2025, 12, 17, 17, 4, 50, 418, DateTimeKind.Local).AddTicks(4232), "This is the Luxury Pool Villa", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSvZb4UP2KexL_WesW7MhPk01OxXRl4qvsVIA&s", "Luxury Pool Villa", 4, 400.0, 750, new DateTime(2025, 12, 17, 17, 4, 50, 418, DateTimeKind.Local).AddTicks(4233) },
                    { 4, "", new DateTime(2025, 12, 17, 17, 4, 50, 418, DateTimeKind.Local).AddTicks(4235), "This is the Diamond Villa", "https://www.shutterstock.com/image-illustration/3d-illustration-newly-built-luxury-260nw-2066280914.jpg", "Diamond Villa", 4, 550.0, 900, new DateTime(2025, 12, 17, 17, 4, 50, 418, DateTimeKind.Local).AddTicks(4236) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
