using CoreMVC.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Data
{
	public class DBObjects
	{
		public static void Initial(AppDBContent content)
		{
			if (!content.Category.Any())
			{
				content.AddRange(
					new Category { CategoryName = "Electric car", Desc = "Modern transport" },
					new Category { CategoryName = "Car with internal combustion engine", Desc = "Classic car" });
			}
			
			if (!content.Car.Any() && content.Category.Any())
			{
				content.AddRange(
					new Car
					{
						Name = "Tesla Model S",
						ShortDesc = "Fast car.",
						LongDesc = "Beautiful, fast and very quiet car.",
						Img = "/img/1024px-Tesla_Model_S_02_2013.jpg",
						Price = 45000,
						IsFavourite = true,
						Available = true,
						Category = content.Category.First()
					},
					new Car
					{
						Name = "Nissan Leaf",
						ShortDesc = "Quiet and economical.",
						LongDesc = "Convenient car for the city.",
						Img = "/img/nissan-leaf-jdm-2020.jpg",
						Price = 15000,
						IsFavourite = true,
						Available = true,
						Category = content.Category.First()
					},
					new Car
					{
						Name = "BMW M3",
						ShortDesc = "Daring and stylish.",
						LongDesc = "Convenient car for the city.",
						Img = "/img/bmw-m3-sedan-render.jpg",
						Price = 65000,
						IsFavourite = true,
						Available = true,
						Category = content.Category.Last()
					},
					new Car
					{
						Name = "Mercedes C class",
						ShortDesc = "Cozy and large.",
						LongDesc = "Convenient car for the city.",
						Img = "/img/1400x936.jpg",
						Price = 40000,
						IsFavourite = true,
						Available = true,
						Category = content.Category.Last()
					});
			}

			content.SaveChanges();
		}
	}
}
