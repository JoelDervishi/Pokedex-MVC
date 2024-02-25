public class Ability{
    //Primary key
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool Is_hidden { get; set; }
    //Foreign key 
    public virtual ICollection<Pokemon>? Pokemons { get; set; }
}