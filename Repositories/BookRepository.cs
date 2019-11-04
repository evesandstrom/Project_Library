using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// The connection between database and service level for book objects.
    /// </summary>
    public class BookRepository : IRepository<Book, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor for book repository.
        /// </summary>
        /// <param name="c">Used to connect repository with database.</param>
        public BookRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Returns all books from the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> All()
        {
            return context.Books;
        }

        /// <summary>
        /// Adds a book to the database.
        /// </summary>
        /// <param name="book">The object being added.</param>
        public void Add(Book book)
        {
            context.Books.Add(book);
        }

        /// <summary>
        /// Removes a book from the database.
        /// </summary>
        /// <param name="book">The object being removed.</param>
        public void Remove(Book book)
        {
            context.Books.Remove(book);
        }

        /// <summary>
        /// Finds a specific book in the database on id.
        /// </summary>
        /// <param name="id">The id used to find the object.</param>
        /// <returns></returns>
        public Book Find(int id)
        {
            Book book = context.Books.Find(id);//b => b.Id == id);
            return book;
        }

        /// <summary>
        /// Save changes in the database.
        /// </summary>
        /// <param name="b">The object being changed.</param>
        public void Edit(Book b)
        {
            context.SaveChanges();
        }
    }
}