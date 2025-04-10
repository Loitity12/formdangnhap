namespace formdangnhap
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Da dang nhap thanh cong!", "Thong bao!", MessageBoxButtons.OK);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Chua nhap ten tai khoan or mat khau!", "Thong bao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Location = groupBox1.Location; // Ensure alignment
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.UseSystemPasswordChar = !textBox5.UseSystemPasswordChar;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox6.UseSystemPasswordChar = !textBox6.UseSystemPasswordChar;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xác thực thành công!", "Thông báo!", MessageBoxButtons.OK);
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Location = groupBox1.Location; // Ensure alignment
            groupBox3.Visible = true;
            groupBox4.Visible = false;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã tạo tài khoản thành công!", "Thông báo!", MessageBoxButtons.OK);
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã thay đổi mật khẩu!", "Thông báo!", MessageBoxButtons.OK);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Location = groupBox1.Location; // Ensure alignment
            groupBox4.Visible = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }
    }


}
