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
						Img = "https://ru.wikipedia.org/wiki/Tesla_Model_S#/media/%D0%A4%D0%B0%D0%B9%D0%BB:Tesla_Model_S_02_2013.jpg",
						Price = 45000,
						IsFavourite = true,
						Available = true, Category =  _categoryCars.AllCategories.First()
					},
					new Car {
						Name = "Nissan Leaf",
						ShortDesc = "Quiet and economical",
						LongDesc = "Convenient car for the city",
						Img = "https://ru.motor1.com/photos/707711/nissan-leaf-jdm-2020/",
						Price = 15000, IsFavourite = true,
						Available = true,
						Category =  _categoryCars.AllCategories.First()
					},
					new Car {
						Name = "BMW M3",
						ShortDesc = "Daring and stylish",
						LongDesc = "Convenient car for the city",
						Img = "https://ru.motor1.com/photo/3749044/rendering-bmw-m3-sedan/",
						Price = 65000, IsFavourite = true,
						Available = true,
						Category =  _categoryCars.AllCategories.Last()
					},
					new Car {
						Name = "Mercedes C class",
						ShortDesc = "Cozy and large",
						LongDesc = "Convenient car for the city",
						Img = "https://mercedes-c-class.infocar.ua/c-class_id5523.html",
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
