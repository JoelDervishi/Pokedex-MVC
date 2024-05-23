using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pokedex_MVC.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
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
                    Animated_s = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
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
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Password = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pokemons",
                columns: table => new
                {
                    DexId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
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
                    ImageId = table.Column<int>(type: "INTEGER", nullable: false),
                    PreviousStageId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemons", x => x.DexId);
                    table.ForeignKey(
                        name: "FK_Pokemons_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemons_Pokemons_PreviousStageId",
                        column: x => x.PreviousStageId,
                        principalTable: "Pokemons",
                        principalColumn: "DexId");
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
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moves", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Moves_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TypesInteractions",
                columns: table => new
                {
                    Interaction = table.Column<float>(type: "REAL", nullable: false),
                    FirstTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    SecondTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_TypesInteractions_Types_FirstTypeId",
                        column: x => x.FirstTypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TypesInteractions_Types_SecondTypeId",
                        column: x => x.SecondTypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Favourite",
                columns: table => new
                {
                    PokemonDexId = table.Column<int>(type: "INTEGER", nullable: false),
                    UserId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Favourite", x => new { x.PokemonDexId, x.UserId });
                    table.ForeignKey(
                        name: "FK_Favourite_Pokemons_PokemonDexId",
                        column: x => x.PokemonDexId,
                        principalTable: "Pokemons",
                        principalColumn: "DexId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Favourite_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
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
                name: "Pokemon_EggGroup",
                columns: table => new
                {
                    PokemonDexId = table.Column<int>(type: "INTEGER", nullable: false),
                    EggGroupId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_EggGroup", x => new { x.PokemonDexId, x.EggGroupId });
                    table.ForeignKey(
                        name: "FK_Pokemon_EggGroup_EggGroups_EggGroupId",
                        column: x => x.EggGroupId,
                        principalTable: "EggGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_EggGroup_Pokemons_PokemonDexId",
                        column: x => x.PokemonDexId,
                        principalTable: "Pokemons",
                        principalColumn: "DexId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon_Type",
                columns: table => new
                {
                    PokemonDexId = table.Column<int>(type: "INTEGER", nullable: false),
                    TypeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_Type", x => new { x.PokemonDexId, x.TypeId });
                    table.ForeignKey(
                        name: "FK_Pokemon_Type_Pokemons_PokemonDexId",
                        column: x => x.PokemonDexId,
                        principalTable: "Pokemons",
                        principalColumn: "DexId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Type_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pokemon_Move",
                columns: table => new
                {
                    PokemonDexId = table.Column<int>(type: "INTEGER", nullable: false),
                    MoveId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pokemon_Move", x => new { x.PokemonDexId, x.MoveId });
                    table.ForeignKey(
                        name: "FK_Pokemon_Move_Moves_MoveId",
                        column: x => x.MoveId,
                        principalTable: "Moves",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Pokemon_Move_Pokemons_PokemonDexId",
                        column: x => x.PokemonDexId,
                        principalTable: "Pokemons",
                        principalColumn: "DexId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Favourite_UserId",
                table: "Favourite",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Moves_TypeId",
                table: "Moves",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Ability_AbilityId",
                table: "Pokemon_Ability",
                column: "AbilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_EggGroup_EggGroupId",
                table: "Pokemon_EggGroup",
                column: "EggGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Move_MoveId",
                table: "Pokemon_Move",
                column: "MoveId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemon_Type_TypeId",
                table: "Pokemon_Type",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_ImageId",
                table: "Pokemons",
                column: "ImageId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pokemons_PreviousStageId",
                table: "Pokemons",
                column: "PreviousStageId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesInteractions_FirstTypeId",
                table: "TypesInteractions",
                column: "FirstTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TypesInteractions_SecondTypeId",
                table: "TypesInteractions",
                column: "SecondTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Favourite");

            migrationBuilder.DropTable(
                name: "Pokemon_Ability");

            migrationBuilder.DropTable(
                name: "Pokemon_EggGroup");

            migrationBuilder.DropTable(
                name: "Pokemon_Move");

            migrationBuilder.DropTable(
                name: "Pokemon_Type");

            migrationBuilder.DropTable(
                name: "TypesInteractions");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Abilities");

            migrationBuilder.DropTable(
                name: "EggGroups");

            migrationBuilder.DropTable(
                name: "Moves");

            migrationBuilder.DropTable(
                name: "Pokemons");

            migrationBuilder.DropTable(
                name: "Types");

            migrationBuilder.DropTable(
                name: "Images");
        }
    }
}
