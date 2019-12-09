using System.ComponentModel.DataAnnotations;
namespace MultipleModels.Models
{
    public class User
    {
        [Required]
        [MinLength(3)]
        public string Username {get; set;}
        [Required]
        [Range(1, int.MaxValue, ErrorMessage="Please enter a value greater than 0")]
        public int Age {get;set;}
    }
}