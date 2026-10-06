using System;
using System.Collections.Generic;
using System.Text;

namespace lesson7
{
    internal class math
    {
        public double sum (double num1, double num2)
        {  
            double result = (num1 + num2);
            return result;
        }
        public double minus(double num1, double num2)
        {
            double result = (num1 - num2);
            return result;
        }
        public double division(double num1, double num2)
        {
            double result = (num1 / num2);
            return result;//ghfnjgfnjghfnjghmhnjyju
        }
        public double multiplication(double num1, double num2)
        {
            double result = (num1 * num2);
            return result;
        }
        public double percent(double num1, double num2)
        {
            double result = (num1 * (num2 / 100));
            return result;
        }
        public double factorial_num1(double num1)
        {
            var result = 0;
            if (num1 < 0)
            {
                Console.WriteLine("Класический факториал вычислить нельзя.");
            }
            else if (num1 == 1)
            {
                result = (1);
            }
            else if (num1 > 1) 
            {
                result = 1;
                for (int f = 2;f<= num1;f++)
                {
                    result *= f;
                }
                return result;
            }
            return result;
        }
    }

}
