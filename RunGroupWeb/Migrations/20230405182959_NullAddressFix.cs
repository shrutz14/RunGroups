using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RunGroupWeb.Migrations
{
    /// <inheritdoc />
    public partial class NullAddressFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresss_AddressID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "AddressID",
                table: "AspNetUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresss_AddressID",
                table: "AspNetUsers",
                column: "AddressID",
                principalTable: "Addresss",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Addresss_AddressID",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "AddressID",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Addresss_AddressID",
                table: "AspNetUsers",
                column: "AddressID",
                principalTable: "Addresss",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
