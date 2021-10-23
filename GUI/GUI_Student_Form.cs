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
using BLL;
using DAL;

namespace GUI
{
    public partial class GUI_Student_Form : Form
    {
        public GUI_Student_Form(int StudentId, string password, string comboBox)
        {
            this.StudentId = StudentId;
            this.Password = password;
            this.ComboBox = comboBox;

            InitializeComponent();

            Visible();
        }

        private string comboBox;

        private int studentId;

        private string password;

        private string address;

        private string gender;

        private DateTime dateOfBirth;

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


        public int StudentId
        {
            get
            {
                return studentId;
            }
            set
            {
                studentId = value;
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

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = value;
            }    
        }

        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }
            set
            {
                dateOfBirth = value;
            }
        }
             
        private void GUI_Student_Form_Load(object sender, EventArgs e)
        {

        }

        public void Visible()
        {
            DTO_Student student = new DTO_Student();
            BLL_Student bll = new BLL_Student();
            
            student = bll.showStudentInfomation(studentId);

            this.Address = student.Address.ToString();
            this.DateOfBirth = student.DateOfBirth.Value;
            this.Gender = student.Gender.ToString();

            label8.Text = studentId.ToString();
            label14.Text = studentId.ToString();
            label16.Text = "Đang hoạt động";
            label16.ForeColor = Color.Green;
            hoVaTenTextBox.Text = student.StudentName.ToString();
            ngaySinhTimePicker.Value = student.DateOfBirth.Value;
            gioiTinhComboBox.Text = student.Gender.ToString();
            diaChiTextBox.Text = student.Address.ToString();
            lopTextBox.Text = student.Class.ToString();
            emailTextBox.Text = student.Email.ToString();

            //Enabel System : 
            hoVaTenTextBox.Enabled = false;
            ngaySinhTimePicker.Enabled = false;
            gioiTinhComboBox.Enabled = false;
            diaChiTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            lopTextBox.Enabled = false;
            huyButton.Enabled = false;
            capNhatButton.Enabled = false;

            BLL_Points bll_1 = new BLL_Points();
            dynamic pointList = bll_1.pointListOfOneStudent(studentId);
            danhSachDiemDataGridView.DataSource = pointList;

            BLL_Points bll_2 = new BLL_Points();
            diemTBTextBox.Text = bll_2.avgPoint(studentId).ToString();
        }

        private void thayDoiButton_Click(object sender, EventArgs e)
        {
            ngaySinhTimePicker.Enabled = true;
            gioiTinhComboBox.Enabled = true;
            diaChiTextBox.Enabled = true;
            huyButton.Enabled = true;
            capNhatButton.Enabled = true;
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                ngaySinhTimePicker.Value = dateOfBirth;
                diaChiTextBox.Text = address;
                gioiTinhComboBox.Text = gender;
                //ENABLE SYSTEM :
                ngaySinhTimePicker.Enabled = false;
                gioiTinhComboBox.Enabled = false;
                diaChiTextBox.Enabled = false;
                huyButton.Enabled = false;
                capNhatButton.Enabled = false;
            }
        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {
            DAL_Student dal = new DAL_Student();


            this.Address = diaChiTextBox.Text.ToString();
            this.DateOfBirth = ngaySinhTimePicker.Value;
            this.Gender = gioiTinhComboBox.Text.ToString();
            DialogResult result;
            result = MessageBox.Show("Bạn đổi mới thông tin của mình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                dal.updateStudentInfomation(studentId, gender, address, dateOfBirth);

                ngaySinhTimePicker.Enabled = false;
                gioiTinhComboBox.Enabled = false;
                diaChiTextBox.Enabled = false;
                huyButton.Enabled = false;
                capNhatButton.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GUI_ChangePassword_Form form = new GUI_ChangePassword_Form(studentId, password, comboBox);
            form.Show();
        }
    }
}
