using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace lab2
{
    public partial class Bai7 : Form
    {
        private const string Placeholder = "...";
        private const long MaxTextFileBytes = 1024 * 1024;   

        public Bai7()
        {
            InitializeComponent();
        }

        private void Bai7_Load(object sender, EventArgs e)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives().Where(d => d.IsReady))
            {
                TreeNode driveNode = new TreeNode(drive.Name);
                driveNode.Tag = drive.RootDirectory.FullName;
                driveNode.Nodes.Add(Placeholder);
                trvExplorer.Nodes.Add(driveNode);
            }

            rtbFileContent.ReadOnly = true;
            picFileContent.Visible = false;
        }

       
        private void trvExplorer_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Nodes.Count == 1 && node.Nodes[0].Text == Placeholder)
            {
                node.Nodes.Clear();
                LoadChildren(node);
            }
        }

        private void LoadChildren(TreeNode parent)
        {
            string path = (string)parent.Tag;

            try
            {
                foreach (string directory in Directory.GetDirectories(path))
                {
                    TreeNode directoryNode = new TreeNode(Path.GetFileName(directory));
                    directoryNode.Tag = directory;
                    directoryNode.Nodes.Add(Placeholder);
                    parent.Nodes.Add(directoryNode);
                }

                foreach (string file in Directory.GetFiles(path))
                {
                    TreeNode fileNode = new TreeNode(Path.GetFileName(file));
                    fileNode.Tag = file;
                    parent.Nodes.Add(fileNode);
                }
            }
            catch (UnauthorizedAccessException)
            {
                
            }
            catch (IOException)
            {
                
            }
        }

       
        private void trvExplorer_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string path = e.Node.Tag as string;
            if (path == null || !File.Exists(path)) return;

            string extension = Path.GetExtension(path).ToLower();

            try
            {
                if (IsImageExtension(extension))
                {
                    ShowImage(path);
                }
                else if (IsTextExtension(extension))
                {
                    ShowText(path);
                }
                else
                {
                    ShowMessageText("Không hỗ trợ xem định dạng " + extension);
                }
            }
            catch (Exception ex)
            {
                ShowMessageText("Không mở được file: " + ex.Message);
            }
        }

        private void ShowImage(string path)
        {
            if (picFileContent.Image != null)
            {
                picFileContent.Image.Dispose();
                picFileContent.Image = null;
            }

            using (FileStream stream = File.OpenRead(path))
            using (Image original = Image.FromStream(stream))
            {
                picFileContent.Image = new Bitmap(original);   
            }

            rtbFileContent.Visible = false;
            picFileContent.Visible = true;
        }

        private void ShowText(string path)
        {
            if (new FileInfo(path).Length > MaxTextFileBytes)
            {
                ShowMessageText("File quá lớn (> 1 MB), không hiển thị.");
                return;
            }

            rtbFileContent.Text = File.ReadAllText(path);
            picFileContent.Visible = false;
            rtbFileContent.Visible = true;
        }

        private void ShowMessageText(string message)
        {
            rtbFileContent.Text = message;
            picFileContent.Visible = false;
            rtbFileContent.Visible = true;
        }

        private static bool IsImageExtension(string ext)
        {
            return ext == ".jpg" || ext == ".jpeg" || ext == ".png" || ext == ".bmp" || ext == ".gif";
        }

        private static bool IsTextExtension(string ext)
        {
            return ext == ".txt" || ext == ".cs" || ext == ".json" || ext == ".xml"
                || ext == ".csv" || ext == ".md" || ext == ".log" || ext == ".html";
        }
    }
}