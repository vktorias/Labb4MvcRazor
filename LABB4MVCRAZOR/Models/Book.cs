using System.ComponentModel.DataAnnotations;

namespace LABB4MVCRAZOR.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required(ErrorMessage = "The title is mandatory.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Publication year is required")]
        public int PublicationYear { get; set; }

    }
}
