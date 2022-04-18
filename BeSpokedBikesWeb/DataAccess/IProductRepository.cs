namespace BeSpokedBikesWeb.DataAccess
{
    public interface IProductRepository
    {
        IEnumerable<ViewModels.Product> GetAllProducts();
        ViewModels.Product GetProduct(int id);
        ViewModels.Product Add(ViewModels.Product product);
        ViewModels.Product Update(ViewModels.Product productChanges);
        ViewModels.Product Delete(int id);
    }
}
