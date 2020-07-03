using CoreMVC.Data.Interfaces;
using CoreMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Data.Mocks
{
	public class MockCar : IAllCars
	{
		private readonly ICarsCategory _categoryCars = new MockCategory();

		public IEnumerable<Car> Cars 
		{
			get 
			{
				return new List<Car> {
					new Car {
						Name = "Tesla Model S",
						ShortDesc = "Fast car",
						LongDesc = "Beautiful, fast and very quiet car",
						Img = "/img/1024px-Tesla_Model_S_02_2013.jpg",
						Price = 45000,
						IsFavourite = true,
						Available = true, Category =  _categoryCars.AllCategories.First()
					},
					new Car {
						Name = "Nissan Leaf",
						ShortDesc = "Quiet and economical",
						LongDesc = "Convenient car for the city",
						Img = "/img/nissan-leaf-jdm-2020.jpg",
						Price = 15000, IsFavourite = true,
						Available = true,
						Category =  _categoryCars.AllCategories.First()
					},
					new Car {
						Name = "BMW M3",
						ShortDesc = "Daring and stylish",
						LongDesc = "Convenient car for the city",
						Img = "/img/bmw-m3-sedan-render.jpg",
						Price = 65000, IsFavourite = true,
						Available = true,
						Category =  _categoryCars.AllCategories.Last()
					},
					new Car {
						Name = "Mercedes C class",
						ShortDesc = "Cozy and large",
						LongDesc = "Convenient car for the city",
						Img = "/img/1400x936.jpg",
						Price = 40000, IsFavourite = false,
						Available = false,
						Category =  _categoryCars.AllCategories.Last()
					}
				};
			}
		}


		public IEnumerable<Car> GetFavCars { get; set; }



		public Car GetObjectCar(int carId)
		{
			throw new NotImplementedException();
		}
	}
}
