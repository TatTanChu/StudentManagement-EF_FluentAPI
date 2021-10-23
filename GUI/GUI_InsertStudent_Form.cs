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
using DTO.Model;

namespace GUI
{
    public partial class GUI_InsertStudent_Form : Form
    {
        public GUI_InsertStudent_Form()
        {
            InitializeComponent();
            Visible();
        }

        private void mssvTextBox_TextChanged(object sender, EventArgs e)
        {
            if (emailTextBox.Enabled == false)
            {
                string studentId = mssvTextBox.Text;
                emailTextBox.Text = studentId + "@gmail.hcmute.edu.vn";
            }
        }

        public void Visible()
        {
            BLL_Classes bll = new BLL_Classes();
            dynamic list = bll.showNameOfClassList();

            lopComboBox.DataSource = list;
            lopComboBox.DisplayMember = "Class";
            lopComboBox.ValueMember = "Class";
            emailTextBox.Enabled = false;
        }

        private void themSVButton_Click(object sender, EventArgs e)
        {
            if(mssvTextBox.Text.Length == 0 || hoVaTenTextBox.Text.Length == 0 || ngaySinhTimePicker.Value == null || 
                gioiTinhComboBox.Text.Length == 0 || diaChiTextBox.Text.Length == 0 || lopComboBox.Text.Length == 0 || emailTextBox.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int studentId = int.Parse(mssvTextBox.Text.Trim().ToString());
                BLL_Student bll_1 = new BLL_Student();
                bool checkExitStudent = bll_1.checkStudentIdInSystem(studentId);
                if (checkExitStudent == true)
                {
                    MessageBox.Show("MSSV này đã tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        string studentName = hoVaTenTextBox.Text.ToString();
                        DateTime dateOfBirth = ngaySinhTimePicker.Value;
                        string gender = gioiTinhComboBox.Text.ToString();
                        string address = diaChiTextBox.Text.ToString();
                        string studentClass = lopComboBox.Text.ToString();
                        string email = emailTextBox.Text.ToString();
                        
                        DTO_Student student = new DTO_Student(studentId, studentName, dateOfBirth, gender, address, email, studentClass);

                        MessageBox.Show(student.StudentName + " " + student.DateOfBirth.ToString() + " " + student.Gender + " " + student.Address + " " + student.Class + " " + student.Email + " " + student.StudentID.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BLL_Student bll = new BLL_Student();
                        bll.insertStudent(student);
                        MessageBox.Show("Thêm sinh viên mới thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        emailTextBox.Enabled = false;
                    }
                    catch
                    {
                    MessageBox.Show("Thông tin điền của bạn gặp vấn đề !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            emailTextBox.Enabled = true;
        }
    }
}
