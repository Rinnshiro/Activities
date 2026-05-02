using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryCatalog.Models;

namespace LibraryCatalog
{
    public partial class LibraryBookCatalog : Form
    {
        private List<Book> books;

        public LibraryBookCatalog()
        {
            InitializeComponent();

            books = new List<Book>();

            books.Add(new Book());

            RefreshBookList();
        }

        private void RefreshBookList()
        {
            lstBooks.Items.Clear();

            foreach (Book book in books)
            {
                lstBooks.Items.Add($"{book.Title} — {book.ISBN}");
            }
        }

        private Book GetSelectedBook()
        {
            if (lstBooks.SelectedIndex >= 0)
            {
                return books[lstBooks.SelectedIndex];
            }

            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string isbn = txtISBN.Text.Trim();
            string title = txtTitle.Text.Trim();
            string author = txtAuthor.Text.Trim();
            string yearText = txtYear.Text.Trim();
            string copiesText = txtCopies.Text.Trim();

            if (string.IsNullOrWhiteSpace(isbn) ||
                string.IsNullOrWhiteSpace(title) ||
                string.IsNullOrWhiteSpace(author))
            {
                MessageBox.Show(
                    "ISBN, Title, and Author are required.",
                    "Missing Required Fields",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            Book newBook;

            bool yearBlank = string.IsNullOrWhiteSpace(yearText);
            bool copiesBlank = string.IsNullOrWhiteSpace(copiesText);

            if (yearBlank && copiesBlank)
            {
                newBook = new Book(isbn, title, author);
            }
            else
            {
                if (!int.TryParse(yearText, out int year))
                {
                    MessageBox.Show(
                        "Year Published must be a valid number.",
                        "Invalid Year",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                if (!int.TryParse(copiesText, out int copies))
                {
                    MessageBox.Show(
                        "Copies Available must be a valid number.",
                        "Invalid Copies",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

                newBook = new Book(isbn, title, author, year, copies);
            }

            books.Add(newBook);
            RefreshBookList();
            ClearFields();

            MessageBox.Show(
                "Book added successfully.",
                "Success",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            Book selectedBook = GetSelectedBook();

            if (selectedBook != null)
            {
                txtDetails.Text = selectedBook.GetDetails();
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Book selectedBook = GetSelectedBook();

            if (selectedBook == null)
            {
                MessageBox.Show(
                    "Please select a book first.",
                    "No Book Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            bool success = selectedBook.BorrowCopy();

            if (!success)
            {
                MessageBox.Show(
                    "No copies are available.",
                    "Borrow Failed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            txtDetails.Text = selectedBook.GetDetails();
            RefreshBookList();
            lstBooks.SelectedIndex = books.IndexOf(selectedBook);
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            Book selectedBook = GetSelectedBook();

            if (selectedBook == null)
            {
                MessageBox.Show(
                    "Please select a book first.",
                    "No Book Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                
                return;
            }

            selectedBook.ReturnCopy();

            txtDetails.Text = selectedBook.GetDetails();
            RefreshBookList();
            lstBooks.SelectedIndex = books.IndexOf(selectedBook);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Book selectedBook = GetSelectedBook();

            if (selectedBook == null)
            {
                MessageBox.Show(
                    "Please select a book to remove.",
                    "No Book Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            books.Remove(selectedBook);
            RefreshBookList();
            txtDetails.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtISBN.Clear();
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
            txtCopies.Clear();
            txtISBN.Focus();
        }
    }
}