using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace data_access1.Migrations
{
    /// <inheritdoc />
    public partial class DbExtensions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ukraine" },
                    { 2, "Germany" },
                    { 3, "France" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Boss" },
                    { 2, "Manager" },
                    { 3, "Doorman" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Rivne" },
                    { 2, 2, "Berlin" },
                    { 3, 3, "Paris" }
                });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "Id", "Adress", "CityId", "ContactNumber", "CountHotelRooms", "Description", "Name", "Stars" },
                values: new object[,]
                {
                    { 1, "Sun 12a", 1, "+380 97 234 1267", 100, "Cool hotel, 5 stars", "SunSet", 5 },
                    { 2, "Sunny 18a", 2, "+380 68 274 1247", 70, "Cool service, 4 stars", "SunRise", 4 },
                    { 3, "Moon 12a", 3, "+380 44 224 6061", 120, "Great hotel, 5 stars", "MoonRise", 5 }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Gmail", "HotelId", "Name", "PhoneNumber", "PositionId", "Salary", "Surname" },
                values: new object[,]
                {
                    { 1, "roberto1237@gmil.com", 1, "Robert", "+380 97 077 2533", 1, 3000m, "Robertov" },
                    { 2, "vika17@gmil.com", 1, "Vika", "+380 97 707 2323", 2, 2000m, "Vivikivna" },
                    { 3, "danyil32@gmil.com", 1, "Danya", "+380 97 036 2632", 3, 1000m, "Dayiilovich" }
                });

            migrationBuilder.InsertData(
                table: "HotelRooms",
                columns: new[] { "Id", "CountVisitors", "HotelId", "IsVip", "Number", "PriceForDay" },
                values: new object[,]
                {
                    { 1, 3, 1, true, 1, 100m },
                    { 2, 2, 1, false, 2, 50m },
                    { 3, 1, 1, false, 3, 30m }
                });

            migrationBuilder.InsertData(
                table: "Visitors",
                columns: new[] { "Id", "HotelRoomId", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 1, 1, "Den", "+380 97 354 1278", "Deniv" },
                    { 2, 2, "Vlad", "+380 68 250 2228", "Vladov" },
                    { 3, 3, "Gill", "+380 97 574 2118", "Gillov" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Visitors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "HotelRooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Positions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Hotels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
