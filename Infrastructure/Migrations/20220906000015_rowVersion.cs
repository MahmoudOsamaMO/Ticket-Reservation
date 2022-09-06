using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class rowVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Trips_tripId",
                table: "Seat");

            migrationBuilder.AlterColumn<int>(
                name: "tripId",
                table: "Seat",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<byte[]>(
                name: "Timestamp",
                table: "Seat",
                type: "rowversion",
                rowVersion: true,
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<string>(
                name: "busId",
                table: "Seat",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "isReserved",
                table: "Seat",
                type: "bit",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Seat",
                columns: new[] { "seatId", "busId", "isReserved", "name", "tripId" },
                values: new object[,]
                {
                    { 1, "bus1", true, "A01", 1 },
                    { 2, "bus1", true, "A02", 1 },
                    { 3, "bus1", true, "A03", 2 },
                    { 4, "bus1", true, "A04", 2 },
                    { 5, "bus1", true, "A05", 2 },
                    { 6, "bus1", true, "A06", 2 },
                    { 7, "bus1", true, "A07", 2 },
                    { 8, "bus1", true, "A08", 2 },
                    { 9, "bus1", true, "A09", 2 },
                    { 10, "bus1", false, "A10", null },
                    { 11, "bus1", false, "A11", null },
                    { 12, "bus1", false, "A12", null },
                    { 13, "bus1", false, "A13", null },
                    { 14, "bus1", false, "A14", null },
                    { 15, "bus1", false, "A15", null },
                    { 16, "bus1", false, "A16", null },
                    { 17, "bus1", false, "A17", null },
                    { 18, "bus1", false, "A18", null },
                    { 19, "bus1", false, "A19", null },
                    { 20, "bus1", false, "A20", null },
                    { 21, "bus2", false, "A00", null },
                    { 22, "bus2", false, "A01", null },
                    { 23, "bus2", false, "A02", null },
                    { 24, "bus2", false, "A03", null },
                    { 25, "bus2", false, "A04", null },
                    { 26, "bus2", false, "A05", null },
                    { 27, "bus2", false, "A06", null },
                    { 28, "bus2", false, "A07", null },
                    { 29, "bus2", false, "A08", null },
                    { 30, "bus2", false, "A09", null },
                    { 31, "bus2", false, "A10", null },
                    { 32, "bus2", false, "A11", null },
                    { 33, "bus2", false, "A12", null },
                    { 34, "bus2", false, "A13", null },
                    { 35, "bus2", false, "A14", null },
                    { 36, "bus2", false, "A15", null },
                    { 37, "bus2", false, "A16", null },
                    { 38, "bus2", false, "A17", null },
                    { 39, "bus2", false, "A18", null },
                    { 40, "bus2", false, "A19", null },
                    { 41, "bus2", false, "A20", null }
                });

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "ID",
                keyValue: 3,
                column: "busId",
                value: "bus2");

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "ID",
                keyValue: 4,
                column: "busId",
                value: "bus2");

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "ID",
                keyValue: 5,
                column: "busId",
                value: "bus2");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Trips_tripId",
                table: "Seat",
                column: "tripId",
                principalTable: "Trips",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Trips_tripId",
                table: "Seat");

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Seat",
                keyColumn: "seatId",
                keyValue: 41);

            migrationBuilder.DropColumn(
                name: "Timestamp",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "busId",
                table: "Seat");

            migrationBuilder.DropColumn(
                name: "isReserved",
                table: "Seat");

            migrationBuilder.AlterColumn<int>(
                name: "tripId",
                table: "Seat",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "ID",
                keyValue: 3,
                column: "busId",
                value: "bus1");

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "ID",
                keyValue: 4,
                column: "busId",
                value: "bus1");

            migrationBuilder.UpdateData(
                table: "Trips",
                keyColumn: "ID",
                keyValue: 5,
                column: "busId",
                value: "bus1");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Trips_tripId",
                table: "Seat",
                column: "tripId",
                principalTable: "Trips",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
