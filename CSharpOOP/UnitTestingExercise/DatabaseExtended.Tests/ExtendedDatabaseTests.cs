namespace DatabaseExtended.Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {

        [Test]
        public void PersonsConstructorIsSettingIdProperly()
        {
            Person testPerson = new Person(1, "TestName");
            Assert.That(testPerson.Id, Is.EqualTo(1));
        }

        [Test]
        public void PersonsConstructorIsSettingUserNameProperly()
        {
            Person testPerson = new Person(1, "TestName");
            Assert.That(testPerson.UserName, Is.EqualTo("TestName"));
        }

        [Test]
        public void DatabaseConstructorIsWorkingProperlyWithValidDataLength()
        {
            Person testPerson = new Person(1, "TestName");
            Database testDatabase = new Database(testPerson);
            Assert.That(testDatabase.Count, Is.EqualTo(1));
        }

        [TestCase(17)]
        [TestCase(100)]
        public void DatabaseConstructorIsThrowingExceptionWithInvalidDataLength(int arrayLength)
        {
            Person[] peopleArray = new Person[arrayLength];

            Assert.Throws<ArgumentException>(() =>
            {
                Database testDatabase = new Database(peopleArray);
            },
            "Provided data length should be in range [0..16]!");
        }

        [Test]
        public void AddMethodIsAddingPersonWhenCorrectDataGive()
        {
            Person[] peopleArray = new Person[10];

            for (int i = 0; i < peopleArray.Length; i++)
            {
                peopleArray[i] = new Person(i, $"TestName{i}");
            }

            Database testDB = new Database(peopleArray);
            Person testPerson = new Person(11, "TestName11");

            Assert.That(testDB.Count, Is.EqualTo(10));
        }

        [Test]
        public void AddMethodIsThrowingExceptionWhenDatabaseIsFull()
        {
            Person[] peopleArray = new Person[16];

            for (int i = 0; i < peopleArray.Length; i++)
            {
                peopleArray[i] = new Person(i, $"TestName{i}");
            }

            Database testDB = new Database(peopleArray);
            Person testPerson = new Person(1, "TestName");

            Assert.Throws<InvalidOperationException>(() =>
            {
                testDB.Add(testPerson);
            },
            "Array's capacity must be exactly 16 integers!");
        }

        [Test]
        public void ItsNotAllowedToAddPersonWithSameUsernameTwice()
        {
            Person testPerson = new Person(1, "TestName");
            Database testDB = new Database(testPerson);

            Assert.Throws<InvalidOperationException>(() =>
            {
                testDB.Add(testPerson);
            },
            "There is already user with this username!");
        }

        [Test]
        public void ItsNotAllowedToAddPersonWithSameIdTwice()
        {
            Person testPerson = new Person(1, "TestName");
            Database testDB = new Database(testPerson);
            Person testPerson2 = new Person(1, "NotExistingName");

            Assert.Throws<InvalidOperationException>(() =>
            {
                testDB.Add(testPerson2);
            },
            "There is already user with this Id!");
        }

        [Test]
        public void RemoveThrowsExceptionWhenDatabaseIsEmpty()
        {
            Person testPerson = new Person(1, "TestName");
            Database testDB = new Database(testPerson);
            testDB.Remove();

            Assert.Throws<InvalidOperationException>(() =>
            {
                testDB.Remove();
            });
        }

        [Test]
        public void RemoveMethodIsRemovingOnlyOnePerson()
        {
            Person testPerson = new Person(1, "TestName");
            Database testDB = new Database(testPerson);
            testDB.Remove();

            Assert.That(testDB.Count, Is.EqualTo(0));
        }

        [Test]
        public void FindByUserNameThrowsExceptionWithNullParameter()
        {
            Person testPerson = new Person(1, "TestName");
            Database testDB = new Database(testPerson);

            Assert.Throws<ArgumentNullException>(() =>
            {
                testDB.FindByUsername(null);
            },
            "Username parameter is null!");
        }

        [Test]
        public void FindByUserNameThrowsExceptionWithNonExistingUsername()
        {
            Person testPerson = new Person(1, "TestName");
            Database testDB = new Database(testPerson);

            Assert.Throws<InvalidOperationException>(() =>
            {
                testDB.FindByUsername("NonExistingUsername");
            },
            "No user is present by this username!");
        }

        [Test]
        public void FindByUserNameWorkingProperlyWithValidData()
        {
            Person testPerson = new Person(1, "TestName");
            Database testDB = new Database(testPerson);

            Assert.That(testDB.FindByUsername("TestName"), Is.EqualTo(testPerson));
        }

        [Test]
        public void FindByIdThrowsExceptionWithValueLessThanZero()
        {
            Person testPerson = new Person(1, "TestName");
            Database testDB = new Database(testPerson);

            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {
                testDB.FindById(-1);
            },
            "Id should be a positive number!");
        }

        [Test]
        public void FindByIdThrowsExceptionWithNonExistingIdHigherThanZero()
        {
            Person testPerson = new Person(1, "TestName");
            Database testDB = new Database(testPerson);

            Assert.Throws<InvalidOperationException>(() =>
            {
                testDB.FindById(2);
            },
            "No user is present by this ID!");
        }

        [Test]
        public void FindByIdWorksProperlyWithCorrectDataGiven()
        {
            Person testPerson = new Person(1, "TestName");
            Database testDB = new Database(testPerson);

            Assert.That(testDB.FindById(1), Is.EqualTo(testPerson));
        }
    }
}