﻿using System;
namespace BlazingShop.Shared
{
	public class Edition
	{
		public int Id { get; set; }

		public string Name { get; set; }

		public List<Product> Products { get; set; }
	}
}

