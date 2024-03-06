using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Move{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Power { get; set; }
    public string? Precision { get; set; }
    

    [ForeignKey("PokemonId")]
    public virtual ICollection<Pokemon>? Pokemons { get; set; }
    [ForeignKey("TypeId")]
    public Type? Type { get; set; }
}