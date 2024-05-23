using Microsoft.EntityFrameworkCore;

public class PokemonContext : DbContext{
    public DbSet<Ability> Abilities { get; set; }
    public DbSet<Image> Images { get; set; }
    public DbSet<Move> Moves { get; set; }
    public DbSet<Pokemon> Pokemons { get; set; }
    public DbSet<Type> Types { get; set; }
    public DbSet<TypesInteraction> TypesInteractions { get; set; }
    public DbSet<EggGroup> EggGroups { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=Data/Pokedex.db");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Pokemon_Ability>().HasKey(x => new {x.PokemonDexId, x.AbilityId});

        modelBuilder.Entity<Pokemon_Ability>()
            .HasOne(e => e.Ability)
            .WithMany(s => s.Pokemons)
            .HasForeignKey(e => e.AbilityId);
        modelBuilder.Entity<Pokemon_Ability>()
            .HasOne(e => e.Pokemon)
            .WithMany(c => c.Abilities)
            .HasForeignKey(e => e.PokemonDexId);        

        modelBuilder.Entity<Pokemon_EggGroup>().HasKey(x => new {x.PokemonDexId, x.EggGroupId});

        modelBuilder.Entity<Pokemon_EggGroup>()
            .HasOne(e => e.EggGroup)
            .WithMany(s => s.Pokemons)
            .HasForeignKey(e => e.EggGroupId);
        modelBuilder.Entity<Pokemon_EggGroup>()
            .HasOne(e => e.Pokemon)
            .WithMany(s => s.EggGroups)
            .HasForeignKey(e => e.PokemonDexId);

        modelBuilder.Entity<Pokemon_Move>().HasKey(x => new {x.PokemonDexId, x.MoveId});

        modelBuilder.Entity<Pokemon_Move>()
            .HasOne(e => e.Move)
            .WithMany(s => s.Pokemons)
            .HasForeignKey(e => e.MoveId);
        modelBuilder.Entity<Pokemon_Move>()
            .HasOne(e => e.Pokemon)
            .WithMany(s => s.Moves)
            .HasForeignKey(e => e.PokemonDexId);

        modelBuilder.Entity<Pokemon_Type>().HasKey(x => new {x.PokemonDexId, x.TypeId});

        modelBuilder.Entity<Pokemon_Type>()
            .HasOne(e => e.Type)
            .WithMany(s => s.Pokemons)
            .HasForeignKey(e => e.TypeId);
        modelBuilder.Entity<Pokemon_Type>()
            .HasOne(e => e.Pokemon)
            .WithMany(s => s.Types)
            .HasForeignKey(e => e.PokemonDexId);
        //
        modelBuilder.Entity<Favourite>().HasKey(x => new {x.PokemonDexId, x.UserId});

        modelBuilder.Entity<Favourite>()
            .HasOne(e => e.Pokemon)
            .WithMany(s => s.Favourites)
            .HasForeignKey(e => e.PokemonDexId);
        modelBuilder.Entity<Favourite>()
            .HasOne(e => e.User)
            .WithMany(s => s.Favourites)
            .HasForeignKey(e => e.UserId);
    }
}