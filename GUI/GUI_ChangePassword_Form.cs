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
    public partial class GUI_ChangePassword_Form : Form
    {
        public GUI_ChangePassword_Form(int id, string password, string comboBox)
        {
            this.ID = id;
            this.Password = password;
            this.ComboBox = comboBox;
            InitializeComponent();
        }

        public GUI_ChangePassword_Form(string id, string password)
        {
            this.AdminId = id;
            this.Password = password;
            this.ComboBox = comboBox;
            InitializeComponent();
        }

        private string adminId;

        private string comboBox;

        private int id;

        private string password;

        public string AdminId
        {
            get
            {
                return adminId;
            }
            set
            {
                adminId = value;
            }
        }

        public string ComboBox
        {
            get
            {
                return comboBox;
            }
            set
            {
                comboBox = value;
            }
        }

        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }
            set
            {
                password = value;
            }
        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {
            string currentPassword = mkHienTaiTextBox.Text;
            string newPassword_1 = mkMoiTextBox.Text;
            string newPassword_2 = nhapLaiMKTextBox.Text;

            if (currentPassword.Length == 0 || newPassword_1.Length == 0 || newPassword_2.Length == 0 ||
                currentPassword.Length == 0 && newPassword_1.Length == 0 || currentPassword.Length == 0 && newPassword_2.Length == 0
                || newPassword_1.Length == 0 && newPassword_2.Length == 0 || currentPassword.Length == 0 && newPassword_1.Length == 0 && newPassword_2.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (currentPassword == password)
                {
                    if (newPassword_1 == newPassword_2)
                    {
                        if (comboBox == "teacherCheck")
                        {
                            BLL_TeacherAccount bll = new BLL_TeacherAccount();
                            bll.changePasswordForTeacher(id, newPassword_1);
                        }
                        else if (comboBox == "studentCheck")
                        {
                            BLL_StudentAccount bll = new BLL_StudentAccount();
                            bll.changePassword(id, newPassword_1);
                        }  
                        else
                        {
                            BLL_Admin bll = new BLL_Admin();
                            bll.changePasswordOfAdmin(adminId, newPassword_1);
                        }    
                        MessageBox.Show("Thay đổi mật khẩu thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đúng thông tin mật khẩu mới !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mật khẩu hiện tại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information); 
            if(result == DialogResult.Yes)
            {
                this.Hide();
            }    
        }
    }
}
