using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1MVC_V3.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(nullable: true),
                    BookAuthor = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    NumberOfBooksInStock = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFName = table.Column<string>(maxLength: 25, nullable: false),
                    CustomerLName = table.Column<string>(maxLength: 25, nullable: false),
                    CustomerEmail = table.Column<string>(maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Loan",
                columns: table => new
                {
                    LoanedBookId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false),
                    LoanDate = table.Column<DateTime>(nullable: false),
                    ReturnDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loan", x => x.LoanedBookId);
                    table.ForeignKey(
                        name: "FK_Loan_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Loan_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookAuthor", "BookName", "Description", "NumberOfBooksInStock" },
                values: new object[,]
                {
                    { 1, "Golda Stokes", "Bedfordshire", "Placeat autem veritatis id temporibus dolorum. Est est vel nulla nihil vero quia ipsam ipsam. Autem ea dolor. Odit aliquam vitae. Sint voluptatum reprehenderit.", 1 },
                    { 9, "Hailee Jacobs", "Buckinghamshire Tokelau", "Repellendus non fugit dolor qui laborum quis quia provident. Qui eveniet consequuntur eaque dolorem facilis voluptatem consequatur rem quis. Ut dicta qui.", 2 },
                    { 8, "Lenore Farrell", "Creek", "Distinctio deserunt et voluptas enim. Optio aut dolorum rerum veniam optio est illum. Voluptas rerum debitis laborum ex reiciendis consequuntur harum. Molestiae qui mollitia. Neque mollitia itaque vel velit rerum pariatur est mollitia.", 5 },
                    { 7, "Ericka Trantow", "Bedfordshire calculate", "Iste quod vel enim rerum maiores possimus enim impedit velit. Id quisquam perspiciatis. Illo earum molestias. In perferendis cum consequuntur. Sit sint aliquid nobis aut error.", 5 },
                    { 6, "Clarabelle Collier", "Intelligent Plastic Ball", "Et non eligendi illo ab dolores dolorem voluptas. Et consequuntur non assumenda consequatur impedit consequatur molestias iste consequatur. A expedita et tenetur et quod at voluptas consequatur. Velit non fugit dolorem dicta neque delectus blanditiis. Ullam in natus rerum reiciendis eum temporibus.", 3 },
                    { 10, "D'angelo Pacocha", "Rubber Ford", "Consequatur nisi quae quam quia. Consequuntur ipsam ipsam et. Repellendus minima blanditiis recusandae debitis officiis in non eveniet.", 6 },
                    { 4, "Loma Green", "Auto Loan Account Connecticut scalable", "Quam dolor voluptatem doloribus et expedita. Asperiores minima voluptate id nulla. At placeat est exercitationem delectus dolores et aspernatur quo exercitationem. Asperiores dolorum excepturi vitae.", 5 },
                    { 3, "Antonia McLaughlin", "extend didactic Practical Frozen Shoes", "Ipsam dignissimos ducimus voluptas molestiae. Ratione et ut qui atque. Aspernatur quaerat et nostrum nam excepturi totam tempore non nobis. Dolor nihil aut sunt. Fuga iusto quasi quia recusandae qui pariatur saepe dignissimos cumque. Porro et incidunt porro expedita ipsam voluptas ipsum.", 6 },
                    { 2, "Herminia Larson", "deposit calculating Metrics", "Sunt neque sequi accusamus veniam aut. Nihil sapiente sit non. Blanditiis rerum autem rerum ut reiciendis cum. Qui nihil perspiciatis sint qui. Debitis voluptatem dolorem suscipit necessitatibus perspiciatis dicta doloribus non.", 6 },
                    { 5, "Chase Grady", "Phased", "Repudiandae labore sint alias eaque sit saepe. Et repellendus pariatur nihil autem distinctio. Distinctio autem ea quia qui rerum a.", 7 }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[,]
                {
                    { 9, "Tyler30@gmail.com", "Richmond", "Bahringer" },
                    { 1, "Derek_Kunde30@hotmail.com", "Ike", "Howell" },
                    { 2, "Ryder_Farrell@yahoo.com", "Moses", "Becker" },
                    { 3, "Carolanne.Rippin@gmail.com", "Leif", "Schmidt" },
                    { 4, "Makenna.OReilly@gmail.com", "Rylan", "Krajcik" },
                    { 5, "Irma_Zieme50@yahoo.com", "Retha", "Rodriguez" },
                    { 6, "Isabel_Ankunding13@yahoo.com", "Veda", "Purdy" },
                    { 7, "Drew_Glover@yahoo.com", "Heber", "Feeney" },
                    { 8, "Abigale.Legros@gmail.com", "Mya", "Bogisich" },
                    { 10, "Tyree_Bradtke72@yahoo.com", "Harrison", "Feeney" }
                });

            migrationBuilder.InsertData(
                table: "Loan",
                columns: new[] { "LoanedBookId", "BookId", "CustomerId", "LoanDate", "ReturnDate" },
                values: new object[,]
                {
                    { 4, 2, 3, new DateTime(2022, 9, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5654), new DateTime(2022, 10, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5656) },
                    { 5, 1, 3, new DateTime(2022, 9, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5664), new DateTime(2022, 10, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5666) },
                    { 2, 1, 4, new DateTime(2022, 9, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5451), new DateTime(2022, 10, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5470) },
                    { 3, 7, 4, new DateTime(2022, 9, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5640), new DateTime(2022, 10, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(5644) },
                    { 1, 6, 5, new DateTime(2022, 9, 19, 14, 34, 7, 897, DateTimeKind.Local).AddTicks(3584), new DateTime(2022, 10, 19, 14, 34, 7, 899, DateTimeKind.Local).AddTicks(2534) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Loan_BookId",
                table: "Loan",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_Loan_CustomerId",
                table: "Loan",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Loan");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
