using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// The connection between database and service level for bookcopy objects.
    /// </summary>
    class BookCopyRepository : IRepository<BookCopy, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor for bookcopy repository.
        /// </summary>
        /// <param name="c">Used to connect repository with database.</param>
        public BookCopyRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Returns all bookcopies i the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BookCopy> All()
        {
            return context.BookCopies;
        }

        /// <summary>
        /// Adds a bookcopy to the database.
        /// </summary>
        /// <param name="bookCopy">The object being added.</param>
        public void Add(BookCopy bookCopy)
        {
            context.BookCopies.Add(bookCopy);
        }

        /// <summary>
        /// Removes a bookcopy from the database.
        /// </summary>
        /// <param name="bookCopy">The object being removed.</param>
        public void Remove(BookCopy bookCopy)
        {
            context.BookCopies.Remove(bookCopy);
        }

        /// <summary>
        /// Finds a specific bookcopy from the database on id.
        /// </summary>
        /// <param name="id">The id used to find the object.</param>
        /// <returns></returns>
        public BookCopy Find(int id)
        {
            BookCopy bookCopy = context.BookCopies.Find(id);//(b => b.Id == id);
            return bookCopy;
        }

        /// <summary>
        /// Saves changes to the database made in bookcopy.
        /// </summary>
        /// <param name="bookCopy">The object being changed.</param>
        public void Edit(BookCopy bookCopy)
        {
            context.SaveChanges();
        }
    }
}
