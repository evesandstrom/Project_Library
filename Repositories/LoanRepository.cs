using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;

namespace Library.Repositories 
{
    /// <summary>
    /// The connection between database and service level for loan objects.
    /// </summary>
    class LoanRepository : IRepository<Loan, int>
    {
        LibraryContext context;

        /// <summary>
        /// Constructor for loanrepository.
        /// </summary>
        /// <param name="c">Used to connect repository with database.</param>
        public LoanRepository(LibraryContext c)
        {
            this.context = c;
        }

        /// <summary>
        /// Returns all loans in database.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Loan> All()
        {
            return context.Loans;
        }

        /// <summary>
        /// Adds a loan to the database.
        /// </summary>
        /// <param name="loan">Object that is being added.</param>
        public void Add(Loan loan)
        {
            context.Loans.Add(loan);
        }
        
        /// <summary>
        /// Removes a loan from the database.
        /// </summary>
        /// <param name="loan">Object that is being removed.</param>
        public void Remove(Loan loan)
        {
            context.Loans.Remove(loan);
        }

        /// <summary>
        /// Finds a specific loan in the database on id.
        /// </summary>
        /// <param name="id">The id used to find the object.</param>
        /// <returns></returns>
        public Loan Find(int id)
        {
            Loan loan = context.Loans.Find(id); //(l => l.Id == id);
            return loan;
        }

        /// <summary>
        /// Saves changes to the database.
        /// </summary>
        /// <param name="loan">The object being changed.</param>
        public void Edit(Loan loan)
        {
            context.SaveChanges();
        }
    }
}
