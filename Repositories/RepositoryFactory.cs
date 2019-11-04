using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Repositories
{
    /// <summary>
    /// Creates repositories.
    /// </summary>
    class RepositoryFactory
    {
        private LibraryContext context;

        /// <summary>
        /// Constructor for repositoryfactory.
        /// </summary>
        /// <param name="c">A Librarycontext that will be shared among repositories</param>
        public RepositoryFactory(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Creates a bookrepository.
        /// </summary>
        /// <returns></returns>
        public BookRepository CreateBookRepository()
        {
            return new BookRepository(context);
        }

        /// <summary>
        /// Creates a authorrepository.
        /// </summary>
        /// <returns></returns>
        public AuthorRepository CreateAuthorRepository()
        {
            return new AuthorRepository(context);
        }

        /// <summary>
        /// Creates a bookcopyrepository.
        /// </summary>
        /// <returns></returns>
        public BookCopyRepository CreateCopyRepository()
        {
            return new BookCopyRepository(context);
        }

        /// <summary>
        /// Creates a loanrepository.
        /// </summary>
        /// <returns></returns>
        public LoanRepository CreateLoanRepository()
        {
            return new LoanRepository(context);
        }

        /// <summary>
        /// Creates a memberrepository.
        /// </summary>
        /// <returns></returns>
        public MemberRepository CreateMemberRepository()
        {
            return new MemberRepository(context);
        }
    }
}
