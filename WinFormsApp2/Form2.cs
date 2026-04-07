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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            label4.Text = countO.ToString();
            label5.Text = countX.ToString();
        }
        private int countX = 0;
        private int countO = 0;
        private string currentPlayer = "X";
        private bool status = true;

        private bool CheckWin(Button button1, Button button2, Button button3)
        {
            if (string.IsNullOrEmpty(button1.Text) ||
                string.IsNullOrEmpty(button2.Text) ||
                string.IsNullOrEmpty(button3.Text)) { return false; }
            return button1.Text == button2.Text && button2.Text == button3.Text;
        }

        private string CheckForWin()
        {
            if (CheckWin(button1_1, button1_2, button1_3)) return button1_1.Text;
            if (CheckWin(button1_1, button2_1, button3_3)) return button1_1.Text;
            if (CheckWin(button1_1, button2_2, button3_3)) return button1_1.Text;

            if (CheckWin(button1_2, button2_2, button3_2)) return button1_2.Text;

            if (CheckWin(button1_3, button2_3, button3_3)) return button1_3.Text;
            if (CheckWin(button1_3, button2_2, button3_1)) return button1_3.Text;

            if (CheckWin(button2_1, button1_1, button3_1)) return button2_1.Text;

            if (CheckWin(button3_1, button3_2, button3_3)) return button3_1.Text;


            return "";
        }

        private void PlaceMark(Button button)
        {
            if (button == null || !string.IsNullOrEmpty(button.Text))
            {
                return;
            }
            button.Text = currentPlayer;
            currentPlayer = (currentPlayer == "X") ? "O" : "X";
        }



        private void button1_1_Click(object sender, EventArgs e)
        {
            PlaceMark(button1_1);

        }

        private void button1_2_Click(object sender, EventArgs e)
        {
            PlaceMark(button1_2);
        }

        private void button1_3_Click(object sender, EventArgs e)
        {
            PlaceMark(button1_3);
        }

        private void button2_1_Click(object sender, EventArgs e)
        {
            PlaceMark(button2_1);
        }
        private void button2_2_Click(object sender, EventArgs e)
        {
            PlaceMark(button2_2);
        }
        private void button2_3_Click(object sender, EventArgs e)
        {

            PlaceMark(button2_3);
        }

        private void button3_1_Click(object sender, EventArgs e)
        {
            PlaceMark(button3_1);
        }

        private void button3_2_Click(object sender, EventArgs e)
        {
            PlaceMark(button3_2);
        }
        private void button3_3_Click(object sender, EventArgs e)
        {
            PlaceMark(button3_3);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
