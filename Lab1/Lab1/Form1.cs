namespace Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textSum.ReadOnly = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void iSum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sum_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(textNum1.Text);
                int num2 = int.Parse(textNum2.Text);
                long sum = num1 + num2;
                textSum.Text = sum.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "", MessageBoxButtons.OK);
            }
        }

        private void iNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            textNum1.Text = "";
            textNum2.Text = "";
            textSum.Text = "";
        }

        private void S(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
