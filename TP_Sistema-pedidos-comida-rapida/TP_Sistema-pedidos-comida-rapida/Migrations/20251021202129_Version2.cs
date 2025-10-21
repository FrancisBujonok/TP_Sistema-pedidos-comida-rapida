using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TP_Sistema_pedidos_comida_rapida.Migrations
{
    /// <inheritdoc />
    public partial class Version2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Productos",
                newName: "ID_Producto");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID_Producto",
                table: "Productos",
                newName: "ID");
        }
    }
}
