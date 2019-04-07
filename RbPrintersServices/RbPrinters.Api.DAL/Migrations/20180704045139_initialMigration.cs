using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RbPrinters.Api.DAL.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    BranchName = table.Column<string>(maxLength: 100, nullable: false),
                    Location = table.Column<string>(maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    Mobile = table.Column<string>(maxLength: 10, nullable: false),
                    MobileAlt = table.Column<string>(maxLength: 10, nullable: true),
                    Phone = table.Column<string>(maxLength: 11, nullable: true),
                    EmailID = table.Column<string>(maxLength: 100, nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ContactPerson = table.Column<string>(maxLength: 50, nullable: true),
                    Mobile = table.Column<string>(maxLength: 10, nullable: false),
                    Home = table.Column<string>(maxLength: 10, nullable: true),
                    Phone = table.Column<string>(maxLength: 11, nullable: true),
                    EmailID = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: false),
                    Pincode = table.Column<string>(maxLength: 6, nullable: true),
                    Comment = table.Column<string>(maxLength: 300, nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatuses",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Status = table.Column<string>(maxLength: 50, nullable: false),
                    Color = table.Column<string>(maxLength: 10, nullable: false),
                    Comment = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatuses", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Mobile = table.Column<string>(maxLength: 10, nullable: false),
                    Home = table.Column<string>(maxLength: 10, nullable: true),
                    Phone = table.Column<string>(maxLength: 11, nullable: true),
                    EmailID = table.Column<string>(maxLength: 20, nullable: true),
                    AccountNumber = table.Column<string>(nullable: true),
                    IFSCNumber = table.Column<string>(maxLength: 15, nullable: true),
                    AccountName = table.Column<string>(maxLength: 100, nullable: true),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    Pincode = table.Column<string>(maxLength: 6, nullable: true),
                    Comment = table.Column<string>(maxLength: 300, nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Role = table.Column<string>(maxLength: 100, nullable: false),
                    Comment = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(maxLength: 10, nullable: false),
                    MoblieNumber_Alt = table.Column<string>(maxLength: 10, nullable: true),
                    EmailID = table.Column<string>(maxLength: 100, nullable: true),
                    HashPassword = table.Column<string>(maxLength: 20, nullable: false),
                    PasswordSalt = table.Column<string>(maxLength: 200, nullable: false),
                    CreateOn = table.Column<DateTime>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    CustomerID = table.Column<Guid>(nullable: false),
                    OrderStatusID = table.Column<Guid>(nullable: false),
                    OrderNumber = table.Column<string>(maxLength: 7, nullable: false),
                    Comment = table.Column<string>(maxLength: 300, nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
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
                        name: "FK_Orders_OrderStatuses_OrderStatusID",
                        column: x => x.OrderStatusID,
                        principalTable: "OrderStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeddingCards",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    SupplierID = table.Column<Guid>(nullable: false),
                    CardNumber = table.Column<string>(maxLength: 15, nullable: false),
                    TotalCards = table.Column<int>(nullable: false),
                    Rate = table.Column<decimal>(nullable: false),
                    PurchaseDate = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<Guid>(nullable: false),
                    ModifiedOn = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<Guid>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeddingCards", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WeddingCards_Suppliers_SupplierID",
                        column: x => x.SupplierID,
                        principalTable: "Suppliers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    UserID = table.Column<Guid>(nullable: false),
                    BranchID = table.Column<Guid>(nullable: false),
                    UserRoleID = table.Column<Guid>(nullable: false),
                    Comments = table.Column<string>(maxLength: 300, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Permissions_Branches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branches",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permissions_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Permissions_UserRoles_UserRoleID",
                        column: x => x.UserRoleID,
                        principalTable: "UserRoles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeddingCardOrders",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    OrderID = table.Column<Guid>(nullable: false),
                    OrderStatusID = table.Column<Guid>(nullable: false),
                    WeddingCardID = table.Column<Guid>(nullable: false),
                    TotalCards = table.Column<int>(nullable: false),
                    TotalPrint = table.Column<int>(nullable: false),
                    TotalColor = table.Column<int>(nullable: false),
                    Rate = table.Column<decimal>(nullable: false),
                    TotalAmount = table.Column<decimal>(nullable: false),
                    Comment = table.Column<string>(maxLength: 300, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeddingCardOrders", x => x.ID);
                    table.ForeignKey(
                        name: "FK_WeddingCardOrders_Orders_OrderID",
                        column: x => x.OrderID,
                        principalTable: "Orders",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeddingCardOrders_OrderStatuses_OrderStatusID",
                        column: x => x.OrderStatusID,
                        principalTable: "OrderStatuses",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WeddingCardOrders_WeddingCards_WeddingCardID",
                        column: x => x.WeddingCardID,
                        principalTable: "WeddingCards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Branches_BranchName",
                table: "Branches",
                column: "BranchName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_Name",
                table: "Customers",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderNumber",
                table: "Orders",
                column: "OrderNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusID",
                table: "Orders",
                column: "OrderStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatuses_Color",
                table: "OrderStatuses",
                column: "Color",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatuses_Status",
                table: "OrderStatuses",
                column: "Status",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_BranchID",
                table: "Permissions",
                column: "BranchID");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_UserID",
                table: "Permissions",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Permissions_UserRoleID",
                table: "Permissions",
                column: "UserRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_Role",
                table: "UserRoles",
                column: "Role",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_EmailID",
                table: "Users",
                column: "EmailID",
                unique: true,
                filter: "[EmailID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_MobileNumber",
                table: "Users",
                column: "MobileNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeddingCardOrders_OrderID",
                table: "WeddingCardOrders",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingCardOrders_OrderStatusID",
                table: "WeddingCardOrders",
                column: "OrderStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingCardOrders_WeddingCardID",
                table: "WeddingCardOrders",
                column: "WeddingCardID");

            migrationBuilder.CreateIndex(
                name: "IX_WeddingCards_CardNumber",
                table: "WeddingCards",
                column: "CardNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_WeddingCards_SupplierID",
                table: "WeddingCards",
                column: "SupplierID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "WeddingCardOrders");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "WeddingCards");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "OrderStatuses");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
