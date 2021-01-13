using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP.NETMVCCORE.Migrations
{
    public partial class DatabasePopulationMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Address", "Biography", "Category", "DOB", "Email", "Gender", "KeyWordsForSkill", "LocationOfWork", "MobileNo", "Name" },
                values: new object[,]
                {
                    { 1, "10 HighBury Lane, Se3 3ep", "I am kind of a genius", 0, new DateTime(2020, 3, 20, 0, 21, 42, 535, DateTimeKind.Local), "a@gmail.com", 0, "Entrepeneur", "Canary Wharf, London", "07716628264", "Harry" },
                    { 2, "10 Farnharm Road, Se4 5ep", "I am a good learner", 1, new DateTime(2020, 3, 20, 0, 21, 42, 542, DateTimeKind.Local), "b@gmail.com", 0, "Senior Manager", "Liverpool Street, London", "07716623324", "Mike" },
                    { 3, "30 melvin Road, SW3 7WL", "I am a good performer", 4, new DateTime(2020, 3, 20, 0, 21, 42, 542, DateTimeKind.Local), "n@gmail.com", 1, "Guitarist", "Kensington Road, London", "07326623324", "Felisha" },
                    { 4, "30 Avenue Street, NW3 31M", "I live in Norwich and I work as a chef in the five star hotel", 3, new DateTime(2020, 3, 20, 0, 21, 42, 542, DateTimeKind.Local), "m@gmail.com", 1, "Chef", "GreenField Lane, Norwich", "07116623324", "Mary" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4);
        }
    }
}
