namespace BeSpokedBikesWeb.DataAccess
{
    public interface ICustomerRepository
    {
        IEnumerable<ViewModels.Customer> GetAllCustomers();
        ViewModels.Customer GetCustomer(int id);
        ViewModels.Customer Add(ViewModels.Customer customer);
        ViewModels.Customer Update(ViewModels.Customer cutomerChanges);
        ViewModels.Customer Delete(int id);
    }
}
