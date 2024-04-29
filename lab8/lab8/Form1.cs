using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "Пойти сегодня в университет?";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rdn = new Random();
            double p = 0.5;
            double ans = rdn.NextDouble() - p;
            if (ans >= 0)
            {
                label1.Visible = true;
                label1.Text = "ДА!";
                label1.BackColor = Color.LimeGreen;
                label1.ForeColor = Color.White;
            }
            else
            {
                label1.Visible = true;
                label1.Text = "НЕТ!";
                label1.BackColor = Color.LimeGreen;
                label1.ForeColor = Color.White;
            }
        }
    }
}
