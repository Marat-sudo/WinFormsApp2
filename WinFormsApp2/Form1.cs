namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            buttonSetName.Visible = true;
            textBox1.Visible = true;
            label1.Visible = false;
        }

        private void buttonSetName_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
            textBox1.Visible = false;
            buttonSetName.Visible = false;
            label1.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            buttonSetSecondName.Visible = true;
            textBox2.Visible = true;
            label2.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            buttonSetPhone.Visible = true;
            textBox3.Visible = true;
            label3.Visible = false;
        }

        private void buttonSetSecondName_Click(object sender, EventArgs e)
        {
            label2.Text = textBox2.Text;
            textBox2.Visible = false;
            buttonSetSecondName.Visible = false;
            label2.Visible = true;
        }
        private void buttonSetPhone_Click(object sender, EventArgs e)
        {
            label3.Text = textBox3.Text;
            textBox3.Visible = false;
            buttonSetPhone.Visible = false;
            label3.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\rpo\Pictures\sharaga.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Hide();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void tabHone_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.ShowDialog();
        }
    }
}
