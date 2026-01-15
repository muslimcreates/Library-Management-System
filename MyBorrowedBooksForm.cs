using Library_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class MyBorrowedBooksForm : Form
    {
        public MyBorrowedBooksForm()
        {
            InitializeComponent();


        }
        private void LoadBorrowedBooks()
        {
            var data = BorrowRepository.GetBorrowedBooks(CurrentUser.UserID);

            MessageBox.Show($"Borrowed books found: {data.Count}");
            dgvBorrowedBooks.AutoGenerateColumns = true;
            dgvBorrowedBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowedBooks.MultiSelect = false;
            dgvBorrowedBooks.ReadOnly = true;

            dgvBorrowedBooks.DataSource = null;   // reset
            dgvBorrowedBooks.DataSource =
                BorrowRepository.GetBorrowedBooks(CurrentUser.UserID);
        }


        private void MyBorrowedBooksForm_Load(object sender, EventArgs e)
        {
            LoadBorrowedBooks();
        }



        private void btnReturn_Click(object sender, EventArgs e)
        {
            int borrowId = Convert.ToInt32(
    dgvBorrowedBooks.SelectedRows[0].Cells["BorrowID"].Value
);

            if (BorrowRepository.ReturnBook(borrowId))
            {
                MessageBox.Show("Book returned.");
                LoadBorrowedBooks();
            }

        }

       
    }
}
