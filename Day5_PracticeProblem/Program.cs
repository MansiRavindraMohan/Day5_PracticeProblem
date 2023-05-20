using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5_PracticeProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MinimumInteger minimumInteger = new MinimumInteger();
            minimumInteger.IntegerMethod();

            MinimumFloat minimumFloat = new MinimumFloat();
            minimumFloat.FloatMethod();

            MinimumString minimumString = new MinimumString();
            minimumString.StringMethod();
            Console.ReadLine();
        }
    }
}
