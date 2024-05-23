using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class Pokemon {
    [Key]
    public int DexId { get; set; }
    public string? Name{ get; set; }
    public float Height { get; set; }
    public float Weight { get; set; }
    public int Catch_rate { get; set; }
    public string? Growth_rate { get; set; }
    public int Gender_rate { get; set; }
    public bool Is_baby { get; set; }
    public bool Is_legendary { get; set; }
    public bool Is_mythic { get; set; }
    public int HP { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }
    public int SpAtk { get; set; }
    public int SpDef { get; set; }
    public int Spd { get; set; }

    public int ImageId { get; set; }
    public Image? Image { get; set; }
    public int? PreviousStageId { get; set; }
    public virtual Pokemon? PreviousStage { get; set; }
    
    public virtual ICollection<Pokemon_Ability>? Abilities { get; set; }
    public virtual ICollection<Pokemon_Move>? Moves { get; set; }
    public virtual ICollection<Pokemon_Type>? Types { get; set; }
    public virtual ICollection<Pokemon_EggGroup>? EggGroups { get; set; }
    public virtual ICollection<Favourite>? Favourites { get; set; }
}