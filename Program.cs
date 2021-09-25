using System;
using System.Collections.Generic;
using System.Linq;

namespace TELEPHONE_NUMBERS
{
    class Program
    {
        static void Main(string[] args)
        {
            var telephoneNumbers = new HashSet<string>();
            List<string> inputs = new List<string>();

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                inputs.Add(Console.ReadLine());
            }

            foreach (string line in inputs)
            {
                var join = line.Select(t => t.ToString()).Aggregate((a, b) =>
                {
                    var join = string.Join(String.Empty, a, b);

                    telephoneNumbers.Add(a);
                    return join;
                });
                telephoneNumbers.Add(join);
            }

            Console.WriteLine(telephoneNumbers.Count);


        }
    }
}