namespace Bai16_OpenFileDialog
{
    partial class Form1
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
			this.picAnh = new System.Windows.Forms.PictureBox();
			this.btnHienThi = new System.Windows.Forms.Button();
			this.odlgAnh = new System.Windows.Forms.OpenFileDialog();
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
			this.SuspendLayout();
			// 
			// picAnh
			// 
			this.picAnh.Location = new System.Drawing.Point(14, 18);
			this.picAnh.Name = "picAnh";
			this.picAnh.Size = new System.Drawing.Size(596, 340);
			this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.picAnh.TabIndex = 0;
			this.picAnh.TabStop = false;
			// 
			// btnHienThi
			// 
			this.btnHienThi.Location = new System.Drawing.Point(46, 387);
			this.btnHienThi.Name = "btnHienThi";
			this.btnHienThi.Size = new System.Drawing.Size(530, 36);
			this.btnHienThi.TabIndex = 1;
			this.btnHienThi.Text = "&Hiển thị ảnh";
			this.btnHienThi.UseVisualStyleBackColor = true;
			this.btnHienThi.Click += new System.EventHandler(this.btnHienThi_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightGreen;
			this.ClientSize = new System.Drawing.Size(625, 450);
			this.Controls.Add(this.btnHienThi);
			this.Controls.Add(this.picAnh);
			this.ForeColor = System.Drawing.Color.Red;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bài 16: OpenFileDialog _ Mở file ảnh";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Button btnHienThi;
        private System.Windows.Forms.OpenFileDialog odlgAnh;
    }
}

