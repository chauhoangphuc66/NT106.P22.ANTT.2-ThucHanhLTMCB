namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fileChar.ReadOnly = true;
            fileName.ReadOnly = true;
            fileURL.ReadOnly = true;
            fileWord.ReadOnly = true;
            fileRow.ReadOnly = true;
            outputBox.ReadOnly = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Select a Text File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string content = sr.ReadToEnd();
                        int wordCount = content.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Length;
                        int lineCount = content.Split(new char[] { '\n' }).Length;
                        int charCount = content.Length;

                        outputBox.Text = content ;
                        fileName.Text = Path.GetFileName(filePath);
                        fileURL.Text = filePath;
                        fileRow.Text = lineCount.ToString();
                        fileWord.Text = wordCount.ToString();
                        fileChar.Text = charCount.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("File này không thể đọc" + ex.Message);
            }
        }
    }
}
