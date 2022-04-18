using System.ComponentModel.DataAnnotations;

namespace BeSpokedBikesWeb.ViewModels
{
    public class Salesperson
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public string Manager { get; set; }
    }
}
