using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class Favourite {
    public int PokemonDexId { get; set; }
    public virtual Pokemon? Pokemon { get; set; }
    public int UserId { get; set; }
    public virtual User? User { get; set; }
}