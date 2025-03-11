using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab1
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
            iResult.ReadOnly = true;
            comboBox1.Items.Add("DEC");
            comboBox1.Items.Add("HEX");
            comboBox1.Items.Add("BIN");

            comboBox2.Items.Add("DEC");
            comboBox2.Items.Add("HEX");
            comboBox2.Items.Add("BIN");
            comboBox1.SelectedIndex = 0; // Mặc định chọn "DEC"
            comboBox2.SelectedIndex = 2; // Mặc định chọn "BIN"
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void bConvert_Click(object sender, EventArgs e)
        {
            string inputValue = iNum.Text;
            string source = comboBox1.SelectedItem.ToString();
            string dest = comboBox2.SelectedItem.ToString();
            string result = "";
            if (string.IsNullOrEmpty(inputValue))
            {
                MessageBox.Show("Please enter a value.");
                return;
            }
            try
            {
                int decValue = 0;
                switch (source)
                {
                    case "DEC":
                        decValue = Convert.ToInt32(inputValue);
                        break;
                    case "HEX":
                        decValue = Convert.ToInt32(inputValue, 16);
                        break;
                    case "BIN":
                        decValue = Convert.ToInt32(inputValue, 2);
                        break;
                }
                string output = "";
                switch (dest)
                {
                    case "DEC":
                        output = decValue.ToString();
                        break;
                    case "HEX":
                        output = decValue.ToString("X");
                        break;
                    case "BIN":
                        output = Convert.ToString(decValue, 2);
                        break;
                }
                iResult.Text = output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid input value.");
            }

        }
        private void bThoat_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
        private void bReset_Click(object sender, EventArgs e)
        {
            iNum.Text = "";
            iResult.Text = "";
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 2;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
