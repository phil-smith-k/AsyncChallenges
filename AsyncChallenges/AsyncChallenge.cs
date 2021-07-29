using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncChallenges
{
    /*
        Refactor the following methods to make them async. Doing this will 
        cause the code in Program.cs to break. Refactor the 
        Program.cs code so that application runs (you will have to use the 'await' keyword.
        Don't be afraid of the errors. Research errors before you ask an instructor.
    */

    public class AsyncChallenge
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public bool IsGreaterThan(int a, int b)
        {
            return a > b;
        }

        public IEnumerable<string> GetStrings()
        {
            List<string> result = new List<string>();

            foreach (int i in Enumerable.Range(0, 100))
            {
                result.Add(i.ToString());
            }

            return result;
        }

        public void VoidMethod()
        {
            Console.WriteLine("This is the void method.");
        }

        public (bool, int) GetIntegerAndIsLessThanLimit(int limit)
        {
            int integer = GetRandomInteger();
            return (integer < limit, integer);
        }

        private int GetRandomInteger()
        {
            Random random = new Random();
            return random.Next(0, 1000);
        }
    }
}
