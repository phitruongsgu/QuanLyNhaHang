﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNH_APIs.Migrations
{
    public partial class Add_Table_Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*            migrationBuilder.CreateTable(
                            name: "Category",
                            columns: table => new
                            {
                                Id = table.Column<int>(type: "int", nullable: false)
                                    .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                                Name = table.Column<string>(type: "longtext", nullable: false)
                                    .Annotation("MySql:CharSet", "utf8mb4"),
                                Description = table.Column<string>(type: "longtext", nullable: false)
                                    .Annotation("MySql:CharSet", "utf8mb4")
                            },
                            constraints: table =>
                            {
                                table.PrimaryKey("PK_Category", x => x.Id);
                            })
                            .Annotation("MySql:CharSet", "utf8mb4");*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            /*            migrationBuilder.DropTable(
                            name: "Category");*/
        }
    }
}
