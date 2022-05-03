using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace IteratorsAndComparators
{
    public partial class Library : IEnumerable<Book>, IComparer<Book>
    {
        public Library(params Book[] books)
        {
            Books = books.ToList();
            Books.Sort(new BookComparator());
        }
        public List<Book> Books { get; set; } = new List<Book>();        

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public int Compare(Book x, Book y)
        {
            if (x.Year < y.Year)
            {
                return -1;
            }
            else if (x.Year > y.Year)
            {
                return 1;
            }
            else
            {
                return x.Title.CompareTo(y.Title);
            }
        }
    }
}
