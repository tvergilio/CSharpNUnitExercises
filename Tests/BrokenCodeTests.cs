using CSharpNUnitExercises;

namespace Tests
{
    public class BrokenCodeTests
    {
        private BrokenCode exercise;

        [SetUp]
        public void Setup()
        {
            exercise = new BrokenCode();
        }

        [TestCase(new int[] { }, 0)]
        [TestCase(new int[] { 5 }, 5)]
        [TestCase(new int[] { 1, 2, 3 }, 6)]
        public void SumNumbers(IEnumerable<int> numbers, int expected)
        {
            Assert.That(exercise.SumNumbers(numbers), Is.EqualTo(expected));
        }

        [TestCase(new string[] { null }, new string[] { null })]
        [TestCase(new string[] { }, new string[] { })]
        [TestCase(new string[] { "abc" }, new string[] { "cba" })]
        [TestCase(new string[] { "abc", "eye", "dally" }, new string[] { "cba", "eye", "yllad" })]
        public void ReverseStrings(IEnumerable<string> input, IEnumerable<string> expected)
        {
            Assert.That(exercise.ReverseStrings(input), Is.EqualTo(expected));
        }

        [TestCase(new string[] { null }, new string[] { null })]
        [TestCase(new string[] { }, new string[] { })]
        [TestCase(new string[] { "abc" }, new string[] { "cba" })]
        [TestCase(new string[] { "abc", "eye", "dally" }, new string[] { "cba", "eye", "yllad" })]
        public void AltReverseStrings(string[] input, string[] expected)
        {
            Assert.That(exercise.AltReverseStrings(input), Is.EqualTo(expected));
        }
    }
}