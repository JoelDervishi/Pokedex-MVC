using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class Pokemon_Ability{
    public bool Is_hidden { get; set; }
    
    public int PokemonDexId { get; set; }
    public virtual Pokemon? Pokemon { get; set; }
    public int AbilityId { get; set; }
    public virtual Ability? Ability { get; set; }
}