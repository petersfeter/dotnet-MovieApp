using Microsoft.EntityFrameworkCore.Migrations;

namespace MvcMovie.Migrations
{
    public partial class AddMovieTypeRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "MovieType");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "MovieType",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movie",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 30);

            migrationBuilder.AddColumn<int>(
                name: "MovieTypeFK",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TypeId",
                table: "Movie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_MovieTypeFK",
                table: "Movie",
                column: "MovieTypeFK");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_MovieType_MovieTypeFK",
                table: "Movie",
                column: "MovieTypeFK",
                principalTable: "MovieType",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_MovieType_MovieTypeFK",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_MovieTypeFK",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "MovieType");

            migrationBuilder.DropColumn(
                name: "MovieTypeFK",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "TypeId",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "MovieType",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Genre",
                table: "Movie",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
