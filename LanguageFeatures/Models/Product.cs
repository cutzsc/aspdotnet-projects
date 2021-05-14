using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
	public class Product
	{
		public string Name { get; set; }
		public string Category { get; set; } = "Watersports";
		public decimal? Price { get; set; }
		public Product Related { get; set; }
		public bool InStock { get; }

		public Product(bool inStock = true) => InStock = InStock;

		public static Product[] GetProducts()
		{
			Product[] products = new Product[]
			{
				new Product { Name = "Kayak", Category = "Water Craft", Price = 275m },
				new Product { Name = "Lifejacket", Price = 48.95m },
				new Product { Name = "Soccer ball", Price = 19.50m },
				new Product { Name = "Corner flag", Price = 34.95m },
				null
			};

			products[0].Related = products[1];

			return products;
		}
	}
}
