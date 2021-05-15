using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using LanguageFeatures.Models;
using LanguageFeatures.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Tests
{
	public class ProductTests
	{
		[Fact]
		public void CanCgangeProductName()
		{
			// Arrange
			Product p = new Product { Name = "Test", Price = 100m };
			// Act
			p.Name = "New Name";
			// Assert
			Assert.Equal("New Name", p.Name);
		}

		[Fact]
		public void CanChangeProductPrice()
		{
			// Arrange
			Product p = new Product { Name = "Test", Price = 100M };
			// Act
			p.Price = 200m;
			//Assert
			Assert.Equal(200m, p.Price);
		}

		[Fact]
		public void IndexActionModelIsComplete()
		{
			// Arrange
			var controller = new HomeController();

			Product[] testData = new Product[]
			{
				new Product { Name = "Kayak", Category = "Water Craft", Price = 275m },
				new Product { Name = "Lifejacket", Price = 48.95m },
				new Product { Name = "Soccer ball", Price = 19.50m },
				new Product { Name = "Corner flag", Price = 34.95m },
				null
			};

			// Act
			var result = (controller.Index().Result as ViewResult)?.ViewData.Model as IEnumerable<Product>;

			// Assert
			Assert.Equal(testData, result,
				Comparer.Get<Product>((p1, p2) =>
					p1?.Name == p2?.Name && p1?.Price == p2?.Price));
		}
	}
}
