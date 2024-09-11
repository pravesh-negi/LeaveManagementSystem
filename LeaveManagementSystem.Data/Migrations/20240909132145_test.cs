using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagementSystem.Data.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42007a2a-ea58-4504-bc91-d80810beb3b7", "AQAAAAIAAYagAAAAEEfANvf0XMTwLzgNdwFFa9BFHLuffqQIIIDbImBzHGQerU+QdnBxY0JZqp5jTO9Hvg==", "7c6a6eb2-ca59-4528-b7df-4cb592c7899c" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "361fa870-8f81-4047-aa79-462d3ce2f197", "AQAAAAIAAYagAAAAEA2AOZ24afQpUZ9/Elgh4wNAQEtPaggUQpLY87iaV7c+oxo0qEPvLS3eTqo2jlzSDg==", "1499cfe3-d3e3-4918-a6b3-d84c503f8a40" });
        }
    }
}
