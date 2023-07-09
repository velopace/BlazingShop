﻿using System;
using BlazingShop.Shared;

namespace BlazingShop.Server.Services.ProductService
{
	public interface IProductService
	{
		Task<List<Product>> GetAllProducts();

		Task<List<Product>> GetProductsByCateogory(string categoryUrl);

		Task<Product> GetProduct(int id);

		Task<List<Product>> SearchProducts(string searchText);
	}
}

