using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GroceryFinal.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataForStates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StateTable",
                columns: new[] { "StateId", "StateName" },
                values: new object[,]
                {
                    { 1, "Andhra Pradesh" },
                    { 2, "Arunachal Pradesh" },
                    { 3, "Assam" },
                    { 4, "Bihar" },
                    { 5, "Chhattisgarh" },
                    { 6, "Goa" },
                    { 7, "Gujarat" },
                    { 8, "Haryana" },
                    { 9, "Himachal Pradesh" },
                    { 10, "Jharkhand" },
                    { 11, "Karnataka" },
                    { 12, "Kerala" },
                    { 13, "Madhya Pradesh" },
                    { 14, "Maharashtra" },
                    { 15, "Manipur" },
                    { 16, "Meghalaya" },
                    { 17, "Mizoram" },
                    { 18, "Nagaland" },
                    { 19, "Odisha" },
                    { 20, "Punjab" },
                    { 21, "Rajasthan" },
                    { 22, "Sikkim" },
                    { 23, "Tamil Nadu" },
                    { 24, "Telangana" },
                    { 25, "Tripura" },
                    { 26, "Uttarakhand" },
                    { 27, "Uttar Pradesh" },
                    { 28, "West Bengal" },
                    { 29, "Andaman and Nicobar Islands" },
                    { 30, "Chandigarh" },
                    { 31, "Dadra and Nagar Haveli and Daman and Diu" },
                    { 32, "Delhi" },
                    { 33, "Jammu and Kashmir" },
                    { 34, "Ladakh" },
                    { 35, "Lakshadweep" },
                    { 36, "Puducherry" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "StateTable",
                keyColumn: "StateId",
                keyValue: 36);
        }
    }
}
