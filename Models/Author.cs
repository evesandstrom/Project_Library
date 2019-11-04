using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// Defines domain object Author and its properties.
    /// </summary>
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; }

        /// <summary>
        /// Useful for adding the Author objects directly to a ListBox.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1}", this.Id, this.Name);
        }
    }
}
