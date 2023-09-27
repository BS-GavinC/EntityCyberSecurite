using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityCyberSecurite.Migrations
{
    public partial class removeNotMapped : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "T_user",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_T_user_RoleId",
                table: "T_user",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_T_user_roles_RoleId",
                table: "T_user",
                column: "RoleId",
                principalTable: "roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_T_user_roles_RoleId",
                table: "T_user");

            migrationBuilder.DropIndex(
                name: "IX_T_user_RoleId",
                table: "T_user");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "T_user");
        }
    }
}
