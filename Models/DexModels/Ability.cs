using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Ability{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public bool Is_hidden { get; set; }
    
    [ForeignKey("Pokemon")]
    public virtual ICollection<Pokemon>? Pokemons { get; set; }
}