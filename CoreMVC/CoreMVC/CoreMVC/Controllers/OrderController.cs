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

        public IActionResult CheckOut()
        {
            return View();
        }
    }
}