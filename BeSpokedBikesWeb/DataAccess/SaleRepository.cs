using AutoMapper;
using BeSpokedBikesWeb.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BeSpokedBikesWeb.DataAccess
{
    public class SaleRepository : ISaleRepository
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;
        public SaleRepository(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Sale Add(Sale sale)
        {
            throw new NotImplementedException();
        }

        public Sale Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Sale> GetAllSales()
        {
            return _mapper.Map<List<Sale>>(_context.Sales);
        }

        public Sale GetSale(int id)
        {
            return _mapper.Map<Sale>(_context.Sales.Find(id));
        }

        public Sale Update(Sale saleChanges)
        {
            var tracking = _context.Sales.Attach(_mapper.Map<Models.Sale>(saleChanges));
            tracking.State = EntityState.Modified;
            _context.SaveChanges();

            return saleChanges;
        }
    }
}
