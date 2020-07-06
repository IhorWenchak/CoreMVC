﻿using CoreMVC.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMVC.Data
{
	public class AppDBContent : DbContext 
	{
		public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
		{

		}

		public DbSet<Car> Car { get; set; }
		public DbSet<Category> Category { get; set; }
	}
}