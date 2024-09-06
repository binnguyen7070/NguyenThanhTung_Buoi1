namespace NguyenThanhTung_Buoi1
{
    public partial class Form1 : Form
    {

        int a;
        int b;
        int c;
        double x1;
        double x2;
        double dental;
        private void LayThongTin()
        {
            try
            {
                a = Convert.ToInt32(txta.Text);
                b = Convert.ToInt32(txtb.Text);
                c = Convert.ToInt32(txtc.Text);
            }
            catch
            {
                MessageBox.Show("Phải nhập số thập phân hoặc số nguyên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txta.Clear();
                txtc.Clear();
                txtc.Clear();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void GPTBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    label5.Text = ("Phương trình vô số nghiệm");
                }
                else
                {
                    label5.Text = ("Phương trình vô nghiệm");
                }
            }
            else
            {
                label5.Text = ($"Nghiệm là " + Math.Round((-b / a), 2));
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXTrang_Click(object sender, EventArgs e)
        {
            txta.Text = "";
            txtb.Text = "";
            txtc.Text = "";
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            LayThongTin();
            if (a == 0)
            {
                GPTBac1(b, c);
            }
            else
            {
                dental = (double)Math.Pow(b, 2) - 4 * a * c;
                label5.Text = ($"Delta là " + dental.ToString());
            }
        }
    }

}
}
