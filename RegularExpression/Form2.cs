using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.ScriptErrorsSuppressed = true ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.amazon.in/s?k=" + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = webBrowser1.DocumentText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String patt = "<span class=\"a-price-whole\">[0-9]+,[0-9]+</span>";
            Regex reg = new Regex(patt);
            Match mc = reg.Match(richTextBox1.Text);
            while (mc.Success)
            {
                String s = mc.Value;
                listBox1.Items.Add(s);
                mc = mc.NextMatch();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            String patt = "<span class=\"a-price-whole\">[0-9]+,[0-9]+</span>";
            Regex reg = new Regex(patt);
            Match mc = reg.Match(richTextBox1.Text);
            while (mc.Success)
            {
                String s = mc.Value;
                string cleanData = s.Replace("<span class=\"a-price-whole\">", "");
                cleanData = cleanData.Replace("</span>", "");
                listBox2.Items.Add(cleanData);
                mc = mc.NextMatch();
            }
        }
    }
}
