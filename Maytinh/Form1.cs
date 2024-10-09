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

        }

        private void btnchia_Click(object sender, EventArgs e)
        {

        }
    }
}
