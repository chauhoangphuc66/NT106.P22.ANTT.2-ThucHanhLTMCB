using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            textResult.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(textInput.Text);
                string[] numText = new string[] { "Không", "Một", "Hai", "Ba", "Bốn", "Năm", "Sáu", "Bảy", "Tám", "Chín" };
                if (num >= 0 && num <= 9)
                {
                    textResult.Text = numText[num];
                }
                else if (num >= 10 && num <= 99)
                {
                    int num1 = num / 10;
                    int num2 = num % 10;
                    if (num2 == 0)
                    {
                        textResult.Text = numText[num1] + " Mươi";
                    }
                    else
                    {
                        textResult.Text = numText[num1] + " Mươi " + numText[num2];
                    }
                }
                else if (num >= 100 && num <= 999)
                {
                    int num1 = num / 100;
                    int num2 = (num % 100) / 10;
                    int num3 = num % 10;
                    if (num2 == 0 && num3 == 0)
                    {
                        textResult.Text = numText[num1] + " Trăm";
                    }
                    else if (num2 == 0)
                    {
                        textResult.Text = numText[num1] + " Trăm Lẻ " + numText[num3];
                    }
                    else if (num3 == 0)
                    {
                        textResult.Text = numText[num1] + " Trăm " + numText[num2] + " Mươi";
                    }
                    else
                    {
                        textResult.Text = numText[num1] + " Trăm " + numText[num2] + " Mươi " + numText[num3];
                    }
                }
                else if (num >= 1000 && num <= 9999)
                {
                    int num1 = num / 1000;
                    int num2 = (num % 1000) / 100;
                    int num3 = (num % 100) / 10;
                    int num4 = num % 10;
                    if (num2 == 0 && num3 == 0 && num4 == 0)
                    {
                        textResult.Text = numText[num1] + " Ngàn";
                    }
                    else if (num2 == 0 && num3 == 0)
                    {
                        textResult.Text = numText[num1] + " Ngàn Lẻ " + numText[num4];
                    }
                    else if (num2 == 0 && num4 == 0)
                    {
                        textResult.Text = numText[num1] + " Ngàn " + numText[num2] + " Trăm " + numText[num3] + " Mươi";
                    }
                    else if (num3 == 0 && num4 == 0)
                    {
                        textResult.Text = numText[num1] + " Ngàn " + numText[num2] + " Trăm";
                    }
                    else if (num2 == 0)
                    {
                        textResult.Text = numText[num1] + " Ngàn Lẻ " + numText[num3] + " Mươi " + numText[num4];
                    }
                    else if (num3 == 0)
                    {
                        textResult.Text = numText[num1] + " Ngàn " + numText[num2] + " Trăm Lẻ " + numText[num4];
                    }
                    else if (num4 == 0)
                    {
                        textResult.Text = numText[num1] + " Ngàn " + numText[num2] + " Trăm " + numText[num3] + " Mươi";
                    }
                    else
                    {
                        textResult.Text = numText[num1] + " Ngàn " + numText[num2] + " Trăm " + numText[num3] + " Mươi " + numText[num4];
                    }
                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số nguyên!", "", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textInput.Text = "";
            textResult.Text = "";
        }

        private void textInput_TextChanged(object sender, EventArgs e)
        {

        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void textInput_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
