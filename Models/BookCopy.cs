using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// Defines domain object BookCopy and its properties.
    /// </summary>
    public class BookCopy
    {
        public int Id { get; set; }
        public int Condition { get; set; }

        public int BookId { get; set; }
        public virtual Book Book { get; set; }

        /// <summary>
        /// Useful for adding the BookCopy objects directly to a ListBox.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("[{0}] -- {3} {1}/10", this.Id, this.Condition, this.BookId, this.Book.Title);
        }
    }
}
