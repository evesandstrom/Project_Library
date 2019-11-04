using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// Defines domain object Loan and its properties.
    /// </summary>
    public class Loan
    {
        public int Id { get; set; }
        public DateTime TimeOfLoan { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime? TimeOfReturn { get; set; }

        public int BookCopyId { get; set; }
        public virtual BookCopy BookCopy { get; set; }

        public int MemberId { get; set; }
        public virtual Member Member { get; set; }

        /// <summary>
        /// Useful for adding the Loan objects directly to a ListBox.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1} {2} {3}", this.Id, this.TimeOfLoan, this.DueDate, this.TimeOfReturn);
        }
    }
}
