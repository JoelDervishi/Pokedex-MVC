using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex_MVC.Migrations
{
    /// <inheritdoc />
    public partial class Fir : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abilities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EggGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EggGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moves",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Power = table.Column<int>(type: "INTEGER", nullable: false),
                    Precision = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moves_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TypesInteractions",
                columns: table => new
                {
                    Interaction = table.Column<float>(type: "REAL", nullable: false),
                    FirstTypeId = table.Column<int>(type: "INTEGER", nullable: true),
                    SecondTypeId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_TypesInteractions_Types_FirstTypeId",
                        column: x => x.FirstTypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TypesInteractions_Types_SecondTypeId",
                        column: x => x.SecondTypeId,
                        principalTable: "Types",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "EggGroupPokemon",
                columns: table => new
                {
                    EggGroupsId = table.Column<int>(type: "INTEGER", nullable: false),
                    PokemonsDexId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EggGroupPokemon", x => new { x.EggGroupsId, x.PokemonsDexId });
                    table.ForeignKey(
                        name: "FK_EggGroupPokemon_EggGroups_EggGroupsId",
                        column: x => x.EggGroupsId,
                        principalTable: "EggGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Official = table.Column<string>(type: "TEXT", nullable: true),
                    Official_s = table.Column<string>(type: "TEXT", nullable: true),
                    Sprite = table.Column<string>(type: "TEXT", nullable: true),
                    Sprite_s = table.Column<string>(type: "TEXT", nullable: true),
                    Animated = table.Column<string>(type: "TEXT", nullable: true),
                    Animated_s = table.Column<string>(type: "TEXT", nullable: true),
                    PokemonId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    DexId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Name_Jap = table.Column<string>(type: "TEXT", nullable: true),
                    Roomaji = table.Column<string>(type: "TEXT", nullable: true),
                    Height = table.Column<float>(type: "REAL", nullable: false),
                    Weight = table.Column<float>(type: "REAL", nullable: false),
                    Catch_rate = table.Column<int>(type: "INTEGER", nullable: false),
                    Growth_rate = table.Column<string>(type: "TEXT", nullable: true),
                    Gender_rate = table.Column<int>(type: "INTEGER", nullable: false),
                    Is_baby = table.Column<bool>(type: "INTEGER", nullable: false),
                    Is_legendary = table.Column<bool>(type: "INTEGER", nullable: false),
                    Is_mythic = table.Column<bool>(type: "INTEGER", nullable: false),
                    HP = table.Column<int>(type: "INTEGER", nullable: false),
                    Atk = table.Column<int>(type: "INTEGER", nullable: false),
                    Def = table.Column<int>(type: "INTEGER", nullable: false),
                    SpAtk = table.Column<int>(type: "INTEGER", nullable: false),
                    SpDef = table.Column<int>(type: "INTEGER", nullable: false),
                    Spd = table.Column<int>(type: "INTEGER", nullable: false),
                    ImageId = table.Column<int>(type: "INTEGER", nullable: true),
                    NextStageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.DexId);
                    table.ForeignKey(
                        name: "FK_Pokemons_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Pokemons_Pokemons_NextStageId",
                        column: x => x.NextStageId,
                        principalTable: "Pokemons",
                        principalColumn: "DexId");
                });

            migrationBuilder.CreateTable(
                name: "MovePokemon",
                columns: table => new
                {
                    MovesId = table.Column<int>(type: "INTEGER", nullable: false),
                    PokemonsDexId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovePokemon", x => new { x.MovesId, x.PokemonsDexId });
                    table.ForeignKey(
                        name: "FK_MovePokemon_Moves_MovesId",
                        column: x => x.MovesId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovePokemon_Pokemons_PokemonsDexId",
                        column: x => x.PokemonsDexId,
                        principalTable: "Pokemons",
                        principalColumn: "DexId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon_Ability",
                columns: table => new
                {
                    PokemonDexId = table.Column<int>(type: "INTEGER", nullable: false),
                    AbilityId = table.Column<int>(type: "INTEGER", nullable: false),
                    Is_hidden = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_Ability", x => new { x.PokemonDexId, x.AbilityId });
                    table.ForeignKey(
                        name: "FK_Pokemon_Ability_Abilities_AbilityId",
                        column: x => x.AbilityId,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Ability_Pokemons_PokemonDexId",
                        column: x => x.PokemonDexId,
                        principalTable: "Pokemons",
                        principalColumn: "DexId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonType",
                columns: table => new
                {
                    PokemonsDexId = table.Column<int>(type: "INTEGER", nullable: false),
                    TypesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonType", x => new { x.PokemonsDexId, x.TypesId });
                    table.ForeignKey(
                        name: "FK_PokemonType_Pokemons_PokemonsDexId",
                        column: x => x.PokemonsDexId,
                        principalTable: "Pokemons",
                        principalColumn: "DexId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonType_Types_TypesId",
                        column: x => x.TypesId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EggGroupPokemon_PokemonsDexId",
                table: "EggGroupPokemon",
                column: "PokemonsDexId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PokemonId",
                table: "Images",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_MovePokemon_PokemonsDexId",
                table: "MovePokemon",
                column: "PokemonsDexId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_TypeId",
                table: "Moves",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Ability_AbilityId",
                table: "Pokemon_Ability",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_ImageId",
                table: "Pokemons",
                column: "ImageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_NextStageId",
                table: "Pokemons",
                column: "NextStageId");

            migrationBuilder.CreateIndex(
                name: "IX_PokemonType_TypesId",
                table: "PokemonType",
                column: "TypesId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesInteractions_FirstTypeId",
                table: "TypesInteractions",
                column: "FirstTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesInteractions_SecondTypeId",
                table: "TypesInteractions",
                column: "SecondTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EggGroupPokemon_Pokemons_PokemonsDexId",
                table: "EggGroupPokemon",
                column: "PokemonsDexId",
                principalTable: "Pokemons",
                principalColumn: "DexId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Pokemons_PokemonId",
                table: "Images",
                column: "PokemonId",
                principalTable: "Pokemons",
                principalColumn: "DexId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Pokemons_PokemonId",
                table: "Images");

            migrationBuilder.DropTable(
                name: "EggGroupPokemon");

            migrationBuilder.DropTable(
                name: "MovePokemon");

            migrationBuilder.DropTable(
                name: "Pokemon_Ability");

            migrationBuilder.DropTable(
                name: "PokemonType");

            migrationBuilder.DropTable(
                name: "TypesInteractions");

            migrationBuilder.DropTable(
                name: "EggGroups");

            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
