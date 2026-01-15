namespace Library_System
{
    partial class RegistrationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            textBoxName = new TextBox();
            textBoxUsername = new TextBox();
            label2 = new Label();
            textBoxEmail = new TextBox();
            label3 = new Label();
            textBoxPhone = new TextBox();
            label4 = new Label();
            textBoxPassword = new TextBox();
            label6 = new Label();
            textBoxConfirm = new TextBox();
            label7 = new Label();
            textBoxID = new TextBox();
            label8 = new Label();
            button2 = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(490, 39);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 36);
            label1.Name = "label1";
            label1.Size = new Size(91, 25);
            label1.TabIndex = 1;
            label1.Text = "Full Name";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(173, 30);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(150, 31);
            textBoxName.TabIndex = 2;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(173, 76);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(150, 31);
            textBoxUsername.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 82);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(173, 128);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(150, 31);
            textBoxEmail.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(108, 128);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // textBoxPhone
            // 
            textBoxPhone.Location = new Point(174, 180);
            textBoxPhone.Name = "textBoxPhone";
            textBoxPhone.Size = new Size(150, 31);
            textBoxPhone.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 183);
            label4.Name = "label4";
            label4.Size = new Size(132, 25);
            label4.TabIndex = 7;
            label4.Text = "Phone Number";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(173, 279);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(150, 31);
            textBoxPassword.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(75, 285);
            label6.Name = "label6";
            label6.Size = new Size(87, 25);
            label6.TabIndex = 11;
            label6.Text = "Password";
            // 
            // textBoxConfirm
            // 
            textBoxConfirm.Location = new Point(173, 327);
            textBoxConfirm.Name = "textBoxConfirm";
            textBoxConfirm.Size = new Size(150, 31);
            textBoxConfirm.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 327);
            label7.Name = "label7";
            label7.Size = new Size(156, 25);
            label7.TabIndex = 13;
            label7.Text = "Confirm Password";
            // 
            // textBoxID
            // 
            textBoxID.Location = new Point(173, 229);
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(150, 31);
            textBoxID.TabIndex = 16;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(97, 235);
            label8.Name = "label8";
            label8.Size = new Size(65, 25);
            label8.TabIndex = 15;
            label8.Text = "UserID";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(490, 114);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 17;
            button2.Text = "Continue";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBoxID);
            groupBox1.Controls.Add(textBoxName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBoxConfirm);
            groupBox1.Controls.Add(textBoxUsername);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBoxPassword);
            groupBox1.Controls.Add(textBoxEmail);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBoxPhone);
            groupBox1.Location = new Point(25, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(361, 395);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "RegistrationForm";
            Text = "Registration Form";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBoxName;
        private TextBox textBoxUsername;
        private Label label2;
        private TextBox textBoxEmail;
        private Label label3;
        private TextBox textBoxPhone;
        private Label label4;
        private TextBox textBoxPassword;
        private Label label6;
        private TextBox textBoxConfirm;
        private Label label7;
        private TextBox textBoxID;
        private Label label8;
        private Button button2;
        private GroupBox groupBox1;
    }
}
