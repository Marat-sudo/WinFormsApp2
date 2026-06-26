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
    public partial class Form8 : Form
    {
        private Form1 mainForm;
     
        public Form8(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string title = textBoxName.Text.Trim();
            string cont = richTextBox1.Text.Trim();

            if (title == "" || cont == "") return;

            NewsItem item = new NewsItem { Id = mainForm.getLastId(), Title = title, Date = DateTime.Now, Content = cont };
            mainForm.addNew(item);
            this.Close();
        }
    }
}
