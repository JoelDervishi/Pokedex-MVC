using Microsoft.EntityFrameworkCore;

public class PokemonContext : DbContext{
    public DbSet<Ability> Abilities { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Move> Moves { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<Type> Types { get; set; }
    public DbSet<TypesInteraction> TypesInteractions { get; set; }
    public DbSet<EggGroup> EggGroups { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=Data/Pokedex.db");
    }
}