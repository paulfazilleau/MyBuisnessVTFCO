using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyBuisnessVTCO.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trucks",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OM = table.Column<string>(nullable: true),
                    NumChassis = table.Column<string>(nullable: true),
                    V_Operation = table.Column<string>(nullable: true),
                    V_Description = table.Column<string>(nullable: true),
                    V_Gamme = table.Column<string>(nullable: true),
                    V_Modele = table.Column<string>(nullable: true),
                    V_Type = table.Column<string>(nullable: true),
                    V_Moteur = table.Column<string>(nullable: true),
                    C_Type = table.Column<string>(nullable: true),
                    C_Marque = table.Column<string>(nullable: true),
                    C_Description = table.Column<string>(nullable: true),
                    D_Chassis = table.Column<string>(nullable: true),
                    D_Carrosserie = table.Column<string>(nullable: true),
                    A_Kilometrage = table.Column<string>(nullable: true),
                    A_Immatriculation = table.Column<string>(nullable: true),
                    A_Localisation = table.Column<string>(nullable: true),
                    F_PrixMiniClient = table.Column<string>(nullable: true),
                    F_ComForfait = table.Column<string>(nullable: true),
                    F_VNC = table.Column<string>(nullable: true),
                    ReservationDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trucks", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trucks");
        }
    }
}
