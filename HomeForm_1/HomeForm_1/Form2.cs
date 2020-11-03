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
    public partial class Form2 : Form
    {
        
        Form3 res = new Form3();
        int i = 0;
        Form4 form4 = new Form4();
        Quiz quiz = Form4.quiz;
       
        public Form2()
        {
            InitializeComponent();
            lbTask.Text = $"Pres any button for start";
        }
        
        private void btYes_Click(object sender, EventArgs e)
        {
            if (i != quiz.question.Count)
            {
                lbTask.Text = $"{quiz.question[i++]}";
                quiz.ansver.Add(true);
            }
            else
            {
                
                res.lbRes.Text = $"{quiz.Result()}/{quiz.question.Count}";
                res.ShowDialog();
            }
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            if (i != quiz.question.Count)
            {
                lbTask.Text = $"{quiz.question[i++]}";
                quiz.ansver.Add(false);
            }
            else
            {
               
                res.lbRes.Text = $"{quiz.Result()}/{quiz.question.Count}";
                res.ShowDialog();
            }
        }
    }
}
