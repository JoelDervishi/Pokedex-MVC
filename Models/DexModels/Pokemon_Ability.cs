using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

[Keyless]
public class Pokemon_Ability{
    public bool Is_hidden { get; set; }
    
    [ForeignKey("PokemonId")]
    public virtual ICollection<Pokemon>? Pokemons { get; set; }
    [ForeignKey("AbilityId")]
    public virtual ICollection<Ability>? Abilities { get; set; }
}