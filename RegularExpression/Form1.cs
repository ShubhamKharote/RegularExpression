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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String patt = "\\d+";
            Regex reg = new Regex(patt);
            Match mc = reg.Match(richTextBox1.Text);
            while (mc.Success)
            {
                String s = mc.Value;
                listBox1.Items.Add(s);
                mc = mc.NextMatch();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            String patt = textBox1.Text;
            Regex reg = new Regex(patt);
            Match mc = reg.Match(richTextBox1.Text);
            while (mc.Success)
            {
                String s = mc.Value;
                listBox1.Items.Add(s);
                mc = mc.NextMatch();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            String patt = "\\a+";
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
            listBox1.Items.Clear();
            String patt = "[0-9]{10}";
            Regex reg = new Regex(patt);
            Match mc = reg.Match(richTextBox1.Text);
            while (mc.Success)
            {
                String s = mc.Value;
                listBox1.Items.Add(s);
                mc = mc.NextMatch();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String patt = "[a-z]+[0-9]+@gmail.com";
            Regex reg = new Regex(patt);
            Match mc = reg.Match(richTextBox1.Text);
            while (mc.Success)
            {
                String s = mc.Value;
                listBox1.Items.Add(s);
                mc = mc.NextMatch();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form2 frm= new Form2();
            frm.Show();
            this.Hide();
        }
    }
}
