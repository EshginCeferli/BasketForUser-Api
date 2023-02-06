using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class config : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,8)",
                oldPrecision: 10,
                oldScale: 8);

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "02/06/2023 13:29:06",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "02/06/2023 13:26:48");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "decimal(10,8)",
                precision: 10,
                scale: 8,
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "02/06/2023 13:26:48",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "02/06/2023 13:29:06");
        }
    }
}
