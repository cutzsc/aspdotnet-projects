using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
	public class HomeController : Controller
	{
		public async Task<IActionResult> Index()
		{
			//List<string> results = new List<string>();

			//ShoppingCart shoppingCart = new ShoppingCart (Product.GetProducts());

			//Product[] products = Product.GetProducts();
			//for (int i = 0; i < products.Length; i++)
			//{
			//	if (products[i] != null)
			//	{
			//		results.Add(
			//			$"Name: {products[i].Name ?? "<No Name>"}, " +
			//			$"Price: {products[i].Price ?? 0}, " +
			//			$"Related: {products[i].Related?.Name ?? "<None>"}");
			//	}
			//	else
			//	{
			//		results.Add("It is null Product, should be skipped.");
			//	}
			//}

			//foreach (Product p in Product.GetProducts())
			//{
			//	string name = p?.Name;
			//	decimal? price = p?.Price;
			//	string relatedName = p?.Related?.Name;
			//	results.Add(string.Format($"Name: {name}, Price: {price}, Related: {relatedName}"));
			//}


			//decimal totalPriceByName = shoppingCart
			//	.Filter(p => p?.Name?[0] == 'S')
			//	.Filter(p => (p?.Price ?? 0) >= 15m)
			//	.TotalPrice();
			//results.Add(totalPriceByName.ToString());

			//return View(results);

			IProductSelection cart = new ShoppingCart(
				new Product { Name = "Kayak", Category = "Water Craft", Price = 275m },
				new Product { Name = "Lifejacket", Price = 48.95m },
				new Product { Name = "Soccer ball", Price = 19.50m },
				new Product { Name = "Corner flag", Price = 34.95m },
				null);

			//return View(cart.Products.Select(p => $"{nameof(p.Name)}: {p?.Name ?? "No Name"}"));
			return View(cart.Products);


			//List<string> output = new List<string>();
			//await foreach (long? length in AsyncMethods.GetPagesLengths(output, "apress.com", "microsoft.com", "amazon.com"))
			//{
			//	output.Add($"Page length {length}");
			//}
			//return View(output);
		}
	}
}
