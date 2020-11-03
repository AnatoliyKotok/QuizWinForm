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
    public partial class Form1 : Form
    {
        Form2 fg = new Form2();
        Form4 fa = new Form4();
        public Form1()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btGAme_Click(object sender, EventArgs e)
        {
            
            fg.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fa.ShowDialog();
        }
    }
}
