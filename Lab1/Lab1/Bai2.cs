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

namespace Lab1
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
            textBox5.ReadOnly = true;
            textBox4.ReadOnly = true;
        }

        private void Bai2_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float c = float.Parse(textBox3.Text);
                if (a > b)
                {
                    if (a > c)
                    {
                        textBox4.Text = a.ToString();
                    }
                    else
                    {
                        textBox4.Text = c.ToString();
                    }
                }
                else
                {
                    if (b > c)
                    {
                        textBox4.Text = b.ToString();
                    }
                    else
                    {
                        textBox4.Text = c.ToString();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số! ", "", MessageBoxButtons.OK);
            }

            try
            {
                float a = float.Parse(textBox1.Text);
                float b = float.Parse(textBox2.Text);
                float c = float.Parse(textBox3.Text);
                if (a < b)
                {
                    if (a < c)
                    {
                        textBox5.Text = a.ToString();
                    }
                    else
                    {
                        textBox5.Text = c.ToString();
                    }
                }
                else
                {
                    if (b < c)
                    {
                        textBox5.Text = b.ToString();
                    }
                    else
                    {
                        textBox5.Text = c.ToString();
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập số! ", "", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Xóa tất cả các TextBox
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
         
        }
    }
}
