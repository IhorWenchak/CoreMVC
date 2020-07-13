using CoreMVC.Data.Interfaces;
using CoreMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Data.Repository 
{
	public class OrdersRepository : IAllOrders
	{
		private readonly AppDBContent _appDBContent;
		private readonly SellCart _sellCart;

		public OrdersRepository(AppDBContent appDBContent, SellCart sellCart)
		{
			_appDBContent = appDBContent;
			_sellCart = sellCart;
		}


		public void CreateOrder(Order order)
		{
			order.OrderTime = DateTime.Now;
			_appDBContent.Order.Add(order);

			var items = _sellCart.ListSellItems;

			foreach (var item in items)
			{
				var orderDatail = new OrderDetail
				{
					CarId = item.Car.Id,
					OrderId = order.Id,
					Price = item.Car.Price
				};
				_appDBContent.OrderDetail.Add(orderDatail);
			}
			_appDBContent.SaveChanges();
		}
	}
}

