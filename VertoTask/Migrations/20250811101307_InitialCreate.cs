using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VertoTask.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GlobalContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LogoImage = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    LogoImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HeaderLinks = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionBox = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    QuestionBoxPath = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GlobalContents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HomepageContents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section1_Image1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Section2_Image1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Section4_Image1 = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    Section1_Image1Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section2_Image1Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section4_Image1Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section1_TextOverCarousel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section2_Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section2_SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section2_ButtonText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section3_FloatingText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section4_GlobalText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section4_Image1Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section4_Image1Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section4_Image2Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section4_Image3Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section5_Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section5_SubTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section5_Image1Text = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Section5_Image2Text = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HomepageContents", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "GlobalContents",
                columns: new[] { "Id", "ContactEmail", "HeaderLinks", "LogoImage", "LogoImagePath", "QuestionBox", "QuestionBoxPath" },
                values: new object[] { 1, "coreymedlandweal@gmail.com", "[\"Home\",\"Services\",\"Sustainability\",\"Our work\",\"Resources\",\"About IOTA\",\"Contact us\"]", null, "images/logo.png", null, "images/Rectangle 121.png" });

            migrationBuilder.InsertData(
                table: "HomepageContents",
                columns: new[] { "Id", "Section1_Image1", "Section1_Image1Path", "Section1_TextOverCarousel", "Section2_ButtonText", "Section2_Image1", "Section2_Image1Path", "Section2_SubTitle", "Section2_Title", "Section3_FloatingText", "Section4_GlobalText", "Section4_Image1", "Section4_Image1Description", "Section4_Image1Path", "Section4_Image1Title", "Section4_Image2Title", "Section4_Image3Title", "Section5_Image1Text", "Section5_Image2Text", "Section5_SubTitle", "Section5_Title" },
                values: new object[] { 1, null, "images/image4.png", "Creating Exceptional Workspaces", "WHAT WE DO", null, "images/circle-icons.png", "Specialists in transforming commercial spaces into agile, functional and empowering environments.", "Custom built design & furniture solutions", "Explore our latest work...", "VIEW MORE->", null, "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam.", "images/image2.png", "Case Study Name Here", "Case Study Name Here", "Case Study Name Here", "WATCH THE VIDEO", "ABOUT iOTA", "Find out who we are, why we do it and why we love what we do.", "Discover more about iOTA" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GlobalContents");

            migrationBuilder.DropTable(
                name: "HomepageContents");
        }
    }
}
