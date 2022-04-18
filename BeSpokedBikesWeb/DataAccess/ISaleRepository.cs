namespace BeSpokedBikesWeb.DataAccess
{
    public interface ISaleRepository
    {
        IEnumerable<ViewModels.Sale> GetAllSales();
        ViewModels.Sale GetSale(int id);
        ViewModels.Sale Add(ViewModels.Sale sale);
        ViewModels.Sale Update(ViewModels.Sale saleChanges);
        ViewModels.Sale Delete(int id);
    }
}
