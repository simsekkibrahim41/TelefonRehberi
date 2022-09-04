using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TelefonRehberi.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TelefonRehberleri",
                columns: table => new
                {
                    RehberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Soyad = table.Column<string>(type: "varchar(20)", nullable: false),
                    Telefon_Numarasi = table.Column<string>(type: "varchar(20)", nullable: false),
                    Fax_Numarasi = table.Column<string>(type: "varchar(50)", nullable: false),
                    E_Mail = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TelefonRehberleri", x => x.RehberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TelefonRehberleri");
        }
    }
}
