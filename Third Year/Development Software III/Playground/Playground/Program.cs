using System;

namespace Playground
{
    class Program
    {
        static void MainOne(string[] args)
        {
            string firstName, lastName, town, age;

            firstName = "Christoph";
            lastName = "Percival";
            town = "Johannesburg";
            age = "23";

            Console.WriteLine("First Name: {3}\nLast Name: {1}\nTown: {0}\nAge: {2}\n\nName Again: {3} {1}", town, lastName, age, firstName);

            //COMPSOSITE FORMATTING
            Console.WriteLine("{0,-8}{1,-3}M", 3325, 25);
        }
    }
}