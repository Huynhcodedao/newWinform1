using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalculateDelta();
        }
        int a, b, c;
        double x1, x2, delta;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string data = txt1.Text;
            try
            {
                a = int.Parse(data);
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập vào không phải là số nguyên. Vui lòng nhập lại.");
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string data = txt2.Text;
            try
            {
                b = int.Parse(data);
            }
            catch (FormatException)
            {
                MessageBox.Show("Dữ liệu nhập vào không phải là số nguyên. Vui lòng nhập lại.");
            }
          
        }
        // Sự kiện text changed cho textBox3
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string data = txt3.Text;
            try
            {
                // Chuyển đổi dữ liệu từ textBox3 sang số nguyên và lưu vào biến c
                c = int.Parse(data);
            }
            catch (FormatException)
            {
                // Hiển thị thông báo nếu dữ liệu nhập vào không phải là số nguyên
                MessageBox.Show("Dữ liệu nhập vào không phải là số nguyên. Vui lòng nhập lại.");
            }
            
        }
        // Hàm để tính delta và giải phương trình bậc hai
        private void CalculateDelta()
        {
            // Kiểm tra và giải phương trình bậc hai
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                // Phương trình vô nghiệm
                lb1.Text = "Phương trình vô nghiệm!";
            }
            else if (delta == 0)
            {
                // Phương trình có nghiệm kép
                double x = -b / (2 * a);
                lb1.Text = "Phương trình có nghiệm kép là: x1 = x2 = " + x.ToString();
                
            }
            else
            {
                // Phương trình có 2 nghiệm phân biệt
                double sqrtDelta = Math.Sqrt(delta);
                double x1 = (-b - sqrtDelta) / (2 * a);
                double x2 = (-b + sqrtDelta) / (2 * a);
                lb1.Text = "Phương trình có 2 nghiệm phân biệt là: ";
                lb2.Text = "x1 = "+x1.ToString();
                lb3.Text = "x2 = "+x2.ToString();
            }
        }

    }

}
