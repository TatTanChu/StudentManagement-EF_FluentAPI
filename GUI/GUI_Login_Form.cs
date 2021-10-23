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
    public partial class GUI_Login_Form : Form
    {
        public GUI_Login_Form()
        {
            InitializeComponent();
        }
        private void dangNhapButton_Click(object sender, EventArgs e)
        {
            if (sinhVienRadioButton.Checked)
            {
                int studentId = int.Parse(tenDangNhapTextBox.Text.ToString());
                string password = matKhauTextBox.Text.ToString();
                BLL_Student bll = new BLL_Student(); 
                if (bll.studentCheckLogin(studentId, password))
                {
                    GUI_Student_Form form = new GUI_Student_Form(studentId, password, "studentCheck");
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Sinh viên vui lòng đúng tên tài khoản và mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } 
                    
            }
            else if (giangVienRadioButton.Checked)
            {
                int teacherId = int.Parse(tenDangNhapTextBox.Text.ToString());
                string password = matKhauTextBox.Text.ToString();
                BLL_Teacher bll = new BLL_Teacher();
                if (bll.checkLoginOfTeacher(teacherId, password))
                {
                    GUI_Teacher_Form form = new GUI_Teacher_Form(teacherId, password, "teacherCheck");
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vui lòng đúng tên tài khoản và mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                string AdminId = tenDangNhapTextBox.Text.ToString();
                string password = matKhauTextBox.Text.ToString();
                BLL_Admin bll = new BLL_Admin();
                if (bll.checkAdminLogin(AdminId, password))
                {
                    GUI_Admin_Form form = new GUI_Admin_Form(AdminId, password);
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Vui lòng đúng tên tài khoản và mật khẩu !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }    
               

        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
