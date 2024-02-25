public class TypesInteraction{
    public float Interaction { get; set; }
    //Foreign key
    public Type? FirstType { get; set; }
    public Type? SecondType { get; set; }
}