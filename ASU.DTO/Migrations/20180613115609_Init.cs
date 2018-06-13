using Microsoft.EntityFrameworkCore.Migrations;

namespace ASU.DTO.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseActor",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsSaved = table.Column<bool>(nullable: false),
                    Mnemo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    OriginalId = table.Column<decimal>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseActor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsSaved = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    Login = table.Column<string>(nullable: true),
                    OrganizationId = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    PersonId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_BaseActor_OrganizationId",
                        column: x => x.OrganizationId,
                        principalTable: "BaseActor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_BaseActor_PersonId",
                        column: x => x.PersonId,
                        principalTable: "BaseActor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_OrganizationId",
                table: "Users",
                column: "OrganizationId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonId",
                table: "Users",
                column: "PersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "BaseActor");
        }
    }
}
