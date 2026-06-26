namespace WinFormsApp2
{
    partial class Form7
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
            buttonSave = new Button();
            richTextBox1 = new RichTextBox();
            labelText = new Label();
            labelName = new Label();
            textBoxName = new TextBox();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(398, 72);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(160, 181);
            buttonSave.TabIndex = 23;
            buttonSave.Text = "сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(55, 207);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(232, 185);
            richTextBox1.TabIndex = 21;
            richTextBox1.Text = "";
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(129, 160);
            labelText.Name = "labelText";
            labelText.Size = new Size(98, 15);
            labelText.TabIndex = 20;
            labelText.Text = "контент новости";
            labelText.Click += labelText_Click;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(129, 54);
            labelName.Name = "labelName";
            labelName.Size = new Size(65, 15);
            labelName.TabIndex = 14;
            labelName.Text = "Заголовок";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(129, 72);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 13;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
            Controls.Add(buttonSave);
            Controls.Add(richTextBox1);
            Controls.Add(labelText);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Name = "Form7";
            Text = "Form7";
            Load += Form7_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonSave;
        private RichTextBox richTextBox1;
        private Label labelText;
        private Label labelName;
        private TextBox textBoxName;
    }
}