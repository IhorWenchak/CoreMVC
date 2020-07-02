using CoreMVC.Data.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Controllers
{
	public class CarsController : Controller
	{
		private readonly IAllCars _allCars;
		private readonly ICarsCategory _allCatgories;

		public CarsController(IAllCars allCars, ICarsCategory allCatgories)
		{
			_allCars = allCars;
			_allCatgories = allCatgories;
		}

		public ViewResult ListCars()
		{
			ViewBag.Category = _allCatgories.AllCategories;
			var cars = _allCars.Cars;
			return View(cars);
		}
	}
}
