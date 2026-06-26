namespace WinFormsApp2
{
    partial class Form8
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
            buttonSave.Location = new Point(407, 76);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(160, 181);
            buttonSave.TabIndex = 28;
            buttonSave.Text = "сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(64, 211);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(232, 185);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "";
            // 
            // labelText
            // 
            labelText.AutoSize = true;
            labelText.Location = new Point(138, 164);
            labelText.Name = "labelText";
            labelText.Size = new Size(98, 15);
            labelText.TabIndex = 26;
            labelText.Text = "контент новости";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(138, 58);
            labelName.Name = "labelName";
            labelName.Size = new Size(65, 15);
            labelName.TabIndex = 25;
            labelName.Text = "Заголовок";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(138, 76);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(100, 23);
            textBoxName.TabIndex = 24;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 450);
            Controls.Add(buttonSave);
            Controls.Add(richTextBox1);
            Controls.Add(labelText);
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Name = "Form8";
            Text = "Form8";
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