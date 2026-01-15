namespace Library_System
{
    partial class AvailableBooks
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
            flowBooks = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(87, 47);
            button1.Name = "button1";
            button1.Size = new Size(203, 61);
            button1.TabIndex = 0;
            button1.Text = "See Available Books";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(87, 155);
            button2.Name = "button2";
            button2.Size = new Size(203, 69);
            button2.TabIndex = 1;
            button2.Text = "Button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // flowBooks
            // 
            flowBooks.AutoScroll = true;
            flowBooks.Dock = DockStyle.Bottom;
            flowBooks.Location = new Point(0, 122);
            flowBooks.Name = "flowBooks";
            flowBooks.Size = new Size(1075, 461);
            flowBooks.TabIndex = 2;
            flowBooks.Paint += flowBooks_Paint;
            // 
            // AvailableBooks
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(1075, 583);
            Controls.Add(flowBooks);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "AvailableBooks";
            Text = "Available Books";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private FlowLayoutPanel flowBooks;
    }
}