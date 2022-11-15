using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			bool resualt = 12.IsOdd();
			bool resualt2 = 99.IsEven();

		}
	}

	public static class Mymath
	{

		public static bool IsOdd(this int source)
		{
			return source % 2 == 1;
		}

		public static bool IsEven(this int source)
		{
			return source % 2 == 0;
		}

	}
}
