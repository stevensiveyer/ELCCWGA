using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ELCCWGA.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Scores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    Tee = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Creek1 = table.Column<int>(type: "int", nullable: false),
                    Creek2 = table.Column<int>(type: "int", nullable: false),
                    Creek3 = table.Column<int>(type: "int", nullable: false),
                    Creek4 = table.Column<int>(type: "int", nullable: false),
                    Creek5 = table.Column<int>(type: "int", nullable: false),
                    Creek6 = table.Column<int>(type: "int", nullable: false),
                    Creek7 = table.Column<int>(type: "int", nullable: false),
                    Creek8 = table.Column<int>(type: "int", nullable: false),
                    Creek9 = table.Column<int>(type: "int", nullable: false),
                    Lake1 = table.Column<int>(type: "int", nullable: false),
                    Lake2 = table.Column<int>(type: "int", nullable: false),
                    Lake3 = table.Column<int>(type: "int", nullable: false),
                    Lake4 = table.Column<int>(type: "int", nullable: false),
                    Lake5 = table.Column<int>(type: "int", nullable: false),
                    Lake6 = table.Column<int>(type: "int", nullable: false),
                    Lake7 = table.Column<int>(type: "int", nullable: false),
                    Lake8 = table.Column<int>(type: "int", nullable: false),
                    Lake9 = table.Column<int>(type: "int", nullable: false),
                    Hill1 = table.Column<int>(type: "int", nullable: false),
                    Hill2 = table.Column<int>(type: "int", nullable: false),
                    Hill3 = table.Column<int>(type: "int", nullable: false),
                    Hill4 = table.Column<int>(type: "int", nullable: false),
                    Hill5 = table.Column<int>(type: "int", nullable: false),
                    Hill6 = table.Column<int>(type: "int", nullable: false),
                    Hill7 = table.Column<int>(type: "int", nullable: false),
                    Hill8 = table.Column<int>(type: "int", nullable: false),
                    Hill9 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Scores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Scores");
        }
    }
}
