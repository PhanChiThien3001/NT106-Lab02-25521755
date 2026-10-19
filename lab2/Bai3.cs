using System;
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
namespace lab2
{
    public partial class Bai3 : Form
    {
        private const string InputPath = "input3.txt";
        private const string OutputPath = "output3.txt";
        public Bai3()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (!File.Exists(InputPath))
            {
                MessageBox.Show("Không tìm thấy " + InputPath + " trong thư mục:\n"
                    + AppDomain.CurrentDomain.BaseDirectory);
                return;
            }

            string[] inputLines = File.ReadAllLines(InputPath);
            rtbInput.Lines = inputLines;

            ExpressionEvaluator evaluator = new ExpressionEvaluator();
            List<string> results = new List<string>();

            foreach (string line in inputLines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                try
                {
                    double value = evaluator.Evaluate(line);
                    results.Add(line.Trim() + " = " + FormatNumber(value));
                }
                catch (Exception ex)
                {
                    results.Add(line.Trim() + " = Lỗi (" + ex.Message + ")");
                }
            }

            File.WriteAllLines(OutputPath, results);
            rtbOutput.Lines = results.ToArray();

            MessageBox.Show("Đã ghi kết quả vào " + OutputPath);
        }

        private static string FormatNumber(double value)
        {
            return Math.Round(value, 6).ToString("0.######", CultureInfo.InvariantCulture);
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
