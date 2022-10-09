namespace ceki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            double height = double.Parse(textBox1.Text)/100;
            double weight = double.Parse(textBox2.Text);
            double BMI = weight / Math.Pow(height, 2);
            lbl3.Text = $"BMI: {BMI}";
            if (BMI <= 18.5)
            {
                lbl4.Text = "You are Underweight!";
            } 
            else if (BMI < 25)
            {
                lbl4.Text = "You are Health Weight";
            }
            else if (BMI<30)
            {
                lbl4.Text = "You are Overweight";
            }
            else
            {
                lbl4.Text = "You are  Obese";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}