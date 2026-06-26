using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    public class NewsItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public string Content { get; set; }

        public NewsItem()
        {
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()} - {Title}";
        }
    }
}
