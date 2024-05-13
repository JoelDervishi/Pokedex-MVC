using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class EggGroup{
    [Key]
    public int Id { get; set; }
    public string? Name { get; set; }
    
    public virtual ICollection<Pokemon>? Pokemons { get; set; }
}