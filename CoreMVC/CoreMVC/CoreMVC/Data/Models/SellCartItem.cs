using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Data.Models
{
	public class SellCartItem
	{
		public int Id { get; set; }

		public Car Car { get; set; }

		public int Price { get; set; }

		public string SellCartId { get; set; }
	}
}
