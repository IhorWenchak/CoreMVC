using CoreMVC.Data.Interfaces;
using CoreMVC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Data.Repository
{
	public class CarRepository : IAllCars
	{
		private readonly AppDBContent appDBContent;

		public CarRepository(AppDBContent appDBContent)
		{
			this.appDBContent = appDBContent;
		}

		IEnumerable<Car> IAllCars.Cars => appDBContent.Car.Include(c => c.Category);

		IEnumerable<Car> IAllCars.GetFavCars => appDBContent.Car.Where(p => p.IsFavourite).Include(c => c.Category);

		Car IAllCars.GetObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.Id == carId);
		
	}
}
