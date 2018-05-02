using BethanyPieShop.Web.Models;
using BethanyPieShop.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanyPieShop.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPieRepository _pieRepository;

        public HomeController(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public IActionResult Index()
        {
            var pies = _pieRepository.GetAllPies();
            var viewModel = new PieListViewModel
            {
                Pies = pies,
                Title = "Available Pies"
            };

            return View(viewModel);
        }
    }
}