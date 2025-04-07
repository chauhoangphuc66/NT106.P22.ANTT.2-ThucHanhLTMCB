﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace Lab2
{
    public partial class frmB4 : Form
    {
        public frmB4()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {

            ofd.ShowDialog();
            int count = 1;

            // Đọc file
            StreamReader str = new StreamReader(ofd.FileName);

            while (!str.EndOfStream)
            {
                try
                {
                    rtbHocVien.Text += count.ToString() + ": ";
                    string mssv = str.ReadLine();
                    rtbHocVien.Text += mssv + "  ";
                    string name = str.ReadLine();
                    rtbHocVien.Text += name + "  ";
                    string n_phone = str.ReadLine();
                    rtbHocVien.Text += n_phone + "\n";

                    float score_math = float.Parse(str.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
                    rtbHocVien.Text += "Điểm toán: \t" + score_math.ToString() + "\n";

                    float score_literature = float.Parse(str.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
                    rtbHocVien.Text += "Điểm văn: \t" + score_literature.ToString() + "\n";

                    float score_average = (score_math + score_literature) / 2;
                    rtbHocVien.Text += "Điểm trung bình: \t" + score_literature.ToString() + "\n\n";

                    // Hàng trống.
                    str.ReadLine();
                    count++;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File input không đúng định dạng.", "Lỗi.", MessageBoxButtons.OK);
                }
            }
            str.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xuất file và điểm trung bình vào output.txt", "XUẤT FILE");

            // Path output
            string path = "D:\\UITerK18\\HK4\\Lap trinh mang can ban\\Thuc Hanh\\Lab2\\output.txt";

            // Create file if it does not exist
            if (!File.Exists(path))
                File.CreateText(path).Close();

            // Ghi file
            StreamWriter stw = new StreamWriter(path);
            StreamReader str = new StreamReader(ofd.FileName);
            while (!str.EndOfStream)
            {
                try
                {
                    string mssv = str.ReadLine();
                    stw.WriteLine(mssv);

                    string name = str.ReadLine();
                    stw.WriteLine(name);

                    string n_phone = str.ReadLine();
                    stw.WriteLine(n_phone);

                    float score_math = float.Parse(str.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
                    stw.WriteLine(score_math.ToString());

                    float score_literature = float.Parse(str.ReadLine(), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture);
                    stw.WriteLine(score_literature.ToString());

                    float score_average = (score_math + score_literature) / 2;
                    stw.WriteLine(score_average.ToString());

                    // Hàng trống.
                    stw.WriteLine("\n");
                    str.ReadLine();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File input không đúng định dạng.", "Lỗi.", MessageBoxButtons.OK);
                }
            }
            stw.Close();
            str.Close();
        }

    }
}