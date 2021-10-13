using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FlowersShop.Migrations
{
    public partial class Flowers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Flowers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmallImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BigImageLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SmallInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BigInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flowers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Korzinas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlowerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlowerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FlowersCount = table.Column<int>(type: "int", nullable: false),
                    FlowersPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Korzinas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "News",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SmallInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BigInfo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_News", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Flowers");

            migrationBuilder.DropTable(
                name: "Korzinas");

            migrationBuilder.DropTable(
                name: "News");
        }
    }
}
