using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            if (a == 1)
            {
                for (int i = 0; i < 10; i++)
                {
                    textBox2.Text += i;
                }
            }
            if (a == 0)
            {
                int i = 0;
                while (i < 10)
                {
                    textBox2.Text += i;
                    i++;
                }
            }

            if (a == 2)
            {
                int[] mas;
                mas = new int[10];
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    mas[i] = i;
                }
                foreach (int k in mas)
                {
                    textBox2.Text += k;
                }


            }



        }
        public void foo() { }
    }
}

