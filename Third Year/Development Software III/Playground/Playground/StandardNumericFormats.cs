using System;

namespace Playground
{
    public class StandardNumericFormats
    {
        public static void MainTwo(string args)
        {
            //Currency
            Console.WriteLine("Currency: {0:C2}\n", 79.986);
            //Integer Number
            Console.WriteLine("Integer Number: {0:D5}\n", 456);
            //Exponential Notation
            Console.WriteLine("Exponential Notation: {0:E2}\n", 123);
            //Integer or Decimal Number
            Console.WriteLine("Integer / Decimal Number: {0:F1}\n", 79.686);
            //Separator for Numbers by 3
            Console.WriteLine("Separator for Numbers by 3: {0:N2}\n", 7092.486);
            //Percentage
            Console.WriteLine("Percentage: {0:P2}\n", 0.4568);
            //Hexadecimal
            Console.WriteLine("Hexadecimal: {0,6:X}\n", 254);
        }
    }
}