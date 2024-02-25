public class Image{
    public string? Official { get; set; }
    public string? Official_s { get; set; }
    public string? Sprite { get; set; }
    public string? Sprite_s { get; set; }
    public string? Animated { get; set; }
    public string? Animated_s { get; set; }
    //Foreign key
    public Pokemon? Pokemon { get; set; }
}