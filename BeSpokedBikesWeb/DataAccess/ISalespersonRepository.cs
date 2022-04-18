namespace BeSpokedBikesWeb.DataAccess
{
    public interface ISalespersonRepository
    {
        IEnumerable<ViewModels.Salesperson> GetAllSalespersons();
        ViewModels.Salesperson GetSalesperson(int id);
        ViewModels.Salesperson Add(ViewModels.Salesperson salesperson);
        ViewModels.Salesperson Update(ViewModels.Salesperson SalespersonChanges);
        ViewModels.Salesperson Delete(int id);
    }
}
