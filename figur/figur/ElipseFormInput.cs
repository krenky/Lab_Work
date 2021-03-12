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
    public partial class ElipseFormInput : Form
    {
        public ElipseFormInput()
        {
            InitializeComponent();
        }
        int r;
        int r2;

        public int R { get => r; set => r = value; }
        public int R2 { get => r2; set => r2 = value; }

        private void ElipseFormInput_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                R = Convert.ToInt32(textBox1.Text);
                R2 = Convert.ToInt32(textBox2.Text);
                this.DialogResult = DialogResult.OK;
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
