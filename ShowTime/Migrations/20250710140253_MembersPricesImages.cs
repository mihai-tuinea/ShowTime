using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShowTime.Migrations
{
    /// <inheritdoc />
    public partial class MembersPricesImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Festivals",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "PricePerDay",
                table: "Festivals",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Cost",
                table: "Bookings",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Bands",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Members",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BandId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Members", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Members_Bands_BandId",
                        column: x => x.BandId,
                        principalTable: "Bands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_BandId",
                table: "Members",
                column: "BandId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Members");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Festivals");

            migrationBuilder.DropColumn(
                name: "PricePerDay",
                table: "Festivals");

            migrationBuilder.DropColumn(
                name: "Cost",
                table: "Bookings");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "Bands");
        }
    }
}
