using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

public class User {
    [Key]
    public int Id { get; set; }
    public string? Username{ get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; } 
    public virtual ICollection<Favourite>? Favourites { get; set; }

}