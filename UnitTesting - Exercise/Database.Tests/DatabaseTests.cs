namespace Database.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;
    using NUnit.Framework.Internal;

    [TestFixture]
    public class DatabaseTests
    {
        [TestCaseSource(nameof(GetValidDatabaseSizes))]
        public void DatabaseShouldBeInitializedCorrectly(int n)
        {
            int[] data = new int[n];

            for (int i = 0; i < n; i++)
            {
                data[i] = Random.Shared.Next();
            }

            Database database = new Database(data);

            Assert.That(database.Count, Is.EqualTo(n));

            int[] fetchResult = database.Fetch();
            Assert.That(fetchResult, Is.Not.SameAs(data));
            Assert.That(fetchResult, Has.Length.EqualTo(data.Length));
            Assert.That(fetchResult, Is.EqualTo(data));
        }

        [Test]
        public void AddShouldWork()
        {
            Database database = new Database();

            for (int i = 0; i < 16; i++)
            {
                database.Add(Random.Shared.Next());
                Assert.That(database.Count, Is.EqualTo(i + 1));
            }
        }

        [Test]
        public void RemoveShouldWork()
        {
            Database database = new Database();

            for (int i = 0; i < 16; i++)
            {
                database.Add(Random.Shared.Next());
            }

            for (int i = 0; i < 16; i++)
            {
                database.Remove();
                Assert.That(database.Count, Is.EqualTo(16 - (i + 1)));
            }
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 })]
        public void DatabaseShouldThrowExceptionIfTheCapacityIsFull(int[] elements)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Database testDb = new Database(elements);
            });
        }

        [Test]
        public void DatabaseShouldThrowExceptionIsItsEmpty()
        {
            Database database = new Database();
            Assert.Throws<InvalidOperationException>(()=>database.Remove());
        }

        public static IEnumerable<object[]> GetValidDatabaseSizes()
        {
            for (int i = 0; i <= 16; i++)
            {
                yield return new object[] { i };
            }
        }
    }
}
