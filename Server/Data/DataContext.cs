﻿using System;
using BlazingShop.Shared;
using Microsoft.EntityFrameworkCore;

namespace BlazingShop.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{
		}

		public DbSet<Category> Categories { get; set; }

		public DbSet<Product> Products { get; set; }
	}
}

