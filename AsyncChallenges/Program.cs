using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncChallenge challenge = new AsyncChallenge();

            int addResult = challenge.Add(1, 4);
            Console.WriteLine(addResult);

            bool isGreaterThan = challenge.IsGreaterThan(23, 100);
            Console.WriteLine(isGreaterThan);

            IEnumerable<string> strings = challenge.GetStrings();
            foreach(string str in strings)
            {
                Console.WriteLine(str);
            }

            challenge.VoidMethod();

            var (isLessThan, integer) = challenge.GetIntegerAndIsLessThanLimit(100);
            Console.WriteLine($"Is Less Than: {isLessThan} Integer: {integer}");
        }
    }
}
