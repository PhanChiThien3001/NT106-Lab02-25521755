using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Bai4 : Form
    {
        private const string InputPath = "input4.txt";
        private const string OutputPath = "output4.txt";
        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions { WriteIndented = true };

        private readonly List<Student> students = new List<Student>();
        private List<Student> loadedStudents = new List<Student>();
        private int currentIndex;
        public Bai4()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!TryReadStudentFromInput(out Student student)) return;
            students.Add(student);
            lstStudents.Items.Add($"{student.FullName} - {student.StudentId}");
        }
        private bool TryReadStudentFromInput(out Student student)
        {
            student = null;

            if (string.IsNullOrWhiteSpace(txtName.Text))
                return ShowError("Họ tên không được để trống");
            if (!Regex.IsMatch(txtId.Text, @"^\d{8}$"))
                return ShowError("MSSV phải gồm đúng 8 chữ số");
            if (!Regex.IsMatch(txtPhone.Text, @"^0\d{9}$"))
                return ShowError("SĐT phải có 10 chữ số và bắt đầu bằng 0");
            if (!TryParseScore(txtCourse1.Text, out float s1) ||
                !TryParseScore(txtCourse2.Text, out float s2) ||
                !TryParseScore(txtCourse3.Text, out float s3))
                return ShowError("Điểm phải là số từ 0 đến 10");

            student = new Student
            {
                FullName = txtName.Text.Trim(),
                StudentId = int.Parse(txtId.Text),
                Phone = txtPhone.Text,
                Score1 = s1,
                Score2 = s2,
                Score3 = s3
            };
            return true;
        }
        private static bool TryParseScore(string text, out float score)
        {
            return float.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out score)
                   && score >= 0 && score <= 10;
        }

        private bool ShowError(string message)
        {
            MessageBox.Show(message, "Dữ liệu không hợp lệ");
            return false;
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            File.WriteAllText(InputPath, JsonSerializer.Serialize(students, JsonOptions));
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(InputPath);
            loadedStudents = JsonSerializer.Deserialize<List<Student>>(json) ?? new List<Student>();

            foreach (Student s in loadedStudents)
                s.Average = (s.Score1 + s.Score2 + s.Score3) / 3f;

            File.WriteAllText(OutputPath, JsonSerializer.Serialize(loadedStudents, JsonOptions));
            currentIndex = 0;
            ShowCurrentStudent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentIndex < loadedStudents.Count - 1) { currentIndex++; ShowCurrentStudent(); }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0) { currentIndex--; ShowCurrentStudent(); }
        }
        private void ShowCurrentStudent()
        {
            if (loadedStudents.Count == 0) return;
            Student s = loadedStudents[currentIndex];
            txtNameView.Text = s.FullName;
            txtIdView.Text = s.StudentId.ToString();
            txtPhoneView.Text = s.Phone;
            txtCourse1View.Text = s.Score1.ToString();
            txtCourse2View.Text = s.Score2.ToString();
            txtCourse3View.Text = s.Score3.ToString();
            txtAverageView.Text = s.Average.ToString("0.00");
            lblPage.Text = $"{currentIndex + 1}/{loadedStudents.Count}";
        }
    }
}
