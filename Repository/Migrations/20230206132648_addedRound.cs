using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedRound : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "02/06/2023 13:26:48",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "02/06/2023 11:33:41");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "02/06/2023 11:33:41",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "02/06/2023 13:26:48");
        }
    }
}
