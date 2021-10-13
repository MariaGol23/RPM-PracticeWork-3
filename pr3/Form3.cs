using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Str = Convert.ToString(textBox1.Text);
            int count = 0;
            int res=0;
            for (int i = 0; i < Str.Length; i++)
            {
                if (Str[i] == 'а' || Str[i] == 'А')
                {
                    count++;
                }
                if (count == 3)
                {
                    count = 0;
                    res++;
                }
            }
            label4.Text = "Результат: " + res;
        }
    }
}
