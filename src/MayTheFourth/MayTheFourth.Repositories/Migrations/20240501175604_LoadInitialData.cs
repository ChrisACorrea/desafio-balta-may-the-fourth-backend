using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MayTheFourth.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class LoadInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RunMigrationSqlFromFile("20240501175604_LoadInitialData_Up.sql");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RunMigrationSqlFromFile("20240501175604_LoadInitialData_Down.sql");
        }
    }
}
