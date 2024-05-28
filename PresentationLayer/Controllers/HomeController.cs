using BusinessLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace PresentationLayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductRepository _productRepository;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository; 
        }

        public IActionResult Index()
        {
            List<Product> products = _productRepository.GetAll();   
            return View(products);
        }

        public IActionResult Create(string name, string description)
        {
            _productRepository.Create(new Product { Name = name, Description = description });
            return View("Views/Home/Index.cshtml", _productRepository.GetAll());
        }

        public IActionResult Privacy()
        {
            return View();
        }

    }
}
