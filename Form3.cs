using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void regis_btn_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox tương ứng
            string name = textName.Text;
            string username = textUser.Text;
            string password = textPass.Text;
            string email = textEmail.Text;

            // Kiểm tra xem tất cả các trường đã được điền chưa
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }

            // Thực hiện việc đăng ký (ví dụ: lưu thông tin vào cơ sở dữ liệu)

            MessageBox.Show("Đăng ký thành công!");
        }
    }
}
