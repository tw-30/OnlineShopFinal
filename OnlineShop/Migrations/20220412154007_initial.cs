using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineShop.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(nullable: false),
                    Code = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 1, "Laptops" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 2, "Computers" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Name" },
                values: new object[] { 3, "Mobile Phones" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductID", "CategoryID", "Code", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 1, "MacAir", "Macbook Air ", 999m },
                    { 2, 1, "Omen16T", "Omen by HP Laptop 16t-b100", 1099.99m },
                    { 3, 1, "Victus16T", "Victus by HP 16T-d100", 849.99m },
                    { 4, 1, "GalaxyBook", "Samsung Galaxy Book Pro 360", 999m },
                    { 5, 1, "Inspiron3511", "Dell Inspiron 3511", 439.99m },
                    { 6, 1, "VivoBook", "Asus Vivobook", 319.99m },
                    { 7, 2, "EnvyPC", "HP Envy Desktop", 689.99m },
                    { 8, 2, "Vengance", "Corsair Vengance a7200", 1999.99m },
                    { 9, 3, "Iphone13Pro", "Iphone 13 Pro", 999.99m },
                    { 10, 3, "GalaxyS22", "Samsung Galaxy S22 Ultra", 399.99m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
