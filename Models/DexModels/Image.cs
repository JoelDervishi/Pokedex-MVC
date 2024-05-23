using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Image {
    [Key]
    public int Id { get; set; }
    public string? Official { get; set; }
    public string? Official_s { get; set; }
    public string? Sprite { get; set; }
    public string? Sprite_s { get; set; }
    public string? Animated { get; set; } 
    public string? Animated_s { get; set; }

    public Pokemon? Pokemon { get; set; }
} 