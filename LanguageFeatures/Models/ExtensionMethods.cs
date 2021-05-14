using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
	public static class ExtensionMethods
	{
		public static decimal TotalPrice(this IEnumerable<Product> products)
		{
			decimal total = 0m;
			foreach (Product product in products)
			{
				total += product?.Price ?? 0m;
			}
			return total;
		}

		public static IEnumerable<Product> Filter(this IEnumerable<Product> products,
			Predicate<Product> predicate)
		{
			foreach (Product product in products)
			{
				if (predicate(product))
					yield return product;
			}
		}
	}
}
