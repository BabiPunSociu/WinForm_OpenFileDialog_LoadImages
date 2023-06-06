using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai16_OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            odlgAnh.FileName = "";  // Tên file + Đường dẫn
            // Auto chỉnh kích thước ảnh bằng kích thước pictureBox
            picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        }

        private void btnHienThi_Click(object sender, EventArgs e)
        {
            //    OpenFileDialog odlgAnh = new OpenFileDialog();    // Đã tạo bằng kéo thả


            //  Xác định danh sách các bộ lọc tập tin mà hộp hội thoại sẽ hiển thị
            //  KHÔNG ĐƯỢC CHỨA DẤU CÁCH
            // "(Nội dung hiển thị trên ô filter)|(Định dạng để lọc file)"
            // Dấu '*' có ý nghĩa là bất kì kí tự nào
            odlgAnh.Filter = "Bitmap(*.bmp)|*.bmp|JPG(*.jpg)|*.jpg|Gif(*.gif)|*.gif|AllFiles(*.*)|*.*";

            //  Xác định thư mục mặc định cho hộp hội thoại khi vừa được gọi
            odlgAnh.InitialDirectory = "Desktop";

            //  Chỉ ra bộ lọc tập tin mặc định, đánh theo số thứ tự 1,2,3...
            odlgAnh.FilterIndex = 2;

            //  Xác định tiêu đề của hộp hội thoại
            odlgAnh.Title = "Chọn ảnh để hiển thị";


            if (odlgAnh.ShowDialog() == DialogResult.OK)
                picAnh.Image = Image.FromFile(odlgAnh.FileName  /* Lấy ra tên file và đường dẫn */);
            else
                MessageBox.Show("You clicked Cancel", "Open Dialog",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        
    }
}
