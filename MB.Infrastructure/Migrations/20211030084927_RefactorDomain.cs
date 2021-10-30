using Microsoft.EntityFrameworkCore.Migrations;

namespace MB.Infrastructure.Migrations
{
    public partial class RefactorDomain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CommentId",
                schema: "dbo",
                table: "Comments",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ArticleCategoryId",
                schema: "dbo",
                table: "ArticleCategories",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                schema: "dbo",
                table: "Article",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "Comments",
                newName: "CommentId");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "ArticleCategories",
                newName: "ArticleCategoryId");

            migrationBuilder.RenameColumn(
                name: "Id",
                schema: "dbo",
                table: "Article",
                newName: "ArticleId");
        }
    }
}
