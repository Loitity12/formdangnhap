using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class formquenmatkhau : Form
    {
        public formquenmatkhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Mật khẩu đã được gửi đến email của bạn" + MessageBoxButtons.OK);
            if (result == DialogResult.OK) // Kiểm tra nếu người dùng nhấn OK
            {
                this.Close(); // Đóng form hiện tại
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;
        }
    }
    }

