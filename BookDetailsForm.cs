using Library_Classes;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library_System
{
    public partial class BookDetailsForm : Form
    {
        private Books _book;

        public BookDetailsForm(Books book)
        {
            InitializeComponent();
            _book = book;
            LoadBookDetails();
        }

        private void LoadBookDetails()
        {
            lblTitle.Text = _book.Title;
            lblAuthor.Text = "Author: " + _book.Author;
            lblCategory.Text = "Category: " + _book.Category;
            lblQuantity.Text = "Available: " + _book.Quantity;



            string fullImagePath = Path.Combine(
                AppContext.BaseDirectory,
                _book.ImagePath
            );

            if (File.Exists(fullImagePath))
            {
                picBook.Image = Image.FromFile(fullImagePath);
            }
        }
        private void btnBorrow_Click(object sender, EventArgs e)
        {
        }

        private void btnBorrow_Click_1(object sender, EventArgs e)
        {

            if (_book.Quantity <= 0)
            {
                MessageBox.Show("This book is currently unavailable.");
                return;
            }

            string msg;
            bool success = BorrowRepository.BorrowBook(
                CurrentUser.UserID,
                _book.BookID,
                out msg
            );

            MessageBox.Show(msg);

            if (success)
            {
                _book.Quantity--;
                lblQuantity.Text = "Available: " + _book.Quantity;
            }

        }
    }
}

