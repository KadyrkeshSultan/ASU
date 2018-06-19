using Microsoft.EntityFrameworkCore.Migrations;

namespace ASU.DTO.Migrations
{
    public partial class Measure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseActor",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "BaseActor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IIN",
                table: "BaseActor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "BaseActor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Verificator_Address",
                table: "BaseActor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Certificate",
                table: "BaseActor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "BaseActor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Director",
                table: "BaseActor",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsCheckAuthor",
                table: "BaseActor",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Verificator_Phone",
                table: "BaseActor",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BaseEntity",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsSaved = table.Column<bool>(nullable: false),
                    Mnemo = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AuthorId = table.Column<string>(nullable: true),
                    Note = table.Column<string>(nullable: true),
                    OriginalId = table.Column<decimal>(nullable: false),
                    OwnerId = table.Column<string>(nullable: true),
                    ParentId = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    TECoutry = table.Column<string>(nullable: true),
                    TEManufatureDate = table.Column<string>(nullable: true),
                    TEModel = table.Column<string>(nullable: true),
                    TEProducer = table.Column<string>(nullable: true),
                    TEWorkNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseActor_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "BaseActor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseActor_OwnerId",
                        column: x => x.OwnerId,
                        principalTable: "BaseActor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseEntity_BaseEntity_ParentId",
                        column: x => x.ParentId,
                        principalTable: "BaseEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MeasurementTypes",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    IsSaved = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeasurementTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_AuthorId",
                table: "BaseEntity",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_OwnerId",
                table: "BaseEntity",
                column: "OwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_BaseEntity_ParentId",
                table: "BaseEntity",
                column: "ParentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BaseEntity");

            migrationBuilder.DropTable(
                name: "MeasurementTypes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseActor");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "BaseActor");

            migrationBuilder.DropColumn(
                name: "IIN",
                table: "BaseActor");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "BaseActor");

            migrationBuilder.DropColumn(
                name: "Verificator_Address",
                table: "BaseActor");

            migrationBuilder.DropColumn(
                name: "Certificate",
                table: "BaseActor");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "BaseActor");

            migrationBuilder.DropColumn(
                name: "Director",
                table: "BaseActor");

            migrationBuilder.DropColumn(
                name: "IsCheckAuthor",
                table: "BaseActor");

            migrationBuilder.DropColumn(
                name: "Verificator_Phone",
                table: "BaseActor");
        }
    }
}
