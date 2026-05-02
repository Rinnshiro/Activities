using System;

namespace LibraryCatalog.Models
{
    public class Book
    {
        private string isbn;
        private string title;
        private string author;
        private int yearPublished;
        private int copiesAvailable;

        public string ISBN
        {
            get { return isbn; }
            set { isbn = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int YearPublished
        {
            get { return yearPublished; }
            set
            {
                int currentYear = DateTime.Now.Year;

                if (value < 1450 || value > currentYear)
                {
                    yearPublished = 1450;
                }
                else
                {
                    yearPublished = value;
                }
            }
        }

        public int CopiesAvailable
        {
            get { return copiesAvailable; }
            set
            {
                if (value < 0)
                {
                    copiesAvailable = 0;
                }
                else
                {
                    copiesAvailable = value;
                }
            }
        }

        public Book()
        {
            ISBN = "978-0747532699";
            Title = "Harry Potter and the Philosopher's Stone";
            Author = "J.K. Rowling";
            YearPublished = 1997;
            CopiesAvailable = 500;
        }

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            YearPublished = 1450;
            CopiesAvailable = 0;
        }

        public Book(string isbn, string title, string author, int yearPublished, int copiesAvailable)
        {
            ISBN = isbn;
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            CopiesAvailable = copiesAvailable;
        }

        public string GetDetails()
        {
            return $"ISBN: {ISBN}" + Environment.NewLine +
                   $"Title: {Title}" + Environment.NewLine +
                   $"Author: {Author}" + Environment.NewLine +
                   $"Year Published: {YearPublished}" + Environment.NewLine +
                   $"Copies Available: {CopiesAvailable}";
        }

        public bool BorrowCopy()
        {
            if (CopiesAvailable > 0)
            {
                CopiesAvailable--;
                return true;
            }

            return false;
        }

        public bool ReturnCopy()
        {
            CopiesAvailable++;
            return true;
        }
    }
}