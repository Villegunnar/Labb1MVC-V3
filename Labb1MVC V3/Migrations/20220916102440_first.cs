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
                    Description = table.Column<string>(nullable: true)
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
                    LoanDate = table.Column<DateTime>(nullable: false)
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
                columns: new[] { "BookId", "BookAuthor", "BookName", "Description" },
                values: new object[,]
                {
                    { 1, "Wilson Rutherford", "payment National", "channels override" },
                    { 9, "Hallie Bashirian", "Handmade Cotton Shoes Investor", "contingency" },
                    { 8, "Shania Olson", "Rustic Fresh Chicken Games, Tools & Beauty", "Rhode Island" },
                    { 7, "Maymie Gulgowski", "synthesizing Practical Fresh Sausages", "parse" },
                    { 6, "Nyasia Feil", "Dobra Awesome compressing", "online Sleek" },
                    { 10, "Gabriel Feil", "eyeballs models efficient", "plug-and-play quantify" },
                    { 4, "Omari Jacobson", "Mount contingency Auto Loan Account", "disintermediate" },
                    { 3, "Margarita Zieme", "Savings Account", "Lead Solutions" },
                    { 2, "Marlen Konopelski", "Australia Auto Loan Account", "optical Integration" },
                    { 5, "Addison Brakus", "azure", "HTTP cross-media array" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[,]
                {
                    { 9, "Rachael.Baumbach@hotmail.com", "Kira", "Marquardt" },
                    { 1, "Caesar.Schultz44@hotmail.com", "Bailee", "Weissnat" },
                    { 2, "Eino_Bode9@yahoo.com", "Loy", "McGlynn" },
                    { 3, "Amanda9@hotmail.com", "Magnus", "Howell" },
                    { 4, "Cloyd_Leuschke78@yahoo.com", "Chelsie", "Hamill" },
                    { 5, "Jimmie9@hotmail.com", "Lilliana", "Treutel" },
                    { 6, "Wendy.Marks5@hotmail.com", "Javonte", "Hand" },
                    { 7, "Kamryn_Pacocha@yahoo.com", "Jayde", "Langosh" },
                    { 8, "Ron.Ryan70@hotmail.com", "Joshua", "DuBuque" },
                    { 10, "Kenton.Vandervort@gmail.com", "Florida", "Cruickshank" }
                });

            migrationBuilder.InsertData(
                table: "Loan",
                columns: new[] { "LoanedBookId", "BookId", "CustomerId", "LoanDate" },
                values: new object[,]
                {
                    { 1, 6, 3, new DateTime(2022, 9, 16, 12, 24, 40, 703, DateTimeKind.Local).AddTicks(9207) },
                    { 2, 2, 3, new DateTime(2022, 9, 16, 12, 24, 40, 706, DateTimeKind.Local).AddTicks(535) },
                    { 4, 9, 3, new DateTime(2022, 9, 16, 12, 24, 40, 706, DateTimeKind.Local).AddTicks(717) },
                    { 5, 1, 3, new DateTime(2022, 9, 16, 12, 24, 40, 706, DateTimeKind.Local).AddTicks(727) },
                    { 3, 2, 7, new DateTime(2022, 9, 16, 12, 24, 40, 706, DateTimeKind.Local).AddTicks(703) }
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
