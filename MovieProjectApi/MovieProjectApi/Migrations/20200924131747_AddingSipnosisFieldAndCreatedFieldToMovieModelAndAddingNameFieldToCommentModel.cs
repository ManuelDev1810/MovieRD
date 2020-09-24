using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieProjectApi.Migrations
{
    public partial class AddingSipnosisFieldAndCreatedFieldToMovieModelAndAddingNameFieldToCommentModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Movie",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Sinopsis",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Comment",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Sinopsis",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Comment");
        }
    }
}
