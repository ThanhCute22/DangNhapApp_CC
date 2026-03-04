using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DangNhapApp_CC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

  

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();   // hoặc txtTenDangNhap.Text
            string password = txtpassword.Text.Trim();   // hoặc txtMatKhau.Text

            if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Chuyển sang form thành công (nếu có)
                // Form2 formThanhCong = new Form2();
                // formThanhCong.Show();
                // this.Hide();   // ẩn form login

                // Hoặc đơn giản chỉ hiện thông báo như trên
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtpassword.Clear();   // xóa mật khẩu cho lần nhập sau
                txtpassword.Focus();   // con trỏ nhảy về ô pass
            }
        }
    }
}
