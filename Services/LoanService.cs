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
    /// Executes queries requested by the GUI for the loan objects.
    /// </summary>
    class LoanService : IService
    {
        LoanRepository loanRepository;

        /// <summary>
        /// Lets the GUI know a change was made and that it should be updated.
        /// </summary>
        public event EventHandler Updated;

        /// <summary>
        /// Constructor for loanservice, creates a repository for the service.
        /// </summary>
        /// <param name="rFactory">A repository factory, so the service can create its own repository</param>
        public LoanService(RepositoryFactory rFactory)
        {
            this.loanRepository = rFactory.CreateLoanRepository();
        }

        /// <summary>
        /// Returns all loans.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Loan> All()
        {
            return loanRepository.All();
        }

        /// <summary>
        /// Returns all loans done by one member.
        /// </summary>
        /// <param name="id">Identifies member.</param>
        /// <returns></returns>
        public IEnumerable<Loan> LoanByMember(int id)
        {
            return loanRepository.All().Where(loan => loan.MemberId == id);
        }

        /// <summary>
        /// Checks if the due date of a loan is more than the current date and returns loans who are.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Loan> CheckIfOverdue()
        {
            DateTime now = DateTime.Now;
            return loanRepository.All().Where(loan => loan.DueDate < now);
        }

        /// <summary>
        /// Returns loans who has a time of return.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Loan> CheckIfReturned()
        {
            return loanRepository.All().Where(loan => loan.TimeOfReturn != null);
        }

        /// <summary>
        /// Returns loans who hasn't been returned.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Loan> NotReturned()
        {
            return loanRepository.All().Where(loan => loan.TimeOfReturn == null);
        }

        /// <summary>
        /// Calculates if and if so how many days a book has been returned late and gives a fine days * 10.
        /// </summary>
        /// <param name="a">Which loan has been returned.</param>
        /// <returns></returns>
        public double CalculateFine(Loan a)
        {
            double fine = 0;
            DateTime DayOfReturn = a.TimeOfReturn.Value;
            
            if (a.DueDate < a.TimeOfReturn)
            {
                double diff = (DayOfReturn - a.DueDate).TotalDays;
                double diff2 = Math.Round(diff);
                fine = diff2 * 10;
            }
            return fine;
        }

        /// <summary>
        /// Adds a loan to the database.
        /// </summary>
        /// <param name="a">Loan to be added.</param>
        public void Add(Loan a)
        {
            loanRepository.Add(a);
        }

        /// <summary>
        /// Finds the last loan in the database and returns the id.
        /// </summary>
        /// <returns></returns>
        public int findLastId()
        {
            Loan loan = loanRepository.All().Last();
            return loan.Id;
        }

        /// <summary>
        /// If there are no previous members the id is set to 1, else it adds the last id number with 1.
        /// </summary>
        /// <returns></returns>
        public int GenerateId()
        {
            if (loanRepository.All().Count() == 0)
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
        /// <param name="a">Loan object to be saved.</param>
        public void Edit(Loan a)
        {
            loanRepository.Edit(a);
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
