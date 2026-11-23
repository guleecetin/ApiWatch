using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiWatch.Infrastructure.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureMonitor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Monitors",
                type: "character varying(2048)",
                maxLength: 2048,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Monitors",
                type: "character varying(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_Enabled_NextRunAt",
                table: "Monitors",
                columns: new[] { "Enabled", "NextRunAt" });

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_OrganizationId",
                table: "Monitors",
                column: "OrganizationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Monitors_Enabled_NextRunAt",
                table: "Monitors");

            migrationBuilder.DropIndex(
                name: "IX_Monitors_OrganizationId",
                table: "Monitors");

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Monitors",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(2048)",
                oldMaxLength: 2048);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Monitors",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(200)",
                oldMaxLength: 200);
        }
    }
}
