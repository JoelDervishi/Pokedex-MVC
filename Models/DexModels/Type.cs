using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Type {
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    
    [ForeignKey("Pokemon")]
    public virtual ICollection<Pokemon>? Pokemons { get; set; }
    [ForeignKey("Move")]
    public virtual ICollection<Move>? Moves { get; set; }
}