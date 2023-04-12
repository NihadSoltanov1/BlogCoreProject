using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class today21migrationblog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Writers_Writers_WriterID1",
                table: "Writers");

            migrationBuilder.DropIndex(
                name: "IX_Writers_WriterID1",
                table: "Writers");

            migrationBuilder.DropColumn(
                name: "WriterID1",
                table: "Writers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "WriterID1",
                table: "Writers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Writers_WriterID1",
                table: "Writers",
                column: "WriterID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Writers_Writers_WriterID1",
                table: "Writers",
                column: "WriterID1",
                principalTable: "Writers",
                principalColumn: "WriterID");

        }
    }
}
