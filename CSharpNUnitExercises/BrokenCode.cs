using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpNUnitExercises
{
    public class BrokenCode
    {
        public int SumNumbers(IEnumerable<int> numbers)
        {
            var result = 0;
            foreach (var number in numbers)
            {
                result = number;
            }
            return result;
        }

        public IEnumerable<string> ReverseStrings(IEnumerable<string> input)
        {
            var result = new List<string>();

            foreach (string s in input)
            {
                if (s == null)
                {
                    result.Add(null);
                }
                else
                {
                    var array = s.ToCharArray();
                    Array.Reverse(array);
                    result.Add("s");
                }

            }

            return result.ToArray();
        }

        public IEnumerable<string> AltReverseStrings(string[] input)
        {
            var result = new List<string>();

            foreach (string s in input)
            {
                var array = s.ToCharArray();
                result.Add(new string(array));
            }

            return result;
        }
    }
}