namespace CSharpNUnitExercises
{
    public class BrokenCode
    {
        public int SumNumbers(IEnumerable<int> numbers)
        {
            return numbers.Sum();
        }

        public IEnumerable<string> ReverseStrings(IEnumerable<string> input)
        {
            return input.Select(s => s == null ? null : new string(s.Reverse().ToArray()));
        }

       public IEnumerable<string> AltReverseStrings(string[] input)
       {
           return input.Select(s => s == null ? null : new string(s.Reverse().ToArray()));
       }
    }
}