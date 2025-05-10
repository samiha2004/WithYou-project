using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WithYou_project.Migrations
{
    /// <inheritdoc />
    public partial class RelaPsychologistMessageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PsychologistId",
                table: "Message",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Message_PsychologistId",
                table: "Message",
                column: "PsychologistId");

            migrationBuilder.AddForeignKey(
                name: "FK_Message_Psychologiest_PsychologistId",
                table: "Message",
                column: "PsychologistId",
                principalTable: "Psychologiest",
                principalColumn: "PsychologistId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Message_Psychologiest_PsychologistId",
                table: "Message");

            migrationBuilder.DropIndex(
                name: "IX_Message_PsychologistId",
                table: "Message");

            migrationBuilder.DropColumn(
                name: "PsychologistId",
                table: "Message");
        }
    }
}
