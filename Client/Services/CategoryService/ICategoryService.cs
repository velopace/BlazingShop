using System;
using BlazingShop.Shared;

namespace BlazingShop.Client.Services.CategoryService
{
	public interface ICategoryService
	{
		List<Category> Categories { get; set; }
		public Task LoadCategories();
	}
}

