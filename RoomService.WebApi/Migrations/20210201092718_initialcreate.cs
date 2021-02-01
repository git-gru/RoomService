using Microsoft.EntityFrameworkCore.Migrations;

namespace RoomService.WebApi.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SiteName = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    PromoCode = table.Column<string>(type: "TEXT", nullable: true),
                    IsBonusActivated = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "IsBonusActivated", "PromoCode", "SiteName" },
                values: new object[] { 1L, "Description1", false, "PromoCode1", "SiteConstructor.io" });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "IsBonusActivated", "PromoCode", "SiteName" },
                values: new object[] { 2L, "Description2", false, "PromoCode2", "AppVision.io" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
