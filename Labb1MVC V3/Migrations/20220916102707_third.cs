using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Labb1MVC_V3.Migrations
{
    public partial class third : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 1,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Lesly Olson", "convergence access Product", "Cumque aut sed velit delectus eveniet doloribus assumenda ipsum. Dicta velit incidunt tenetur velit voluptas quas. Non nostrum aut in." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 2,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Gage Rohan", "e-enable", "Nemo dolore aut omnis et. Ratione molestiae voluptatibus cupiditate deserunt voluptas. Atque ut cumque non ut. Est inventore et ea dolores. Saepe corporis qui id corporis deserunt ratione magnam." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 3,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Lesly Larkin", "PCI Technician", "Occaecati nobis itaque non soluta repudiandae voluptatem soluta nobis odit. Magni quaerat quas voluptas reiciendis eum. Eos quia amet soluta non dignissimos excepturi voluptas. Mollitia qui similique et dolorem nisi qui." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 4,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Cleora Effertz", "microchip", "Inventore et corrupti id quia consectetur ea. Asperiores vel necessitatibus autem earum qui voluptas. Quos sit quo nostrum quisquam hic sed blanditiis officia. Fugit tempora quia dolor quidem molestias placeat qui magni." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 5,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Gina O'Hara", "Road", "Minus facere omnis. Ea esse iusto delectus nihil dolor. Aspernatur repellendus odit dolores doloremque. Suscipit architecto dolores velit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 6,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Lisa Cartwright", "grey", "Enim repellendus et amet doloremque expedita eius consequatur optio. Eum optio temporibus sequi. Blanditiis dolores et. Accusantium sunt velit. Illo in magni et occaecati sunt vel." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 7,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Cierra Bergstrom", "solution-oriented payment Customer", "Consequuntur suscipit aut hic autem nisi aliquam eos quisquam dolore. Dicta similique sed eveniet tempora sunt est eveniet alias optio. Ipsam voluptatem aut debitis consequuntur et nesciunt et hic." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 8,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Katelyn Braun", "Corporate Cliff", "In eum pariatur dolores pariatur adipisci aliquam praesentium possimus. Reiciendis culpa dolorem consequuntur consectetur suscipit sit est. Et eius facere voluptatibus illum exercitationem iure dolor et." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 9,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Emery Weissnat", "wireless Berkshire Rubber", "Et fuga libero maxime totam molestiae. Quam dolor hic odit inventore. Aliquam cumque error est ea aperiam quo laudantium sit." });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "BookId",
                keyValue: 10,
                columns: new[] { "BookAuthor", "BookName", "Description" },
                values: new object[] { "Giuseppe Skiles", "CFA Franc BCEAO Games & Movies Tajikistan", "Debitis omnis consequatur excepturi necessitatibus molestiae delectus qui deleniti et. Qui non nihil unde tenetur repudiandae et ut consequatur. Et ut consequatur blanditiis esse adipisci commodi aliquam architecto porro." });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Adriana.Nikolaus90@hotmail.com", "Lucie", "Halvorson" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Alphonso29@yahoo.com", "Jerod", "Mueller" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Vicky.Kuhic@yahoo.com", "Janie", "Lakin" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Coby_Beer@yahoo.com", "Amie", "Blick" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Trevion89@yahoo.com", "Lee", "Connelly" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 6,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Alec_Ruecker@gmail.com", "Selena", "Lesch" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 7,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Lorena72@hotmail.com", "Dillan", "Koch" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 8,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Daren.Rice@gmail.com", "Ryann", "Parker" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 9,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Rick89@yahoo.com", "Neoma", "Kemmer" });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 10,
                columns: new[] { "CustomerEmail", "CustomerFName", "CustomerLName" },
                values: new object[] { "Lourdes_Adams@gmail.com", "Jayden", "Watsica" });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 1,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 3, 9, new DateTime(2022, 9, 16, 12, 27, 7, 184, DateTimeKind.Local).AddTicks(9746) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 2,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 7, 1, new DateTime(2022, 9, 16, 12, 27, 7, 187, DateTimeKind.Local).AddTicks(3411) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 3,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 7, 8, new DateTime(2022, 9, 16, 12, 27, 7, 187, DateTimeKind.Local).AddTicks(3660) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 4,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 6, 6, new DateTime(2022, 9, 16, 12, 27, 7, 187, DateTimeKind.Local).AddTicks(3679) });

            migrationBuilder.UpdateData(
                table: "Loan",
                keyColumn: "LoanedBookId",
                keyValue: 5,
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 6, 8, new DateTime(2022, 9, 16, 12, 27, 7, 187, DateTimeKind.Local).AddTicks(3691) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "BookId", "CustomerId", "LoanDate" },
                values: new object[] { 1, 3, new DateTime(2022, 9, 16, 12, 26, 10, 683, DateTimeKind.Local).AddTicks(8971) });

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
    }
}
