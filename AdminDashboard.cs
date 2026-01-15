using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_Classes;
using Microsoft.Data.SqlClient;

namespace Library_System
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void hideallpanels()
        {
            panelAddBooks.Visible = false;
            panelMemberDetails.Visible = false;
            panelManageBorrowings.Visible = false;
        }
        //panelAddBooks code
        string selectedImagePath = "";
        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files|*.jpg;*.png;*.jpeg";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                selectedImagePath = dialog.FileName;
                picBook.Image = Image.FromFile(selectedImagePath);
            }
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(selectedImagePath))
            {
                MessageBox.Show("Please select an image");
                return;
            }
            else
            {


                string imagesFolder = Path.Combine(Application.StartupPath, "BookImages");
                Directory.CreateDirectory(imagesFolder);

                string fileName = Guid.NewGuid() + Path.GetExtension(selectedImagePath);
                string destinationPath = Path.Combine(imagesFolder, fileName);

                File.Copy(selectedImagePath, destinationPath, true);

                string imagePathForDb = "BookImages/" + fileName;
                string query = @"
INSERT INTO Books (Title, Author, Category, Quantity, ImagePath)
VALUES (@title, @author, @category, @quantity, @imagePath)";
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);

                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@author", txtAuthor.Text);
                    cmd.Parameters.AddWithValue("@category", txtCategory.Text);
                    cmd.Parameters.AddWithValue("@quantity", numQuantity.Value);
                    cmd.Parameters.AddWithValue("@imagePath", imagePathForDb);

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Book Added Successfully");
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            hideallpanels();
            panelAddBooks.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
           hideallpanels();
            panelMemberDetails.Visible = true;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideallpanels();
            panelManageBorrowings.Visible = true;
        }

      
    }
}

