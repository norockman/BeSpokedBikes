namespace BeSpokedBikesWeb.DataAccess
{
    public interface IDiscountRepository
    {
        IEnumerable<ViewModels.Discount> GetAllDiscounts();
        ViewModels.Discount GetDiscount(int id);
        ViewModels.Discount Add(ViewModels.Discount discount);
        ViewModels.Discount Update(ViewModels.Discount discountChanges);
        ViewModels.Discount Delete(int id);
    }
}
