namespace WinFormsApp2
{
    partial class Form1
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
            tabControl1 = new TabControl();
            tabHome = new TabPage();
            label4 = new Label();
            button1 = new Button();
            buttonSetPhone = new Button();
            textBox3 = new TextBox();
            label3 = new Label();
            buttonSetSecondName = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            buttonSetName = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tabNews = new TabPage();
            button3 = new Button();
            button2 = new Button();
            tabService = new TabPage();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tabControl1.SuspendLayout();
            tabHome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabNews.SuspendLayout();
            tabService.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabHome);
            tabControl1.Controls.Add(tabNews);
            tabControl1.Controls.Add(tabService);
            tabControl1.Location = new Point(1, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(801, 441);
            tabControl1.TabIndex = 1;
            // 
            // tabHome
            // 
            tabHome.BackColor = Color.DarkGray;
            tabHome.Controls.Add(label4);
            tabHome.Controls.Add(button1);
            tabHome.Controls.Add(buttonSetPhone);
            tabHome.Controls.Add(textBox3);
            tabHome.Controls.Add(label3);
            tabHome.Controls.Add(buttonSetSecondName);
            tabHome.Controls.Add(textBox2);
            tabHome.Controls.Add(label2);
            tabHome.Controls.Add(buttonSetName);
            tabHome.Controls.Add(textBox1);
            tabHome.Controls.Add(label1);
            tabHome.Controls.Add(pictureBox1);
            tabHome.Location = new Point(4, 24);
            tabHome.Name = "tabHome";
            tabHome.Padding = new Padding(3);
            tabHome.Size = new Size(793, 413);
            tabHome.TabIndex = 0;
            tabHome.Text = "tabPage1";
            tabHome.Click += tabHone_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 315);
            label4.Name = "label4";
            label4.Size = new Size(160, 15);
            label4.TabIndex = 11;
            label4.Text = "rpo-24 марат семичаевский";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(557, 127);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // buttonSetPhone
            // 
            buttonSetPhone.Font = new Font("Segoe UI", 10F);
            buttonSetPhone.Location = new Point(407, 177);
            buttonSetPhone.Name = "buttonSetPhone";
            buttonSetPhone.Size = new Size(36, 23);
            buttonSetPhone.TabIndex = 9;
            buttonSetPhone.Text = "ok";
            buttonSetPhone.UseVisualStyleBackColor = true;
            buttonSetPhone.Visible = false;
            buttonSetPhone.Click += buttonSetPhone_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(274, 180);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 8;
            textBox3.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 180);
            label3.Name = "label3";
            label3.Size = new Size(99, 15);
            label3.TabIndex = 7;
            label3.Text = "номер телефона";
            label3.Click += label3_Click;
            // 
            // buttonSetSecondName
            // 
            buttonSetSecondName.Font = new Font("Segoe UI", 10F);
            buttonSetSecondName.Location = new Point(407, 109);
            buttonSetSecondName.Name = "buttonSetSecondName";
            buttonSetSecondName.Size = new Size(36, 23);
            buttonSetSecondName.TabIndex = 6;
            buttonSetSecondName.Text = "ok";
            buttonSetSecondName.UseVisualStyleBackColor = true;
            buttonSetSecondName.Visible = false;
            buttonSetSecondName.Click += buttonSetSecondName_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(274, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.Visible = false;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 112);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 4;
            label2.Text = "фамилия";
            label2.Click += label2_Click;
            // 
            // buttonSetName
            // 
            buttonSetName.Font = new Font("Segoe UI", 10F);
            buttonSetName.Location = new Point(407, 45);
            buttonSetName.Name = "buttonSetName";
            buttonSetName.Size = new Size(36, 23);
            buttonSetName.TabIndex = 3;
            buttonSetName.Text = "ok";
            buttonSetName.UseVisualStyleBackColor = true;
            buttonSetName.Visible = false;
            buttonSetName.Click += buttonSetName_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(275, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            textBox1.Visible = false;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(275, 48);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 1;
            label1.Text = "имя";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(33, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(199, 183);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tabNews
            // 
            tabNews.BackColor = Color.NavajoWhite;
            tabNews.Controls.Add(button3);
            tabNews.Controls.Add(button2);
            tabNews.Location = new Point(4, 24);
            tabNews.Name = "tabNews";
            tabNews.Padding = new Padding(3);
            tabNews.Size = new Size(793, 413);
            tabNews.TabIndex = 1;
            tabNews.Text = "tabPage2";
            // 
            // button3
            // 
            button3.Location = new Point(126, 132);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 1;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(126, 63);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 0;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // tabService
            // 
            tabService.BackColor = Color.DarkOliveGreen;
            tabService.Controls.Add(button6);
            tabService.Controls.Add(button5);
            tabService.Controls.Add(button4);
            tabService.Location = new Point(4, 24);
            tabService.Name = "tabService";
            tabService.Size = new Size(793, 413);
            tabService.TabIndex = 2;
            tabService.Text = "tabPage3";
            // 
            // button6
            // 
            button6.Location = new Point(441, 49);
            button6.Name = "button6";
            button6.Size = new Size(229, 84);
            button6.TabIndex = 2;
            button6.Text = "отчеты";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.Location = new Point(86, 232);
            button5.Name = "button5";
            button5.Size = new Size(229, 84);
            button5.TabIndex = 1;
            button5.Text = "button5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(86, 49);
            button4.Name = "button4";
            button4.Size = new Size(229, 84);
            button4.TabIndex = 0;
            button4.Text = "крестики нолики";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabHome.ResumeLayout(false);
            tabHome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabNews.ResumeLayout(false);
            tabService.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabHome;
        private TabPage tabNews;
        private TabPage tabService;
        private TextBox textBox1;
        private Label label1;
        private PictureBox pictureBox1;
        private Button buttonSetName;
        private Button buttonSetPhone;
        private TextBox textBox3;
        private Label label3;
        private Button buttonSetSecondName;
        private TextBox textBox2;
        private Label label2;
        private Button button1;
        private Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button3;
        private Label label4;
        private Button button6;
        private Button button5;
        private Button button4;
    }
}
