using FlightBookingSystemV2.Data;
using FlightBookingSystemV2.Models;
using FlightBookingSystemV2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlightBookingSystemV2.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;
        private readonly IUserRespository _userRepository;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public HomeController(IUserRespository userRespository)
        {
            this._userRepository = userRespository;
        }

        public IActionResult Index()
        {
            return View(_userRepository.GetAll());
        }

        public IActionResult UserRegistration()
        {
            return View(new UserRegistrationVM());
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