namespace Library {
    partial class LibraryForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbAuthors = new System.Windows.Forms.ListBox();
            this.btnSortByAuthor = new System.Windows.Forms.Button();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.lbBooks = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSelectCopy = new System.Windows.Forms.Button();
            this.lbIndCopy = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbChooseAut = new System.Windows.Forms.ListBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtCondition = new System.Windows.Forms.TextBox();
            this.lbOfBooks = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddCopy = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.AddMember = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtPNr = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.rbReturned = new System.Windows.Forms.RadioButton();
            this.rbByMember = new System.Windows.Forms.RadioButton();
            this.rbOverdue = new System.Windows.Forms.RadioButton();
            this.rbAllLoans = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.lbCopies = new System.Windows.Forms.ListBox();
            this.lbMembers = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.show = new System.Windows.Forms.Button();
            this.lbLoans = new System.Windows.Forms.ListBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAuthors
            // 
            this.lbAuthors.FormattingEnabled = true;
            this.lbAuthors.Location = new System.Drawing.Point(6, 316);
            this.lbAuthors.Name = "lbAuthors";
            this.lbAuthors.Size = new System.Drawing.Size(190, 82);
            this.lbAuthors.TabIndex = 11;
            this.lbAuthors.SelectedIndexChanged += new System.EventHandler(this.lbAuthors_SelectedIndexChanged);
            // 
            // btnSortByAuthor
            // 
            this.btnSortByAuthor.Location = new System.Drawing.Point(121, 404);
            this.btnSortByAuthor.Name = "btnSortByAuthor";
            this.btnSortByAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnSortByAuthor.TabIndex = 10;
            this.btnSortByAuthor.Text = "Search";
            this.btnSortByAuthor.UseVisualStyleBackColor = true;
            this.btnSortByAuthor.Click += new System.EventHandler(this.btnSortByAuthor_Click);
            // 
            // btnAvailable
            // 
            this.btnAvailable.Location = new System.Drawing.Point(87, 146);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(109, 23);
            this.btnAvailable.TabIndex = 9;
            this.btnAvailable.Text = "View Available";
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(6, 146);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(75, 23);
            this.btnViewAll.TabIndex = 8;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // lbBooks
            // 
            this.lbBooks.FormattingEnabled = true;
            this.lbBooks.HorizontalScrollbar = true;
            this.lbBooks.Location = new System.Drawing.Point(6, 19);
            this.lbBooks.Name = "lbBooks";
            this.lbBooks.Size = new System.Drawing.Size(323, 121);
            this.lbBooks.TabIndex = 7;
            this.lbBooks.SelectedIndexChanged += new System.EventHandler(this.lbBooks_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.btnSelectCopy);
            this.groupBox1.Controls.Add(this.lbIndCopy);
            this.groupBox1.Controls.Add(this.lbBooks);
            this.groupBox1.Controls.Add(this.lbAuthors);
            this.groupBox1.Controls.Add(this.btnViewAll);
            this.groupBox1.Controls.Add(this.btnSortByAuthor);
            this.groupBox1.Controls.Add(this.btnAvailable);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 437);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Books";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 300);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Search Books by Author:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "View All Copies of Book:";
            // 
            // btnSelectCopy
            // 
            this.btnSelectCopy.Location = new System.Drawing.Point(202, 146);
            this.btnSelectCopy.Name = "btnSelectCopy";
            this.btnSelectCopy.Size = new System.Drawing.Size(84, 23);
            this.btnSelectCopy.TabIndex = 13;
            this.btnSelectCopy.Text = "Select Book";
            this.btnSelectCopy.UseVisualStyleBackColor = true;
            this.btnSelectCopy.Click += new System.EventHandler(this.btnSelectCopy_Click);
            // 
            // lbIndCopy
            // 
            this.lbIndCopy.FormattingEnabled = true;
            this.lbIndCopy.Location = new System.Drawing.Point(6, 197);
            this.lbIndCopy.Name = "lbIndCopy";
            this.lbIndCopy.Size = new System.Drawing.Size(191, 82);
            this.lbIndCopy.TabIndex = 12;
            this.lbIndCopy.SelectedIndexChanged += new System.EventHandler(this.lbIndCopy_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddBook);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbChooseAut);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.txtIsbn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Title);
            this.groupBox2.Controls.Add(this.txtTitle);
            this.groupBox2.Location = new System.Drawing.Point(353, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 242);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Books";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(172, 202);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 20;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Choose Author";
            // 
            // lbChooseAut
            // 
            this.lbChooseAut.FormattingEnabled = true;
            this.lbChooseAut.Location = new System.Drawing.Point(127, 101);
            this.lbChooseAut.Name = "lbChooseAut";
            this.lbChooseAut.Size = new System.Drawing.Size(120, 95);
            this.lbChooseAut.TabIndex = 18;
            this.lbChooseAut.SelectedIndexChanged += new System.EventHandler(this.lbChooseAut_SelectedIndexChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(127, 75);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(120, 20);
            this.txtDescription.TabIndex = 17;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(127, 49);
            this.txtIsbn.MaxLength = 15;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(120, 20);
            this.txtIsbn.TabIndex = 16;
            this.txtIsbn.TextChanged += new System.EventHandler(this.txtIsbn_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "ISBN";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(10, 26);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(27, 13);
            this.Title.TabIndex = 13;
            this.Title.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(127, 23);
            this.txtTitle.MaxLength = 150;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(120, 20);
            this.txtTitle.TabIndex = 12;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCondition);
            this.groupBox3.Controls.Add(this.lbOfBooks);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnAddCopy);
            this.groupBox3.Location = new System.Drawing.Point(622, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(352, 242);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Copy of Book";
            // 
            // txtCondition
            // 
            this.txtCondition.Location = new System.Drawing.Point(198, 155);
            this.txtCondition.MaxLength = 2;
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(132, 20);
            this.txtCondition.TabIndex = 10;
            this.txtCondition.TextChanged += new System.EventHandler(this.txtCondition_TextChanged);
            // 
            // lbOfBooks
            // 
            this.lbOfBooks.FormattingEnabled = true;
            this.lbOfBooks.HorizontalScrollbar = true;
            this.lbOfBooks.Location = new System.Drawing.Point(19, 54);
            this.lbOfBooks.Name = "lbOfBooks";
            this.lbOfBooks.Size = new System.Drawing.Size(311, 95);
            this.lbOfBooks.TabIndex = 9;
            this.lbOfBooks.SelectedIndexChanged += new System.EventHandler(this.lbOfBooks_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose of which book this copy belongs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Condition from 1 to 10";
            // 
            // btnAddCopy
            // 
            this.btnAddCopy.Location = new System.Drawing.Point(255, 181);
            this.btnAddCopy.Name = "btnAddCopy";
            this.btnAddCopy.Size = new System.Drawing.Size(75, 23);
            this.btnAddCopy.TabIndex = 6;
            this.btnAddCopy.Text = "Add Copy";
            this.btnAddCopy.UseVisualStyleBackColor = true;
            this.btnAddCopy.Click += new System.EventHandler(this.btnAddCopy_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.btnAddAuthor);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(353, 260);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(263, 80);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Author";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 19);
            this.txtName.MaxLength = 50;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 6;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.Location = new System.Drawing.Point(139, 45);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(75, 23);
            this.btnAddAuthor.TabIndex = 5;
            this.btnAddAuthor.Text = "Add Author";
            this.btnAddAuthor.UseVisualStyleBackColor = true;
            this.btnAddAuthor.Click += new System.EventHandler(this.btnAddAuthor_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Name";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.AddMember);
            this.groupBox5.Controls.Add(this.monthCalendar1);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.txtLName);
            this.groupBox5.Controls.Add(this.txtFName);
            this.groupBox5.Controls.Add(this.txtPNr);
            this.groupBox5.Location = new System.Drawing.Point(353, 346);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(263, 331);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Add Member";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // AddMember
            // 
            this.AddMember.Location = new System.Drawing.Point(172, 302);
            this.AddMember.Name = "AddMember";
            this.AddMember.Size = new System.Drawing.Size(75, 23);
            this.AddMember.TabIndex = 8;
            this.AddMember.Text = "Add Member";
            this.AddMember.UseVisualStyleBackColor = true;
            this.AddMember.Click += new System.EventHandler(this.AddMember_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(27, 130);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 7;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Start of membership";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Last name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "First name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Person number";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(108, 74);
            this.txtLName.MaxLength = 25;
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 2;
            this.txtLName.TextChanged += new System.EventHandler(this.txtLName_TextChanged);
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(108, 48);
            this.txtFName.MaxLength = 25;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 1;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtPNr
            // 
            this.txtPNr.Location = new System.Drawing.Point(108, 22);
            this.txtPNr.MaxLength = 12;
            this.txtPNr.Name = "txtPNr";
            this.txtPNr.Size = new System.Drawing.Size(100, 20);
            this.txtPNr.TabIndex = 0;
            this.txtPNr.TextChanged += new System.EventHandler(this.txtPNr_TextChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.rbReturned);
            this.groupBox6.Controls.Add(this.rbByMember);
            this.groupBox6.Controls.Add(this.rbOverdue);
            this.groupBox6.Controls.Add(this.rbAllLoans);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.lbCopies);
            this.groupBox6.Controls.Add(this.lbMembers);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.btnReturn);
            this.groupBox6.Controls.Add(this.btnLoan);
            this.groupBox6.Controls.Add(this.show);
            this.groupBox6.Controls.Add(this.lbLoans);
            this.groupBox6.Location = new System.Drawing.Point(622, 260);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(352, 378);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Loans";
            this.groupBox6.Enter += new System.EventHandler(this.groupBox6_Enter);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(16, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(236, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "To make a loan choose member and book copy:";
            // 
            // rbReturned
            // 
            this.rbReturned.AutoSize = true;
            this.rbReturned.Location = new System.Drawing.Point(236, 104);
            this.rbReturned.Name = "rbReturned";
            this.rbReturned.Size = new System.Drawing.Size(69, 17);
            this.rbReturned.TabIndex = 19;
            this.rbReturned.TabStop = true;
            this.rbReturned.Text = "Returned";
            this.rbReturned.UseVisualStyleBackColor = true;
            this.rbReturned.CheckedChanged += new System.EventHandler(this.rbReturned_CheckedChanged);
            // 
            // rbByMember
            // 
            this.rbByMember.AutoSize = true;
            this.rbByMember.Location = new System.Drawing.Point(236, 81);
            this.rbByMember.Name = "rbByMember";
            this.rbByMember.Size = new System.Drawing.Size(78, 17);
            this.rbByMember.TabIndex = 18;
            this.rbByMember.TabStop = true;
            this.rbByMember.Text = "By Member";
            this.rbByMember.UseVisualStyleBackColor = true;
            this.rbByMember.CheckedChanged += new System.EventHandler(this.rbByMember_CheckedChanged);
            // 
            // rbOverdue
            // 
            this.rbOverdue.AutoSize = true;
            this.rbOverdue.Location = new System.Drawing.Point(236, 58);
            this.rbOverdue.Name = "rbOverdue";
            this.rbOverdue.Size = new System.Drawing.Size(66, 17);
            this.rbOverdue.TabIndex = 17;
            this.rbOverdue.TabStop = true;
            this.rbOverdue.Text = "Overdue";
            this.rbOverdue.UseVisualStyleBackColor = true;
            this.rbOverdue.CheckedChanged += new System.EventHandler(this.rbOverdue_CheckedChanged);
            // 
            // rbAllLoans
            // 
            this.rbAllLoans.AutoSize = true;
            this.rbAllLoans.Location = new System.Drawing.Point(236, 35);
            this.rbAllLoans.Name = "rbAllLoans";
            this.rbAllLoans.Size = new System.Drawing.Size(66, 17);
            this.rbAllLoans.TabIndex = 16;
            this.rbAllLoans.TabStop = true;
            this.rbAllLoans.Text = "On Loan";
            this.rbAllLoans.UseVisualStyleBackColor = true;
            this.rbAllLoans.CheckedChanged += new System.EventHandler(this.rbAllLoans_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(233, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "View Loans:";
            // 
            // lbCopies
            // 
            this.lbCopies.FormattingEnabled = true;
            this.lbCopies.HorizontalScrollbar = true;
            this.lbCopies.Location = new System.Drawing.Point(145, 225);
            this.lbCopies.Name = "lbCopies";
            this.lbCopies.Size = new System.Drawing.Size(185, 108);
            this.lbCopies.TabIndex = 12;
            this.lbCopies.SelectedIndexChanged += new System.EventHandler(this.lbCopies_SelectedIndexChanged);
            // 
            // lbMembers
            // 
            this.lbMembers.FormattingEnabled = true;
            this.lbMembers.Location = new System.Drawing.Point(19, 225);
            this.lbMembers.Name = "lbMembers";
            this.lbMembers.Size = new System.Drawing.Size(120, 108);
            this.lbMembers.TabIndex = 11;
            this.lbMembers.SelectedIndexChanged += new System.EventHandler(this.lbMembers_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(113, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Available Book Copies";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Members";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(71, 146);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Location = new System.Drawing.Point(255, 339);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(75, 23);
            this.btnLoan.TabIndex = 3;
            this.btnLoan.Text = "Loan";
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // show
            // 
            this.show.Location = new System.Drawing.Point(152, 146);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(75, 23);
            this.show.TabIndex = 1;
            this.show.Text = "Search";
            this.show.UseVisualStyleBackColor = true;
            this.show.Click += new System.EventHandler(this.show_Click);
            // 
            // lbLoans
            // 
            this.lbLoans.FormattingEnabled = true;
            this.lbLoans.HorizontalScrollbar = true;
            this.lbLoans.Location = new System.Drawing.Point(19, 19);
            this.lbLoans.Name = "lbLoans";
            this.lbLoans.Size = new System.Drawing.Size(208, 121);
            this.lbLoans.TabIndex = 0;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 689);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LibraryForm";
            this.Text = "Library";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAuthors;
        private System.Windows.Forms.Button btnSortByAuthor;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.ListBox lbBooks;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbChooseAut;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtCondition;
        private System.Windows.Forms.ListBox lbOfBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddCopy;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddAuthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button AddMember;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtPNr;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ListBox lbCopies;
        private System.Windows.Forms.ListBox lbMembers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.ListBox lbLoans;
        private System.Windows.Forms.ListBox lbIndCopy;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSelectCopy;
        private System.Windows.Forms.RadioButton rbReturned;
        private System.Windows.Forms.RadioButton rbByMember;
        private System.Windows.Forms.RadioButton rbOverdue;
        private System.Windows.Forms.RadioButton rbAllLoans;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}

