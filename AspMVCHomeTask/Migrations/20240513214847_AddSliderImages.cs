using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspMVCHomeTask.Migrations
{
    public partial class AddSliderImages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SliderImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Order = table.Column<int>(type: "int", nullable: false),
                    SliderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SliderImages_Sliders_SliderId",
                        column: x => x.SliderId,
                        principalTable: "Sliders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SliderImages_SliderId",
                table: "SliderImages",
                column: "SliderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SliderImages");
        }
    }
}
