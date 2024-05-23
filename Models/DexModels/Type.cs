using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Type { 
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    
    public virtual ICollection<Pokemon_Type>? Pokemons { get; set; }
    public virtual ICollection<Move>? Moves { get; set; }
}