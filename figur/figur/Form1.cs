using System.Windows.Forms;

namespace figur
{
    public partial class Form1 : Form
    {
        Figure figure;
        Form form;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            form = new CircleFormInput();
            form.ShowDialog();
            figure = new Circle();
            
        }
    }
}
