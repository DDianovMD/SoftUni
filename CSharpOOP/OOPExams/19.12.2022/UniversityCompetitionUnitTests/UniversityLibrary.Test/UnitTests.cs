namespace UniversityLibrary.Test
{
    using NUnit.Framework;
    using NUnit.Framework.Internal;
    using System;

    public class Tests
    {
        private const string title = "King Rat";
        private const string author = "James Clavell";
        private const string category = "Historical novel";
        private const string holderName = "Pesho";

        private TextBook textBook;
        private UniversityLibrary universityLibrary;

        [SetUp]
        public void Arrange()
        {
            this.textBook = new TextBook(title, author, category);
            this.universityLibrary = new UniversityLibrary();

            this.textBook.Holder = holderName;
        }

        [Test]
        public void TextBook_TitleAuthorCategoryAndHolderAreSetCorrectly()
        {
            // Arrange - done in SetUp

            // Assert
            Assert.That(this.textBook.Title, Is.EqualTo(title));
            Assert.That(this.textBook.Author, Is.EqualTo(author));
            Assert.That(this.textBook.Category, Is.EqualTo(category));
            Assert.That(this.textBook.Holder, Is.EqualTo(holderName));
        }

        [Test]
        public void UniversityLibrary_Catalogue_IsInitializedInConstructor()
        {
            // Arrange - done in SetUp

            // Assert
            // Assert.IsTrue(this.universityLibrary.Catalogue != null);
            Assert.That(this.universityLibrary.Catalogue, Is.Not.Null);
        }

        [Test]
        public void UniversityLibrary_Catalogue_InitialCountIsSetToZero()
        {
            // Arrange - done in SetUp

            Assert.That(this.universityLibrary.Catalogue.Count, Is.EqualTo(0));
        }

        [Test]
        public void UniversityLibrary_AddTextBookToLibrary_SetsTextBookInventoryNumberCorrectly()
        {
            // Arrange
            int expectedInventoryNumber = this.universityLibrary.Catalogue.Count + 1;

            // Act
            this.universityLibrary.AddTextBookToLibrary(this.textBook);

            // Assert
            Assert.That(this.textBook.InventoryNumber, Is.EqualTo(expectedInventoryNumber));
        }

        [Test]
        public void UniversityLibrary_AddTextBookToLibrary_IsAddingGivenBookInCatalogue()
        {
            // Arrange and act
            this.universityLibrary.AddTextBookToLibrary(this.textBook);

            // Assert
            Assert.That(this.universityLibrary.Catalogue.Count, Is.EqualTo(1));
        }

        [Test]
        public void UniversityLibrary_AddTextBookToLibrary_IsWorkingCorrectly()
        {
            // Arrange and act
            string result = this.universityLibrary.AddTextBookToLibrary(this.textBook);
            string expectedString = this.textBook.ToString();

            // Assert
            Assert.That(result, Is.EqualTo(expectedString));
        }

        [TestCase(int.MinValue)]
        [TestCase(0)]
        [TestCase(int.MaxValue)]
        public void UniversityLibrary_LoanTextBook_ThrowsNullReferenceExceptionWithInvalidBookInventoryNumber(int nonExistingBookInventoryNumber)
        {
            // Arrange - done in SetUp

            // Act and assert
            Assert.Throws<NullReferenceException>(() =>
            {
                this.universityLibrary.LoanTextBook(nonExistingBookInventoryNumber, holderName);
            });
        }

        [Test]
        public void UniversityLibrary_LoanTextBook_WorksCorrectlyWithSameHolderAndGivenStudentNames()
        {
            // Arrange
            this.textBook.Holder = holderName;
            this.universityLibrary.AddTextBookToLibrary(this.textBook);
            string expected = $"{this.textBook.Holder} still hasn't returned {this.textBook.Title}!";

            // Act
            string result = this.universityLibrary.LoanTextBook(this.textBook.InventoryNumber, this.textBook.Holder);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        // Given names mustn't be the same as this.holderName value
        [TestCase("Ivan")]
        [TestCase("Dragan")]
        [TestCase("Patkan")]
        public void UniversityLibrary_LoanTextBook_WorksCorrectlyWithDifferentHolderAndGivenStudentNames(string studentName)
        {
            // Arrange
            this.textBook.Holder = holderName;
            this.universityLibrary.AddTextBookToLibrary(this.textBook);
            string expected = $"{textBook.Title} loaned to {studentName}.";

            // Act
            string result = universityLibrary.LoanTextBook(1, studentName);

            // Assert
            Assert.That(this.textBook.Holder, Is.EqualTo(studentName));
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void UniversityLibrary_ReturnTextBook_IsWorkingCorrectlyWithValidBookInventoryNumber()
        {
            // Arrange
            this.universityLibrary.AddTextBookToLibrary(this.textBook);
            string expected = $"{this.textBook.Title} is returned to the library.";

            // Act
            string result = universityLibrary.ReturnTextBook(this.textBook.InventoryNumber);

            // Assert
            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase(int.MinValue)]
        [TestCase(0)]
        [TestCase(int.MaxValue)]
        public void UniversityLibrary_BookInventory_ThrowsNullReferenceExceptionWithInvalidBookInventoryNumber(int nonExistingBookInventoryNumber)
        {
            // Arrange - done in SetUp

            // Act and assert
            Assert.Throws<NullReferenceException>(() =>
            {
                this.universityLibrary.ReturnTextBook(nonExistingBookInventoryNumber);
            });
        }

        [Test]
        public void UniversityLibrary_BookInventory_SetsTextBookHolderCorrectly()
        {
            // Arrange
            this.universityLibrary.AddTextBookToLibrary(this.textBook);

            // Act
            this.universityLibrary.ReturnTextBook(1);

            // Assert
            Assert.That(this.textBook.Holder, Is.EqualTo(string.Empty));
        }
    }
}