using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectTeamVitAspDotNetCore.Migrations
{
    public partial class InitWebDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brand",
                columns: table => new
                {
                    Brand_Id = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    Brand_Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brand", x => x.Brand_Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id_Category = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    Type_Name = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id_Category);
                });

            migrationBuilder.CreateTable(
                name: "Certify",
                columns: table => new
                {
                    Certify_ID = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    Certify_Type = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certify", x => x.Certify_ID);
                });

            migrationBuilder.CreateTable(
                name: "Color",
                columns: table => new
                {
                    Color_Id = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Color", x => x.Color_Id);
                });

            migrationBuilder.CreateTable(
                name: "Dim",
                columns: table => new
                {
                    Dim_Id = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Dim_Crt = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    Dim_Pcs = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    Dim_Gm = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    Dim_Rate = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    Dim_Amt = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    Certify = table.Column<string>(maxLength: 250, nullable: true),
                    Dim_Size = table.Column<decimal>(type: "numeric(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dim", x => x.Dim_Id);
                });

            migrationBuilder.CreateTable(
                name: "DimInfo",
                columns: table => new
                {
                    DimInfoId = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    DimType = table.Column<string>(maxLength: 50, nullable: true),
                    DimSubType = table.Column<string>(maxLength: 50, nullable: true),
                    DimCrt = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    DimPrice = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    DimImg = table.Column<byte[]>(type: "image", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DimInfo", x => x.DimInfoId);
                });

            migrationBuilder.CreateTable(
                name: "Metal",
                columns: table => new
                {
                    Metal_Id = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Metal_Crt = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Metal", x => x.Metal_Id);
                });

            migrationBuilder.CreateTable(
                name: "POST_NEW",
                columns: table => new
                {
                    Create_Time = table.Column<DateTime>(type: "date", nullable: false),
                    Title = table.Column<string>(maxLength: 250, nullable: true),
                    Body = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_POST_NEW", x => x.Create_Time);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<string>(fixedLength: true, maxLength: 10, nullable: false),
                    String_Role = table.Column<string>(maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stone",
                columns: table => new
                {
                    Stone_Id = table.Column<string>(fixedLength: true, maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Stone_Gm = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    Stone_Crt = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    Stone_Rate = table.Column<decimal>(type: "numeric(10, 2)", nullable: true),
                    Stone_Amt = table.Column<decimal>(type: "numeric(10, 2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stone", x => x.Stone_Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Email = table.Column<string>(maxLength: 250, nullable: false),
                    Fname = table.Column<string>(maxLength: 50, nullable: true),
                    Lname = table.Column<string>(maxLength: 50, nullable: true),
                    Bdate = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Confirm_Password = table.Column<string>(nullable: true),
                    Zip_Code = table.Column<string>(fixedLength: true, maxLength: 50, nullable: true),
                    Avatar = table.Column<string>(maxLength: 250, nullable: true),
                    Gender = table.Column<string>(maxLength: 50, nullable: true),
                    Eable = table.Column<bool>(nullable: true, defaultValueSql: "((1))"),
                    Id_Role = table.Column<string>(fixedLength: true, maxLength: 10, nullable: true, defaultValueSql: "((4))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Email);
                    table.ForeignKey(
                        name: "FK_User_Role",
                        column: x => x.Id_Role,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    pd_id = table.Column<string>(maxLength: 50, nullable: false),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Color_id = table.Column<string>(fixedLength: true, maxLength: 50, nullable: true),
                    Size = table.Column<string>(maxLength: 50, nullable: true),
                    Brand_id = table.Column<string>(fixedLength: true, maxLength: 50, nullable: true),
                    Dim_id = table.Column<string>(fixedLength: true, maxLength: 50, nullable: true),
                    Stone_id = table.Column<string>(fixedLength: true, maxLength: 50, nullable: true),
                    Id_Category = table.Column<string>(fixedLength: true, maxLength: 50, nullable: true),
                    Metal_id = table.Column<string>(fixedLength: true, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.pd_id);
                    table.ForeignKey(
                        name: "FK_Product_Brand",
                        column: x => x.Brand_id,
                        principalTable: "Brand",
                        principalColumn: "Brand_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Color",
                        column: x => x.Color_id,
                        principalTable: "Color",
                        principalColumn: "Color_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Dim",
                        column: x => x.Dim_id,
                        principalTable: "Dim",
                        principalColumn: "Dim_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Category",
                        column: x => x.Id_Category,
                        principalTable: "Category",
                        principalColumn: "Id_Category",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Metal",
                        column: x => x.Metal_id,
                        principalTable: "Metal",
                        principalColumn: "Metal_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_Stone",
                        column: x => x.Stone_id,
                        principalTable: "Stone",
                        principalColumn: "Stone_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<string>(maxLength: 50, nullable: false),
                    Create_Time = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<bool>(nullable: true),
                    Name = table.Column<string>(maxLength: 250, nullable: true),
                    Birthday = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(fixedLength: true, maxLength: 50, nullable: true),
                    Gender = table.Column<string>(maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Email = table.Column<string>(maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_User",
                        column: x => x.Email,
                        principalTable: "User",
                        principalColumn: "Email",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Order_Detail",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    od_id = table.Column<string>(maxLength: 50, nullable: false),
                    pd_id = table.Column<string>(maxLength: 50, nullable: false),
                    Size = table.Column<string>(maxLength: 50, nullable: true),
                    Quantity = table.Column<int>(nullable: true),
                    Total_Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order_Detail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Order_Detail_Order",
                        column: x => x.od_id,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Order_Detail_Product",
                        column: x => x.pd_id,
                        principalTable: "Product",
                        principalColumn: "pd_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Order_Email",
                table: "Order",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Detail_od_id",
                table: "Order_Detail",
                column: "od_id");

            migrationBuilder.CreateIndex(
                name: "IX_Order_Detail_pd_id",
                table: "Order_Detail",
                column: "pd_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Brand_id",
                table: "Product",
                column: "Brand_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Color_id",
                table: "Product",
                column: "Color_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Dim_id",
                table: "Product",
                column: "Dim_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Id_Category",
                table: "Product",
                column: "Id_Category");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Metal_id",
                table: "Product",
                column: "Metal_id");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Stone_id",
                table: "Product",
                column: "Stone_id");

            migrationBuilder.CreateIndex(
                name: "IX_User_Id_Role",
                table: "User",
                column: "Id_Role");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Certify");

            migrationBuilder.DropTable(
                name: "DimInfo");

            migrationBuilder.DropTable(
                name: "Order_Detail");

            migrationBuilder.DropTable(
                name: "POST_NEW");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Brand");

            migrationBuilder.DropTable(
                name: "Color");

            migrationBuilder.DropTable(
                name: "Dim");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Metal");

            migrationBuilder.DropTable(
                name: "Stone");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
