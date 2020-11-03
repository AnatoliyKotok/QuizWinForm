using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeForm_1
{
    public partial class Form4 : Form
    {
       public static Quiz quiz = new Quiz();
        public Form4()
        {
            InitializeComponent();
        }

        Question q;
        private void button2_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                q = new Question(textBox1.Text, false);
                button3.Visible = true;
                button4.Visible = true;
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text))
            {
                q = new Question(textBox1.Text, true);
                button3.Visible = true;
                button4.Visible = true;
            } 

        }

        private void button3_Click(object sender, EventArgs e)
        {

            quiz.AddQuestion(q);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
