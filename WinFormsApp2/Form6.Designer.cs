namespace WinFormsApp2
{
    partial class Form6
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
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(61, 66);
            button1.Name = "button1";
            button1.Size = new Size(151, 77);
            button1.TabIndex = 0;
            button1.Text = "регистрация";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(61, 215);
            button2.Name = "button2";
            button2.Size = new Size(151, 77);
            button2.TabIndex = 1;
            button2.Text = "вход";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(282, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form6";
            Text = "Form6";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}