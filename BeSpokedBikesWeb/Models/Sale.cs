
namespace BeSpokedBikesWeb.Models
{
    public class Sale
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public string Salesperson { get; set; }
        public string Customer { get; set; }
        public DateTime? SalesDate { get; set; }
    }
}
