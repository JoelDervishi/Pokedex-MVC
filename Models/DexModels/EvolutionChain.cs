using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class EvolutionChain{
    [Key]
    public int Id { get; set; }
    public string? Method { get; set; }

    [ForeignKey("CurrentStageId")]
    public virtual Pokemon? CurrentStage { get; set; }
    [ForeignKey("NextStageId")]
    public virtual Pokemon? NextStage { get; set; }
}