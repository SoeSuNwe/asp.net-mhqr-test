using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TaskManager2.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    TaskId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    DueDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsCompleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.TaskId);
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "TaskId", "Description", "DueDate", "IsCompleted", "Title" },
                values: new object[,]
                {
                    { 1, "This is Task 1", new DateTime(2023, 9, 24, 21, 49, 32, 919, DateTimeKind.Local).AddTicks(2195), true, "Tesk 1" },
                    { 2, "This is Task 2", new DateTime(2023, 9, 24, 21, 49, 32, 919, DateTimeKind.Local).AddTicks(2232), true, "Tesk 2" },
                    { 3, "This is Task 3", new DateTime(2023, 9, 24, 21, 49, 32, 919, DateTimeKind.Local).AddTicks(2234), true, "Tesk 3" },
                    { 4, "This is Task 4", new DateTime(2023, 9, 24, 21, 49, 32, 919, DateTimeKind.Local).AddTicks(2235), true, "Tesk 4" },
                    { 5, "This is Task 5", new DateTime(2023, 9, 24, 21, 49, 32, 919, DateTimeKind.Local).AddTicks(2236), true, "Tesk 5" },
                    { 6, "This is Task 6", new DateTime(2023, 9, 24, 21, 49, 32, 919, DateTimeKind.Local).AddTicks(2238), true, "Tesk 6" },
                    { 7, "This is Task 7", new DateTime(2023, 9, 24, 21, 49, 32, 919, DateTimeKind.Local).AddTicks(2239), true, "Tesk 7" },
                    { 8, "This is Task 8", new DateTime(2023, 9, 24, 21, 49, 32, 919, DateTimeKind.Local).AddTicks(2240), true, "Tesk 8" },
                    { 9, "This is Task 9", new DateTime(2023, 9, 24, 21, 49, 32, 919, DateTimeKind.Local).AddTicks(2240), true, "Tesk 9" },
                    { 10, "This is Task 10", new DateTime(2023, 9, 24, 21, 49, 32, 919, DateTimeKind.Local).AddTicks(2242), true, "Tesk 10" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
