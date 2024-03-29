namespace TemperatureCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            // get input form textbox
            string input = textBoxC.Text;

            // convert to f
            // f = c * 9/5 +32
            double c = Convert.ToDouble(input);
            double f = c * 9 / 5 + 32;

            
            textBoxF.Text = f.ToString();
        }

        private void buttonConvert2_Click(object sender, EventArgs e)
        {
            // get input form textbox
            string input = textBoxF.Text;

            // convert to c
            // f = c - 32 * 5/9
            double f = Convert.ToDouble(input);
            double c = ( f - 32 ) * 5 / 9;

            // show input to textbox
            textBoxC.Text = c.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxC.Text = "";
            textBoxF.Text = "";
        }
    }
}