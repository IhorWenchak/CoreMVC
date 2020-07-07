using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Data.Models
{
	public class SellCart
	{

		private readonly AppDBContent appDBContent;

		public SellCart(AppDBContent appDBContent)
		{
			this.appDBContent = appDBContent;
		}


		public string SellCartId { get; set; }

		public List<SellCartItem> ListSellItems { get; set; }

		public static SellCart GetCart(IServiceProvider services)
		{
			ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
			var context = services.GetService<AppDBContent>();
			string sellCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

			session.SetString("CartId", sellCartId);

			return new SellCart(context) { SellCartId = sellCartId };
		}

		public void AddToCart(Car car)
		{
			appDBContent.SellCartItem.Add(new SellCartItem
			{
				SellCartId = SellCartId,
				Car = car,
				Price = car.Price
			});

			appDBContent.SaveChanges();
		}

		public List<SellCartItem> GetSellItems()
		{
			return appDBContent.SellCartItem.Where(c => c.SellCartId == SellCartId).Include(s => s.Car).ToList();
		}
	}
}
