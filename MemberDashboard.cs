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
    public partial class MemberDashboard : Form
    {
        public MemberDashboard()
        {
            InitializeComponent();
        }

        private void hideallpanels()
        {
            panelAvailableBooks.Visible = false;
            panelMyBorrowedBooks.Visible = false;
        }
        private void MemberDashboard_load(object sender, EventArgs e)
        {
            hideallpanels();

        }
        //panelMyBorrowedBooks code
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



        private void button1_Click(object sender, EventArgs e)
        {
            hideallpanels();
            panelAvailableBooks.Visible = true;

            flowBooks.Controls.Clear();

            List<Books> books = BookRepository.GetAllBooks();

            foreach (Books book in books)
            {
                Panel card = new Panel
                {
                    Width = 160,
                    Height = 260,
                    BorderStyle = BorderStyle.FixedSingle
                };

                PictureBox pic = new PictureBox
                {
                    Width = 140,
                    Height = 180,
                    Top = 10,
                    Left = 10,
                    SizeMode = PictureBoxSizeMode.Zoom
                };

                string fullImagePath = Path.Combine(
                    AppContext.BaseDirectory,
                    book.ImagePath
                );

                if (File.Exists(fullImagePath))
                {
                    pic.Image = Image.FromFile(fullImagePath);
                }

                Label lblTitle = new Label
                {
                    Text = book.Title,
                    Top = 200,
                    Left = 10,
                    Width = 140
                };
                card.Cursor = Cursors.Hand;


                card.Controls.Add(pic);
                card.Controls.Add(lblTitle);
                card.Click += (s, e) =>
                {
                    BookDetailsForm details = new BookDetailsForm(book);
                    details.ShowDialog();
                };

                // Also make child controls clickable
                foreach (Control ctrl in card.Controls)
                {
                    ctrl.Click += (s, e) =>
                    {
                        BookDetailsForm details = new BookDetailsForm(book);
                        details.ShowDialog();
                    };
                }

                flowBooks.Controls.Add(card);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideallpanels();

            panelMyBorrowedBooks.Visible = true;
            LoadBorrowedBooks();
            dgvBorrowedBooks.Visible = true;
            dgvBorrowedBooks.BringToFront();
            panelMyBorrowedBooks.BringToFront();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int borrowId = Convert.ToInt32(
dgvBorrowedBooks.SelectedRows[0].Cells["BorrowID"].Value
);

            if (BorrowRepository.ReturnBook(borrowId))
            {
                MessageBox.Show("Book returned.");
                LoadBorrowedBooks();
            }
            else
            {
                MessageBox.Show("Please select a book to return.");
            }
        }

        private void MemberDashboard_Load_1(object sender, EventArgs e)
        {
            hideallpanels();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int borrowId = Convert.ToInt32(
dgvBorrowedBooks.SelectedRows[0].Cells["BorrowID"].Value
);

            if (BorrowRepository.ReturnBook(borrowId))
            {
                MessageBox.Show("Book returned.");
                LoadBorrowedBooks();
            }
            else
            {
                MessageBox.Show("Please select a book to return.");
            }
        }
    }
}
