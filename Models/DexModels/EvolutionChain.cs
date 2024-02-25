public class EvolutionChain{
    //Primary key
    public int Id { get; set; }
    public string? Method { get; set; }
    //Foreign keys 
    public virtual Pokemon? CurrentStage { get; set; }
    public virtual Pokemon? NextStage { get; set; }
}