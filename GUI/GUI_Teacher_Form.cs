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
using DTO.Model;

namespace GUI
{
    public partial class GUI_Teacher_Form : Form
    {
        public GUI_Teacher_Form(int teacherId, string password, string comboBox)
        {
            this.TeacherId = teacherId;
            this.Password = password;
            this.ComboBox = comboBox;
            InitializeComponent();
            Visible();
        }

        private string comboBox;

        private int teacherId;

        private string password;

        private string gender;

        private string address;

        private string email;

        private int phone;

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

        public int TeacherId
        {
            get
            {
                return teacherId;
            }
            set
            {
                teacherId = value;
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

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public int Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
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

        public void Visible()
        {
            label1.Text = teacherId.ToString();

            DTO_Teacher teacher = new DTO_Teacher();
            BLL_Teacher bll = new BLL_Teacher();
            teacher = bll.showInformationOfTeacher(teacherId);

            this.address = teacher.Address;
            this.phone = teacher.Phone;
            this.gender = teacher.Gender;
            this.email = teacher.Email;
            this.dateOfBirth = teacher.DateOfBirth.Value;

            hoVaTenTextBox.Text = teacher.TeacherName.ToString();
            diaChiTextBox.Text = teacher.Address.ToString();
            emailTextBox.Text = teacher.Email.ToString();
            sdtTextBox.Text = teacher.Phone.ToString();
            gioiTinhComboBox.Text = teacher.Gender.ToString();
            ngaySinhTimePicker.Value = teacher.DateOfBirth.Value;

            //ENABEL SYSTEM : 
            hoVaTenTextBox.Enabled = false;
            diaChiTextBox.Enabled = false;
            emailTextBox.Enabled = false;
            sdtTextBox.Enabled = false;
            gioiTinhComboBox.Enabled = false;
            ngaySinhTimePicker.Enabled = false;
            huyButton.Enabled = false;
            capNhatButton.Enabled = false;

            BLL_Classes bll_1 = new BLL_Classes();
            dynamic listClass = bll_1.showClassListForTeacher(teacherId);
            timKiemDataGridView.DataSource = listClass;
        }

        private void thayDoiButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn thật sự muốn thay đổi thông tin của mình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                diaChiTextBox.Enabled = true;
                emailTextBox.Enabled = true;
                sdtTextBox.Enabled = true;
                gioiTinhComboBox.Enabled = true;
                ngaySinhTimePicker.Enabled = true;
                huyButton.Enabled = true;
                capNhatButton.Enabled = true;
                thayDoiButton.Enabled = false;
            }

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
                emailTextBox.Text = email;
                sdtTextBox.Text = phone.ToString();
                //ENABLE SYSTEM :
                ngaySinhTimePicker.Enabled = false;
                gioiTinhComboBox.Enabled = false;
                diaChiTextBox.Enabled = false;
                sdtTextBox.Enabled = false;
                emailTextBox.Enabled = false;
                huyButton.Enabled = false;
                capNhatButton.Enabled = false;
                thayDoiButton.Enabled = true;
            }
        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {

            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn đổi mới thông tin ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (dateOfBirth == ngaySinhTimePicker.Value && address == diaChiTextBox.Text && gender == gioiTinhComboBox.Text && email == emailTextBox.Text && phone.ToString() == sdtTextBox.Text)
                {
                    MessageBox.Show("Bạn vẫn chưa thay đổi bất kỳ thông tin gì ?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    this.address = diaChiTextBox.Text;
                    this.phone = int.Parse(sdtTextBox.Text);
                    this.gender = gioiTinhComboBox.Text;
                    this.email = emailTextBox.Text;
                    this.dateOfBirth = ngaySinhTimePicker.Value;

                    BLL_Teacher bll = new BLL_Teacher();
                    bll.updateTeacherInformation(teacherId, dateOfBirth, address, gender, email, phone);

                    ngaySinhTimePicker.Enabled = false;
                    gioiTinhComboBox.Enabled = false;
                    diaChiTextBox.Enabled = false;
                    sdtTextBox.Enabled = false;
                    emailTextBox.Enabled = false;
                    huyButton.Enabled = false;
                    capNhatButton.Enabled = true;
                    MessageBox.Show("Thông tin của bạn đã được cập nhật !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void thayDoiMKButton_Click(object sender, EventArgs e)
        {
            GUI_ChangePassword_Form form = new GUI_ChangePassword_Form(teacherId, password, comboBox);
            form.Show();
        }

        private void timKiemButton_Click(object sender, EventArgs e)
        {
            try
            {
                string searchString = timKiemTextBox.Text;
                BLL_Classes bll = new BLL_Classes();
                dynamic searchClass = bll.searchClassForTeacher(teacherId, searchString);
                timKiemDataGridView.DataSource = searchClass;
            }
            catch
            {
                timKiemDataGridView.DataSource = null;
            }
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchString = timKiemTextBox.Text;
                BLL_Classes bll = new BLL_Classes();
                dynamic searchClass = bll.searchClassForTeacher(teacherId, searchString);
                timKiemDataGridView.DataSource = searchClass;
            }
            catch
            {
                timKiemDataGridView.DataSource = null;
            }
        }

        private void timKiemDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = timKiemDataGridView.CurrentCell.RowIndex;
            string StudentClass = timKiemDataGridView.Rows[r].Cells[0].Value.ToString();
            string SubjectID = timKiemDataGridView.Rows[r].Cells[1].Value.ToString();
            GUI_StudentList_Form form = new GUI_StudentList_Form(StudentClass, SubjectID);
            form.Show();
        }
    }
}
