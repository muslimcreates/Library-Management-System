namespace Library_System
{
    partial class AddBookForm
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
            label1 = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            label2 = new Label();
            txtCategory = new TextBox();
            label3 = new Label();
            numQuantity = new NumericUpDown();
            label4 = new Label();
            picBook = new PictureBox();
            label5 = new Label();
            btnUpload = new Button();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBook).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 75);
            label1.Name = "label1";
            label1.Size = new Size(44, 25);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(207, 72);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(150, 31);
            txtTitle.TabIndex = 1;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(207, 144);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(150, 31);
            txtAuthor.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 147);
            label2.Name = "label2";
            label2.Size = new Size(67, 25);
            label2.TabIndex = 2;
            label2.Text = "Author";
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(207, 220);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(150, 31);
            txtCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 223);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 4;
            label3.Text = "Category";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(207, 292);
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(180, 31);
            numQuantity.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(111, 294);
            label4.Name = "label4";
            label4.Size = new Size(80, 25);
            label4.TabIndex = 7;
            label4.Text = "Quantity";
            // 
            // picBook
            // 
            picBook.Location = new Point(638, 131);
            picBook.Name = "picBook";
            picBook.Size = new Size(150, 101);
            picBook.SizeMode = PictureBoxSizeMode.Zoom;
            picBook.TabIndex = 8;
            picBook.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(662, 72);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 9;
            label5.Text = "Book Cover";
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(662, 271);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(112, 48);
            btnUpload.TabIndex = 10;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(358, 401);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(258, 56);
            btnSave.TabIndex = 11;
            btnSave.Text = "SAVE BOOK";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddBookForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 529);
            Controls.Add(btnSave);
            Controls.Add(btnUpload);
            Controls.Add(label5);
            Controls.Add(picBook);
            Controls.Add(label4);
            Controls.Add(numQuantity);
            Controls.Add(txtCategory);
            Controls.Add(label3);
            Controls.Add(txtAuthor);
            Controls.Add(label2);
            Controls.Add(txtTitle);
            Controls.Add(label1);
            Name = "AddBookForm";
            Text = "AddBookForm";
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBook).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private Label label2;
        private TextBox txtCategory;
        private Label label3;
        private NumericUpDown numQuantity;
        private Label label4;
        private PictureBox picBook;
        private Label label5;
        private Button btnUpload;
        private Button btnSave;
    }
}