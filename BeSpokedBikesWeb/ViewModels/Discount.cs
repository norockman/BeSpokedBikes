using System.ComponentModel.DataAnnotations;

namespace BeSpokedBikesWeb.ViewModels
{
    public class Discount
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Product { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DiscountPercentage { get; set; }
    }
}
