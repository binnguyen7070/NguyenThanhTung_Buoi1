using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

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
                a = Convert.ToInt32(txtA.Text);
                b = Convert.ToInt32(txtB.Text);
                c = Convert.ToInt32(txtC.Text);
            }
            catch
            {
                MessageBox.Show("Phải nhập số thập phân hoặc số nguyên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Clear();
                txtB.Clear();
                txtC.Clear();
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void GPTBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    lblKQ.Text = ("Phương trình vô số nghiệm");
                }
                else
                {
                    lblKQ.Text = ("Phương trình vô nghiệm");
                }
            }
            else
            {
                lblKQ.Text = ($"Nghiệm là " + Math.Round((-b / a), 2));
            }
        }

            private void btngiai_Click(object sender, EventArgs e)
        {
            LayThongTin();
            if (a == 0)
            {
                GPTBac1(b, c);
            }
            else

            {
                dental = (double)Math.Pow(b, 2) - 4 * a * c;
                lblKQ.Text = ($"Delta là " + dental.ToString());
            }
        }
    }
}
