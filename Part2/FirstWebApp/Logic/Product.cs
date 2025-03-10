using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace FirstWebApp.Logic;

public class Product
{
    
    [Required]
    [StringLength(50, ErrorMessage = "Name must be less than 50 characters.")]
    public string Name { get; set; }
    [Required]
    [Range(0, double.MaxValue, ErrorMessage = "Price must 0 or greater")]
    public decimal Price { get; set; }
    public DateOnly Date { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    public string Description { get; set; }
    public bool IsPublished { get; set; }
    [Range(0, int.MaxValue, ErrorMessage = "Stock cannot be negative.")]
    public int Stock { get; set; }
    [Required]
    public string Category { get; set; }
}