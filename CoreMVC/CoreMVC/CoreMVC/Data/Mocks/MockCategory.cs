using CoreMVC.Data.Interfaces;
using CoreMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Data.Mocks
{
	public class MockCategory : ICarsCategory
	{
		public IEnumerable<Category> AllCategories 
			
		{
			get 
			{
			return new List<Category>
			{
				new Category { CategoryName = "Electric car", Desc = "Modern transport" },
				new Category { CategoryName = "Car with internal combustion engine", Desc = "Classic car" }
			};
			}

		}
		
	}
}
