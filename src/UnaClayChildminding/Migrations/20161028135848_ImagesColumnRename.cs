using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UnaClayChildminding.Migrations
{
    public partial class ImagesColumnRename : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "url",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "fileName",
                table: "Images",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "fileName",
                table: "Images");

            migrationBuilder.AddColumn<string>(
                name: "url",
                table: "Images",
                nullable: true);
        }
    }
}
