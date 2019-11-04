using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories
{
    /// <summary>
    /// The connection between database and service level for author objects.
    /// </summary>
    public class AuthorRepository : IRepository<Author, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor for authorrepository.
        /// </summary>
        /// <param name="c">Used to connect repository with database.</param>
        public AuthorRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Returns all authors in the database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Author> All()
        {
            return context.Authors;
        }

        /// <summary>
        /// Adds an author to the database.
        /// </summary>
        /// <param name="author">The author object that is being added.</param>
        public void Add(Author author)
        {
            context.Authors.Add(author);
        }

        /// <summary>
        /// Removes and author from the database.
        /// </summary>
        /// <param name="author">The author objects that is being removed.</param>
        public void Remove(Author author)
        {
            context.Authors.Remove(author);
        }

        /// <summary>
        /// Finds a specific author based on id from the database.
        /// </summary>
        /// <param name="id">The id used to find the author object.</param>
        /// <returns></returns>
        public Author Find(int id)
        {
            Author author = context.Authors.Find(id);
            return author;
        }

        /// <summary>
        /// Saves changes in the database made in the author table.
        /// </summary>
        /// <param name="author">What object has been changed.</param>
        public void Edit(Author author)
        {
            context.SaveChanges();
        }
    }
}
