public class Pokemon{
    //Primary key
    public int DexId { get; set; }  
    public string? Name{ get; set; }
    public string? Name_Jap { get; set; }
    public float Height { get; set; }
    public float Weight { get; set; }
    public string? Egg_group { get; set; }
    public int Catch_rate { get; set; }
    public string? Growth_rate { get; set; }
    public int Gender_rate { get; set; }
    public bool Is_baby { get; set; }
    public bool Is_legendary { get; set; }
    public bool Is_mythic { get; set; }
    //Foreign keys
    public virtual ICollection<Type>? Types { get; set; }
    public virtual ICollection<Ability>? Abilities { get; set; }
    public EvolutionChain? EvolutionChain { get; set; }
    public virtual ICollection<Move>? Moves { get; set; }

}