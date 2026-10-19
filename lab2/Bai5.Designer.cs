namespace lab2
{
    partial class Bai5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReadFile = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.prgExport = new System.Windows.Forms.ProgressBar();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.txtSoldSeats = new System.Windows.Forms.TextBox();
            this.txtTotalSeats = new System.Windows.Forms.TextBox();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.txtRoomName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAddRoom = new System.Windows.Forms.Button();
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.lsvMovies = new System.Windows.Forms.ListView();
            this.rtbStatistics = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnReadFile
            // 
            this.btnReadFile.Location = new System.Drawing.Point(814, 43);
            this.btnReadFile.Name = "btnReadFile";
            this.btnReadFile.Size = new System.Drawing.Size(187, 71);
            this.btnReadFile.TabIndex = 0;
            this.btnReadFile.Text = "Đọc File";
            this.btnReadFile.UseVisualStyleBackColor = true;
            this.btnReadFile.Click += new System.EventHandler(this.btnReadFile_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(814, 151);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(187, 71);
            this.btnExport.TabIndex = 1;
            this.btnExport.Text = "Xuất";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // prgExport
            // 
            this.prgExport.Location = new System.Drawing.Point(139, 531);
            this.prgExport.Name = "prgExport";
            this.prgExport.Size = new System.Drawing.Size(181, 50);
            this.prgExport.TabIndex = 4;
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(218, 37);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(172, 31);
            this.txtMovieName.TabIndex = 5;
            // 
            // txtSoldSeats
            // 
            this.txtSoldSeats.Location = new System.Drawing.Point(218, 308);
            this.txtSoldSeats.Name = "txtSoldSeats";
            this.txtSoldSeats.Size = new System.Drawing.Size(172, 31);
            this.txtSoldSeats.TabIndex = 6;
            // 
            // txtTotalSeats
            // 
            this.txtTotalSeats.Location = new System.Drawing.Point(218, 236);
            this.txtTotalSeats.Name = "txtTotalSeats";
            this.txtTotalSeats.Size = new System.Drawing.Size(172, 31);
            this.txtTotalSeats.TabIndex = 7;
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(218, 101);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(172, 31);
            this.txtBasePrice.TabIndex = 8;
            // 
            // txtRoomName
            // 
            this.txtRoomName.Location = new System.Drawing.Point(218, 168);
            this.txtRoomName.Name = "txtRoomName";
            this.txtRoomName.Size = new System.Drawing.Size(172, 31);
            this.txtRoomName.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Phim";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Giá Vé";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Tên phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Tổng ghế";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Ghế đã bán";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(814, 263);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(187, 76);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Location = new System.Drawing.Point(71, 375);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Size = new System.Drawing.Size(119, 64);
            this.btnAddRoom.TabIndex = 17;
            this.btnAddRoom.Text = "Thêm Phòng";
            this.btnAddRoom.UseVisualStyleBackColor = true;
            this.btnAddRoom.Click += new System.EventHandler(this.btnAddRoom_Click);
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(271, 375);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(119, 64);
            this.btnWriteFile.TabIndex = 18;
            this.btnWriteFile.Text = "Đọc File";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // lsvMovies
            // 
            this.lsvMovies.HideSelection = false;
            this.lsvMovies.Location = new System.Drawing.Point(459, 43);
            this.lsvMovies.Name = "lsvMovies";
            this.lsvMovies.Size = new System.Drawing.Size(324, 324);
            this.lsvMovies.TabIndex = 19;
            this.lsvMovies.UseCompatibleStateImageBehavior = false;
            // 
            // rtbStatistics
            // 
            this.rtbStatistics.Location = new System.Drawing.Point(523, 413);
            this.rtbStatistics.Name = "rtbStatistics";
            this.rtbStatistics.Size = new System.Drawing.Size(361, 196);
            this.rtbStatistics.TabIndex = 20;
            this.rtbStatistics.Text = "";
            // 
            // Bai5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 646);
            this.Controls.Add(this.rtbStatistics);
            this.Controls.Add(this.lsvMovies);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.btnAddRoom);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRoomName);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.txtTotalSeats);
            this.Controls.Add(this.txtSoldSeats);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.prgExport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnReadFile);
            this.Name = "Bai5";
            this.Text = "Bai5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.ProgressBar prgExport;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.TextBox txtSoldSeats;
        private System.Windows.Forms.TextBox txtTotalSeats;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.TextBox txtRoomName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddRoom;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.ListView lsvMovies;
        private System.Windows.Forms.RichTextBox rtbStatistics;
    }
}