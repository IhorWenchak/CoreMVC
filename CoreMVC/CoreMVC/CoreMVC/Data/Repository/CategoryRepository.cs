using CoreMVC.Data.Interfaces;
using CoreMVC.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Data.Repository
{
	public class CategoryRepository : ICarsCategory
	{

		private readonly AppDBContent appDBContent;

		public CategoryRepository(AppDBContent appDBContent)
		{
			this.appDBContent = appDBContent;
		}

		IEnumerable<Category> ICarsCategory.AllCategories => appDBContent.Category;
	}
}
