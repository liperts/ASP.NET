using Microsoft.EntityFrameworkCore.Migrations;

namespace assignment02.Migrations
{
    public partial class ChangePhoneAttribute : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Member",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Member",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
