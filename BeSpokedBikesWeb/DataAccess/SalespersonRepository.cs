using AutoMapper;
using BeSpokedBikesWeb.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace BeSpokedBikesWeb.DataAccess
{
    public class SalespersonRepository : ISalespersonRepository
    {
        AppDBContext _context;
        IMapper _mapper;
        public SalespersonRepository(AppDBContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Salesperson Add(Salesperson salesperson)
        {
            throw new NotImplementedException();
        }

        public Salesperson Delete(int id)
        {
            Models.Salesperson salesperson = _context.Salespersons.Find(id);
            if (salesperson != null)
            {
                _context.Salespersons?.Remove(salesperson);
                _context.SaveChanges();
            }

            return _mapper.Map<Salesperson>(salesperson);
        }

        public IEnumerable<Salesperson> GetAllSalespersons()
        {
            return _mapper.Map<List<Salesperson>>(_context.Salespersons);
        }

        public Salesperson GetSalesperson(int id)
        {
            return _mapper.Map<Salesperson>(_context.Salespersons.Find(id));
        }

        public Salesperson Update(Salesperson salespersonChanges)
        {
            Models.Salesperson salePerson = _mapper.Map<Models.Salesperson>(salespersonChanges);

            if (_context.Salespersons.Where(s => s.FirstName == salePerson.FirstName && s.LastName == salePerson.LastName).FirstOrDefault() != null)
                throw new InvalidOperationException("Duplicate sale person name!");

            var tracking = _context.Salespersons.Attach(salePerson);
            tracking.State = EntityState.Modified;
            _context.SaveChanges();

            return salespersonChanges;
        }
    }
}
