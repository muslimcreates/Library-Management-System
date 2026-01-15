using Library_Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library_System
{
    public partial class AvailableBooks : Form
    {
        public AvailableBooks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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

        private void flowBooks_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

