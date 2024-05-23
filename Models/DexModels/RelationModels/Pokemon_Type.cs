public class Pokemon_Type {
    public int PokemonDexId { get; set; }
    public virtual Pokemon? Pokemon { get; set; }
    public int TypeId { get; set; }
    public virtual Type? Type { get; set; }
}