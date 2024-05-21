using CSharpNUnitExercises;

namespace Tests
{
    public class PropertiesTests
    {
        private Properties exercise;

        [SetUp]
        public void Setup()
        {
            exercise = new Properties();
        }

        [Test]
        public void FirstNames()
        {
            var people = new List<Person> {
                new Person("Joe", "Bloggs"),
                new Person("Jill", "Dash"),
                new Person("Arthur", "Dent"),
                new Person("Selina", "Kyle")
            };

            Assert.That(exercise.FirstNames(people), Is.EqualTo(new[] { "Joe", "Jill", "Arthur", "Selina" }));
        }

        [Test]
        public void FullNames()
        {
            var people = new List<Person> {
                new Person("Joe", "Bloggs"),
                new Person("Jill", "Dash"),
                new Person("Arthur", "Dent"),
                new Person("Selina", "Kyle")
            };

            Assert.That(exercise.FullNames(people), Is.EqualTo(new[] { "Joe Bloggs", "Jill Dash", "Arthur Dent", "Selina Kyle" }));
        }

        [Test]
        public void UpperCaseNames()
        {
            var person = new Person("Joe", "Bloggs");
            exercise.UpperCaseNames(person);
            Assert.Multiple(() =>
            {
                Assert.That(person.FirstName, Is.EqualTo("JOE"));
                Assert.That(person.LastName, Is.EqualTo("BLOGGS"));
            });
        }

        [Test]
        public void CreatePeopleListFromFullNames()
        {
            var names = new[] { "Joe Bloggs", "Jill Dash", "Arthur Dent", "Selina Kyle" };

            var people = exercise.CreatePeople(names);

            Assert.That(people.All(p => p is Person), Is.True);
            Assert.That(people.Count, Is.EqualTo(names.Length));
            Assert.That(people.Any(p => p.FirstName == "Joe" && p.LastName == "Bloggs"), Is.True);
            Assert.That(people.Any(p => p.FirstName == "Selina" && p.LastName == "Kyle"), Is.True);
        }

        [Test]
        public void Heights()
        {
            var people = new List<Person> {
                new Person("Joe", "Bloggs", 185),
                new Person("Jill", "Dash", 176),
                new Person("Arthur", "Dent", 163),
                new Person("Selina", "Kyle", 170)
            };

            Assert.That(exercise.Heights(people), Is.EqualTo(new[] { 185, 176, 163, 170 }));
        }
    }
}
