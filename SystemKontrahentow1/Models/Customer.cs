using System.ComponentModel.DataAnnotations;

namespace SystemKontrahentow1.Models
{
    public class Customer
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "To pole jest wymagane!")]
        public string NIP { get; set; }
    }
}
