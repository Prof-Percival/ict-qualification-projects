using System;
using System.Numerics;

namespace Playground
{
	public class C4_ConditionsTesting
	{
		public static void Main()
		{
			/*
			Console.WriteLine("Input Three Real Numbers");
			double num1 = double.Parse(Console.ReadLine());
			double num2 = double.Parse(Console.ReadLine());
			double num3 = double.Parse(Console.ReadLine());


			double biggest = 0;

			if (num1 > num2)
			{
				if (num1 > num3)
                {
					biggest = num1;
                }
				else
                {
					biggest = num3;
                }
			}
			else if (num2 > num3)
            {
				biggest = num2;
            }
            else
            {
				biggest = num3;
            }

			Console.WriteLine("\nBiggest Number Between {0}, {1} & {2} is: {3}", num1, num2, num3, biggest);
			*/


			//Sort 3 real numbers in descending order. Use nested if statements

			/*
			double max, med, min;
			max = med = min = 0;

			if (num1 > num2)
            {
				if (num1 > num3)
                {
					max = num1;
					if (num2 > num3)
                    {
						med = num2;
						min = num3;
                    }
                    else
                    {
						med = num3;
						min = num2;
                    }
                }
                else
                {
					max = num3;
					med = num1;
					min = num2;
                }
            }
            else
            {
				if (num2 > num3)
                {
					max = num2;

					if (num1 > num3)
                    {
						med = num1;
						min = num3;
                    }
                    else
                    {
						med = num3;
						min = num1;
                    }
                }
                else
                {
					max = num3;
					med = num2;
					min = num1;
                }
            }

			Console.WriteLine("\nBiggest Number Between {0}, {1} & {2} is: {3}", num1, num2, num3, max);
			Console.WriteLine("\n({0} , {1} , {2}) in Descending Order: ({3} , {4} , {5})", num1, num2, num3, max, med, min);
			Console.WriteLine("\n{0}, {1}, {2} in Ascending Order: {3}, {4}, {5}", num1, num2, num3, min, med, max);
			*/


			//Write a program that finds the greatest of given 5 numbers
			
			Console.WriteLine("Input Five Numbers");
			double num1 = double.Parse(Console.ReadLine());
			double num2 = double.Parse(Console.ReadLine());
			double num3 = double.Parse(Console.ReadLine());
			double num4 = double.Parse(Console.ReadLine());
			double num5 = double.Parse(Console.ReadLine());

			double greatest = 0;

			greatest = (num1 > num2) ? num1 : num2;

			greatest = (greatest > num3) ? greatest : num3;

			greatest = (greatest > num4) ? greatest : num4;

			greatest = (greatest > num5) ? greatest : num5;

			Console.WriteLine("\nGreatest Number Between ({0}, {1}, {2}, {3}, {4}) is: {5})", num1, num2, num3, num4, num5, greatest);

			BigInteger num = 8373647382938475829;
		}
	}
}