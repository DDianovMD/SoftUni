namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Linq;

    [TestFixture]
    public class DatabaseTests
    {
        [Test]
        public void ArrayCapacityOver16ThrowsException()
        {
            int[] testArray = new int[16];

            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = i;
            }
            Database testDB = new Database(testArray);

            Assert.Throws<InvalidOperationException>(() =>
            {
                testDB.Add(1);
            },
            "Array's capacity must be exactly 16 integers!");
            
        }

        [Test]
        public void CountPropertyIsWorkingProperly()
        {
            int[] testArray = new int[16];

            for (int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = i;
            }
            Database testDB = new Database(testArray);

            Assert.That(testDB.Count, Is.EqualTo(16));

        }

        [Test]
        public void ItsNotAllowedToRemoveElementFromEmptyDatabase()
        {
            int[] testArray = new int[0];
            Database testDB = new Database(testArray);

            Assert.Throws<InvalidOperationException>(() =>
            {
                testDB.Remove();
            },
            "The collection is empty!");

        }

        [Test]
        public void RemoveIsRemovingOnlyOneElement()
        {
            int[] testArray = new int[1];
            Database testDB = new Database(testArray);
            testDB.Remove();

            Assert.That(testDB.Count, Is.EqualTo(0));

        }

        [Test]
        public void FetchIsCopyingWholeDatabase()
        {
            int[] testArray = new int[0];
            Database testDB = new Database(testArray);

            Assert.That(testDB.Fetch, Is.EqualTo(testArray));

        }

        [Test]
        public void FetchIsCopyingExactDatabase()
        {
            int[] testArray = new int[1] { 1 };
            Database testDB = new Database(testArray);

            Assert.That(testDB.Fetch().ElementAt(0), Is.EqualTo(testArray.ElementAt(0)));

        }
    }
}
