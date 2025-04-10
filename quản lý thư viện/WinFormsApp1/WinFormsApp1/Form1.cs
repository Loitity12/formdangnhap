namespace WinFormsApp1
{
    public partial class fromdangnhap : Form
    {
        public fromdangnhap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formdangki fr1 = new formdangki();
            fr1.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formtrangchu fr1 = new formtrangchu();
            fr1.Show();
        }

        private void fromdangnhap_Load(object sender, EventArgs e)
        {
            groupBox1.Left = (this.ClientSize.Width - groupBox1.Width) / 2;
            groupBox1.Top = (this.ClientSize.Height - groupBox1.Height) / 2;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            formquenmatkhau fr1 = new formquenmatkhau();
            fr1.Show();
        }
    }
}
