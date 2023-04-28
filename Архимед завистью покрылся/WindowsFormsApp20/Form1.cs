using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // эта строка - ваш введенный код
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // здесь начинается ваш код
            int summa = Int32.Parse(txtA.Text) +
               Int32.Parse(txtB.Text) + Int32.Parse(txtC.Text);
            txtSumma.Text = summa.ToString();
            // здесь ваш код закончился
        }
    }
}
