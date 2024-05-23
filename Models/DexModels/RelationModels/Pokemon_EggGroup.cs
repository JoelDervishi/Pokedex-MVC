public class Pokemon_EggGroup {
    public int PokemonDexId { get; set; }
    public virtual Pokemon? Pokemon { get; set; }
    public int EggGroupId { get; set; }
    public virtual EggGroup? EggGroup { get; set; }
}