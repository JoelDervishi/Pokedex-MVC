using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Move{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public int? Power { get; set; }
    public int? Precision { get; set; }
    public int? PowerPoints { get; set; }
    
    public int TypeId { get; set; }
    public Type? Type { get; set; }
    
    public virtual ICollection<Pokemon_Move>? Pokemons { get; set; }
}