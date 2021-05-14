﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
	public class AsyncMethods
	{
		public static async Task<long?> GetPageLength()
		{
			HttpClient client = new HttpClient();
			var httpMessage = await client.GetAsync(@"http://apress.com");
			return httpMessage.Content.Headers.ContentLength;
		}

		public static async IAsyncEnumerable<long?> GetPagesLengths(List<string> output, params string[] urls)
		{
			HttpClient client = new HttpClient();
			foreach (string url in urls)
			{
				output.Add($"Started request for: {url}");
				var httpMessage = await client.GetAsync($@"http://{url}");
				output.Add($"Completed request for: {url}");
				yield return httpMessage.Content.Headers.ContentLength;
			}
		}
	}
}
