namespace Regression
{
    public partial class Form1 : Form
    {
        Regression reg = new Regression();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = reg.Calculate(x);

            lbl_output.Text = y.ToString();
        }
    }
}