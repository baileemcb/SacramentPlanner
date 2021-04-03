using Microsoft.EntityFrameworkCore.Migrations;

namespace SacramentPlanner.Migrations
{
    public partial class Changes2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Speaker_SpeakerID",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_SpeakerID",
                table: "Meeting");

            migrationBuilder.AddColumn<int>(
                name: "MeetingID",
                table: "Speaker",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SpeakersID",
                table: "Meeting",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_SpeakersID",
                table: "Meeting",
                column: "SpeakersID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Speaker_SpeakersID",
                table: "Meeting",
                column: "SpeakersID",
                principalTable: "Speaker",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Meeting_Speaker_SpeakersID",
                table: "Meeting");

            migrationBuilder.DropIndex(
                name: "IX_Meeting_SpeakersID",
                table: "Meeting");

            migrationBuilder.DropColumn(
                name: "MeetingID",
                table: "Speaker");

            migrationBuilder.DropColumn(
                name: "SpeakersID",
                table: "Meeting");

            migrationBuilder.CreateIndex(
                name: "IX_Meeting_SpeakerID",
                table: "Meeting",
                column: "SpeakerID");

            migrationBuilder.AddForeignKey(
                name: "FK_Meeting_Speaker_SpeakerID",
                table: "Meeting",
                column: "SpeakerID",
                principalTable: "Speaker",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
