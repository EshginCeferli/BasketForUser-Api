using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class removeCategoryID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Saturday, February 4, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Friday, February 3, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "02/04/2023 17:53:14",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "02/03/2023 07:53:17");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BasketProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Saturday, February 4, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Friday, February 3, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Basket",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Saturday, February 4, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Friday, February 3, 2023");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Friday, February 3, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Saturday, February 4, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "02/03/2023 07:53:17",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "02/04/2023 17:53:14");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "BasketProduct",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Friday, February 3, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Saturday, February 4, 2023");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Basket",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Friday, February 3, 2023",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Saturday, February 4, 2023");
        }
    }
}
