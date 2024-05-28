using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex_MVC.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypesInteractions_Types_FirstTypeId",
                table: "TypesInteractions");

            migrationBuilder.DropForeignKey(
                name: "FK_TypesInteractions_Types_SecondTypeId",
                table: "TypesInteractions");

            migrationBuilder.DropIndex(
                name: "IX_TypesInteractions_FirstTypeId",
                table: "TypesInteractions");

            migrationBuilder.RenameTable(
                name: "TypesInteractions",
                newName: "TypesInteraction");

            migrationBuilder.RenameIndex(
                name: "IX_TypesInteractions_SecondTypeId",
                table: "TypesInteraction",
                newName: "IX_TypesInteraction_SecondTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TypesInteraction",
                table: "TypesInteraction",
                columns: new[] { "FirstTypeId", "SecondTypeId" });

            migrationBuilder.AddForeignKey(
                name: "FK_TypesInteraction_Types_FirstTypeId",
                table: "TypesInteraction",
                column: "FirstTypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypesInteraction_Types_SecondTypeId",
                table: "TypesInteraction",
                column: "SecondTypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TypesInteraction_Types_FirstTypeId",
                table: "TypesInteraction");

            migrationBuilder.DropForeignKey(
                name: "FK_TypesInteraction_Types_SecondTypeId",
                table: "TypesInteraction");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TypesInteraction",
                table: "TypesInteraction");

            migrationBuilder.RenameTable(
                name: "TypesInteraction",
                newName: "TypesInteractions");

            migrationBuilder.RenameIndex(
                name: "IX_TypesInteraction_SecondTypeId",
                table: "TypesInteractions",
                newName: "IX_TypesInteractions_SecondTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesInteractions_FirstTypeId",
                table: "TypesInteractions",
                column: "FirstTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TypesInteractions_Types_FirstTypeId",
                table: "TypesInteractions",
                column: "FirstTypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TypesInteractions_Types_SecondTypeId",
                table: "TypesInteractions",
                column: "SecondTypeId",
                principalTable: "Types",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
