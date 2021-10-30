using Microsoft.EntityFrameworkCore.Migrations;

namespace MB.Infrastructure.Migrations
{
    public partial class CommentAddedAmended2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Emial",
                schema: "dbo",
                table: "Comments",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                schema: "dbo",
                table: "Comments",
                newName: "Emial");
        }
    }
}
