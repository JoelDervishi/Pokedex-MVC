public class Pokemon_Move {
    public int PokemonDexId { get; set; }
    public virtual Pokemon? Pokemon { get; set; }
    public int MoveId { get; set; }
    public virtual Move? Move { get; set; }
}