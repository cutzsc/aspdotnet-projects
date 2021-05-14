using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
	public class ShoppingCart : IProductSelection
	{
		public List<Product> products;

		IEnumerable<Product> IProductSelection.Products => products;

		public ShoppingCart(params Product[] products)
		{
			this.products = new List<Product>(products);
		}
	}
}
