public class Move{
    //Primary key
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public string? Power { get; set; }
    public string? Precision { get; set; }
    //Foreign keys
    public virtual ICollection<Pokemon>? Pokemon { get; set; }
    public Type? Type { get; set; }
}