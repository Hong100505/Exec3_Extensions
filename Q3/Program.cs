using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Q3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string word = "Aaa";

			Console.WriteLine( word.ToInt());

		}
	}

	public static class Trans
	{
		public static int ToInt(this string valuse, int defaultValue = -1)
		{
			int i = 0;
			bool isInt =  int.TryParse(valuse, out i);
		
			int resault = isInt ? i : defaultValue;
			return resault;
		}

	}
}
