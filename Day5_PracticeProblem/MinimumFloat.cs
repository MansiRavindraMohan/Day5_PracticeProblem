using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblem
{
    public class MinimumFloat
    {
        public void FloatMethod()
        {
            float numOne = 10.5f;
            float numTwo = 5.3f;
            float numThree = 8.7f;

            float min = FindMinimum(numOne, numTwo, numThree);
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
