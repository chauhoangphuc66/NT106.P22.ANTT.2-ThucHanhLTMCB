using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LAB2.Bai04;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB2
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public class Student
        {
            public string ID;
            public string Name;
            public string Phone;
            public string Diem1;
            public string Diem2;
            public string Diem3;
            public string Avg;

            public Student()
            {
            }

            public string Show()
            {
                string content = "";
                content += Name + Environment.NewLine;
                content += ID + Environment.NewLine;
                content += Phone + Environment.NewLine;
                content += Diem1 + Environment.NewLine;
                content += Diem2 + Environment.NewLine;
                content += Diem3 + Environment.NewLine;
                content += Avg + Environment.NewLine;
                return content;
            }
        }

        List<Student> students = new List<Student>();

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (checkID(textBoxWID.Text) && checkPhone(textBoxWPhone.Text) && checkCourse(textBoxW1.Text) 
                && checkCourse(textBoxW2.Text) && checkCourse(textBoxW3.Text))
            {
                Student student = new Student();
                student.ID = textBoxWID.Text;
                student.Name = textBoxWName.Text;
                student.Phone = textBoxWPhone.Text;
                student.Diem1 = textBoxW1.Text;
                student.Diem2 = textBoxW2.Text;
                student.Diem3 = textBoxW3.Text;
                students.Add(student);
                textBoxShow.Text += student.Show();
            }
            else
            {
                MessageBox.Show("Thông tin không hợp lệ!");
            }
        }

        private bool checkID(string id)
        {
            long num;
            return id.Length == 8 && long.TryParse(id, out num);
        }

        private bool checkPhone(string phone)
        {
            long num;
            return phone.Length == 10 && phone.StartsWith("0") && long.TryParse(phone, out num);
        }

        private bool checkCourse(string course)
        {
            float num;
            return float.TryParse(course, out num) && num >= 0 && num <= 10;
        }

        private void buttonWrite_Click(object sender, EventArgs e)
        {
            string outputFilePath = "D:\\UITerK18\\HK4\\Lap trinh mang can ban\\Thuc Hanh\\Lab2\\input.txt.txt";
            using ( StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.Write(textBoxShow.Text);
            }
            MessageBox.Show("Đã ghi nội dung thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            string content = "";
            foreach (var student in students)
            {
                student.Avg = ((float)(float.Parse(students[0].Diem1) + float.Parse(students[0].Diem2) 
                    + float.Parse(students[0].Diem3)) / 3).ToString();
                content += student.Show() + Environment.NewLine;
            }
            textBoxRName.Text = students[0].Name;
            textBoxRID.Text = students[0].ID;
            textBoxRPhone.Text = students[0].Phone;
            textBoxR1.Text = students[0].Diem1;
            textBoxR2.Text = students[0].Diem2;
            textBoxR3.Text = students[0].Diem3;
            textBoxRAvg.Text = students[0].Avg;
            textBoxSTT.Text = "1";
            string outputFilePath = "D:\\UITerK18\\HK4\\Lap trinh mang can ban\\Thuc Hanh\\Lab2\\output.txt.txt";
            using (StreamWriter writer = new StreamWriter(outputFilePath))
            {
                writer.Write(content);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSTT.Text == "1")
            {
                int index = students.Count - 1;
                textBoxRName.Text = students[index].Name;
                textBoxRID.Text = students[index].ID;
                textBoxRPhone.Text = students[index].Phone;
                textBoxR1.Text = students[index].Diem1;
                textBoxR2.Text = students[index].Diem2;
                textBoxR3.Text = students[index].Diem3;
                textBoxRAvg.Text = students[index].Avg;
                textBoxSTT.Text = students.Count.ToString();
            }
            else
            {
                int index = int.Parse(textBoxSTT.Text) - 2;
                textBoxRName.Text = students[index].Name;
                textBoxRID.Text = students[index].ID;
                textBoxRPhone.Text = students[index].Phone;
                textBoxR1.Text = students[index].Diem1;
                textBoxR2.Text = students[index].Diem2;
                textBoxR3.Text = students[index].Diem3;
                textBoxRAvg.Text = students[index].Avg;
                textBoxSTT.Text = (int.Parse(textBoxSTT.Text) - 1).ToString();
            }    
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (textBoxSTT.Text == students.Count.ToString())
            {
                int index = 0;
                textBoxRName.Text = students[index].Name;
                textBoxRID.Text = students[index].ID;
                textBoxRPhone.Text = students[index].Phone;
                textBoxR1.Text = students[index].Diem1;
                textBoxR2.Text = students[index].Diem2;
                textBoxR3.Text = students[index].Diem3;
                textBoxRAvg.Text = students[index].Avg;
                textBoxSTT.Text = "1";
            }
            else
            {
                int index = int.Parse(textBoxSTT.Text);
                textBoxRName.Text = students[index].Name;
                textBoxRID.Text = students[index].ID;
                textBoxRPhone.Text = students[index].Phone;
                textBoxR1.Text = students[index].Diem1;
                textBoxR2.Text = students[index].Diem2;
                textBoxR3.Text = students[index].Diem3;
                textBoxRAvg.Text = students[index].Avg;
                textBoxSTT.Text = (int.Parse(textBoxSTT.Text) + 1).ToString();
            }
        }
    }
}

