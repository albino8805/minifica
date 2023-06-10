using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace minifica.data.Migrations
{
    /// <inheritdoc />
    public partial class ParterMinificaDataBase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ExternalNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    InternalNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NeighbourhoodFK = table.Column<int>(type: "int", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateBy = table.Column<int>(type: "int", nullable: false),
                    UpdateBy = table.Column<int>(type: "int", nullable: false),
                    ContactName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactPhone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Partners_Neighbourhoods_NeighbourhoodFK",
                        column: x => x.NeighbourhoodFK,
                        principalTable: "Neighbourhoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Partners_NeighbourhoodFK",
                table: "Partners",
                column: "NeighbourhoodFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partners");
        }
    }
}
