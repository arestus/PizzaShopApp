using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaOrderingSystemWebMVC.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PizzaDetails",
                columns: table => new
                {
                    PizzaNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PizzaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PizzaPrice = table.Column<int>(type: "int", nullable: true),
                    PizzaType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaDetails", x => x.PizzaNumber);
                });

            migrationBuilder.CreateTable(
                name: "Toppings",
                columns: table => new
                {
                    ToppingNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ToppingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ToppingPrice = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Toppings", x => x.ToppingNumber);
                });

            migrationBuilder.CreateTable(
                name: "UserLoginDetails",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_email = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    User_name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    User_password = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    User_Address = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Phone_No = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__B0FBA213F7B4106B", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TotalAmount = table.Column<double>(type: "float", nullable: true),
                    DelivaryCharges = table.Column<int>(type: "int", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_UserLoginDetails_UserId",
                        column: x => x.UserId,
                        principalTable: "UserLoginDetails",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    ItemNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: true),
                    PizzaNumber = table.Column<int>(type: "int", nullable: true),
                    PizzaNumberNavigationPizzaNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.ItemNumber);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderDetails_PizzaDetails_PizzaNumberNavigationPizzaNumber",
                        column: x => x.PizzaNumberNavigationPizzaNumber,
                        principalTable: "PizzaDetails",
                        principalColumn: "PizzaNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderItemDetails",
                columns: table => new
                {
                    ItemNumber = table.Column<int>(type: "int", nullable: false),
                    ToppingNumber = table.Column<int>(type: "int", nullable: false),
                    ItemNumberNavigationItemNumber = table.Column<int>(type: "int", nullable: true),
                    ToppingNumberNavigationToppingNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemDetails", x => new { x.ItemNumber, x.ToppingNumber });
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_OrderDetails_ItemNumberNavigationItemNumber",
                        column: x => x.ItemNumberNavigationItemNumber,
                        principalTable: "OrderDetails",
                        principalColumn: "ItemNumber",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OrderItemDetails_Toppings_ToppingNumberNavigationToppingNumber",
                        column: x => x.ToppingNumberNavigationToppingNumber,
                        principalTable: "Toppings",
                        principalColumn: "ToppingNumber",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_PizzaNumberNavigationPizzaNumber",
                table: "OrderDetails",
                column: "PizzaNumberNavigationPizzaNumber");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDetails_ItemNumberNavigationItemNumber",
                table: "OrderItemDetails",
                column: "ItemNumberNavigationItemNumber");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemDetails_ToppingNumberNavigationToppingNumber",
                table: "OrderItemDetails",
                column: "ToppingNumberNavigationToppingNumber");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItemDetails");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Toppings");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PizzaDetails");

            migrationBuilder.DropTable(
                name: "UserLoginDetails");
        }
    }
}
