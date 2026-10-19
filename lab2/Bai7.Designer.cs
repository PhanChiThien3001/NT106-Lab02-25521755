namespace lab2
{
    partial class Bai7
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
            this.trvExplorer = new System.Windows.Forms.TreeView();
            this.grpFileContent = new System.Windows.Forms.GroupBox();
            this.rtbFileContent = new System.Windows.Forms.RichTextBox();
            this.picFileContent = new System.Windows.Forms.PictureBox();
            this.grpFileContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFileContent)).BeginInit();
            this.SuspendLayout();
            // 
            // trvExplorer
            // 
            this.trvExplorer.Location = new System.Drawing.Point(9, 9);
            this.trvExplorer.Name = "trvExplorer";
            this.trvExplorer.Size = new System.Drawing.Size(143, 435);
            this.trvExplorer.TabIndex = 0;
            this.trvExplorer.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvExplorer_BeforeExpand);
            this.trvExplorer.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvExplorer_AfterSelect);
            // 
            // grpFileContent
            // 
            this.grpFileContent.Controls.Add(this.picFileContent);
            this.grpFileContent.Controls.Add(this.rtbFileContent);
            this.grpFileContent.Location = new System.Drawing.Point(158, 9);
            this.grpFileContent.Name = "grpFileContent";
            this.grpFileContent.Size = new System.Drawing.Size(630, 435);
            this.grpFileContent.TabIndex = 1;
            this.grpFileContent.TabStop = false;
            this.grpFileContent.Text = "groupBox1";
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.Location = new System.Drawing.Point(3, 28);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.Size = new System.Drawing.Size(621, 407);
            this.rtbFileContent.TabIndex = 0;
            this.rtbFileContent.Text = "";
            // 
            // picFileContent
            // 
            this.picFileContent.Location = new System.Drawing.Point(20, 50);
            this.picFileContent.Name = "picFileContent";
            this.picFileContent.Size = new System.Drawing.Size(593, 379);
            this.picFileContent.TabIndex = 1;
            this.picFileContent.TabStop = false;
            // 
            // Bai7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpFileContent);
            this.Controls.Add(this.trvExplorer);
            this.Name = "Bai7";
            this.Text = "Bai7";
            this.Load += new System.EventHandler(this.Bai7_Load);
            this.grpFileContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFileContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvExplorer;
        private System.Windows.Forms.GroupBox grpFileContent;
        private System.Windows.Forms.PictureBox picFileContent;
        private System.Windows.Forms.RichTextBox rtbFileContent;
    }
}