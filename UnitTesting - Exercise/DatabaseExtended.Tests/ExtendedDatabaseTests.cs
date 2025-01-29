namespace DatabaseExtended.Tests
{
    using System;
    using System.Linq;
    using ExtendedDatabase;
    using NUnit.Framework;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        [Test]
        public void ConstructorShouldBeInitializedCorrectly()
        {
            Person[] people = new Person[]
            {
                new Person (1, "User1"),
                new Person (2, "User2")
            };

            Database database = new Database(people);

            Assert.That(people.Length, Is.EqualTo(database.Count));
        }

        [Test]
        public void ConstructorShouldThrowAnExceptionWhenPeopleAreMoreThan16()
        {
            Person[] people = Enumerable.Range(1, 17).Select(id => new Person(id, $"User{id}")).ToArray();
            Assert.Throws<ArgumentException>(() => new Database(people));
        }

        [Test]
        public void AddShouldThrowAnExceptionIfGivenIdAlreadyExists()
        {
            Database database = new Database(new Person(1, "User1"));
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(1, "User2")));
        }

        [Test]
        public void AddShouldThrowAnExceptionIfGivenUsernameAlreadyExists()
        {
            Database database = new Database(new Person(1, "User1"));
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(2, "User1")));
        }

        [Test]
        public void AddShouldThrowAnExceptionWhenDatabaseIsFull()
        {
            Person[]people=Enumerable.Range(1, 16).Select(id=>new Person(id, $"User{id}")).ToArray();

            Database database=new Database(people);
            Assert.Throws<InvalidOperationException>(() => database.Add(new Person(17, "User17")));
        }

        [Test]
        public void AddShouldIncreaseCount()
        {
            Database database = new Database(new Person(1, "User1"));
            database.Add(new Person(2, "User2"));
            Assert.That(database.Count, Is.EqualTo(2));
        }

        [Test]
        public void RemoveShouldThrowAnExceptionWhenItsEmpty()
        {
            Database database = new Database();
            Assert.Throws<InvalidOperationException>(()=>database.Remove());
        }

        [Test]
        public void RemoveShouldDecreaseCount()
        {
            Database database=new Database(new Person(1, "User1"), new Person(2, "User2"));
            database.Remove();
            Assert.That(database.Count, Is.EqualTo(1)); 
        }

        [Test]
        public void FindByUsernameShouldWork()
        {
            Database database = new Database(new Person(1, "User1"));
            Person result = database.FindByUsername("User1");
            Assert.That(result.Id, Is.EqualTo(1));
        }

        [Test]
        public void FindByUsernameShouldThrowAnExceptionWhenItsNotFound()
        {
            Database database = new Database();
            Assert.Throws<InvalidOperationException>(()=>database.FindByUsername("User1"));
        }

        [Test]
        public void FindByUsernameShouldThrowAnExceptionWhenItsNull()
        {
            Database database = new Database();
            Assert.Throws<ArgumentNullException>(() => database.FindByUsername(null));
        }

        [Test]
        public void FindByIdShouldWork()
        {
            Database database = new Database(new Person(1, "User1"));
            Person result= database.FindById(1);
            Assert.That(result.UserName, Is.EqualTo("User1"));
        }

        [Test]
        public void FindByIdShouldThrowAnExceptionWhenItsNotFound()
        {
            Database database = new Database();
            Assert.Throws<InvalidOperationException>(()=>database.FindById(1));
        }

        [Test]
        public void FindByIdShouldThrowAnExceptionWhenItsNegative()
        {
            Database database= new Database();
            Assert.Throws<ArgumentOutOfRangeException>(()=>database.FindById(-1));
        }

       
    }
}