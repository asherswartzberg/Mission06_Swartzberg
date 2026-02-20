using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Swartzberg.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }
        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        [Required(ErrorMessage = "Must enter a title")]
        public string Title { get; set; }
        [Range(1888, 2026, ErrorMessage = "Enter a valid year")]
        public int Year { get; set; } = 2026;
        public string? Director { get; set; }
        public string? Rating { get; set; }
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        public bool? CopiedToPlex { get; set; }
        [MaxLength(25)]
        public string? Notes { get; set; }

    }
}
