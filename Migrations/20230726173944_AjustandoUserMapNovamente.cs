using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Migrations
{
    /// <inheritdoc />
    public partial class AjustandoUserMapNovamente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_PostId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_UserId",
                table: "UserRole");

            migrationBuilder.RenameColumn(
                name: "PostId",
                table: "UserRole",
                newName: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_RoleId",
                table: "UserRole",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_RoleId",
                table: "UserRole");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRole_UserId",
                table: "UserRole");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "UserRole",
                newName: "PostId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_PostId",
                table: "UserRole",
                column: "PostId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRole_UserId",
                table: "UserRole",
                column: "UserId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
