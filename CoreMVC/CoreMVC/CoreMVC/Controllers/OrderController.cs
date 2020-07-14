using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVC.Data.Interfaces;
using CoreMVC.Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class OrderController : Controller
    {
		private readonly IAllOrders _allOrders;
		private readonly SellCart _sellCart;

		public OrderController(IAllOrders allOrders, SellCart sellCart)
		{
			_allOrders = allOrders;
			_sellCart = sellCart;
		}

		[HttpGet]
		public IActionResult CheckOut()
		{
			_sellCart.ListSellItems = _sellCart.GetSellItems();
			if (_sellCart.ListSellItems.Count == 0)
			{
				ModelState.AddModelError("", "Cart is empty!");
				return RedirectToAction("NotComplete");
			}
			return View();
		}

		[HttpPost]
		public IActionResult CheckOut(Order order)
		{
			_sellCart.ListSellItems = _sellCart.GetSellItems();

			if (ModelState.IsValid) 
			{
				_allOrders.CreateOrder(order);
				return RedirectToAction("Complete");
			}

			return View(order);
		}

		public IActionResult Complete()
		{
			ViewBag.Message = "Order is complete.";
			return View();
		}

		public IActionResult NotComplete()
		{
			ViewBag.Message = "Cart is empty!";
			return View();
		}
	}
}