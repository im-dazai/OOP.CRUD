using Microsoft.AspNetCore.Mvc;
using OOP.CRUD.DAL;
using OOP.CRUD.Entity.VM;
using OOP.CRUD.Models;
using System.Diagnostics;

namespace OOP.CRUD.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        public IActionResult Index()
        {
            // Implement return list
            var list = _productRepository.GetAll();
            return View(list);
        }

        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(TblProduct product)
        {
            _productRepository.Add(product); 
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditProduct(TblProduct product)
        {
            _productRepository.Update(product);
            return RedirectToAction("Index");
        }

        public IActionResult EditProduct(int id)
        {
            var product = _productRepository.GetByID(id); 
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            _productRepository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}