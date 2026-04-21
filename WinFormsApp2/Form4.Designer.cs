namespace WinFormsApp2
{
    partial class Form4
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
            textBoxName = new TextBox();
            labelName = new Label();
            labelSecondName = new Label();
            textBoxSecondName = new TextBox();
            labelRez = new Label();
            textBoxRez = new TextBox();
            monthCalendar1 = new MonthCalendar();
            labelText = new Label();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            buttonSave = new Button();
            buttonEmail = new Button();
            labelTest = new Label();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(123, 80);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(123, 62);
            labelName.Name = "labelName";
            labelName.Size = new Size(29, 15);
            labelName.TabIndex = 1;
            labelName.Text = "имя";
            // 
            // labelSecondName
            // 
            labelSecondName.AutoSize = true;
            labelSecondName.Location = new Point(123, 127);
            labelSecondName.Name = "labelSecondName";
            labelSecondName.Size = new Size(58, 15);
            labelSecondName.TabIndex = 3;
            labelSecondName.Text = "фамилия";
            // 
            // textBoxSecondName
            // 
            textBoxSecondName.Location = new Point(123, 145);
            textBoxSecondName.Name = "textBoxSecondName";
            textBoxSecondName.Size = new Size(100, 23);
            textBoxSecondName.TabIndex = 2;
            // 
            // labelRez
            // 
            labelRez.AutoSize = true;
            labelRez.Location = new Point(123, 195);
            labelRez.Name = "labelRez";
            labelRez.Size = new Size(96, 15);
            labelRez.TabIndex = 5;
            labelRez.Text = "название отчета";
            // 
            // textBoxRez
            // 
            textBoxRez.Location = new Point(123, 213);
            textBoxRez.Name = "textBoxRez";
            textBoxRez.Size = new Size(100, 23);
            textBoxRez.TabIndex = 4;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(321, 80);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 6;
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(123, 260);
            labelText.Name = "labelText";
            labelText.Size = new Size(74, 15);
            labelText.TabIndex = 8;
            labelText.Text = "текст отчета";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(54, 287);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(232, 96);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(321, 56);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 10;
            label1.Text = "выберите дату отчета";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(373, 287);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(160, 56);
            buttonSave.TabIndex = 11;
            buttonSave.Text = "сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonEmail
            // 
            buttonEmail.Location = new Point(373, 371);
            buttonEmail.Name = "buttonEmail";
            buttonEmail.Size = new Size(160, 40);
            buttonEmail.TabIndex = 12;
            buttonEmail.Text = "отправить на почту";
            buttonEmail.UseVisualStyleBackColor = true;
            buttonEmail.Click += buttonEmail_Click;
            // 
            // labelTest
            // 
            labelTest.AutoSize = true;
            labelTest.Location = new Point(16, 15);
            labelTest.Name = "labelTest";
            labelTest.Size = new Size(38, 15);
            labelTest.TabIndex = 13;
            labelTest.Text = "label2";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientActiveCaption;
            ClientSize = new Size(582, 507);
            Controls.Add(labelTest);
            Controls.Add(buttonEmail);
            Controls.Add(buttonSave);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(labelText);
            Controls.Add(monthCalendar1);
            Controls.Add(labelRez);
            Controls.Add(textBoxRez);
            Controls.Add(labelSecondName);
            Controls.Add(textBoxSecondName);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private Label labelName;
        private Label labelSecondName;
        private TextBox textBoxSecondName;
        private Label labelRez;
        private TextBox textBoxRez;
        private MonthCalendar monthCalendar1;
        private Label labelText;
        private RichTextBox richTextBox1;
        private Label label1;
        private Button buttonSave;
        private Button buttonEmail;
        private Label labelTest;
    }
}