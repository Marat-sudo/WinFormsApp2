using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form7 : Form
    {
        private Form1 mainForm;
        private NewsItem olditem;
        public Form7(Form1 mainForm, NewsItem olditem)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.olditem = olditem;

            textBoxName.Text = olditem.Title;
            richTextBox1.Text = olditem.Content;
        }

        

        private void Form7_Load(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelText_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string title = textBoxName.Text.Trim();
            string cont = richTextBox1.Text.Trim();

            if (title == "" || cont == "") return;

            NewsItem item = new NewsItem { Id = olditem.Id, Title = title, Date = olditem.Date, Content = cont };
            mainForm.updateNew(item);
            this.Close();

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void newsContent_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
