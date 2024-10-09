using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maytinh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
                // Chuyển giá trị từ TextBox sang số nguyên (int)
                int so1 = int.Parse(txtsoA.Text);
                int so2 = int.Parse(txtsoB.Text);

                // Thực hiện phép tính cộng
                int ketQua = so1 + so2;

                // Hiển thị kết quả lên Label
                txtKQ.Text = ketQua.ToString();
        }

        private void btntru_Click(object sender, EventArgs e)
        {

        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            double number1, number2;
            if (double.TryParse(txtso1.Text, out number1) && double.TryParse(txtso2.Text, out number2))
            {
                double result = number1 * number2;
                txtKQ.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            try
            {
                // Chuyển giá trị từ TextBox sang số nguyên (int)
                int so1 = int.Parse(txtsoA.Text);
                int so2 = int.Parse(txtsoB.Text);

                // Kiểm tra phép chia cho 0
                if (so2 == 0)
                {
                    txtKQ.Text = "Không thể chia cho 0!";
                }
                else
                {
                    // Thực hiện phép chia
                    double ketQua = (double)so1 / so2;

                    // Hiển thị kết quả lên TextBox
                    txtKQ.Text = ketQua.ToString();
                }
            }
            catch (FormatException)
            {
                txtKQ.Text = "Vui lòng nhập số hợp lệ!";
            }
        }
    }
}
