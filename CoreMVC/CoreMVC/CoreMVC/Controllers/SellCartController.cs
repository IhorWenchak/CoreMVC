using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC.Data.Interfaces;
using CoreMVC.Data.Models;
using CoreMVC.Data.Repository;
using CoreMVC.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class SellCartController : Controller
    {
		private readonly IAllCars _carRepository;
		private readonly SellCart _sellCart;

		public SellCartController(IAllCars carRepository, SellCart sellCart)
		{
			_carRepository = carRepository;
			_sellCart = sellCart;
		}


        public IActionResult Index()
        {
			var items = _sellCart.GetSellItems();
			_sellCart.ListSellItems = items;

			var obj = new SellCartViewModel
			{
				SellCart = _sellCart
			};

            return View(obj);
        }

		public RedirectToActionResult AddToCart(int id)
		{
			var item = _carRepository.Cars.FirstOrDefault(i => i.Id == id);
			if (item != null)
			{
				_sellCart.AddToCart(item);
			}
			return RedirectToAction("Index");
		}
    }
} 