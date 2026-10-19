using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private const string InputPath = "input1.txt";
        private const string OutputPath = "output1.txt";

        private void btnRead_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader(InputPath))
            {
                richTextBox1.Text = reader.ReadToEnd();
            }
            if (!File.Exists(InputPath))
            {
                MessageBox.Show($"Không tìm thấy file {InputPath} trong thư mục:\n{AppDomain.CurrentDomain.BaseDirectory}");
                return;
            }

            using (StreamReader reader = new StreamReader(InputPath))
            {
                richTextBox1.Text = reader.ReadToEnd();
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            string content = File.ReadAllText(InputPath);
            using (StreamWriter writer = new StreamWriter(OutputPath))
            {
                writer.Write(content.ToUpper());
            }
            MessageBox.Show("Đã ghi output1.txt");
        }
    }
}
