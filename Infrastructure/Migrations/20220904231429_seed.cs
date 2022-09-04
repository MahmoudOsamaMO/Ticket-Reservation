using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Trips_TripID",
                table: "Seat");

            migrationBuilder.RenameColumn(
                name: "TripID",
                table: "Seat",
                newName: "tripId");

            migrationBuilder.RenameIndex(
                name: "IX_Seat_TripID",
                table: "Seat",
                newName: "IX_Seat_tripId");

            migrationBuilder.AlterColumn<int>(
                name: "tripId",
                table: "Seat",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "ID", "busId", "price", "tripType", "userEmail" },
                values: new object[,]
                {
                    { 1, "bus1", 10, 0, "mahmoud@gmail.com" },
                    { 2, "bus1", 10, 0, "mahmoud@gmail.com" },
                    { 3, "bus1", 10, 1, "mahmoud@gmail.com" },
                    { 4, "bus1", 10, 1, "Yehia@gmail.com" },
                    { 5, "bus1", 10, 1, "Yehia@gmail.com" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Trips_tripId",
                table: "Seat",
                column: "tripId",
                principalTable: "Trips",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Seat_Trips_tripId",
                table: "Seat");

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Trips",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.RenameColumn(
                name: "tripId",
                table: "Seat",
                newName: "TripID");

            migrationBuilder.RenameIndex(
                name: "IX_Seat_tripId",
                table: "Seat",
                newName: "IX_Seat_TripID");

            migrationBuilder.AlterColumn<int>(
                name: "TripID",
                table: "Seat",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Seat_Trips_TripID",
                table: "Seat",
                column: "TripID",
                principalTable: "Trips",
                principalColumn: "ID");
        }
    }
}
