using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblem
{
    public class MinimumInteger
    {
        public void IntegerMethod()
        {
            int numOne = 80;
            int numTwo = 50;
            int numThree = 10;

            int min = FindMinimum(numOne, numTwo, numThree);
            Console.WriteLine("Minimum value: " + min);
        }
        public static T FindMinimum<T>(T valueOne, T valueTwo, T valueThree) where T : IComparable<T>
        {
            T min = valueOne;

            if (valueTwo.CompareTo(min) < 0)
                min = valueTwo;

            if (valueThree.CompareTo(min) < 0)
                min = valueThree;

            return min;
        }
    }
}
