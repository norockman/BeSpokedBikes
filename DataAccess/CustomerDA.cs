using BeSpokedBikes.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace BeSpokedBikes.DataAccess
{
    public class CustomerDA
    {
        //private readonly AppDBContext _context;
        //public CustomerDA(AppDBContext context)
        //{
        //    _context = context;
        //}

        //public Customer GetCustomerById(int Id)
        //{
        //    return _context.Customers.Single(x => x.Id == Id);
        //}

        //public List<Customer> GetCustomers()
        //{
        //    return _context.Customers.ToList();
        //}

        //public void Update(Customer updateCustomer)
        //{
        //    var booking = _context.Customers.Attach(updateCustomer);
        //    booking.State = EntityState.Modified;
        //    _context.SaveChanges();
        //}
    }
}
