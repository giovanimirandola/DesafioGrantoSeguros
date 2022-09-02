using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesafioGrantoSeguros.Infrastructure.DataAccess.Migrations
{
    public partial class RazaoSocial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Descricao",
                table: "Oportunidades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RazaoSocial",
                table: "Oportunidades",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Descricao",
                table: "Oportunidades");

            migrationBuilder.DropColumn(
                name: "RazaoSocial",
                table: "Oportunidades");
        }
    }
}
