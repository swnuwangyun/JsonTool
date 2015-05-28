using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace JsonTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string json = this.richTextBox1.Text;
            json = Regex.Replace(json, @"\s+", "");
            this.textBox1.Text = json;

            string jsonc = json;
            jsonc = jsonc.Replace("\"", "\\\"");
            this.textBox2.Text = jsonc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox1.Text) == false)
                Clipboard.SetText(this.textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.textBox2.Text) == false)
                Clipboard.SetText(this.textBox2.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.button1.PerformClick();
        }
    }
}
