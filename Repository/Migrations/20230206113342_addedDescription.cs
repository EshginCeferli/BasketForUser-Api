using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Monday, February 6, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Saturday, February 4, 2023");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "02/06/2023 11:33:41",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "02/04/2023 18:08:03");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BasketProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Monday, February 6, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Saturday, February 4, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Basket",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Monday, February 6, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Saturday, February 4, 2023");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Product");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Saturday, February 4, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Monday, February 6, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "02/04/2023 18:08:03",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "02/06/2023 11:33:41");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BasketProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Saturday, February 4, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Monday, February 6, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Basket",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Saturday, February 4, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Monday, February 6, 2023");
        }
    }
}
