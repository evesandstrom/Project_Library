using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using Library.Repositories;

namespace Library.Services
{
    /// <summary>
    /// Executes queries requested by the GUI for the bookcopy objects.
    /// </summary>
    class BookCopyService : IService
    {
        BookCopyRepository copyRepository;

        /// <summary>
        /// Lets the GUI know a change was made and that it should be updated.
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Constructor for bookcopyservice, creates a repository for the service.
        /// </summary>
        /// <param name="rFactory">A repository factory, so the service can create its own repository</param>
        public BookCopyService(RepositoryFactory rFactory)
        {
            this.copyRepository = rFactory.CreateCopyRepository();
        }

        /// <summary>
        /// Returns all bookcopies.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<BookCopy> All()
        {
            return copyRepository.All();
        }

        /// <summary>
        /// Returns all bookcopies of a specific book.
        /// </summary>
        /// <param name="id">Used to find the specific book.</param>
        /// <returns></returns>
        public IEnumerable<BookCopy> ByBook(int id)
        {
            return copyRepository.All().Where(c => c.BookId == id);
        }

        /// <summary>
        /// Adds a bookcopy to the database.
        /// </summary>
        /// <param name="copy">BookCopy to be added.</param>
        public void Add(BookCopy copy)
        {
            copyRepository.Add(copy);
        }

        /// <summary>
        /// The Edit method makes sure that the given BookCopy object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="copy">The object to be saved.</param>
        public void Edit(BookCopy copy)
        {
            copyRepository.Edit(copy);
            OnUpdated(new EventArgs());
        }

        /// <summary>
        /// Finds the last bookcopy in the database and returns the id.
        /// </summary>
        /// <returns></returns>
        public int findLastId()
        {
            BookCopy copy = copyRepository.All().Last();
            return copy.Id;
        }

        /// <summary>
        /// If no previous object exists, id is set to 1, otherwise it adds the id number with 1.
        /// </summary>
        /// <returns></returns>
        public int GenerateId()
        {
            if (copyRepository.All().Count() == 0)
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
        /// Raises the event.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnUpdated(EventArgs e)
        {
            Updated?.Invoke(this, e);
        }
    }
}
