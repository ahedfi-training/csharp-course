using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsynchronousProgrammingLab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DownloadHtml("https://devblogs.microsoft.com/");
            Task task = DowloadHtmlAsync("https://devblogs.microsoft.com/");
            Console.WriteLine("done");
        }

        private void DownloadHtml(string url)
        {
            var webClient = new WebClient();
            var html = webClient.DownloadString(url);
            using (var streamWriter = new StreamWriter(@"c:\Result\result.html"))
            {
                streamWriter.Write(html);
            }
        }

        private async Task DowloadHtmlAsync(string url)
        {
            using (var webClient = new WebClient())
            {
                var html = await webClient.DownloadStringTaskAsync(url);
                Console.WriteLine("downloading is done");
                using (var streamWriter = new StreamWriter(@"c:\Result\result.html"))
                {
                    await streamWriter.WriteAsync(html);
                }
            }
        }
    }
}
