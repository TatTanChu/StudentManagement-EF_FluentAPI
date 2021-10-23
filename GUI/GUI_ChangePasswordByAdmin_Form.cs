using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class GUI_ChangePasswordByAdmin_Form : Form
    {
        public GUI_ChangePasswordByAdmin_Form(int id, string objectName)
        {
            InitializeComponent();
        }

        private int id;

        private string objectName;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string ObjectName
        {
            get { return objectName; }
            set { objectName = value; }
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Hide();
            }
        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {
            string newPassword_1 = mkMoiTextBox.Text;
            string newPassword_2 = nhapLaiMKTextBox.Text;

            if (newPassword_1.Length == 0 || newPassword_2.Length == 0 ||
                newPassword_1.Length == 0 && newPassword_2.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (newPassword_1 == newPassword_2)
                {
                    if (objectName == "teacherObject")
                    {
                        BLL_TeacherAccount bll = new BLL_TeacherAccount();
                        bll.changePasswordForTeacher(id, newPassword_1);
                    }
                    else if (objectName == "studentObject")
                    {
                        BLL_StudentAccount bll = new BLL_StudentAccount();
                        bll.changePassword(id, newPassword_1);
                    }
                    MessageBox.Show("Thay đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng thông tin mật khẩu mới !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
