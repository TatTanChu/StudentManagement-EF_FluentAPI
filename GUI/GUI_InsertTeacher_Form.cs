using BLL;
using DTO.Model;
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
    public partial class GUI_InsertTeacher_Form : Form
    {
        public GUI_InsertTeacher_Form()
        {
            InitializeComponent();
            emailTextBox.Enabled = false;
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void themGVButton_Click(object sender, EventArgs e)
        {
            if (msgvTextBox.Text.Length == 0 || hoVaTenTextBox.Text.Length == 0 || ngaySinhTimePicker.Value == null ||
                gioiTinhComboBox.Text.Length == 0 || diaChiTextBox.Text.Length == 0 || phoneTextBox.Text.Length == 0 || emailTextBox.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int teacherId = int.Parse(msgvTextBox.Text.Trim().ToString());
                BLL_Teacher bll_1 = new BLL_Teacher();
                bool check = bll_1.checkExistOfTeacher(teacherId);

                if (check == true)
                {
                    MessageBox.Show("Mã số giảng viên này đã tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (phoneTextBox.Text.Length != 10)
                    {
                        MessageBox.Show("Số điện thoại vừa nhập không hợp lệ !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        try
                        {
                            string teacherName = hoVaTenTextBox.Text.ToString();
                            DateTime dateOfBirth = ngaySinhTimePicker.Value;
                            string gender = gioiTinhComboBox.Text.ToString();
                            string address = diaChiTextBox.Text.ToString();
                            string email = emailTextBox.Text.ToString();
                            int phone = int.Parse(phoneTextBox.Text.ToString());

                            DTO_Teacher teacher = new DTO_Teacher();
                            teacher.TeacherID = teacherId;
                            teacher.TeacherName = teacherName;
                            teacher.DateOfBirth = dateOfBirth;
                            teacher.Gender = gender;
                            teacher.Address = address;
                            teacher.Email = email;
                            teacher.Phone = phone;

                            BLL_Teacher bll = new BLL_Teacher();
                            bll.insertTeacher(teacher);
                            MessageBox.Show("Đã thêm thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Thông tin điền của bạn gặp vấn đề !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
            }
            }
        }

        private void msgvTextBox_TextChanged(object sender, EventArgs e)
        {
            if (emailTextBox.Enabled == false)
            {
                string teacherId = msgvTextBox.Text;
                emailTextBox.Text = teacherId + "@teacher.hcmute.edu.vn";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            emailTextBox.Enabled = true;
        }
    }
}
