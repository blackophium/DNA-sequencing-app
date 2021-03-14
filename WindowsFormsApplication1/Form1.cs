using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
  
        public partial class Form1 : Form
    {
        private string rndstring;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rndstring = "";
            rnd();
            textBox1.Text = rndstring;

        }
        private void rnd()
        {
            
            char[] letters = "GATC".ToCharArray();
            Random r = new Random();
            for(int i = 0;  i<numericUpDown1.Value; i++)
            {
                rndstring += letters[r.Next(0, 4)].ToString();
            }
         
        }

        private void button2_Click(object sender, EventArgs e)
        {
           


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.richTextBox1.SelectionBackColor = Color.White;
            textBox3.Text = Regex.Matches(textBox1.Text, textBox2.Text).Count.ToString();
            richTextBox1.Text = textBox1.Text;
            int len = this.richTextBox1.TextLength;
            int index = 0;
            int lastIndex = this.richTextBox1.Text.LastIndexOf(this.textBox2.Text);

            while (index < lastIndex)
            {
                this.richTextBox1.Find(this.textBox2.Text, index, len, RichTextBoxFinds.None);
                this.richTextBox1.SelectionBackColor = Color.Yellow;
                index = this.richTextBox1.Text.IndexOf(this.textBox2.Text, index) + 1;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.richTextBox1.SelectionBackColor = Color.White;
            textBox4.Text = Regex.Matches(textBox1.Text, textBox5.Text).Count.ToString();
            richTextBox1.Text = textBox1.Text;
            int len = this.richTextBox1.TextLength;
            int index = 0;
            int lastIndex = this.richTextBox1.Text.LastIndexOf(this.textBox5.Text);

            while (index < lastIndex)
            {
                this.richTextBox1.Find(this.textBox5.Text, index, len, RichTextBoxFinds.None);
                this.richTextBox1.SelectionBackColor = Color.Green;
                index = this.richTextBox1.Text.IndexOf(this.textBox2.Text, index) + 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            this.richTextBox1.SelectionBackColor = Color.White;
            textBox6.Text = Regex.Matches(textBox1.Text, textBox7.Text).Count.ToString();
            richTextBox1.Text = textBox1.Text;
            int len = this.richTextBox1.TextLength;
            int index = 0;
            int lastIndex = this.richTextBox1.Text.LastIndexOf(this.textBox7.Text);

            while (index < lastIndex)
            {
                this.richTextBox1.Find(this.textBox7.Text, index, len, RichTextBoxFinds.None);
                this.richTextBox1.SelectionBackColor = Color.SkyBlue;
                index = this.richTextBox1.Text.IndexOf(this.textBox2.Text, index) + 1;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
