using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MathPractice
{
    public partial class Form1 : Form
    {

        Random Ran = new Random();

        int Ran1 = 0;
        int Ran2 = 0;
        int Ans = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewSet();
        }



        private void NewSet(){
            Ran1 = Ran.Next(100000000, 1000000000);
            Ran2 = Ran.Next(100000000, 1000000000);
            txtAnswer.Text = "";
            Ans = Ran1 + Ran2;

            txtNum1.Text = Ran1+ "";
            txtNum2.Text = Ran2+ "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewSet();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            txtAnswer.Text =  textBox2.Text+txtAnswer.Text;
            textBox2.Text = "";
        }



        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Equals(Ans + ""))
            {
                NewSet();
            }
            else
            {

            }
     }

    }
}
