using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8.Features
{
    public class Calculator
    {
        public int Calculate()
        {
            int number_1 = 10;
            int number_2 = 20;
            int myValue = 50;

            int result = Sum();

            int Sum() => number_1 + number_2 + myValue;

            return result;
        }

        public int StaticCalculate()
        {
            int number_1 = 30;
            int number_2 = 50;

            int result = Sum(number_1, number_2);

            
            //we Should use static to make sum not access  number_1 & number_2 
            static int Sum(int first, int second) => first + second;

            return result;
        }

    }
}
