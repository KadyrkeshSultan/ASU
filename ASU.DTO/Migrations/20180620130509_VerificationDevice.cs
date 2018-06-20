using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASU.DTO.Migrations
{
    public partial class VerificationDevice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalInfo",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DKP",
                table: "BaseEntity",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpirationDate",
                table: "BaseEntity",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalInfo",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "DKP",
                table: "BaseEntity");

            migrationBuilder.DropColumn(
                name: "ExpirationDate",
                table: "BaseEntity");
        }
    }
}
