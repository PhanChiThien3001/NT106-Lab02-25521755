namespace lab2
{
    partial class Bai6
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
            this.components = new System.ComponentModel.Container();
            this.txtDishName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtContributor = new System.Windows.Forms.TextBox();
            this.txtImagePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDishResult = new System.Windows.Forms.Label();
            this.lblContributorResult = new System.Windows.Forms.Label();
            this.btnBrowseImage = new System.Windows.Forms.Button();
            this.btnAddDish = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picDish = new System.Windows.Forms.PictureBox();
            this.lsvDishes = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.picDish)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDishName
            // 
            this.txtDishName.Location = new System.Drawing.Point(253, 42);
            this.txtDishName.Name = "txtDishName";
            this.txtDishName.Size = new System.Drawing.Size(219, 31);
            this.txtDishName.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtContributor
            // 
            this.txtContributor.Location = new System.Drawing.Point(253, 118);
            this.txtContributor.Name = "txtContributor";
            this.txtContributor.Size = new System.Drawing.Size(219, 31);
            this.txtContributor.TabIndex = 2;
            // 
            // txtImagePath
            // 
            this.txtImagePath.Location = new System.Drawing.Point(253, 198);
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.Size = new System.Drawing.Size(219, 31);
            this.txtImagePath.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên Món";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Người đóng góp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Đường dẫn ảnh";
            // 
            // lblDishResult
            // 
            this.lblDishResult.AutoSize = true;
            this.lblDishResult.Location = new System.Drawing.Point(199, 486);
            this.lblDishResult.Name = "lblDishResult";
            this.lblDishResult.Size = new System.Drawing.Size(122, 25);
            this.lblDishResult.TabIndex = 7;
            this.lblDishResult.Text = "Dish Result";
            // 
            // lblContributorResult
            // 
            this.lblContributorResult.AutoSize = true;
            this.lblContributorResult.Location = new System.Drawing.Point(570, 486);
            this.lblContributorResult.Name = "lblContributorResult";
            this.lblContributorResult.Size = new System.Drawing.Size(185, 25);
            this.lblContributorResult.TabIndex = 8;
            this.lblContributorResult.Text = "Contributor Result";
            // 
            // btnBrowseImage
            // 
            this.btnBrowseImage.Location = new System.Drawing.Point(528, 42);
            this.btnBrowseImage.Name = "btnBrowseImage";
            this.btnBrowseImage.Size = new System.Drawing.Size(113, 64);
            this.btnBrowseImage.TabIndex = 9;
            this.btnBrowseImage.Text = "Browse Image";
            this.btnBrowseImage.UseVisualStyleBackColor = true;
            this.btnBrowseImage.Click += new System.EventHandler(this.btnBrowseImage_Click);
            // 
            // btnAddDish
            // 
            this.btnAddDish.Location = new System.Drawing.Point(528, 181);
            this.btnAddDish.Name = "btnAddDish";
            this.btnAddDish.Size = new System.Drawing.Size(113, 64);
            this.btnAddDish.TabIndex = 10;
            this.btnAddDish.Text = "Add Dish";
            this.btnAddDish.UseVisualStyleBackColor = true;
            this.btnAddDish.Click += new System.EventHandler(this.btnAddDish_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(728, 42);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(113, 64);
            this.btnRandom.TabIndex = 11;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(728, 178);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 64);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picDish
            // 
            this.picDish.Location = new System.Drawing.Point(528, 257);
            this.picDish.Name = "picDish";
            this.picDish.Size = new System.Drawing.Size(293, 203);
            this.picDish.TabIndex = 13;
            this.picDish.TabStop = false;
            // 
            // lsvDishes
            // 
            this.lsvDishes.HideSelection = false;
            this.lsvDishes.Location = new System.Drawing.Point(84, 254);
            this.lsvDishes.Name = "lsvDishes";
            this.lsvDishes.Size = new System.Drawing.Size(319, 206);
            this.lsvDishes.TabIndex = 14;
            this.lsvDishes.UseCompatibleStateImageBehavior = false;
            // 
            // Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 520);
            this.Controls.Add(this.lsvDishes);
            this.Controls.Add(this.picDish);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnAddDish);
            this.Controls.Add(this.btnBrowseImage);
            this.Controls.Add(this.lblContributorResult);
            this.Controls.Add(this.lblDishResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtImagePath);
            this.Controls.Add(this.txtContributor);
            this.Controls.Add(this.txtDishName);
            this.Name = "Bai6";
            this.Text = "Bai6";
            this.Load += new System.EventHandler(this.Bai6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDish)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDishName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtContributor;
        private System.Windows.Forms.TextBox txtImagePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDishResult;
        private System.Windows.Forms.Label lblContributorResult;
        private System.Windows.Forms.Button btnBrowseImage;
        private System.Windows.Forms.Button btnAddDish;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picDish;
        private System.Windows.Forms.ListView lsvDishes;
    }
}