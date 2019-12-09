using System.ComponentModel.DataAnnotations;
namespace RazorFun.Models
{
    public class Student
    {
        [Required]
        [MinLength(3)]
        public string Name {get; set;}
        public string Location {get; set;}
        [Required]
        public string Content {get; set;}
    }
}