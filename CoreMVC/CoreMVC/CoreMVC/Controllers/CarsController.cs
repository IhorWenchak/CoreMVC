using CoreMVC.Data.Interfaces;
using CoreMVC.ViewModels;
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
			ViewBag.Title = "Page with cars";
			CarsListViewModel carsListViewModel = new CarsListViewModel();
			CarsListViewModel obj = carsListViewModel;
			obj.AllCars = _allCars.Cars;
			obj._currCategory = " ";
			return View(obj);
		}
	}
}
