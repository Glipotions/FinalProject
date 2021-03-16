using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;


namespace ConsoleUI
{
	class Program
	{
		static void Main(string[] args)
		{
			//ProductTest();
			//CategoryTest();
			ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

			var result = productManager.GetProductDetails();
			if (result.Success)
			{
				foreach (var product in result.Data)
				{
					Console.WriteLine(product.CategoryName + " -- " + product.ProductName);
				}
			}
			else
			{
				Console.WriteLine(result.Message);
			}

		}

		private static void CategoryTest()
		{
			CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
			foreach (var category in categoryManager.GetAll().Data)
			{
				Console.WriteLine(category.CategoryName);
			}
		}

		private static void ProductTest()
		{
			ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

			foreach (var product in productManager.GetAllByUnitPrice(50, 120).Data)
			{
				Console.WriteLine(product.ProductName);
			}
		}
	}
}
