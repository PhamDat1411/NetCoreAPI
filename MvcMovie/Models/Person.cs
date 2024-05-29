using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public string PersonId { get; set;}
        [Required]
        public string FullName { get; set;}
        [Required]
        public string? Address { get; set;}
        public string? WorkAt { get; set; }
    }
}