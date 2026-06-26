using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private List<NewsItem> newsList = new List<NewsItem>() {
        new NewsItem { Id = 1, Title = "Новость 1", Date = DateTime.Now, Content = "Текст..." },
        new NewsItem { Id = 2, Title = "Новость 2", Date = DateTime.Now, Content = "Текст..." }
        };

        public Form1()
        {
            InitializeComponent();

            LoadData();
        }

        public int getLastId()
        {
            return newsList.Count + 1;
        }

        public void updateNew(NewsItem item)
        {
            NewsItem? news = newsList.Find(it => it.Id == item.Id);

            if (news == null) return;

            news.Title = item.Title;
            news.Content = item.Content;

            LoadData();
        }

        public void addNew(NewsItem item)
        {
            newsList.Add(item);
            LoadData();
        }

        private void LoadData()
        {
            listBox1.Items.Clear();

            foreach (NewsItem item in newsList)
            {
                listBox1.Items.Add(item);
            }
 

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
            Form f6 = new Form3();
            f6.ShowDialog();
        }

        // new news
        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        // add
        private void button2_Click_1(object sender, EventArgs e)
        {
            Form f = new Form8(this);
            f.ShowDialog();
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            NewsItem selectedNews = (NewsItem)listBox1.SelectedItem;
            
            DisplayNews(selectedNews);
        }

        private void DisplayNews(NewsItem news)
        {
            if (news == null) return;
            newName.Text = news.Title;
            newData.Text = news.Date.ToShortTimeString();
            newText.Text = news.Content;
        }

        private bool isClike()
        {
            return (NewsItem?)listBox1.SelectedItem != null;
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (!isClike()) return;
            
            var selectedNews = (NewsItem)listBox1.SelectedItem;

            Form red = new Form7(this, selectedNews);
            red.ShowDialog();
        }
    }
}
