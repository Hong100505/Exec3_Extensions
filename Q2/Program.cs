using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("輸入數字，取前三個數");
			string valuse = Console.ReadLine();
			valuse = valuse.Left(3);
			Console.WriteLine(valuse);


		}
	}

	public static class Math
	{
		public static string Left(this string sourse,int length)
		{
			if(string.IsNullOrEmpty(sourse))
			{
				return string.Empty;
			}
			if (length <= 0) return string.Empty;
			if (sourse.Length < length) return sourse;

			return sourse.Substring(0, length);

		}


	}
}
