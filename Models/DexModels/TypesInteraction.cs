using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Keyless]
public class TypesInteraction{
    
    public float Interaction { get; set; }
    
    [ForeignKey("FirstTypeId")]
    public Type? FirstType { get; set; }
    [ForeignKey("SecondTypeId")]
    public Type? SecondType { get; set; }
}