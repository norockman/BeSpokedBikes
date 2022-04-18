using BeSpokedBikesWeb.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedBikesWeb.Controllers
{
    public class SalespersonController : Controller
    {
        ISalespersonRepository _salespersonRepository;
        public SalespersonController(ISalespersonRepository salespersonRepository)
        {
            _salespersonRepository = salespersonRepository;
        }
        public IActionResult Index()
        {
            return View(_salespersonRepository.GetAllSalespersons());
        }

        [HttpGet]
        public IActionResult Update(int Id)
        {
            return PartialView("UpdateSalesperson", _salespersonRepository.GetSalesperson(Id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ViewModels.Salesperson salesPerson)
        {
            try
            {
                _salespersonRepository.Update(salesPerson);
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Content(ex.Message);
            }
            return PartialView("UpdateSalesperson", salesPerson);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _salespersonRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
