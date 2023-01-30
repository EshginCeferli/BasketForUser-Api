using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class ConvertDateString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "Sunday, January 29, 2023",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 28, 6, 43, 53, 940, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.AlterColumn<string>(
                name: "CreateDate",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "01/29/2023 18:22:57",
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 28, 6, 43, 53, 941, DateTimeKind.Utc).AddTicks(6951));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 6, 43, 53, 940, DateTimeKind.Utc).AddTicks(4098),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "Sunday, January 29, 2023");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 6, 43, 53, 941, DateTimeKind.Utc).AddTicks(6951),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldDefaultValue: "01/29/2023 18:22:57");
        }
    }
}
