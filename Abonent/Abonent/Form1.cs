using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abonent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ClMid Mid = new ClMid();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Mid.Add(NameBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Введите корректное имя");
            }
        }
    }
}
