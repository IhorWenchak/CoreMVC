using CoreMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.ViewModels
{
	public class CarsListViewModel
	{
		public IEnumerable<Car> AllCars { get; set; }

		public string _currCategory { get; set; }
	}
}
