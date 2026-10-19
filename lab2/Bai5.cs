using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Bai5 : Form
    {
        private const string InputPath = "input5.txt";
        private const string OutputPath = "output5.txt";

        private List<Movie> movies = new List<Movie>();

        public Bai5()
        {
            InitializeComponent();
            lsvMovies.View = View.Details;
            lsvMovies.FullRowSelect = true;
            lsvMovies.Columns.Add("Tên phim", 180);
            lsvMovies.Columns.Add("Giá vé", 90);
            lsvMovies.Columns.Add("Số phòng", 80);
            lsvMovies.Columns.Add("Đã bán", 70);
            lsvMovies.Columns.Add("Tổng ghế", 80);
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            string movieName = txtMovieName.Text.Trim();
            string roomName = txtRoomName.Text.Trim();
            decimal price;
            int totalSeats;
            int soldSeats;

            if (movieName.Length == 0 || roomName.Length == 0)
            {
                ShowError("Tên phim và tên phòng không được để trống");
                return;
            }
            if (!decimal.TryParse(txtBasePrice.Text, NumberStyles.Number, CultureInfo.InvariantCulture, out price) || price < 0)
            {
                ShowError("Giá vé không hợp lệ");
                return;
            }
            if (!int.TryParse(txtTotalSeats.Text, out totalSeats) || totalSeats <= 0)
            {
                ShowError("Tổng số ghế phải là số nguyên dương");
                return;
            }
            if (!int.TryParse(txtSoldSeats.Text, out soldSeats) || soldSeats < 0 || soldSeats > totalSeats)
            {
                ShowError("Số ghế đã bán phải từ 0 đến tổng số ghế");
                return;
            }

            Movie movie = movies.FirstOrDefault(m =>
                string.Equals(m.Name, movieName, StringComparison.OrdinalIgnoreCase));
            if (movie == null)
            {
                movie = new Movie { Name = movieName, BasePrice = price };
                movies.Add(movie);
            }
            else
            {
                movie.BasePrice = price;
            }

            movie.Rooms.Add(new MovieRoom { Name = roomName, TotalSeats = totalSeats, SoldSeats = soldSeats });
            RefreshMovieList();
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(InputPath))
            {
                foreach (Movie movie in movies)
                {
                    writer.WriteLine(movie.Name);
                    writer.WriteLine(movie.BasePrice.ToString(CultureInfo.InvariantCulture));
                    foreach (MovieRoom room in movie.Rooms)
                    {
                        writer.WriteLine(room.Name + ";" + room.TotalSeats + ";" + room.SoldSeats);
                    }
                    writer.WriteLine();
                }
            }
            MessageBox.Show("Đã ghi " + InputPath);
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            if (!File.Exists(InputPath))
            {
                MessageBox.Show("Không tìm thấy " + InputPath + " trong thư mục:\n"
                    + AppDomain.CurrentDomain.BaseDirectory);
                return;
            }

            try
            {
                movies = ParseMovies(InputPath);
                RefreshMovieList();
            }
            catch (Exception ex)
            {
                ShowError("File sai định dạng: " + ex.Message);
            }
        }   

        private List<Movie> ParseMovies(string path)
        {
            List<Movie> result = new List<Movie>();
            Movie current = null;
            int lineIndexInBlock = 0;

            foreach (string rawLine in File.ReadAllLines(path))
            {
                string line = rawLine.Trim();

                if (line.Length == 0)          
                {
                    current = null;
                    lineIndexInBlock = 0;
                    continue;
                }

                if (lineIndexInBlock == 0)
                {
                    current = new Movie { Name = line };
                    result.Add(current);
                }
                else if (lineIndexInBlock == 1)
                {
                    current.BasePrice = decimal.Parse(line, NumberStyles.Number, CultureInfo.InvariantCulture);
                }
                else
                {
                    string[] parts = line.Split(';');
                    if (parts.Length != 3)
                        throw new FormatException("Dòng phòng chiếu sai: " + line);

                    current.Rooms.Add(new MovieRoom
                    {
                        Name = parts[0].Trim(),
                        TotalSeats = int.Parse(parts[1]),
                        SoldSeats = int.Parse(parts[2])
                    });
                }
                lineIndexInBlock++;
            }
            return result;
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            if (movies.Count == 0)
            {
                ShowError("Chưa có dữ liệu phim");
                return;
            }

            btnExport.Enabled = false;
            rtbStatistics.Clear();

            List<Movie> ranked = movies.OrderByDescending(m => m.Revenue).ToList();
            prgExport.Minimum = 0;
            prgExport.Maximum = ranked.Count;
            prgExport.Value = 0;

            using (StreamWriter writer = new StreamWriter(OutputPath))
            {
                for (int i = 0; i < ranked.Count; i++)
                {
                    Movie m = ranked[i];
                    string line = string.Format(
                        "{0} | Bán: {1} | Tồn: {2} | Tỉ lệ: {3:0.0}% | Doanh thu: {4:N0} | Hạng: {5}",
                        m.Name, m.SoldTickets, m.RemainingTickets, m.SoldRate * 100, m.Revenue, i + 1);

                    await writer.WriteLineAsync(line);
                    rtbStatistics.AppendText(line + Environment.NewLine);
                    prgExport.Value = i + 1;
                    await Task.Delay(200);   
                }
            }

            btnExport.Enabled = true;
            MessageBox.Show("Đã ghi " + OutputPath);
        }

        private void RefreshMovieList()
        {
            lsvMovies.Items.Clear();
            foreach (Movie movie in movies)
            {
                ListViewItem item = new ListViewItem(movie.Name);
                item.SubItems.Add(movie.BasePrice.ToString("N0"));
                item.SubItems.Add(movie.Rooms.Count.ToString());
                item.SubItems.Add(movie.SoldTickets.ToString());
                item.SubItems.Add(movie.TotalSeats.ToString());
                lsvMovies.Items.Add(item);
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }   

    public class MovieRoom
    {
        public string Name { get; set; }
        public int TotalSeats { get; set; }
        public int SoldSeats { get; set; }
    }

    public class Movie
    {
        public string Name { get; set; }
        public decimal BasePrice { get; set; }
        public List<MovieRoom> Rooms { get; } = new List<MovieRoom>();

        public int TotalSeats { get { return Rooms.Sum(r => r.TotalSeats); } }
        public int SoldTickets { get { return Rooms.Sum(r => r.SoldSeats); } }
        public int RemainingTickets { get { return TotalSeats - SoldTickets; } }
        public double SoldRate { get { return TotalSeats == 0 ? 0 : (double)SoldTickets / TotalSeats; } }
        public decimal Revenue { get { return SoldTickets * BasePrice; } }
    }
}