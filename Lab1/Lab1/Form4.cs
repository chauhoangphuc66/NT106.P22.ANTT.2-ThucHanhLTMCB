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

                foreach (float point in pointValues)
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
 
                CalculateStatistics(pointValues);
            }
            catch (FormatException)
            {
                MessageBox.Show("Phải nhập một số từ 0 đến 10");
            }
        }

        private void CalculateStatistics(float[] points)
        {
            float avg = points.Average();
            dAvg.Text = avg.ToString("F2");

            float max = points.Max();
            dMax.Text = max.ToString("F2");

  
            float min = points.Min();
            dMin.Text = min.ToString("F2");

            int passing = points.Count(p => p >= 5.0);
            int failing = points.Length - passing;

            iNumDau.Text = passing.ToString();
            iNumRot.Text = failing.ToString();

            string hocLuc = "";
            if (avg >= 8.0)
                hocLuc = "Giỏi";
            else if (avg >= 6.5)
                hocLuc = "Khá";
            else if (avg >= 5.0)
                hocLuc = "Trung bình";
            else
                hocLuc = "Yếu";

            sHocLuc.Text = hocLuc;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            listBoxPoints = new ListBox();
            listBoxPoints.Location = new Point(0, 20);
            listBoxPoints.Size = new Size(2000, 1000);
            groupBox1.Controls.Add(listBoxPoints);
        }

        private ListBox listBoxPoints;

        private void sInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void dAvg_TextChanged(object sender, EventArgs e)
        {

        }

        private void dAvg_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void iNumDau_TextChanged(object sender, EventArgs e)
        {

        }

        private void sHocLuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void dMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void iNumRot_TextChanged(object sender, EventArgs e)
        {

        }
    }
}