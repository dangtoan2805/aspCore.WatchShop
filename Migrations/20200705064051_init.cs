using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace aspCore.WatchShop.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(maxLength: 16, nullable: true),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Fees",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tax = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    Transport = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Infos",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Logo = table.Column<string>(maxLength: 30, nullable: true),
                    TitleWeb = table.Column<string>(maxLength: 100, nullable: true),
                    NameShop = table.Column<string>(maxLength: 100, nullable: true),
                    Desription = table.Column<string>(maxLength: 500, nullable: true),
                    Phone = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 150, nullable: true),
                    Email = table.Column<string>(maxLength: 50, nullable: true),
                    LinkFB = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infos", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    Icon = table.Column<string>(maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    FromDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    ToDate = table.Column<DateTime>(type: "smalldatetime", nullable: true),
                    isAlways = table.Column<bool>(nullable: true, defaultValue: false),
                    Status = table.Column<bool>(nullable: true, defaultValue: true),
                    Discount = table.Column<decimal>(type: "decimal(2,2)", nullable: false),
                    Amount = table.Column<int>(nullable: false),
                    TypePromotion = table.Column<bool>(nullable: true, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TypeWires",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeWires", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nchar(25)", maxLength: 25, nullable: true),
                    Password = table.Column<string>(maxLength: 25, nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BillPromotions",
                columns: table => new
                {
                    PromotionID = table.Column<int>(nullable: false),
                    MinTotal = table.Column<int>(nullable: true),
                    NumberProduct = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillPromotions", x => x.PromotionID);
                    table.ForeignKey(
                        name: "FK_BillPromotions_Promotions_PromotionID",
                        column: x => x.PromotionID,
                        principalTable: "Promotions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: true),
                    isShow = table.Column<bool>(nullable: true, defaultValue: true),
                    isDel = table.Column<bool>(nullable: true, defaultValue: false),
                    Price = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    SaleCount = table.Column<int>(nullable: false, defaultValue: 0),
                    CategoryID = table.Column<int>(nullable: false),
                    TypeWireID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_TypeWires_TypeWireID",
                        column: x => x.TypeWireID,
                        principalTable: "TypeWires",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(type: "smalldatetime", nullable: false),
                    Note = table.Column<string>(maxLength: 150, nullable: true),
                    BillPromotion = table.Column<decimal>(type: "decimal(2,2)", nullable: false, defaultValue: 0m),
                    TransportFee = table.Column<int>(nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(2,2)", nullable: false, defaultValue: 0m),
                    Status = table.Column<int>(nullable: false, defaultValue: 0),
                    CustomerID = table.Column<int>(nullable: false),
                    UserID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductDetails",
                columns: table => new
                {
                    ProductID = table.Column<int>(nullable: false),
                    Images = table.Column<string>(nullable: true),
                    TypeGlass = table.Column<string>(maxLength: 30, nullable: true),
                    TypeBorder = table.Column<string>(maxLength: 30, nullable: true),
                    TypeMachine = table.Column<string>(maxLength: 30, nullable: true),
                    Parameter = table.Column<string>(maxLength: 30, nullable: true),
                    ResistWater = table.Column<string>(maxLength: 30, nullable: true),
                    Warranty = table.Column<string>(maxLength: 30, nullable: true),
                    Brand = table.Column<string>(maxLength: 30, nullable: true),
                    Origin = table.Column<string>(maxLength: 30, nullable: true),
                    Color = table.Column<string>(maxLength: 30, nullable: true),
                    Func = table.Column<string>(maxLength: 30, nullable: true),
                    DescriptionProduct = table.Column<string>(maxLength: 1500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductDetails", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_ProductDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PromotionDetails",
                columns: table => new
                {
                    PromotionID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PromotionDetails", x => new { x.ProductID, x.PromotionID });
                    table.ForeignKey(
                        name: "FK_PromotionDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PromotionDetails_Promotions_PromotionID",
                        column: x => x.PromotionID,
                        principalTable: "Promotions",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderID = table.Column<int>(nullable: false),
                    ProductID = table.Column<int>(nullable: false),
                    Quantity = table.Column<byte>(nullable: false),
                    Price = table.Column<int>(nullable: false),
                    Promotion = table.Column<decimal>(type: "decimal(2,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.OrderID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Products",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductID",
                table: "OrderDetails",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserID",
                table: "Orders",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryID",
                table: "Products",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_Products_TypeWireID",
                table: "Products",
                column: "TypeWireID");

            migrationBuilder.CreateIndex(
                name: "IX_PromotionDetails_PromotionID",
                table: "PromotionDetails",
                column: "PromotionID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BillPromotions");

            migrationBuilder.DropTable(
                name: "Fees");

            migrationBuilder.DropTable(
                name: "Infos");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "ProductDetails");

            migrationBuilder.DropTable(
                name: "PromotionDetails");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "TypeWires");
        }
    }
}
