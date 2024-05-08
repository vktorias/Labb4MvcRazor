using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LABB4MVCRAZOR.Models
{
    public class Lending
    {
        [Key]
        public int LendingId { get; set; }

        [Required(ErrorMessage = "Customer is required")]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Book is required")]
        [ForeignKey("Book")]
        public int BookId { get; set; }

        [Required(ErrorMessage = "Lend date is required")]
        public DateTime LendDate { get; set; }

        public DateTime? ReturnDate { get; set; }
        public bool Returned { get; set; }
        public Customer Customer { get; set; }
        public Book Book { get; set; }
    }
}

