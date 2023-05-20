using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblem
{
    public class MinimumString
    {
        public void StringMethod()
        {
            string strOne = "apple";
            string strTwo = "pineapple";
            string strThree = "blueberry";

            string min = FindMinimum(strOne, strTwo, strThree);
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
