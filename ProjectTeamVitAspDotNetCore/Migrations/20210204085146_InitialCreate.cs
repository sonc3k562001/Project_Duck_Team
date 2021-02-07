using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTeamVitAspDotNetCore.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    BrandId = table.Column<string>(nullable: false),
                    BrandName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    IdCategory = table.Column<string>(nullable: false),
                    TypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.IdCategory);
                });

            migrationBuilder.CreateTable(
                name: "Certify",
                columns: table => new
                {
                    CertifyId = table.Column<string>(nullable: false),
                    CertifyType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certify", x => x.CertifyId);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    ColorId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.ColorId);
                });

            migrationBuilder.CreateTable(
                name: "Dim",
                columns: table => new
                {
                    DimId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    DimCrt = table.Column<decimal>(nullable: true),
                    DimPcs = table.Column<decimal>(nullable: true),
                    DimGm = table.Column<decimal>(nullable: true),
                    DimRate = table.Column<decimal>(nullable: true),
                    DimAmt = table.Column<decimal>(nullable: true),
                    Certify = table.Column<string>(nullable: true),
                    DimSize = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dim", x => x.DimId);
                });

            migrationBuilder.CreateTable(
                name: "DimInfo",
                columns: table => new
                {
                    DimInfoId = table.Column<string>(nullable: false),
                    DimType = table.Column<string>(nullable: true),
                    DimSubType = table.Column<string>(nullable: true),
                    DimCrt = table.Column<string>(nullable: true),
                    DimPrice = table.Column<decimal>(nullable: true),
                    DimImg = table.Column<byte[]>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimInfo", x => x.DimInfoId);
                });

            migrationBuilder.CreateTable(
                name: "Metal",
                columns: table => new
                {
                    MetalId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    MetalCrt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metal", x => x.MetalId);
                });

            migrationBuilder.CreateTable(
                name: "PostNew",
                columns: table => new
                {
                    CreateTime = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Content = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostNew", x => x.CreateTime);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    StringRole = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stone",
                columns: table => new
                {
                    StoneId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: true),
                    StoneGm = table.Column<decimal>(nullable: true),
                    StoneCrt = table.Column<decimal>(nullable: true),
                    StoneRate = table.Column<decimal>(nullable: true),
                    StoneAmt = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stone", x => x.StoneId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Email = table.Column<string>(nullable: false),
                    Fname = table.Column<string>(nullable: true),
                    Lname = table.Column<string>(nullable: true),
                    Bdate = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ConfirmPassword = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    Avatar = table.Column<string>(nullable: true),
                    Gender = table.Column<string>(nullable: true),
                    Eable = table.Column<bool>(nullable: true),
                    IdRole = table.Column<string>(nullable: true),
                    IdRoleNavigationId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Email);
                    table.ForeignKey(
                        name: "FK_User_Role_IdRoleNavigationId",
                        column: x => x.IdRoleNavigationId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    PdId = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Image1 = table.Column<byte[]>(nullable: true),
                    Image2 = table.Column<byte[]>(nullable: true),
                    ColorId = table.Column<string>(nullable: true),
                    Size = table.Column<double>(nullable: true),
                    BrandId = table.Column<string>(nullable: true),
                    DimId = table.Column<string>(nullable: true),
                    StoneId = table.Column<string>(nullable: true),
                    IdCategory = table.Column<string>(nullable: true),
                    MetalId = table.Column<string>(nullable: true),
                    CategoryIdCategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.PdId);
                    table.ForeignKey(
                        name: "FK_Product_Brand_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brand",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryIdCategory",
                        column: x => x.CategoryIdCategory,
                        principalTable: "Category",
                        principalColumn: "IdCategory",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Color_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Color",
                        principalColumn: "ColorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Dim_DimId",
                        column: x => x.DimId,
                        principalTable: "Dim",
                        principalColumn: "DimId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Metal_MetalId",
                        column: x => x.MetalId,
                        principalTable: "Metal",
                        principalColumn: "MetalId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Stone_StoneId",
                        column: x => x.StoneId,
                        principalTable: "Stone",
                        principalColumn: "StoneId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    CreateTime = table.Column<DateTime>(nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    EmailNavigationEmail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_User_EmailNavigationEmail",
                        column: x => x.EmailNavigationEmail,
                        principalTable: "User",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OdId = table.Column<string>(nullable: false),
                    PdId = table.Column<string>(nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    TotalPrice = table.Column<decimal>(nullable: true),
                    OdId1 = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.OdId);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OdId1",
                        column: x => x.OdId1,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_PdId",
                        column: x => x.PdId,
                        principalTable: "Product",
                        principalColumn: "PdId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_EmailNavigationEmail",
                table: "Order",
                column: "EmailNavigationEmail");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OdId1",
                table: "OrderDetail",
                column: "OdId1");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_PdId",
                table: "OrderDetail",
                column: "PdId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_BrandId",
                table: "Product",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryIdCategory",
                table: "Product",
                column: "CategoryIdCategory");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ColorId",
                table: "Product",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DimId",
                table: "Product",
                column: "DimId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MetalId",
                table: "Product",
                column: "MetalId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_StoneId",
                table: "Product",
                column: "StoneId");

            migrationBuilder.CreateIndex(
                name: "IX_User_IdRoleNavigationId",
                table: "User",
                column: "IdRoleNavigationId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certify");

            migrationBuilder.DropTable(
                name: "DimInfo");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "PostNew");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Dim");

            migrationBuilder.DropTable(
                name: "Metal");

            migrationBuilder.DropTable(
                name: "Stone");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
