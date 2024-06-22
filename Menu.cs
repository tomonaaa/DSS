using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSS
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            // Xóa lựa chọn của tất cả các radiobutton
            foreach (Control control in Controls)
            {
                if (control is RadioButton radioButton)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void bt_ChanDoan_Click(object sender, EventArgs e)
        {
            // Đánh giá điều kiện để chẩn đoán bệnh
            bool isDepressed = CheckDepression();

            // Hiển thị kết quả chẩn đoán
            ChanDoan formChanDoan = new ChanDoan();
            formChanDoan.DiagnosisResult = isDepressed ? "Bạn có khả năng bị trầm cảm." : "Bạn không bị trầm cảm.";
            formChanDoan.ShowDialog();
        }
        private bool CheckDepression()
        {
            // Kiểm tra các điều kiện để chẩn đoán bệnh trầm cảm
            // Có thể thay đổi các giá trị này tùy theo yêu cầu cụ thể hoặc dữ liệu thực tế
            bool isDepressed = false;

            if (bt_23l.Checked || bt_4l.Checked)
            {
                isDepressed = true;
            }
            else if (bt_Never.Checked && (bt_12d.Checked || bt_34d.Checked))
            {
                isDepressed = true;
            }
            else if (bt_Never.Checked && bt_57d.Checked && (bt_34d2.Checked || bt_34d3.Checked || bt_34d4.Checked || bt_34d5.Checked || bt_34d6.Checked))
            {
                isDepressed = true;
            }
            else if (bt_Never.Checked && bt_12d.Checked && bt_57d1.Checked && (bt_34d5.Checked || bt_34d6.Checked))
            {
                isDepressed = true;
            }
            else if (bt_Never.Checked && bt_12d.Checked && bt_34d1.Checked && bt_34d2.Checked)
            {
                isDepressed = true;
            }
            else if (bt_Never.Checked && bt_12d.Checked && bt_12d1.Checked && (bt_34d5.Checked || bt_34d6.Checked))
            {
                isDepressed = true;
            }

            return isDepressed;
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
