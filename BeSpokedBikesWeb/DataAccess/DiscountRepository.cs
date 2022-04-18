using AutoMapper;
using BeSpokedBikesWeb.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BeSpokedBikesWeb.DataAccess
{
    public class DiscountRepository : IDiscountRepository
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;
        public DiscountRepository(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Discount Add(Discount discount)
        {
            throw new NotImplementedException();
        }

        public Discount Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Discount> GetAllDiscounts()
        {
            return _mapper.Map<List<Discount>>(_context.Discounts);
        }

        public Discount GetDiscount(int id)
        {
            return _mapper.Map<Discount>(_context.Discounts.Find(id));
        }

        public Discount Update(Discount discountChanges)
        {
            var tracking = _context.Discounts.Attach(_mapper.Map<Models.Discount>(discountChanges));
            tracking.State = EntityState.Modified;
            _context.SaveChanges();

            return discountChanges;
        }
    }
}
