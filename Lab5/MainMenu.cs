using System.Runtime.Intrinsics.X86;

namespace LAB5
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void bai1_button_Click(object sender, EventArgs e)
        {
            Bai1 Bai1 = new Bai1();
            Bai1.Show();
        }
        private void bai2_button_Click(object sender, EventArgs e)
        {
            Bai2 Bai2 = new Bai2();
            Bai2.Show();
        }

        private void bai3_button_Click(object sender, EventArgs e)
        {
            Bai3 Bai3 = new Bai3();
            Bai3.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
