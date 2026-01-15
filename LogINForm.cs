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
    public partial class LogINForm : Form
    {
        public LogINForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Library_Classes.Members member = new Library_Classes.Members();
            Library_Classes.Admin Admin = new Library_Classes.Admin();
            bool isValid = member.Login(textBoxUsername.Text, textBoxPassword.Text,comboBox1.SelectedItem.ToString());
            bool isAdminValid = Admin.Login(textBoxUsername.Text, textBoxPassword.Text, comboBox1.SelectedItem.ToString());
            if (isValid )
            {
                MessageBox.Show(CurrentUser.UserID.ToString());

                MemberDashboard form = new MemberDashboard();
                    form.Show();
                    this.Hide();
                }
                else if (isAdminValid )
                {
                AdminDashboard form = new AdminDashboard();
                    form.Show();
                    this.Hide();
                }
            else
            {
                    MessageBox.Show("Invalid Credentials");
            }

        }
    }
}
