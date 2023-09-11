using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP02.Migrations
{
    /// <inheritdoc />
    public partial class ContainerAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Container",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Tamanho = table.Column<int>(type: "int", nullable: false),
                    BLID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Container", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Container_BL_BLID",
                        column: x => x.BLID,
                        principalTable: "BL",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Container_BLID",
                table: "Container",
                column: "BLID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Container");
        }
    }
}
