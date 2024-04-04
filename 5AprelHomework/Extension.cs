using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5AprelHomework
{
    public static class Extension
    {

        public static bool IsPrime(this int number)
        {
            if (number < 2)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }
            for (int i = 2; i*i < number; i++)
            {
                
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static int Faktorial(this int faktorial)
        {
            int a = 1;
            for (int i = 1; i <= faktorial; i++)
            {
                a = i * a;
            }
            return a;
        }
        public static double Fahrenheit(this double fahrenheit)
        {
            double C;
            C = (fahrenheit - 32) * 5 / 9;
            return C;
        }
        public static double Celsius(this double celsius)
        {
            double F;
            F = celsius * 9/5 + 32;
            return F;
        }
            
    }
}
