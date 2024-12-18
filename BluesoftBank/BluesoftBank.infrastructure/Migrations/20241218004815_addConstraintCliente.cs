using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BluesoftBank.infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class addConstraintCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_tipo_cliente_id_tipo_cliente",
                table: "clientes");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_tipo_cliente_id_tipo_cliente",
                table: "clientes",
                column: "id_tipo_cliente",
                principalTable: "tipo_cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_tipo_cliente_id_tipo_cliente",
                table: "clientes");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_tipo_cliente_id_tipo_cliente",
                table: "clientes",
                column: "id_tipo_cliente",
                principalTable: "tipo_cliente",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
