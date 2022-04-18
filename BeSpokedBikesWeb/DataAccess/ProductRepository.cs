using AutoMapper;
using BeSpokedBikesWeb.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BeSpokedBikesWeb.DataAccess
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDBContext _context;
        private readonly IMapper _mapper;
        public ProductRepository(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public Product Add(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _mapper.Map<List<Product>>(_context.Products);
        }

        public Product GetProduct(int id)
        {
            return _mapper.Map<Product>(_context.Products.Find(id));
        }

        public Product Update(Product productChanges)
        {
            Models.Product product = _mapper.Map<Models.Product>(productChanges);

            if (_context.Products.Where(p=>p.Name == product.Name).FirstOrDefault() != null)
                throw new InvalidOperationException("Duplicate product name!");

            var tracking = _context.Products.Attach(product);
            tracking.State = EntityState.Modified;
            _context.SaveChanges();

            return productChanges;
        }
    }
}
