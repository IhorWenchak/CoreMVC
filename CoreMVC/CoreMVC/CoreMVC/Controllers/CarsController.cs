using CoreMVC.Data.Interfaces;
using CoreMVC.Data.Models;
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

		public CarsController(IAllCars allCars, ICarsCategory allCatigories)
		{
			_allCars = allCars;
			_allCatgories = allCatigories;
		}

		[Route("Cars/ListCars")]
		[Route("Cars/ListCars/{category}")]
		public ViewResult ListCars(string category)
		{
			string _category = category;
			string _currCategory = "";

			IEnumerable<Car> cars = null;

			if(string.IsNullOrEmpty(_category))
			{
				cars = _allCars.Cars.OrderBy(i => i.Id);
			}
			else
			{
				int currCatId = _allCatgories.AllCategories.Where(i => i.CategoryName.Contains(_category)).First().Id;
				cars = _allCars.Cars.Where(i => i.CategoryId == currCatId);

				if(currCatId == 1)
				{
					_currCategory = "Electric cars:";
				}
				else if(currCatId == 2)
				{
					_currCategory = "Cars with internal combustion engine:";
				}
				
			}
			
			ViewBag.Title = "Page with cars";

			var obj = new CarsListViewModel()
			{
				AllCars = cars,
				CurrCategory = _currCategory
			};			
			
			return View(obj);
		}
	}
}
