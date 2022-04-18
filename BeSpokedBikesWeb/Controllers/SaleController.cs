using BeSpokedBikesWeb.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedBikesWeb.Controllers
{
    public class SaleController : Controller
    {
        ISaleRepository _saleRepository;
        public SaleController(ISaleRepository saleRepository)
        {
            _saleRepository = saleRepository;
        }
        public IActionResult Index()
        {
            return View(_saleRepository.GetAllSales());
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return PartialView("UpdateSale", _saleRepository.GetSale(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ViewModels.Sale sale)
        {
            _saleRepository.Update(sale);
            return PartialView("UpdateSale", sale);
        }
    }
}
