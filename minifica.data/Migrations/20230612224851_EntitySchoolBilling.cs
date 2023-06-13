using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace minifica.data.Migrations
{
    /// <inheritdoc />
    public partial class EntitySchoolBilling : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SchoolBillingInformations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RFC = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Street = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ExternalNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    InternalNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NeighbourhoodFK = table.Column<int>(type: "int", nullable: false),
                    PostalCode = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SchoolBillingInformations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SchoolBillingInformations_Neighbourhoods_NeighbourhoodFK",
                        column: x => x.NeighbourhoodFK,
                        principalTable: "Neighbourhoods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SchoolBillingInformations_NeighbourhoodFK",
                table: "SchoolBillingInformations",
                column: "NeighbourhoodFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SchoolBillingInformations");
        }
    }
}
