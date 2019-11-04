using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Library.Models
{
    /// <summary>
    /// Defines domain object Book and its properties.
    /// </summary>
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Isbn { get; set; }
        public string Description { get; set; }

        public virtual ICollection<BookCopy> Copies { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        /// <summary>
        /// Useful for adding the book objects directly to a ListBox.
        /// </summary>
        public override string ToString()
        {
            return String.Format("[{0}] -- {1} {2} {3}", this.Id, this.Title, this.Isbn, this.Description);
        }
    }
}