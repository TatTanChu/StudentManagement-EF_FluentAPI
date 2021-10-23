using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class GUI_InsertClass_Form : Form
    {
        public GUI_InsertClass_Form()
        {
            InitializeComponent();
        }

        private void huyThaoTacButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void themLopButton_Click(object sender, EventArgs e)
        {
            string studentClass = tenLopTextBox.Text;
            int quantity = int.Parse(soLuongTextBox.Text);
            BLL_Classes bll = new BLL_Classes();
            bll.insertClass(studentClass, quantity);
            MessageBox.Show("Đã thêm lớp học thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
