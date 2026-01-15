namespace Library_System
{
    partial class BookDetailsForm
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
            lblTitle = new Label();
            picBook = new PictureBox();
            groupBox1 = new GroupBox();
            btnBorrow = new Button();
            lblQuantity = new Label();
            lblCategory = new Label();
            lblAuthor = new Label();
            ((System.ComponentModel.ISupportInitialize)picBook).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(126, 174);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(59, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "label1";
            // 
            // picBook
            // 
            picBook.Location = new Point(82, 40);
            picBook.Name = "picBook";
            picBook.Size = new Size(150, 113);
            picBook.SizeMode = PictureBoxSizeMode.Zoom;
            picBook.TabIndex = 1;
            picBook.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBorrow);
            groupBox1.Controls.Add(lblQuantity);
            groupBox1.Controls.Add(lblCategory);
            groupBox1.Controls.Add(lblAuthor);
            groupBox1.Controls.Add(picBook);
            groupBox1.Controls.Add(lblTitle);
            groupBox1.Location = new Point(235, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 384);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // btnBorrow
            // 
            btnBorrow.FlatStyle = FlatStyle.Popup;
            btnBorrow.Location = new Point(70, 323);
            btnBorrow.Name = "btnBorrow";
            btnBorrow.Size = new Size(174, 35);
            btnBorrow.TabIndex = 5;
            btnBorrow.Text = "Borrow";
            btnBorrow.UseVisualStyleBackColor = true;
            btnBorrow.Click += btnBorrow_Click_1;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(126, 286);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(59, 25);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "label1";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(126, 247);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(63, 25);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "lblTitle";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(113, 209);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(86, 25);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "lblAuthor";
            // 
            // BookDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "BookDetailsForm";
            Text = "BookDetailsForm";
            ((System.ComponentModel.ISupportInitialize)picBook).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitle;
        private PictureBox picBook;
        private GroupBox groupBox1;
        private Label lblCategory;
        private Label lblAuthor;
        private Button btnBorrow;
        private Label lblQuantity;
    }
}