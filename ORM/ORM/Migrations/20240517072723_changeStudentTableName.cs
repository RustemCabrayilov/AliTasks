using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ORM.Migrations
{
    /// <inheritdoc />
    public partial class changeStudentTableName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "TestStudent");

            migrationBuilder.RenameIndex(
                name: "IX_Students_GroupId",
                table: "TestStudent",
                newName: "IX_TestStudent_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TestStudent",
                table: "TestStudent",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddress_TestStudent_StudentId",
                table: "StudentAddress",
                column: "StudentId",
                principalTable: "TestStudent",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TestStudent_Groups_GroupId",
                table: "TestStudent",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentAddress_TestStudent_StudentId",
                table: "StudentAddress");

            migrationBuilder.DropForeignKey(
                name: "FK_TestStudent_Groups_GroupId",
                table: "TestStudent");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TestStudent",
                table: "TestStudent");

            migrationBuilder.RenameTable(
                name: "TestStudent",
                newName: "Students");

            migrationBuilder.RenameIndex(
                name: "IX_TestStudent_GroupId",
                table: "Students",
                newName: "IX_Students_GroupId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentAddress_Students_StudentId",
                table: "StudentAddress",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Groups_GroupId",
                table: "Students",
                column: "GroupId",
                principalTable: "Groups",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
