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
using System.Xml.Linq;

namespace lab2
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog { Filter = "Text files|*.txt" };
            if (ofd.ShowDialog() != DialogResult.OK) return;

            string path = ofd.FileName;
            string content;
            using (StreamReader reader = new StreamReader(path))
            {
                content = reader.ReadToEnd();
            }

            txtFileName.Text = ofd.SafeFileName;
            txtSize.Text = new FileInfo(path).Length + " bytes";
            txtURL.Text = path;
            txtLineCount.Text = File.ReadAllLines(path).Length.ToString();
            txtWordCount.Text = content
                .Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Length.ToString();
            txtCharacterCount.Text = content.Length.ToString();
            rtbContent.Text = content;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
