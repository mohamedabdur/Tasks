using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace inheritanceEF.Migrations
{
    /// <inheritdoc />
    public partial class migrate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicle",
                columns: table => new
                {
                    vehicleNumber = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    vehicleMaxSpeed = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.vehicleNumber);
                });

            migrationBuilder.CreateTable(
                name: "Bike",
                columns: table => new
                {
                    vehicleNumber = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bike", x => x.vehicleNumber);
                    table.ForeignKey(
                        name: "FK_Bike_Vehicle_vehicleNumber",
                        column: x => x.vehicleNumber,
                        principalTable: "Vehicle",
                        principalColumn: "vehicleNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Car",
                columns: table => new
                {
                    vehicleNumber = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Car", x => x.vehicleNumber);
                    table.ForeignKey(
                        name: "FK_Car_Vehicle_vehicleNumber",
                        column: x => x.vehicleNumber,
                        principalTable: "Vehicle",
                        principalColumn: "vehicleNumber",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bike");

            migrationBuilder.DropTable(
                name: "Car");

            migrationBuilder.DropTable(
                name: "Vehicle");
        }
    }
}
