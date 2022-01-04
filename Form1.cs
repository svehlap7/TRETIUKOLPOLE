using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRETIUKOLPOLE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cisla = textBox1.Text.Length;
            char[] pole = new char[cisla];
            int i = 0;

            foreach (char znaky in textBox1.Text)
            {
                pole[i] = znaky;
                i++;
            }
            char posledni = pole.Last();
            if (posledni >= '0' && posledni <= '9')
            {
                i = 0;
                foreach (char znak in pole)
                {
                    if (znak >= '0' && znak <= '9')
                    {
                        pole[i] = 'x';
                    }
                    i++;
                }
            }
            else
            {
                int maxi = pole.Max();
                int misto = Array.IndexOf(pole, (char)maxi);
                pole[i - 1] = (char)maxi;
                pole[misto] = (char)posledni;
            }
            foreach (char znak in pole)
            {
                textBox2.AppendText(znak.ToString());
            }
        }
    }
}
