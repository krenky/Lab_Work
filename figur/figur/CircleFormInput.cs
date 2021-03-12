using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figur
{
    public partial class CircleFormInput : Form
    {
        public CircleFormInput()
        {
            InitializeComponent();
        }
        int r = 0;

        public int R { get => r; set => r = value; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                R = Convert.ToInt32(textBox1.Text);
                Text = textBox1.Text;
                this.DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение");
                return;
            }
        }
    }
}
