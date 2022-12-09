using System;
//using Nakov.IO.Cin;

namespace Playground
{
	public class CustomDatesFormats
	{
		public static void MainFour(string[] args)
		{
			DateTime d = new DateTime(2012, 02, 27, 17, 30, 22);
			Console.WriteLine("{0:dd/MM/yyyy HH:mm:ss}", d);
			Console.WriteLine("{0:d.MM.yy}\n\n", d);

			Console.WriteLine("Day: {0:dd}\n", d);
			Console.WriteLine("Month: {0:MM}\n", d);
			Console.WriteLine("Year: {0:yyyy}\n", d);

			//int x = Cin.NextInt();
		}
	}
}