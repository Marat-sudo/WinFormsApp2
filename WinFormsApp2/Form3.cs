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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sum = 0;
            int count = 0;

            string selectItem = listBox1.SelectedItem.ToString();
            int selectId = listBox1.SelectedIndex;

            count = int.Parse(textBox1.Text);
            sum = int.Parse(textBox3.Text);
            sum = sum * count;

            listBox3.Items.Add(selectItem + " : " + sum.ToString());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectItem = listBox1.SelectedItem.ToString();
            int selectId = listBox1.SelectedIndex;
            textBox3.Text = prices.Items[selectId].ToString();
        }
    }
}
