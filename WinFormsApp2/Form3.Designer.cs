namespace WinFormsApp2
{
    partial class Form3
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            textBox1 = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox2 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            monthCalendar1 = new MonthCalendar();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            listBox2 = new ListBox();
            label6 = new Label();
            listBox3 = new ListBox();
            prices = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(58, 652);
            button1.Name = "button1";
            button1.Size = new Size(284, 54);
            button1.TabIndex = 0;
            button1.Text = "ГОТОВО";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(124, 9);
            label1.Name = "label1";
            label1.Size = new Size(93, 30);
            label1.TabIndex = 1;
            label1.Text = "Данные";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(729, 9);
            label2.Name = "label2";
            label2.Size = new Size(160, 30);
            label2.TabIndex = 2;
            label2.Text = "Расчет данных";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 14F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Items.AddRange(new object[] { "хлеб", "кефир ", "" });
            listBox1.Location = new Point(58, 54);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(237, 229);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(58, 445);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 4;
            label3.Text = "кол-вр";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(195, 447);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox2
            // 
            textBox2.Location = new Point(195, 500);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.Location = new Point(58, 498);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 7;
            label4.Text = "вес в грам";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(195, 569);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(58, 567);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 9;
            label5.Text = "цена";
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(307, 121);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(687, 652);
            button2.Name = "button2";
            button2.Size = new Size(237, 54);
            button2.TabIndex = 12;
            button2.Text = "СОХРАНИТЬ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(58, 300);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 130);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Segoe UI", 14F);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 25;
            listBox2.Items.AddRange(new object[] { "text", "docx", "cvs", "json" });
            listBox2.Location = new Point(687, 527);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(237, 79);
            listBox2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F);
            label6.Location = new Point(640, 54);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 15;
            // 
            // listBox3
            // 
            listBox3.Font = new Font("Segoe UI", 14F);
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 25;
            listBox3.Location = new Point(687, 54);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(237, 229);
            listBox3.TabIndex = 16;
            listBox3.SelectedIndexChanged += listBox3_SelectedIndexChanged;
            // 
            // prices
            // 
            prices.Font = new Font("Segoe UI", 14F);
            prices.FormattingEnabled = true;
            prices.ItemHeight = 25;
            prices.Items.AddRange(new object[] { "50", "100" });
            prices.Location = new Point(307, 54);
            prices.Name = "prices";
            prices.Size = new Size(237, 229);
            prices.TabIndex = 17;
            prices.Visible = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 718);
            Controls.Add(prices);
            Controls.Add(listBox3);
            Controls.Add(label6);
            Controls.Add(listBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(monthCalendar1);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private TextBox textBox1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private MonthCalendar monthCalendar1;
        private Button button2;
        private PictureBox pictureBox1;
        private ListBox listBox2;
        private Label label6;
        private ListBox listBox3;
        private ListBox prices;
    }
}