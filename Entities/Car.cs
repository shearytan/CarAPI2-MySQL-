using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarAPI.Entities 
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Firstname { get; set; }
        [Required]
        [MaxLength(100)]
        public string Lastname { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name_speak { get; set; }
    }
}