using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WithYou_project.Migrations
{
    /// <inheritdoc />
    public partial class testLogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthViewModels",
                table: "AuthViewModels");

            migrationBuilder.RenameTable(
                name: "AuthViewModels",
                newName: "AuthViewModel");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthViewModel",
                table: "AuthViewModel",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AuthViewModel",
                table: "AuthViewModel");

            migrationBuilder.RenameTable(
                name: "AuthViewModel",
                newName: "AuthViewModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AuthViewModels",
                table: "AuthViewModels",
                column: "Id");
        }
    }
}
