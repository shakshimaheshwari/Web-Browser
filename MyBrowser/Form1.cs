using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                String address = textBox1.Text;
                String address1 = textBox1.Text;
                if (String.IsNullOrEmpty(address))
                    return;
                if (!address.StartsWith("http://") && !address.StartsWith("https://"))
                {
                    address = "https://" + address;
                }
                try
                {
                    webBrowser1.Navigate(new Uri(address));
                }
                catch (System.UriFormatException)
                {
                    webBrowser1.Navigate(new Uri("https://www.google.com/?gws_rd=ssl#q=" + address1));
                }
            }
        
}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl1.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
            tabControl1.TabPages.Add("New tab");
            tabControl1.SelectTab(i);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.SelectedTab.Controls.Add(webBrowser1);
            i++;

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tabControl1.Anchor = AnchorStyles.Top & AnchorStyles.Bottom & AnchorStyles.Left & AnchorStyles.Right;
            tabControl1.TabPages.Add("New tab");
            tabControl1.SelectTab(i);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.SelectedTab.Controls.Add(webBrowser1);
            i++;
        }


       
    }
}
