using AutoMapper;
using BeSpokedBikesWeb.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BeSpokedBikesWeb.DataAccess
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;
        public CustomerRepository(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Customer Add(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _mapper.Map<List<Customer>>(_context.Customers);
        }

        public Customer GetCustomer(int id)
        {
            return _mapper.Map<Customer>(_context.Customers.Find(id));
        }

        public Customer Update(Customer cutomerChanges)
        {
            var tracking = _context.Customers.Attach(_mapper.Map<Models.Customer>(cutomerChanges));
            tracking.State = EntityState.Modified;
            _context.SaveChanges();

            return cutomerChanges;
        }
    }
}
