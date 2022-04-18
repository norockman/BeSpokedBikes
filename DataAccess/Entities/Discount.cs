namespace BeSpokedBikes.DataAccess.Entities
{ 
    public class Discount
    {
        public int Id { get; set; }
        public string Product { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int DiscountPercentage { get; set; }
    }
}
