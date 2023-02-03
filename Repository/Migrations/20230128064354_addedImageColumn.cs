using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Repository.Migrations
{
    public partial class addedImageColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 6, 43, 53, 940, DateTimeKind.Utc).AddTicks(4098),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 26, 6, 0, 0, 971, DateTimeKind.Utc).AddTicks(4956));

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Product",
                type: "varbinary(max)",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 28, 6, 43, 53, 941, DateTimeKind.Utc).AddTicks(6951),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 26, 6, 0, 0, 974, DateTimeKind.Utc).AddTicks(2471));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Product");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 6, 0, 0, 971, DateTimeKind.Utc).AddTicks(4956),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 28, 6, 43, 53, 940, DateTimeKind.Utc).AddTicks(4098));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreateDate",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2023, 1, 26, 6, 0, 0, 974, DateTimeKind.Utc).AddTicks(2471),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2023, 1, 28, 6, 43, 53, 941, DateTimeKind.Utc).AddTicks(6951));
        }
    }
}
