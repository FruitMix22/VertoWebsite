using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VertoTask.Migrations
{
    /// <inheritdoc />
    public partial class FooterVars : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Section1_Image1",
                table: "HomepageContents");

            migrationBuilder.DropColumn(
                name: "Section2_Image1",
                table: "HomepageContents");

            migrationBuilder.DropColumn(
                name: "Section4_Image1",
                table: "HomepageContents");

            migrationBuilder.DropColumn(
                name: "LogoImage",
                table: "GlobalContents");

            migrationBuilder.DropColumn(
                name: "QuestionBox",
                table: "GlobalContents");

            migrationBuilder.AddColumn<string>(
                name: "AdressLine1",
                table: "GlobalContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdressLine2",
                table: "GlobalContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdressName",
                table: "GlobalContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "CoopyRightext",
                table: "GlobalContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "TermsConditions",
                table: "GlobalContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WebsiteMakerText",
                table: "GlobalContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "interactionText1",
                table: "GlobalContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "interactionText2",
                table: "GlobalContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "phoneNumber",
                table: "GlobalContents",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "GlobalContents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdressLine1", "AdressLine2", "AdressName", "ContactEmail", "CoopyRightext", "TermsConditions", "WebsiteMakerText", "interactionText1", "interactionText2", "phoneNumber" },
                values: new object[] { "The Crabtree, Quinton Green Park,", "Quinton, Northampton, NN7 2EG", "Head Office", "hello@iotaofficefurniture.co.uk", "© iOTA Interiors Limited T/A iOTA Office Furniture", "Terms and conditions", "Site by Verto", "Connect with us", "Like us", "+44(0) 1604289630" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdressLine1",
                table: "GlobalContents");

            migrationBuilder.DropColumn(
                name: "AdressLine2",
                table: "GlobalContents");

            migrationBuilder.DropColumn(
                name: "AdressName",
                table: "GlobalContents");

            migrationBuilder.DropColumn(
                name: "CoopyRightext",
                table: "GlobalContents");

            migrationBuilder.DropColumn(
                name: "TermsConditions",
                table: "GlobalContents");

            migrationBuilder.DropColumn(
                name: "WebsiteMakerText",
                table: "GlobalContents");

            migrationBuilder.DropColumn(
                name: "interactionText1",
                table: "GlobalContents");

            migrationBuilder.DropColumn(
                name: "interactionText2",
                table: "GlobalContents");

            migrationBuilder.DropColumn(
                name: "phoneNumber",
                table: "GlobalContents");

            migrationBuilder.AddColumn<byte[]>(
                name: "Section1_Image1",
                table: "HomepageContents",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Section2_Image1",
                table: "HomepageContents",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "Section4_Image1",
                table: "HomepageContents",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "LogoImage",
                table: "GlobalContents",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "QuestionBox",
                table: "GlobalContents",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "GlobalContents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ContactEmail", "LogoImage", "QuestionBox" },
                values: new object[] { "coreymedlandweal@gmail.com", null, null });

            migrationBuilder.UpdateData(
                table: "HomepageContents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Section1_Image1", "Section2_Image1", "Section4_Image1" },
                values: new object[] { null, null, null });
        }
    }
}
