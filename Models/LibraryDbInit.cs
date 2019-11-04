using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// Database strategy is chosen as the base class to LibraryDbInit.
    /// Here in the Seed method you can create the default objects you want in the database.
    /// </summary>
    class LibraryDbInit : DropCreateDatabaseAlways<LibraryContext>
    {
        protected override void Seed(LibraryContext context)
        {
            base.Seed(context);

            Author AlexD = new Author()
            {
                Id = 1,
                Name = "Alexandre Dumas",
            };

            Author CarmenB = new Author()
            {
                Id = 2,
                Name = "Carmen Bin Ladin"
            };

            Book monteCristo = new Book()
            {
                Id = 1,
                Title = "The Count of Monte Cristo",
                Isbn = "478-92-34511-0",
                Description = "Some description of the book.",
                Author = AlexD,
                AuthorId = AlexD.Id
            };

            Book gylleneBur = new Book()
            {
                Id = 2,
                Title = "En Gyllene Bur",
                Isbn = "778-64-74635-0",
                Description = "Life in Saudi Arabia",
                Author = CarmenB,
                AuthorId = CarmenB.Id
            };

            BookCopy copyMC = new BookCopy
            {
                Id = 1,
                Condition = 6,
                Book = monteCristo,
                BookId = monteCristo.Id
            };

            Member mem1 = new Member
            {
                MemberId = 1,
                PersonNumber = 9712187053,
                Name = "Evelina Sandström",
                MembershipDate = new DateTime(2019, 08, 20)
            };

            Loan loan = new Loan
            {
                Id = 1,
                TimeOfLoan = new DateTime(2019, 10, 13),
                DueDate = new DateTime(2019, 10, 28),
                TimeOfReturn = null,
                BookCopy = copyMC,
                BookCopyId = copyMC.Id,
                Member = mem1,
                MemberId = mem1.MemberId,
            };

            // Add the objects to the DbSet of object.
            context.Books.Add(monteCristo);
            context.Authors.Add(AlexD);
            context.Books.Add(gylleneBur);
            context.Authors.Add(CarmenB);
            context.BookCopies.Add(copyMC);
            context.Members.Add(mem1);
            context.Loans.Add(loan);

            // Persist changes to the database
            context.SaveChanges();
        }
    }
}
