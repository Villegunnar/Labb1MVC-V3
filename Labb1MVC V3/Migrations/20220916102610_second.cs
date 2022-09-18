using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1MVC_V3.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Kelly Lemke", "Groves auxiliary", "Minima sed neque enim." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Jamie Schneider", "Metrics Hong Kong Group", "Et numquam ut itaque." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Kallie Walsh", "Strategist", "Suscipit qui et accusamus et aspernatur ut." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Gerry Ritchie", "real-time software Iceland", "Rerum vel ut aliquid aut perferendis commodi sint." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Karelle Leuschke", "Cove", "Quod adipisci facilis reiciendis." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Dominique Greenfelder", "attitude", "Iusto non ipsa sint beatae nobis quo." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Alec Cummerata", "directional strategic", "Similique voluptatem aliquid voluptatem cupiditate." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Kory Mayer", "Roads", "Rerum nihil magni quam id consequatur sunt nemo." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Kennith Gibson", "parse Lights deliverables", "Pariatur culpa dolorem voluptatum et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Everette Kautzer", "Handmade Wooden Cheese implement Berkshire", "Velit quam eos tempore delectus quasi quisquam magnam animi." });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Ova46@hotmail.com", "Reed", "Volkman" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Hallie.Schowalter@yahoo.com", "Morgan", "Zieme" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Turner51@gmail.com", "Romaine", "Friesen" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Erik_Corkery@yahoo.com", "Bailey", "Anderson" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Dangelo23@yahoo.com", "Sheila", "Lakin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Maverick73@hotmail.com", "Rosemary", "Hodkiewicz" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Leila_Wolf@yahoo.com", "Fae", "Weissnat" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Evan71@hotmail.com", "Micheal", "Rohan" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Josiah_Runte48@yahoo.com", "Stephen", "Collins" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Felipe_Cartwright34@hotmail.com", "Alicia", "Denesik" });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 1,
                columns: new[] { "BookId", "LoanDate" },
                values: new object[] { 1, new DateTime(2022, 9, 16, 12, 26, 10, 683, DateTimeKind.Local).AddTicks(8971) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 2,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 8, 7, new DateTime(2022, 9, 16, 12, 26, 10, 685, DateTimeKind.Local).AddTicks(8733) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 3,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 1, 2, new DateTime(2022, 9, 16, 12, 26, 10, 685, DateTimeKind.Local).AddTicks(8870) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 4,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 7, 2, new DateTime(2022, 9, 16, 12, 26, 10, 685, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 5,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 9, 7, new DateTime(2022, 9, 16, 12, 26, 10, 685, DateTimeKind.Local).AddTicks(8894) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Wilson Rutherford", "payment National", "channels override" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Marlen Konopelski", "Australia Auto Loan Account", "optical Integration" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Margarita Zieme", "Savings Account", "Lead Solutions" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Omari Jacobson", "Mount contingency Auto Loan Account", "disintermediate" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Addison Brakus", "azure", "HTTP cross-media array" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Nyasia Feil", "Dobra Awesome compressing", "online Sleek" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Maymie Gulgowski", "synthesizing Practical Fresh Sausages", "parse" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Shania Olson", "Rustic Fresh Chicken Games, Tools & Beauty", "Rhode Island" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Hallie Bashirian", "Handmade Cotton Shoes Investor", "contingency" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Gabriel Feil", "eyeballs models efficient", "plug-and-play quantify" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Caesar.Schultz44@hotmail.com", "Bailee", "Weissnat" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Eino_Bode9@yahoo.com", "Loy", "McGlynn" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Amanda9@hotmail.com", "Magnus", "Howell" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Cloyd_Leuschke78@yahoo.com", "Chelsie", "Hamill" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Jimmie9@hotmail.com", "Lilliana", "Treutel" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Wendy.Marks5@hotmail.com", "Javonte", "Hand" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Kamryn_Pacocha@yahoo.com", "Jayde", "Langosh" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Ron.Ryan70@hotmail.com", "Joshua", "DuBuque" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Rachael.Baumbach@hotmail.com", "Kira", "Marquardt" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Kenton.Vandervort@gmail.com", "Florida", "Cruickshank" });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 1,
                columns: new[] { "BookId", "LoanDate" },
                values: new object[] { 6, new DateTime(2022, 9, 16, 12, 24, 40, 703, DateTimeKind.Local).AddTicks(9207) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 2,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 2, 3, new DateTime(2022, 9, 16, 12, 24, 40, 706, DateTimeKind.Local).AddTicks(535) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 3,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 2, 7, new DateTime(2022, 9, 16, 12, 24, 40, 706, DateTimeKind.Local).AddTicks(703) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 4,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 9, 3, new DateTime(2022, 9, 16, 12, 24, 40, 706, DateTimeKind.Local).AddTicks(717) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 5,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 1, 3, new DateTime(2022, 9, 16, 12, 24, 40, 706, DateTimeKind.Local).AddTicks(727) });
        }
    }
}
