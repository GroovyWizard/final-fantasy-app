using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace backend.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Game = table.Column<string>(type: "TEXT", nullable: true),
                    ImgUrl = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                });

                 migrationBuilder.InsertData(
                    table: "Characters",
                    columns: new[] { "Id", "Name", "Game", "ImgUrl" },
                    values: new object[] { 1, "Sephiroth", "Final Fantasy VII", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fwww.mariowiki.com%2Fimages%2Fthumb%2Fd%2Fd6%2FSSBU_Sephiroth.png%2F1200px-SSBU_Sephiroth.png&f=1&nofb=1" });
                  migrationBuilder.InsertData(
                    table: "Characters",
                    columns: new[] { "Id", "Name", "Game", "ImgUrl" },
                    values: new object[] { 3, "Garland", "Final Fantasy", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fvignette.wikia.nocookie.net%2Ffinalfantasy%2Fimages%2F0%2F0e%2FDFF2015_Garland_Render.png%2Frevision%2Flatest%3Fcb%3D20160811183610&f=1&nofb=1" 
                    });

                      migrationBuilder.InsertData(
                    table: "Characters",
                    columns: new[] { "Id", "Name", "Game", "ImgUrl" },
                    values: new object[] { 2, "Cloud", "Final Fantasy VII", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fvignette.wikia.nocookie.net%2Ffinalfantasy%2Fimages%2F6%2F69%2FSSBU_Cloud_Strife_render_002.png%2Frevision%2Flatest%2Fscale-to-width-down%2F2000%3Fcb%3D20180918182717&f=1&nofb=1" 
                    });

                      migrationBuilder.InsertData(
                    table: "Characters",
                    columns: new[] { "Id", "Name", "Game", "ImgUrl" },
                    values: new object[] { 4, "Noctis Lucius Caelum", "Final Fantasy XV", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fvignette.wikia.nocookie.net%2Ffinalfantasy2%2Fimages%2Fa%2Faf%2FNoctis_Render.png%2Frevision%2Flatest%3Fcb%3D20130612210839%26path-prefix%3Dde&f=1&nofb=1" 
                    });

                      migrationBuilder.InsertData(
                    table: "Characters",
                    columns: new[] { "Id", "Name", "Game", "ImgUrl" },
                    values: new object[] { 5, "Cecil Harvey", "Final Fantasy IV", "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Fgamepedia.cursecdn.com%2Fdissidiafinalfantasynt_gamepedia_en%2Fd%2Fde%2FProfile_Cecil_Harvey.png&f=1&nofb=1" 
                    });
        }   

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");
        }
    }
}
