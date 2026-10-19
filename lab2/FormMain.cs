using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnBai1_Click(object sender, EventArgs e)
        {
            Bai1 form = new Bai1();
            form.ShowDialog();
        }

        private void btnBai2_Click(object sender, EventArgs e)
        {
            new Bai2().ShowDialog();
        }

        private void btnBai3_Click(object sender, EventArgs e)
        {
            new Bai3().ShowDialog();
        }

        private void btnBai4_Click(object sender, EventArgs e)
        {
            new Bai4().ShowDialog();
        }

        private void btnBai5_Click(object sender, EventArgs e)
        {
            new Bai5().ShowDialog();
        }

        private void btnBai6_Click(object sender, EventArgs e)
        {
            new Bai6().ShowDialog();
        }

        private void btnBai7_Click(object sender, EventArgs e)
        {
            new Bai7().ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
