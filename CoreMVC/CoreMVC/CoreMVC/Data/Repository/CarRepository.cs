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

		public IEnumerable<Car> Cars => appDBContent.Car.Include(c => c.Category);

		public IEnumerable<Car> GetFavCars => appDBContent.Car.Where(p => p.IsFavourite).Include(c => c.Category);

		Car IAllCars.GetObjectCar(int carId) => appDBContent.Car.FirstOrDefault(p => p.Id == carId);
		
	}
}
