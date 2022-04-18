using BeSpokedBikesWeb.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedBikesWeb.Controllers
{
    public class DiscountController : Controller
    {
        private readonly IDiscountRepository _discountRepository;
        public DiscountController(IDiscountRepository discountRepository)
        {
            _discountRepository = discountRepository;
        }
        public IActionResult Index()
        {
            return View(_discountRepository.GetAllDiscounts());
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return PartialView("UpdateDiscount", _discountRepository.GetDiscount(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ViewModels.Discount discount)
        {
            _discountRepository.Update(discount);
            return PartialView("UpdateDiscount", discount);
        }
    }
}
