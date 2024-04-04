using System;

namespace _5AprelHomework
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!")
            int number = 99;
            Console.WriteLine(number.IsPrime());
            int faktorial = 5;
            Console.WriteLine(faktorial.Faktorial());
            double fahrenneit = 8;
            Console.WriteLine(fahrenneit.Fahrenheit());
            double celsie = 5;
            Console.WriteLine(celsie.Celsius());
        }
    }
}
