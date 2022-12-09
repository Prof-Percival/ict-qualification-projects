using System;

namespace Playground
{
	public class CustomNumericFormats
	{
		public static void MainThree(string[] args)
		{
			//StandardNumericFormats.MainTwo(" ");

			Console.WriteLine("{0:0.00}", 1);

			Console.WriteLine("{0:#.##}", 0.234);

			Console.WriteLine("{0:#####}", 12345.67);

			Console.WriteLine("{0:(0#) ### ## ##}", 29342525);

			Console.WriteLine("{0:%##}", 0.234);
		}
	}
}