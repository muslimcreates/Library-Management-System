namespace Library_System
{
    partial class AdminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            panelMemberDetails = new Panel();
            panelManageBorrowings = new Panel();
            panelAddBooks = new Panel();
            btnSave = new Button();
            btnUpload = new Button();
            picBook = new PictureBox();
            label4 = new Label();
            numQuantity = new NumericUpDown();
            txtCategory = new TextBox();
            label3 = new Label();
            txtAuthor = new TextBox();
            label2 = new Label();
            txtTitle = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panelMemberDetails.SuspendLayout();
            panelAddBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBook).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.Screenshot_2026_01_15_184358;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(31, 24);
            button1.Name = "button1";
            button1.Size = new Size(128, 115);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.Screenshot_2026_01_15_184529;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(31, 163);
            button2.Name = "button2";
            button2.Size = new Size(128, 123);
            button2.TabIndex = 2;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.Screenshot_2026_01_15_184550;
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(31, 308);
            button3.Name = "button3";
            button3.Size = new Size(128, 114);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Olive;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(184, 447);
            panel1.TabIndex = 4;
            // 
            // panelMemberDetails
            // 
            panelMemberDetails.BackColor = Color.Cornsilk;
            panelMemberDetails.Controls.Add(panelManageBorrowings);
            panelMemberDetails.Location = new Point(0, 3);
            panelMemberDetails.Name = "panelMemberDetails";
            panelMemberDetails.Size = new Size(473, 447);
            panelMemberDetails.TabIndex = 6;
            // 
            // panelManageBorrowings
            // 
            panelManageBorrowings.BackColor = Color.Cornsilk;
            panelManageBorrowings.Location = new Point(0, 0);
            panelManageBorrowings.Name = "panelManageBorrowings";
            panelManageBorrowings.Size = new Size(473, 447);
            panelManageBorrowings.TabIndex = 7;
            // 
            // panelAddBooks
            // 
            panelAddBooks.BackColor = Color.Cornsilk;
            panelAddBooks.Controls.Add(panelMemberDetails);
            panelAddBooks.Controls.Add(btnSave);
            panelAddBooks.Controls.Add(btnUpload);
            panelAddBooks.Controls.Add(picBook);
            panelAddBooks.Controls.Add(label4);
            panelAddBooks.Controls.Add(numQuantity);
            panelAddBooks.Controls.Add(txtCategory);
            panelAddBooks.Controls.Add(label3);
            panelAddBooks.Controls.Add(txtAuthor);
            panelAddBooks.Controls.Add(label2);
            panelAddBooks.Controls.Add(txtTitle);
            panelAddBooks.Controls.Add(label1);
            panelAddBooks.Location = new Point(193, 4);
            panelAddBooks.Name = "panelAddBooks";
            panelAddBooks.Size = new Size(473, 447);
            panelAddBooks.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Cornsilk;
            btnSave.FlatStyle = FlatStyle.Popup;
            btnSave.Location = new Point(73, 366);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(258, 56);
            btnSave.TabIndex = 19;
            btnSave.Text = "SAVE BOOK";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = Color.Cornsilk;
            btnUpload.FlatStyle = FlatStyle.Popup;
            btnUpload.Location = new Point(128, 216);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(155, 40);
            btnUpload.TabIndex = 18;
            btnUpload.Text = "Upload Cover";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click_1;
            // 
            // picBook
            // 
            picBook.Location = new Point(141, 281);
            picBook.Name = "picBook";
            picBook.Size = new Size(128, 79);
            picBook.SizeMode = PictureBoxSizeMode.Zoom;
            picBook.TabIndex = 16;
            picBook.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 163);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 15;
            label4.Text = "Quantity";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(119, 161);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(150, 31);
            numQuantity.TabIndex = 14;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(119, 111);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(150, 31);
            txtCategory.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 114);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 12;
            label3.Text = "Category";
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(119, 67);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(150, 31);
            txtAuthor.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 70);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 10;
            label2.Text = "Author";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(119, 21);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 24);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 8;
            label1.Text = "Title";
            // 
            // AdminDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 450);
            Controls.Add(panelAddBooks);
            Controls.Add(panel1);
            Name = "AdminDashboard";
            Text = "AdminDashboard";
            panel1.ResumeLayout(false);
            panelMemberDetails.ResumeLayout(false);
            panelAddBooks.ResumeLayout(false);
            panelAddBooks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBook).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Panel panelAddBooks;
        private Panel panelMemberDetails;
        private Panel panelManageBorrowings;
        private Label label4;
        private NumericUpDown numQuantity;
        private TextBox txtCategory;
        private Label label3;
        private TextBox txtAuthor;
        private Label label2;
        private TextBox txtTitle;
        private Label label1;
        private Button btnUpload;
        private PictureBox picBook;
        private Button btnSave;
    }
}