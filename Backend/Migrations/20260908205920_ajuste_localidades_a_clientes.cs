using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Backend.Migrations
{
    /// <inheritdoc />
    public partial class ajuste_localidades_a_clientes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 8, 17, 59, 19, 614, DateTimeKind.Unspecified).AddTicks(3315), new TimeSpan(0, -3, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 8, 17, 59, 19, 614, DateTimeKind.Unspecified).AddTicks(3361), new TimeSpan(0, -3, 0, 0, 0)), 1 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 8, 17, 59, 19, 614, DateTimeKind.Unspecified).AddTicks(3363), new TimeSpan(0, -3, 0, 0, 0)), 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 1, 18, 42, 37, 450, DateTimeKind.Unspecified).AddTicks(2649), new TimeSpan(0, -3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 1, 18, 42, 37, 450, DateTimeKind.Unspecified).AddTicks(2686), new TimeSpan(0, -3, 0, 0, 0)), 0 });

            migrationBuilder.UpdateData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created_at", "LocalidadId" },
                values: new object[] { new DateTimeOffset(new DateTime(2026, 9, 1, 18, 42, 37, 450, DateTimeKind.Unspecified).AddTicks(2688), new TimeSpan(0, -3, 0, 0, 0)), 0 });
        }
    }
}
