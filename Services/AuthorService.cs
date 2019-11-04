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
    /// Executes queries requested by the GUI for the author objects.
    /// </summary>
    class AuthorService : IService
    {
        AuthorRepository authorRepository;

        /// <summary>
        /// Lets the GUI know a change was made and that it should be updated.
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Constructor for authorservice, creates a repository for the service.
        /// </summary>
        /// <param name="rFactory">A repository factory, so the service can create its own repository</param>
        public AuthorService(RepositoryFactory rFactory)
        {
            this.authorRepository = rFactory.CreateAuthorRepository();
        }

        /// <summary>
        /// Returns all Authors.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Author> All()
        {
            return authorRepository.All();
        }

        /// <summary>
        /// Adds an author to the database.
        /// </summary>
        /// <param name="a">Author to be added.</param>
        public void Add(Author a)
        {
            authorRepository.Add(a);
        }

        /// <summary>
        /// Finds the last author in the database and returns the id.
        /// </summary>
        /// <returns></returns>
        public int findLastId()
        {
            Author aut = authorRepository.All().Last();
            return aut.Id;
        }

        /// <summary>
        /// If no previous object exists, id is set to 1, otherwise it adds the id number with 1.
        /// </summary>
        /// <returns></returns>
        public int GenerateId()
        {
            if (authorRepository.All().Count() == 0)
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
        /// The Edit method makes sure that the given Author object is saved to the database and raises the Updated() event.
        /// </summary>
        /// <param name="a">Author object to bes saved.</param>
        public void Edit(Author a)
        {
            authorRepository.Edit(a);

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
