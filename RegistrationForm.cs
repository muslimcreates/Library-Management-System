using Library_Classes;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Library_System
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == textBoxConfirm.Text)
            {
               
                
                    Library_Classes.Members Member = new Library_Classes.Members();
                   bool isvalid= Member.Register(textBoxName.Text, textBoxUsername.Text, textBoxPassword.Text, textBoxPhone.Text, textBoxID.Text);
                    if(!isvalid)
                    {
                        MessageBox.Show("Username Already Exists");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Member Successfully Registered");
                    }
                        
                    

                
               

            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            
                if(textBoxConfirm.Text != textBoxPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.");
                    return;
                }
                else
                {
                 LogINForm form = new LogINForm();
                 form.Show();
                 this.Hide();
                }
                  
            
            

        }
    }
}
