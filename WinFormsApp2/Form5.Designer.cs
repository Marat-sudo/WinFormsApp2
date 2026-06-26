namespace WinFormsApp2
{
    partial class Form5
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
            textBox1 = new TextBox();
            RegUser = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(325, 66);
            label1.Name = "label1";
            label1.Size = new Size(132, 37);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20F);
            textBox1.Location = new Point(340, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 43);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // RegUser
            // 
            RegUser.Location = new Point(302, 288);
            RegUser.Name = "RegUser";
            RegUser.Size = new Size(168, 58);
            RegUser.TabIndex = 2;
            RegUser.Text = "reg";
            RegUser.UseVisualStyleBackColor = true;
            RegUser.Click += RegUser_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegUser);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form5";
            Text = "Form5";
            Load += Form5_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button RegUser;
    }
}