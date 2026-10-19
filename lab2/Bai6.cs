using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace lab2
{
    public partial class Bai6 : Form
    {
        private const string ConnectionString = "Data Source=monan.db;Version=3;";

        public Bai6()
        {
            InitializeComponent();

            lsvDishes.View = View.Details;
            lsvDishes.FullRowSelect = true;
            lsvDishes.Columns.Add("Tên món", 200);
            lsvDishes.Columns.Add("Người đóng góp", 160);
        }

        private void Bai6_Load(object sender, EventArgs e)
        {
            InitDatabase();
            LoadDishList();
        }

       
        private void InitDatabase()
        {
            const string sql = @"
                CREATE TABLE IF NOT EXISTS NguoiDung(
                    IDNCC    INTEGER PRIMARY KEY AUTOINCREMENT,
                    HoVaTen  TEXT NOT NULL,
                    QuyenHan TEXT);
                CREATE TABLE IF NOT EXISTS MonAn(
                    IDMA     INTEGER PRIMARY KEY AUTOINCREMENT,
                    TenMonAn TEXT NOT NULL,
                    HinhAnh  TEXT,
                    IDNCC    INTEGER,
                    FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC));";

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        
        private void btnBrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Ảnh|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txtImagePath.Text = dialog.FileName;
            }
        }

        
        private void btnAddDish_Click(object sender, EventArgs e)
        {
            string dishName = txtDishName.Text.Trim();
            string contributor = txtContributor.Text.Trim();

            if (dishName.Length == 0 || contributor.Length == 0)
            {
                MessageBox.Show("Nhập tên món và tên người đóng góp");
                return;
            }

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                long contributorId = GetOrCreateContributor(connection, contributor);

                using (SQLiteCommand insert = new SQLiteCommand(
                    "INSERT INTO MonAn(TenMonAn, HinhAnh, IDNCC) VALUES(@name, @image, @id)", connection))
                {
                    insert.Parameters.AddWithValue("@name", dishName);
                    insert.Parameters.AddWithValue("@image", txtImagePath.Text);
                    insert.Parameters.AddWithValue("@id", contributorId);
                    insert.ExecuteNonQuery();
                }
            }

            txtDishName.Clear();
            txtImagePath.Clear();
            LoadDishList();
        }

        private long GetOrCreateContributor(SQLiteConnection connection, string name)
        {
            using (SQLiteCommand find = new SQLiteCommand(
                "SELECT IDNCC FROM NguoiDung WHERE HoVaTen = @name", connection))
            {
                find.Parameters.AddWithValue("@name", name);
                object found = find.ExecuteScalar();
                if (found != null) return Convert.ToInt64(found);
            }

            using (SQLiteCommand insert = new SQLiteCommand(
                "INSERT INTO NguoiDung(HoVaTen, QuyenHan) VALUES(@name, 'User'); " +
                "SELECT last_insert_rowid();", connection))
            {
                insert.Parameters.AddWithValue("@name", name);
                return Convert.ToInt64(insert.ExecuteScalar());
            }
        }

        
        private void LoadDishList()
        {
            lsvDishes.Items.Clear();

            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(
                    @"SELECT m.TenMonAn, n.HoVaTen
                      FROM MonAn m JOIN NguoiDung n ON m.IDNCC = n.IDNCC
                      ORDER BY m.IDMA", connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ListViewItem item = new ListViewItem(reader.GetString(0));
                        item.SubItems.Add(reader.GetString(1));
                        lsvDishes.Items.Add(item);
                    }
                }
            }
        }

        
        private void btnRandom_Click(object sender, EventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand(
                    @"SELECT m.TenMonAn, m.HinhAnh, n.HoVaTen
                      FROM MonAn m JOIN NguoiDung n ON m.IDNCC = n.IDNCC
                      ORDER BY RANDOM() LIMIT 1", connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                    {
                        MessageBox.Show("Chưa có món ăn nào trong cơ sở dữ liệu");
                        return;
                    }

                    lblDishResult.Text = "Hôm nay ăn: " + reader.GetString(0);
                    lblContributorResult.Text = "Người đóng góp: " + reader.GetString(2);
                    ShowImage(reader.IsDBNull(1) ? "" : reader.GetString(1));
                }
            }
        }

        private void ShowImage(string path)
        {
            if (picDish.Image != null)
            {
                picDish.Image.Dispose();
                picDish.Image = null;
            }

            if (path.Length == 0 || !File.Exists(path)) return;

            
            using (Image original = Image.FromFile(path))
            {
                picDish.Image = new Bitmap(original);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}