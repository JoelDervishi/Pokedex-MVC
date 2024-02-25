public class Type {
    //Primary key
    public int  Id { get; set; }
    public string? Name { get; set; }
    //Foreign key
    public virtual ICollection<Pokemon>? Pokemons { get; set; }
    public virtual ICollection<TypesInteraction>? TypesInteractions { get; set; }
}