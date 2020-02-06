using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SixteenDaysRootObjects",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    city_name = table.Column<string>(nullable: true),
                    lon = table.Column<string>(nullable: true),
                    timezone = table.Column<string>(nullable: true),
                    lat = table.Column<string>(nullable: true),
                    country_code = table.Column<string>(nullable: true),
                    state_code = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SixteenDaysRootObjects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    icon = table.Column<string>(nullable: true),
                    code = table.Column<int>(nullable: false),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Datums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    moonrise_ts = table.Column<int>(nullable: false),
                    wind_cdir = table.Column<string>(nullable: true),
                    rh = table.Column<int>(nullable: false),
                    pres = table.Column<double>(nullable: false),
                    high_temp = table.Column<double>(nullable: false),
                    sunset_ts = table.Column<int>(nullable: false),
                    ozone = table.Column<double>(nullable: false),
                    moon_phase = table.Column<double>(nullable: false),
                    wind_gust_spd = table.Column<double>(nullable: false),
                    snow_depth = table.Column<double>(nullable: false),
                    clouds = table.Column<int>(nullable: false),
                    ts = table.Column<int>(nullable: false),
                    sunrise_ts = table.Column<int>(nullable: false),
                    app_min_temp = table.Column<double>(nullable: false),
                    wind_spd = table.Column<double>(nullable: false),
                    pop = table.Column<int>(nullable: false),
                    wind_cdir_full = table.Column<string>(nullable: true),
                    slp = table.Column<double>(nullable: false),
                    valid_date = table.Column<string>(nullable: true),
                    app_max_temp = table.Column<double>(nullable: false),
                    vis = table.Column<double>(nullable: false),
                    dewpt = table.Column<double>(nullable: false),
                    snow = table.Column<double>(nullable: false),
                    uv = table.Column<double>(nullable: false),
                    weatherId = table.Column<int>(nullable: true),
                    wind_dir = table.Column<int>(nullable: false),
                    max_dhi = table.Column<string>(nullable: true),
                    clouds_hi = table.Column<int>(nullable: false),
                    precip = table.Column<double>(nullable: false),
                    low_temp = table.Column<double>(nullable: false),
                    max_temp = table.Column<double>(nullable: false),
                    moonset_ts = table.Column<int>(nullable: false),
                    datetime = table.Column<string>(nullable: true),
                    temp = table.Column<double>(nullable: false),
                    min_temp = table.Column<double>(nullable: false),
                    clouds_mid = table.Column<int>(nullable: false),
                    clouds_low = table.Column<int>(nullable: false),
                    SixteenDaysId = table.Column<int>(nullable: true),
                    SixteenDaysRootObjectID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datums", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Datums_SixteenDaysRootObjects_SixteenDaysId",
                        column: x => x.SixteenDaysId,
                        principalTable: "SixteenDaysRootObjects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Datums_Weathers_weatherId",
                        column: x => x.weatherId,
                        principalTable: "Weathers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Datums_SixteenDaysId",
                table: "Datums",
                column: "SixteenDaysId");

            migrationBuilder.CreateIndex(
                name: "IX_Datums_weatherId",
                table: "Datums",
                column: "weatherId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Datums");

            migrationBuilder.DropTable(
                name: "SixteenDaysRootObjects");

            migrationBuilder.DropTable(
                name: "Weathers");
        }
    }
}
