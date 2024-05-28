using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class TypesInteraction{
    
    public float Interaction { get; set; }
    
    public int FirstTypeId { get; set; }
    public Type? FirstType { get; set; }
    public int SecondTypeId { get; set; }
    public Type? SecondType { get; set; }
}