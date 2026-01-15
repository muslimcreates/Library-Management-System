namespace Library_System
{
    partial class MemberDashboard
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
            panel1 = new Panel();
            panelAvailableBooks = new Panel();
            flowBooks = new FlowLayoutPanel();
            panelMyBorrowedBooks = new Panel();
            button3 = new Button();
            dgvBorrowedBooks = new DataGridView();
            panel1.SuspendLayout();
            panelAvailableBooks.SuspendLayout();
            panelMyBorrowedBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(24, 52);
            button1.Name = "button1";
            button1.Size = new Size(127, 130);
            button1.TabIndex = 0;
            button1.Text = "View All Books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(24, 239);
            button2.Name = "button2";
            button2.Size = new Size(127, 137);
            button2.TabIndex = 1;
            button2.Text = "My Borrowed Books";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Olive;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 437);
            panel1.TabIndex = 2;
            // 
            // panelAvailableBooks
            // 
            panelAvailableBooks.BackColor = Color.Cornsilk;
            panelAvailableBooks.Controls.Add(flowBooks);
            panelAvailableBooks.Location = new Point(195, 6);
            panelAvailableBooks.Name = "panelAvailableBooks";
            panelAvailableBooks.Size = new Size(593, 432);
            panelAvailableBooks.TabIndex = 3;
            // 
            // flowBooks
            // 
            flowBooks.AutoScroll = true;
            flowBooks.Dock = DockStyle.Bottom;
            flowBooks.Location = new Point(0, 52);
            flowBooks.Name = "flowBooks";
            flowBooks.Size = new Size(593, 380);
            flowBooks.TabIndex = 3;
            // 
            // panelMyBorrowedBooks
            // 
            panelMyBorrowedBooks.BackColor = Color.Moccasin;
            panelMyBorrowedBooks.Controls.Add(button3);
            panelMyBorrowedBooks.Controls.Add(dgvBorrowedBooks);
            panelMyBorrowedBooks.Location = new Point(195, 6);
            panelMyBorrowedBooks.Name = "panelMyBorrowedBooks";
            panelMyBorrowedBooks.Size = new Size(593, 432);
            panelMyBorrowedBooks.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(136, 355);
            button3.Name = "button3";
            button3.Size = new Size(221, 34);
            button3.TabIndex = 1;
            button3.Text = "Return";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // dgvBorrowedBooks
            // 
            dgvBorrowedBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBorrowedBooks.GridColor = Color.Gold;
            dgvBorrowedBooks.Location = new Point(70, 43);
            dgvBorrowedBooks.Name = "dgvBorrowedBooks";
            dgvBorrowedBooks.RowHeadersWidth = 62;
            dgvBorrowedBooks.Size = new Size(364, 283);
            dgvBorrowedBooks.TabIndex = 0;
            // 
            // MemberDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(panelMyBorrowedBooks);
            Controls.Add(panelAvailableBooks);
            Controls.Add(panel1);
            Name = "MemberDashboard";
            Text = "MemberDashboard";
            Load += MemberDashboard_Load_1;
            panel1.ResumeLayout(false);
            panelAvailableBooks.ResumeLayout(false);
            panelMyBorrowedBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBorrowedBooks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Panel panel1;
        private Panel panelAvailableBooks;
        private FlowLayoutPanel flowBooks;
        public Panel panelMyBorrowedBooks;
        private Button button3;
        private DataGridView dgvBorrowedBooks;
    }
}