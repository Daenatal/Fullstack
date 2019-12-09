using System.ComponentModel.DataAnnotations;
namespace MultipleModels.Models 
{
    public class Product 
    {
        [Required]
        [MinLength(3)]
        public string Name {get; set;}
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage="Please enter a value greater than 0")]
        public double Price {get; set;}
    }
}