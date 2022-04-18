using BeSpokedBikesWeb.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedBikesWeb.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IActionResult Index()
        {
            return View(_customerRepository.GetAllCustomers());
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return PartialView("UpdateCustomer", _customerRepository.GetCustomer(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ViewModels.Customer customer)
        {
            _customerRepository.Update(customer);
            return PartialView("UpdateCustomer", customer);
        }
    }
}
