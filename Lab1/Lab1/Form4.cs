using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bXuat_Click(object sender, EventArgs e)
        {
            string input = sInput.Text;

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Hãy nhập điểm.");
                return;
            }

            try
            {
                string[] points = input.Split(',');

                if (points.Length < 5)
                {
                    MessageBox.Show("Phải nhập ít nhất 5 môn");
                    return;
                }


                float[] pointValues = points.Select(p => float.Parse(p.Trim())).ToArray();

                foreach (int point in pointValues)
                {
                    if (point < 0 || point > 10)
                    {
                        MessageBox.Show("Phải nhập một số từ 0 đến 10");
                        return;
                    }
                }

                listBoxPoints.Items.Clear();
                for (int i = 0; i < pointValues.Length; i++)
                {
                    listBoxPoints.Items.Add($"Môn {i + 1}: {pointValues[i]} điểm");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Phải nhập một số từ 0 đến 10");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Khởi tạo ListBox trong GroupBox
            listBoxPoints = new ListBox();
            listBoxPoints.Location = new Point(0, 20);
            listBoxPoints.Size = new Size(2000, 1000);
            groupBox1.Controls.Add(listBoxPoints);
        }

        // Khai báo ListBox để hiển thị điểm
        private ListBox listBoxPoints;

        private void sInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void dAvg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


