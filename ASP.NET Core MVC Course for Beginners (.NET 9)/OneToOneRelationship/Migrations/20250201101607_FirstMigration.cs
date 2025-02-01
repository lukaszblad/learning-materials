using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OneToOneRelationship.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MyItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    SerialNumberId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MyItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SerialNumber",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MyItemId = table.Column<int>(type: "int", nullable: true),
                    ItemId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SerialNumber", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SerialNumber_MyItems_ItemId",
                        column: x => x.ItemId,
                        principalTable: "MyItems",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "MyItems",
                columns: new[] { "Id", "Name", "Price", "SerialNumberId" },
                values: new object[] { 4, "microphone", 40.0, 10 });

            migrationBuilder.InsertData(
                table: "SerialNumber",
                columns: new[] { "Id", "ItemId", "MyItemId", "Name" },
                values: new object[] { 10, null, 4, "MIC344" });

            migrationBuilder.CreateIndex(
                name: "IX_SerialNumber_ItemId",
                table: "SerialNumber",
                column: "ItemId",
                unique: true,
                filter: "[ItemId] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SerialNumber");

            migrationBuilder.DropTable(
                name: "MyItems");
        }
    }
}
