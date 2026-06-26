using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

using System.Net.Http;

namespace WinFormsApp2
{
    public partial class Form5 : Form
    {

        private readonly HttpClient _client = new HttpClient()
        {
            BaseAddress = new Uri("http://127.0.0.1:8000")
        };


        public Form5()
        {
            InitializeComponent();
            _client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private async void RegUser_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();

      

            RegUser.Enabled = false;

            var data = new
            {
                username = username
            };

            string json = JsonConvert.SerializeObject(data);
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

            try
            {
                var response = await _client.PostAsync("/user/register", content);

                Console.WriteLine(response);

                if (response.IsSuccessStatusCode)
                {
                    
                    MessageBox.Show("Успех");
                }
                else
                {
                    string errorText = await response.Content.ReadAsStringAsync();
                    MessageBox.Show("Error: " + errorText);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                RegUser.Enabled = true;
            }
            
        }
    }
}
