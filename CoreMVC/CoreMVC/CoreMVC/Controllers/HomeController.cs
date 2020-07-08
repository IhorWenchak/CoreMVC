using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC.Data.Interfaces;
using CoreMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class HomeController : Controller
    {
		private IAllCars _carRepository;

		public HomeController(IAllCars carRepository)
		{
			_carRepository = carRepository;
		}

        public IActionResult Index()
        {
			var homeCars = new HomeViewModel
			{
				FavCars = _carRepository.GetFavCars
			};
            return View(homeCars);
        }
    }
}