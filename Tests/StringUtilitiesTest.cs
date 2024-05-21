using CSharpNUnitExercises;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;

namespace Tests
{
    public class StringsTests
    {
        private StringUtilities exercise;

        [SetUp]
        public void Setup()
        {
            exercise = new StringUtilities();
        }

        [TestCase("Peter", "Hello Peter!")]
        [TestCase("", "Who are you?")]
        [TestCase("A", "Hello A!")]
        [TestCase("习近平", "Hello 习近平!")]
        public void Hello(string name, string expected)
        {
            Assert.That(exercise.Hello(name), Is.EqualTo(expected));
        }

        [TestCase("essay", "yasse")]
        [TestCase("", "")]
        [TestCase("A bat", "tab A")]
        [TestCase("eye", "eye")]
        [TestCase("习近平", "平近习")]
        public void Reverse(string input, string expected)
        {
            Assert.That(exercise.Reverse(input), Is.EqualTo(expected));
        }

        [TestCase("essay", 3, "ess")]
        [TestCase("A bat", 0, "")]
        [TestCase("conundrum", 1, "c")]
        [TestCase("A bat", 10, "A bat")]
        [TestCase("", 0, "")]
        public void LeadingChars(string input, int n, string expected)
        {
            Assert.That(exercise.LeadingChars(input, n), Is.EqualTo(expected));
        }

        [TestCase("essay", "*ss*y")]
        [TestCase("uoiea", "*****")]
        [TestCase("cnhsj", "cnhsj")]
        [TestCase("A bat", "* b*t")]
        public void ReplaceVowels(string input, string expected)
        {
            Assert.That(exercise.ReplaceVowels(input), Is.EqualTo(expected));
        }

        public static IEnumerable<TestCaseData> WordStatsData()
        {
            yield return new TestCaseData("", new { charCount = 0, lineCount = 0, singleLetterCount = 0, hyphenatedCount = 0, allCapsCount = 0 });
            yield return new TestCaseData("Hello world", new { charCount = 11, lineCount = 1, singleLetterCount = 0, hyphenatedCount = 0, allCapsCount = 0 });
            yield return new TestCaseData("This is not a PARROT, it is a friendly-looking OWL.", new { charCount = 51, lineCount = 1, singleLetterCount = 2, hyphenatedCount = 1, allCapsCount = 2 });
            yield return new TestCaseData(@"There are various aspects to using test-driven development, 
for example the principles of 'keep it simple, stupid' KISS 
and 'You aren't gonna need it' YAGNI. 
By focusing on writing only the code necessary to pass tests, 
designs can often be cleaner and clearer than is achieved by 
other methods.", new { charCount = 305, lineCount = 6, singleLetterCount = 0, hyphenatedCount = 1, allCapsCount = 2 });
        }

        [Test, TestCaseSource(nameof(WordStatsData))]
        public void WordStats(string input, dynamic expected)
        {
            var result = exercise.WordStats(input);

            Assert.That(result.charCount, Is.EqualTo(expected.charCount));
            Assert.That(result.lineCount, Is.EqualTo(expected.lineCount));
            Assert.That(result.singleLetterCount, Is.EqualTo(expected.singleLetterCount));
            Assert.That(result.hyphenatedCount, Is.EqualTo(expected.hyphenatedCount));
            Assert.That(result.allCapsCount, Is.EqualTo(expected.allCapsCount));
        }
    }
} 