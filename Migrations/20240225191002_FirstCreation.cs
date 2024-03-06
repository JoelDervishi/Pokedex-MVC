using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex_MVC.Migrations
{
    /// <inheritdoc />
    public partial class FirstCreation : Migration
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
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Is_hidden = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abilities", x => x.Id);
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
                    Power = table.Column<string>(type: "TEXT", nullable: true),
                    Precision = table.Column<string>(type: "TEXT", nullable: true),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: true),
                    Move = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moves_Types_Move",
                        column: x => x.Move,
                        principalTable: "Types",
                        principalColumn: "Id");
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
                name: "AbilityPokemon",
                columns: table => new
                {
                    Ability = table.Column<int>(type: "INTEGER", nullable: false),
                    Pokemon = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbilityPokemon", x => new { x.Ability, x.Pokemon });
                    table.ForeignKey(
                        name: "FK_AbilityPokemon_Abilities_Pokemon",
                        column: x => x.Pokemon,
                        principalTable: "Abilities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EvolutionChains",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Method = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentStageId = table.Column<int>(type: "INTEGER", nullable: true),
                    NextStageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EvolutionChains", x => x.Id);
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
                    Height = table.Column<float>(type: "REAL", nullable: false),
                    Weight = table.Column<float>(type: "REAL", nullable: false),
                    Egg_group = table.Column<string>(type: "TEXT", nullable: true),
                    Catch_rate = table.Column<int>(type: "INTEGER", nullable: false),
                    Growth_rate = table.Column<string>(type: "TEXT", nullable: true),
                    Gender_rate = table.Column<int>(type: "INTEGER", nullable: false),
                    Is_baby = table.Column<bool>(type: "INTEGER", nullable: false),
                    Is_legendary = table.Column<bool>(type: "INTEGER", nullable: false),
                    Is_mythic = table.Column<bool>(type: "INTEGER", nullable: false),
                    Image = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.DexId);
                    table.ForeignKey(
                        name: "FK_Pokemons_Images_Image",
                        column: x => x.Image,
                        principalTable: "Images",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MovePokemon",
                columns: table => new
                {
                    Move = table.Column<int>(type: "INTEGER", nullable: false),
                    PokemonId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovePokemon", x => new { x.Move, x.PokemonId });
                    table.ForeignKey(
                        name: "FK_MovePokemon_Moves_PokemonId",
                        column: x => x.PokemonId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovePokemon_Pokemons_Move",
                        column: x => x.Move,
                        principalTable: "Pokemons",
                        principalColumn: "DexId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PokemonType",
                columns: table => new
                {
                    Pokemon = table.Column<int>(type: "INTEGER", nullable: false),
                    Type = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PokemonType", x => new { x.Pokemon, x.Type });
                    table.ForeignKey(
                        name: "FK_PokemonType_Pokemons_Type",
                        column: x => x.Type,
                        principalTable: "Pokemons",
                        principalColumn: "DexId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PokemonType_Types_Pokemon",
                        column: x => x.Pokemon,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbilityPokemon_Pokemon",
                table: "AbilityPokemon",
                column: "Pokemon");

            migrationBuilder.CreateIndex(
                name: "IX_EvolutionChains_CurrentStageId",
                table: "EvolutionChains",
                column: "CurrentStageId");

            migrationBuilder.CreateIndex(
                name: "IX_EvolutionChains_NextStageId",
                table: "EvolutionChains",
                column: "NextStageId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_PokemonId",
                table: "Images",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_MovePokemon_PokemonId",
                table: "MovePokemon",
                column: "PokemonId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_Move",
                table: "Moves",
                column: "Move");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_TypeId",
                table: "Moves",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_Image",
                table: "Pokemons",
                column: "Image",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PokemonType_Type",
                table: "PokemonType",
                column: "Type");

            migrationBuilder.CreateIndex(
                name: "IX_TypesInteractions_FirstTypeId",
                table: "TypesInteractions",
                column: "FirstTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesInteractions_SecondTypeId",
                table: "TypesInteractions",
                column: "SecondTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_AbilityPokemon_Pokemons_Ability",
                table: "AbilityPokemon",
                column: "Ability",
                principalTable: "Pokemons",
                principalColumn: "DexId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EvolutionChains_Pokemons_CurrentStageId",
                table: "EvolutionChains",
                column: "CurrentStageId",
                principalTable: "Pokemons",
                principalColumn: "DexId");

            migrationBuilder.AddForeignKey(
                name: "FK_EvolutionChains_Pokemons_NextStageId",
                table: "EvolutionChains",
                column: "NextStageId",
                principalTable: "Pokemons",
                principalColumn: "DexId");

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
                name: "AbilityPokemon");

            migrationBuilder.DropTable(
                name: "EvolutionChains");

            migrationBuilder.DropTable(
                name: "MovePokemon");

            migrationBuilder.DropTable(
                name: "PokemonType");

            migrationBuilder.DropTable(
                name: "TypesInteractions");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
