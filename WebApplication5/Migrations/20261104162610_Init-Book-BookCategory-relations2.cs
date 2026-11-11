using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication5.Migrations
{
    /// <inheritdoc />
    public partial class InitBookBookCategoryrelations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategoryRelationBook_BookCategories_CategoryBookId",
                table: "BookCategoryRelationBook");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategoryRelationBook_Books_BookId",
                table: "BookCategoryRelationBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategoryRelationBook",
                table: "BookCategoryRelationBook");

            migrationBuilder.RenameTable(
                name: "BookCategoryRelationBook",
                newName: "BookCategoryRelations");

            migrationBuilder.RenameIndex(
                name: "IX_BookCategoryRelationBook_CategoryBookId",
                table: "BookCategoryRelations",
                newName: "IX_BookCategoryRelations_CategoryBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategoryRelations",
                table: "BookCategoryRelations",
                columns: new[] { "BookId", "CategoryBookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategoryRelations_BookCategories_CategoryBookId",
                table: "BookCategoryRelations",
                column: "CategoryBookId",
                principalTable: "BookCategories",
                principalColumn: "BookCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategoryRelations_Books_BookId",
                table: "BookCategoryRelations",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookCategoryRelations_BookCategories_CategoryBookId",
                table: "BookCategoryRelations");

            migrationBuilder.DropForeignKey(
                name: "FK_BookCategoryRelations_Books_BookId",
                table: "BookCategoryRelations");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BookCategoryRelations",
                table: "BookCategoryRelations");

            migrationBuilder.RenameTable(
                name: "BookCategoryRelations",
                newName: "BookCategoryRelationBook");

            migrationBuilder.RenameIndex(
                name: "IX_BookCategoryRelations_CategoryBookId",
                table: "BookCategoryRelationBook",
                newName: "IX_BookCategoryRelationBook_CategoryBookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BookCategoryRelationBook",
                table: "BookCategoryRelationBook",
                columns: new[] { "BookId", "CategoryBookId" });

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategoryRelationBook_BookCategories_CategoryBookId",
                table: "BookCategoryRelationBook",
                column: "CategoryBookId",
                principalTable: "BookCategories",
                principalColumn: "BookCategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookCategoryRelationBook_Books_BookId",
                table: "BookCategoryRelationBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "BookId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
