using Library.Models;
using Library.Repositories;
using Library.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace Library
{
    /// <summary>
    /// The GUI class.
    /// </summary>
    public partial class LibraryForm : Form
    {
        BookService bookService;
        AuthorService authorService;
        BookCopyService copyService;
        MemberService memberService;
        LoanService loanService;

        /// <summary>
        /// Constructor of form.
        /// </summary>
        public LibraryForm()
        {
            InitializeComponent();

            // Register derived strategy with seed method
            Database.SetInitializer<LibraryContext>(new LibraryDbInit());

            // We create only one context in our application, which gets shared among repositories
            LibraryContext context = new LibraryContext();

            // We use a factory object that will create the repositories as they are needed, it also makes
            // sure all the repositories created use the same context.
            RepositoryFactory repFactory = new RepositoryFactory(context);

            this.bookService = new BookService(repFactory);
            this.authorService = new AuthorService(repFactory);
            this.copyService = new BookCopyService(repFactory);
            this.memberService = new MemberService(repFactory);
            this.loanService = new LoanService(repFactory);

            // All objects that should show up at the start. 
            ShowAllAuthors(authorService.All());
            ShowAllBooks(bookService.All(), lbBooks);
            ShowAllBooks(bookService.All(), lbOfBooks);
            ShowAllMembers(memberService.All());
            ShowAllLoans(loanService.All());
            ShowAllCopies(CopyNotOnLoan(), lbCopies);

            // Subscribe to event
            bookService.Updated += BookService_Updated;
            copyService.Updated += CopyService_Updated;
            authorService.Updated += AuthorService_Updated;
            memberService.Updated += MemberService_Updated;
            loanService.Updated += LoanService_Updated;
        }

        // Event.
        private void LoanService_Updated(object sender, EventArgs e)
        {
            ShowAllLoans(loanService.All());
            ShowAllCopies(CopyNotOnLoan(), lbCopies);
        }

        private void MemberService_Updated(object sender, EventArgs e)
        {
            ShowAllMembers(memberService.All());
        }

        private void AuthorService_Updated(object sender, EventArgs e)
        {
            ShowAllAuthors(authorService.All());
        }

        private void CopyService_Updated(object sender, EventArgs e)
        {
            ShowAllCopies(CopyNotOnLoan(), lbCopies);
        }

        private void BookService_Updated(object sender, EventArgs e)
        {
            ShowAllBooks(bookService.All(), lbBooks);
            ShowAllBooks(bookService.All(), lbOfBooks);
        }

        // Show All.
        private void ShowAllBooks(IEnumerable<Book> books, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (Book book in books)
            {
                listBox.Items.Add(book);
            }
        }

        private void ShowAllAuthors(IEnumerable<Author> authors)
        {
            lbAuthors.Items.Clear();
            lbChooseAut.Items.Clear();
            foreach (Author author in authors)
            {
                lbAuthors.Items.Add(author);
                lbChooseAut.Items.Add(author);
            }
        }

        private void ShowAllMembers(IEnumerable<Member> members)
        {
            lbMembers.Items.Clear();
            foreach (Member member in members)
            {
                lbMembers.Items.Add(member);
            }
        }

        private void ShowAllCopies(IEnumerable<BookCopy> copies, ListBox listBox)
        {
            listBox.Items.Clear();
            foreach (BookCopy copy in copies)
            {
                listBox.Items.Add(copy);
            }
        }

        private void ShowAllLoans(IEnumerable<Loan> loans)
        {
            lbLoans.Items.Clear();
            foreach (Loan loan in loans)
            {
                lbLoans.Items.Add(loan);
            }
        }

        /// <summary>
        /// Joins book copies and loans and returns the bookcopies that are not on loan.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<BookCopy> CopyNotOnLoan()
        {
            return copyService.All().Except(copyService.All().Join(loanService.NotReturned(), c => c.Id, l => l.BookCopyId, (c, l) => c));
        }

        /// <summary>
        /// Returns the book property from bookcopies that are not on loan.
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Book> AvailableBooks()
        {
            IEnumerable<Book> books = CopyNotOnLoan().Select(b => b.Book);
            return books.Distinct();
        }

        // View Books Group.
        private void lbBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ShowAllBooks(bookService.All(), lbBooks);
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            ShowAllBooks(AvailableBooks(), lbBooks);
        }

        private void lbAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Checks if an author has been chosen in the listbox and then shows books by author.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortByAuthor_Click(object sender, EventArgs e)
        {
            Author auth = lbAuthors.SelectedItem as Author;

            if (lbAuthors.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an author.");
            }
            else
            {
                ShowAllBooks(bookService.BooksByAuthor(auth.Id), lbBooks);
            }
        }

        private void lbIndCopy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Checks if a book has been selected and then shows bookcopies by book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectCopy_Click(object sender, EventArgs e)
        {
            Book book = lbBooks.SelectedItem as Book;

            if (lbBooks.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a book.");
            }
            else
            {
                ShowAllCopies(copyService.ByBook(book.Id), lbIndCopy);
            }
        }

        // Add Books Group
        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            txtTitle.MaxLength = 100;
        }

        private void txtIsbn_TextChanged(object sender, EventArgs e)
        {
            txtTitle.MaxLength = 15;
        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {
            txtTitle.MaxLength = 500;
        }

        private void lbChooseAut_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Takes the input from GUI and checks if it is null or empty, if not it creates a new book.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            int id = bookService.GenerateId();
            Author author = lbChooseAut.SelectedItem as Author;
            string title = txtTitle.Text;
            string isbn = txtIsbn.Text;
            string descrip = txtDescription.Text;

            if (string.IsNullOrEmpty(title) && (string.IsNullOrEmpty(isbn) && (string.IsNullOrEmpty(descrip))))
            {
                MessageBox.Show("Input fields are not filled in.");
            }
            else if (lbChooseAut.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose an author.");
            }
            else
            {
                Book book = new Book()
                {
                    Id = id,
                    Title = title,
                    Isbn = isbn,
                    Description = descrip,
                    Author = author,
                    AuthorId = author.Id
                };

                bookService.Add(book);
                bookService.Edit(book);
            }
        }

        // Add Copy Group
        private void lbOfBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCondition_TextChanged(object sender, EventArgs e)
        {
            txtCondition.MaxLength = 2;
        }

        /// <summary>
        /// Checks if the input in condition is a number and if true, creates a new bookcopy.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCopy_Click(object sender, EventArgs e)
        {
            int id = copyService.GenerateId();

            int x;

            bool convertSuccess = int.TryParse(txtCondition.Text, out x);

            Book book = lbOfBooks.SelectedItem as Book;

            if (convertSuccess && lbOfBooks.SelectedIndex != -1)
            {
                if (1 <= x && x <= 10)
                {
                    BookCopy copy = new BookCopy
                    {
                        Id = id,
                        Condition = x,
                        Book = book,
                        BookId = book.Id
                    };

                    copyService.Add(copy);
                    copyService.Edit(copy);
                }
                else
                {
                    MessageBox.Show("Invalid input, condition was not a number within the specified limit");
                }
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        //Add author Group
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Checks if text input is null or empty, if not it creates a new author.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddAuthor_Click(object sender, EventArgs e)
        {
            int id = authorService.GenerateId();

            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Input fields are not filled in.");
            }
            else
            {
                Author author = new Author
                {
                    Id = id,
                    Name = txtName.Text
                };

                authorService.Add(author);
                authorService.Edit(author);
            }
        }

        // Add Member Group
        private void txtPNr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLName_TextChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        /// <summary>
        /// Checks if input pN is a number and if input fields firstname and lastname are null or empty.
        /// If successfull then it creates a new member.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMember_Click(object sender, EventArgs e)
        {
            int id = memberService.GenerateId();

            long pN;

            bool parseSuccess = long.TryParse(txtPNr.Text, out pN);

            if (string.IsNullOrEmpty(txtFName.Text) && (string.IsNullOrEmpty(txtLName.Text)))
            {
                MessageBox.Show("Input fields are not filled in.");
            }
            else if (parseSuccess)
            {
                Member member = new Member
                {
                    MemberId = id,
                    Name = txtFName.Text + " " + txtLName.Text,
                    PersonNumber = pN,
                    MembershipDate = monthCalendar1.SelectionStart
                };

                memberService.Add(member);
                memberService.Edit(member);
            }
            else
            {
                MessageBox.Show("Invalid input, Person number was not a number");
            }
        }

        // Loans Group

        private void rbAllLoans_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbOverdue_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbByMember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbReturned_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Checks which radiobutton is checked and shows the selected information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void show_Click(object sender, EventArgs e)
        {
            Member mem = lbMembers.SelectedItem as Member;
            if (rbByMember.Checked)
            {
                ShowAllLoans(loanService.LoanByMember(mem.MemberId));
            }

            if (rbAllLoans.Checked)
            {
                ShowAllLoans(loanService.NotReturned());
            }

            if (rbOverdue.Checked)
            {
                ShowAllLoans(loanService.CheckIfOverdue());
            }

            if (rbReturned.Checked)
            {
                ShowAllLoans(loanService.CheckIfReturned());
            }
        }

        private void lbMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lbCopies_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Gets member and bookccopy from listboxes and creates a new loan.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLoan_Click(object sender, EventArgs e)
        {
            int id = loanService.GenerateId();
            DateTime timeOfloan = DateTime.Now;
            DateTime dueDate = timeOfloan.AddDays(15.0);
            DateTime? timeOfReturn = null;
            Member mem = lbMembers.SelectedItem as Member;
            BookCopy copy = lbCopies.SelectedItem as BookCopy;

            if (lbMembers.SelectedIndex == -1 && lbCopies.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a member and a copy.");
            }
            else
            {
                Loan loan = new Loan
                {
                    Id = id,
                    TimeOfLoan = timeOfloan,
                    DueDate = dueDate,
                    TimeOfReturn = timeOfReturn,
                    Member = mem,
                    MemberId = mem.MemberId,
                    BookCopy = copy,
                    BookCopyId = copy.Id
                };

                loanService.Add(loan);
                loanService.Edit(loan);
            }
        }

        /// <summary>
        /// Sets the time of return to loan to show that it has been returned and calculates fine if there is one.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReturn_Click(object sender, EventArgs e)
        {
            Loan loan = lbLoans.SelectedItem as Loan;

            if (lbLoans.SelectedIndex == -1)
            {
                MessageBox.Show("Please choose a loan to return.");
            }
            else
            {
                loan.TimeOfReturn = DateTime.Now;

                if (loanService.CalculateFine(loan) == 0)
                {
                    MessageBox.Show("Book was returned on time.");
                }
                else
                {
                    MessageBox.Show("Book was returned late, calculated fine: " + loanService.CalculateFine(loan) + "kr");
                }

                loanService.Edit(loan);
            } 
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
    }
}
