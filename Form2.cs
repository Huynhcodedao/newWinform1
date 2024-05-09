using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            // Lấy tên người dùng và mật khẩu từ các TextBox tương ứng
            string username = txt1.Text;
            string password =txt2.Text;

            // Kiểm tra tên người dùng và mật khẩu
            if (username == "admin" && password == "123")
            {
                // Nếu tên người dùng và mật khẩu đúng, ẩn Form hiện tại và mở Form khác
                this.Hide();
                Form1 processForm = new Form1();
                processForm.ShowDialog();
            }
            else
            {
                // Nếu tên người dùng hoặc mật khẩu không đúng, hiển thị thông báo lỗi
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng thử lại.");
            }
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 processForm = new Form3();
            processForm.ShowDialog();
        }
    }
}
