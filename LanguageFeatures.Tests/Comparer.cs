using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace LanguageFeatures.Tests
{
	public class Comparer
	{
		public static Comparer<T> Get<T>(Func<T, T, bool> func)
		{
			return new Comparer<T>(func);
		}
	}

	public class Comparer<T> : IEqualityComparer<T>
	{
		private Func<T, T, bool> compFunc;

		public Comparer(Func<T, T, bool> func)
		{
			compFunc = func;
		}

		public bool Equals(T x, T y)
		{
			return compFunc(x, y);
		}

		public int GetHashCode(T obj)
		{
			return obj.GetHashCode();
		}
	}
}
