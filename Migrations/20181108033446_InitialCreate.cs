using Microsoft.EntityFrameworkCore.Migrations;

namespace LojasCRUD.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lojas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    razaoSocial = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: true),
                    logradouro = table.Column<string>(nullable: false),
                    bairro = table.Column<string>(nullable: true),
                    cidade = table.Column<string>(nullable: false),
                    cep = table.Column<string>(nullable: false),
                    uf = table.Column<string>(nullable: false),
                    Latitude = table.Column<string>(nullable: false),
                    Longitude = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lojas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lojas");
        }
    }
}
