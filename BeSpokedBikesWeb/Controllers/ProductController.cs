using BeSpokedBikesWeb.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace BeSpokedBikesWeb.Controllers
{
    public class ProductController : Controller
    {
        IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View(_productRepository.GetAllProducts());
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            return PartialView("UpdateProduct", _productRepository.GetProduct(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(ViewModels.Product product)
        {
            try
            {
                _productRepository.Update(product);
                
            }
            catch (Exception ex)
            {
                Response.StatusCode = 400;
                return Content(ex.Message);
            }

            return PartialView("UpdateProduct", product);
        }
    }
}
