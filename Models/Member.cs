using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// Defines domain object Member and its properties.
    /// </summary>
    public class Member
    {
        public int MemberId { get; set; }
        public long PersonNumber { get; set; }
        public string Name { get; set; }
        public DateTime MembershipDate { get; set; }

        public virtual ICollection<Loan> NumLoans { get; set; }

        /// <summary>
        /// Useful for adding the Member objects directly to a ListBox.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("[{0}] -- {2}", this.MemberId, this.PersonNumber, this.Name, this.MembershipDate);
        }
    }
}
