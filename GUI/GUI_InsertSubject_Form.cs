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
    public partial class GUI_InsertSubject_Form : Form
    {
        public GUI_InsertSubject_Form()
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

        private void themMHButton_Click(object sender, EventArgs e)
        {
            string subjectId = maMHTextBox.Text.ToString();
            string subjectName = tenMHTextBox.Text.ToString();
            BLL_Subjects bll = new BLL_Subjects();
            bll.insertSubject(subjectId, subjectName);
            MessageBox.Show("Đã thêm môn học thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
