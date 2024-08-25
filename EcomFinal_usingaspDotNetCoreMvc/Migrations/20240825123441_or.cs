using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcomFinalusingaspDotNetCoreMvc.Migrations
{
    /// <inheritdoc />
    public partial class or : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Suser",
                table: "Carts",
                newName: "suser");

            migrationBuilder.RenameColumn(
                name: "Pcat",
                table: "Carts",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PName",
                table: "Carts",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "PImg",
                table: "Carts",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "PId",
                table: "Carts",
                newName: "Id");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Carts",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(double),
                oldType: "float",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "OrderEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobile = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    TransactionId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderId = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderEntities", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderEntities");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Carts");

            migrationBuilder.RenameColumn(
                name: "suser",
                table: "Carts",
                newName: "Suser");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Carts",
                newName: "Pcat");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Carts",
                newName: "PName");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Carts",
                newName: "PImg");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Carts",
                newName: "PId");

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Carts",
                type: "float",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }
    }
}
