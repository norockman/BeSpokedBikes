using System.ComponentModel.DataAnnotations;

namespace BeSpokedBikesWeb.ViewModels
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Product { get; set; }
        [Required]
        public string Salesperson { get; set; }
        public string Customer { get; set; }
        public DateTime SalesDate { get; set; }
    }
}
