using Library.Models;
using Library.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Services
{
    /// <summary>
    /// Executes queries requested by the GUI for the book objects.
    /// </summary>
    class BookService : IService
    {
        /// <summary>
        /// Service doesn't need a context but it needs a repository.
        /// </summary>
        BookRepository bookRepository;

        /// <summary>
        /// Lets the GUI know a change was made and that it should be updated.
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Constructor for bookservice, creates a repository for the service.
        /// </summary>
        /// <param name="rFactory">A repository factory, so the service can create its own repository</param>
        public BookService(RepositoryFactory rFactory)
        {
            this.bookRepository = rFactory.CreateBookRepository();
        }

        /// <summary>
        /// Returns all books.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Book> All()
        {
            return bookRepository.All();
        }

        /// <summary>
        /// Returns books by a specific author.
        /// </summary>
        /// <param name="id">Used to find the specific author.</param>
        /// <returns></returns>
        public IEnumerable<Book> BooksByAuthor(int id)
        {
            return bookRepository.All().Where(b => b.AuthorId == id);
        }

        /// <summary>
        /// Adds a book to the database.
        /// </summary>
        /// <param name="b"></param>
        public void Add(Book b)
        {
            bookRepository.Add(b);
        }

        /// <summary>
        /// Finds the last book in the database and returns the id.
        /// </summary>
        /// <returns></returns>
        public int findLastId()
        {
            Book book = bookRepository.All().Last();
            return book.Id;
        }

        /// <summary>
        /// If no previous object exists, id is set to 1, otherwise it adds the id number with 1.
        /// </summary>
        /// <returns></returns>
        public int GenerateId()
        {
            if (bookRepository.All().Count() == 0)
            {
                return 1;
            }
            else
            {
                int id = findLastId();
                return id++;
            }
        }

        /// <summary>
        /// The Edit method makes sure that the given Book object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="b">Book object to be saved.</param>
        public void Edit(Book b)
        {
            bookRepository.Edit(b);

            OnUpdated(new EventArgs());
        }

        /// <summary>
        /// Raises the event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnUpdated(EventArgs e)
        {
            Updated?.Invoke(this, e);
        }
    }
}
