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
    public partial class GUI_Admin_Form : Form
    {
        public GUI_Admin_Form(string AdminId, string password)
        {
            InitializeComponent();
            Visible();
        }

        public GUI_Admin_Form()
        {
            InitializeComponent();
            Visible();
        }

        //ADMIN INFOMATION : 

        private string adminId;

        private string password;

        private string adminName;

        private string phone;

        private DateTime? dateOfBirth;

        private string gender;

        private string address;

        private string email;

        public string AdminName
        {
            get
            {
                return adminName;
            }
            set
            {
                adminName = value;
            }
        }

        public string Phone
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

        public DateTime? DateOfBirth
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

        public void Visible()
        {
            DTO_Admin admin = new DTO_Admin();
            BLL_Admin bll = new BLL_Admin();
            BLL_Classes bll_1 = new BLL_Classes();
            admin = bll.showAdminInfomation(adminId);

            //MANAGEMENT ADMIN INFOMATION : 
                //hoVaTenTextBox.Text = admin.AdminName;
                //ngaySinhTimePicker.Value = admin.DateOfBirth.Value;
                //gioiTinhComboBox.Text = admin.Gender;
                //emailTextBox.Text = admin.Email;
                //diaChiTextBox.Text = admin.Address;
                //sdtTextBox.Text = admin.Phone;

            //MANAGEMENT ADMIN ACCOUNT : 
            tenTKTextBox.Text = adminId;
            label16.Text = "Đang hoạt động";
            label16.ForeColor = Color.Green;

            //MANAGEMENT CLASS :
            lopHocDataGridView.DataSource = bll_1.showClassList();

            this.AdminName = admin.AdminName;
            this.DateOfBirth = admin.DateOfBirth;
            this.Gender = admin.Gender;
            this.Email = admin.Email;
            this.Address = admin.Address;
            this.Phone = admin.Phone;

            //MANAGEMENT POINT : 
            BLL_Points bll_2 = new BLL_Points();
            diemDataGridView.DataSource = bll_2.pointListByTeacherId();

            //MANAMENT SUBJECT : 
            BLL_Subjects bll_3 = new BLL_Subjects();
            monHocDataGridView.DataSource = bll_3.showListOfSubject();

            //ENABLE SYSTEMS : 
            capNhatButton.Enabled = false;
            hoVaTenTextBox.Enabled = false;
            ngaySinhTimePicker.Enabled = false;
            gioiTinhComboBox.Enabled = false;
            emailTextBox.Enabled = false;
            diaChiTextBox.Enabled = false;
            sdtTextBox.Enabled = false;
            tenTKTextBox.Enabled = false;
            capNhatTenTKButton.Enabled = false;
            huyButton.Enabled = false;
            capNhatButton.Enabled = false;
            tenLopTextBox.Enabled = false;
            soLuongTextBox.Enabled = false;
            capNhatLopButton.Enabled = false;
            hoTenSVTextBox.Enabled = false;
            ngSinhSVDateTimePicker.Enabled = false;
            gioiTinhSVComboBox.Enabled = false;
            diaChiSVTextBox.Enabled = false;
            lopSVTextBot.Enabled = false;
            emailSVTextBox.Enabled = false;
            capNhatSVButton.Enabled = false;
            huyThaoTacSVButton.Enabled = false;
            huyThaoTacButton.Enabled = false;
            hoVaTenGVTextBox.Enabled = false;
            ngSinhGVDateTimePicker.Enabled = false;
            gioiTinhGVComboBox.Enabled = false;
            diaChiGVTextBox.Enabled = false;
            emailGVTextBox.Enabled = false;
            sdtGVTextBox.Enabled = false;
            capNhatGVButton.Enabled = false;
            huyThaoTacGVButton.Enabled = false;
            maMonHocTextBox.Enabled = false;
            tenMonHocTextBox.Enabled = false;
        }

        private void thayDoiButton_Click(object sender, EventArgs e)
        {
            huyButton.Enabled = true;
            capNhatButton.Enabled = true;
            hoVaTenTextBox.Enabled = true;
            ngaySinhTimePicker.Enabled = true;
            gioiTinhComboBox.Enabled = true;
            emailTextBox.Enabled = true;
            diaChiTextBox.Enabled = true;
            sdtTextBox.Enabled = true;
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                    //ngaySinhTimePicker.Value = dateOfBirth.Value;
                    //diaChiTextBox.Text = address;
                    //gioiTinhComboBox.Text = gender;
                    //hoVaTenTextBox.Text = adminName;
                    //emailTextBox.Text = email;
                    //sdtTextBox.Text = phone;

                //ENABLE SYSTEM :
                hoVaTenTextBox.Enabled = false;
                ngaySinhTimePicker.Enabled = false;
                gioiTinhComboBox.Enabled = false;
                emailTextBox.Enabled = false;
                diaChiTextBox.Enabled = false;
                sdtTextBox.Enabled = false;
                huyButton.Enabled = false;
                capNhatButton.Enabled = false;
            }
        }

        private void capNhatButton_Click(object sender, EventArgs e)
        {
            //string Phone = sdtTextBox.Text;
            //string Gender = gioiTinhComboBox.Text;
            //string Email = emailTextBox.Text;
            //string AdminName = hoVaTenTextBox.Text;
            //DateTime DateOfBirth = ngaySinhTimePicker.Value;
            //string Address = diaChiTextBox.Text;

            //BLL_Admin bll = new BLL_Admin();
            //bll.updateAdminInformation(adminId, Phone, Gender, Email, AdminName, DateOfBirth, Address);
            MessageBox.Show("Đã cập nhật thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Phone = Phone;
            this.Gender = Gender;
            this.Email = Email;
            this.AdminName = AdminName;
            this.DateOfBirth = DateOfBirth;
            this.Address = Address;

            //ENABLE SYSTEM :
            hoVaTenTextBox.Enabled = false;
            ngaySinhTimePicker.Enabled = false;
            gioiTinhComboBox.Enabled = false;
            emailTextBox.Enabled = false;
            diaChiTextBox.Enabled = false;
            sdtTextBox.Enabled = false;
            huyButton.Enabled = false;
            capNhatButton.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn muốn thay đổi tên đăng nhập của mình ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                tenTKTextBox.Enabled = true;
                capNhatTenTKButton.Enabled = true;
            }
        }

        private void capNhatTenTKButton_Click(object sender, EventArgs e)
        {
            string AdminIdNew = tenTKTextBox.Text;
            BLL_Admin bll = new BLL_Admin();
            bll.changeUserNameOfAdmin(adminId, AdminIdNew);
            //ENABLE SYSTEM :
            tenTKTextBox.Enabled = false;
            capNhatTenTKButton.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GUI_ChangePassword_Form form = new GUI_ChangePassword_Form(adminId, password);
            form.Show();
        }

        private void timSinhVienButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (traCuuSVTextBox.Text.Length != 0)
                {
                    int studentId = int.Parse(traCuuSVTextBox.Text.ToString());
                    DTO_Student student = new DTO_Student();
                    BLL_Student bll = new BLL_Student();
                    student = bll.showStudentInfomation(studentId);
                    hoTenSVTextBox.Text = student.StudentName;
                    ngSinhSVDateTimePicker.Value = student.DateOfBirth.Value;
                    gioiTinhSVComboBox.Text = student.Gender.ToString();
                    diaChiSVTextBox.Text = student.Address;
                    lopSVTextBot.Text = student.Class;
                    emailSVTextBox.Text = student.Email;
                }
                else
                {
                    MessageBox.Show("Vui lòng điền thông tin MSSV!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch {
                MessageBox.Show("Không tồn tại MSSV bạn vừa nhập trong hệ thống này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void themLopButton_Click(object sender, EventArgs e)
        {
            GUI_InsertClass_Form form = new GUI_InsertClass_Form();
            form.Show();
        }

        private void timKiemLopButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (timKiemTextBox.Text.Length != 0)
                {
                    string searchString = timKiemLopButton.Text;
                    BLL_Classes bll = new BLL_Classes();
                    lopHocDataGridView.DataSource = bll.searchClass(searchString);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập tên lớp muốn tìm kiếm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timKiemTextBox_TextChanged(object sender, EventArgs e)
        {
            DataGridView dtg = new DataGridView();
            dtg.DataSource = lopHocDataGridView.DataSource;
            try
            {
                string searchString = timKiemTextBox.Text;
                BLL_Classes bll = new BLL_Classes();
                dynamic searchClass = bll.searchClass(searchString);
                lopHocDataGridView.DataSource = searchClass;
            }
            catch
            {
                lopHocDataGridView.DataSource = dtg.DataSource;
            }
        }

        private void huyThaoTacButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                soLuongTextBox.Enabled = false;
                tenLopTextBox.Enabled = false;
                capNhatLopButton.Enabled = false;
                huyThaoTacButton.Enabled = false;
                themLopButton.Enabled = true;
                suaThongTinLopButton.Enabled = true;
                xoaLopButton.Enabled = true;
            }
        }

        private void xoaLopButton_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result;

                result = MessageBox.Show("Bạn thật sự muốn xóa lớp học này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    string studentClass = tenLopTextBox.Text;
                    BLL_Classes bll = new BLL_Classes();
                    bll.deleteClass(studentClass);
                    MessageBox.Show("Đã xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    BLL_Classes bll_1 = new BLL_Classes();
                    lopHocDataGridView.DataSource = bll_1.showClassList();

                    soLuongTextBox.Text = "";
                    tenLopTextBox.Text = "";

                    soLuongTextBox.Enabled = false;
                    tenLopTextBox.Enabled = false;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void suaThongTinLopButton_Click(object sender, EventArgs e)
        {
            if (tenLopTextBox.Text.Length != 0)
            {
                soLuongTextBox.Enabled = true;
                tenLopTextBox.Enabled = true;
                capNhatLopButton.Enabled = true;
                huyThaoTacButton.Enabled = true;
                suaThongTinLopButton.Enabled = false;
                themLopButton.Enabled = false;
                xoaLopButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lớp học muốn thao tác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void capNhatLopButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn thay đổi thông tin lớp học này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string studentClass = tenLopTextBox.Text;
                int quantity = int.Parse(soLuongTextBox.Text.ToString());
                BLL_Classes bll = new BLL_Classes();
                bll.updateClassInfomation(studentClass, quantity);
                MessageBox.Show("Đã cập nhật thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BLL_Classes bll_1 = new BLL_Classes();
                lopHocDataGridView.DataSource = bll_1.showClassList();
                soLuongTextBox.Enabled = false;
                tenLopTextBox.Enabled = false;
                capNhatLopButton.Enabled = false;
                huyThaoTacButton.Enabled = false;
                suaThongTinLopButton.Enabled = true;
                themLopButton.Enabled = true;
                xoaLopButton.Enabled = true;
            }
        }

        private void lopHocDataGridView_Click(object sender, EventArgs e)
        {
            int r = lopHocDataGridView.CurrentCell.RowIndex;
            string StudentClass = lopHocDataGridView.Rows[r].Cells[0].Value.ToString();
            int quantity = int.Parse(lopHocDataGridView.Rows[r].Cells[1].Value.ToString());
            tenLopTextBox.Text = StudentClass;
            soLuongTextBox.Text = quantity.ToString();
        }

        private void lopHocDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = lopHocDataGridView.CurrentCell.RowIndex;
            string StudentClass = lopHocDataGridView.Rows[r].Cells[0].Value.ToString();
            int quantity = int.Parse(lopHocDataGridView.Rows[r].Cells[1].Value.ToString());
            tenLopTextBox.Text = StudentClass;
            soLuongTextBox.Text = quantity.ToString();
        }

        private void thayDoiThongTinSVButton_Click(object sender, EventArgs e)
        {
            if (traCuuSVTextBox.Text.Length != 0)
            {
                try
                {
                    int studentId = int.Parse(traCuuSVTextBox.Text.ToString());
                    DTO_Student student = new DTO_Student();
                    BLL_Student bll = new BLL_Student();
                    student = bll.showStudentInfomation(studentId);
                    hoTenSVTextBox.Text = student.StudentName;
                    ngaySinhTimePicker.Value = student.DateOfBirth.Value;
                    gioiTinhSVComboBox.Text = student.Gender;
                    diaChiSVTextBox.Text = student.Address;
                    lopSVTextBot.Text = student.Class;
                    emailSVTextBox.Text = student.Email;

                    capNhatSVButton.Enabled = true;
                    hoTenSVTextBox.Enabled = true;
                    ngSinhSVDateTimePicker.Enabled = true;
                    gioiTinhSVComboBox.Enabled = true;
                    diaChiSVTextBox.Enabled = true;
                    lopSVTextBot.Enabled = true;
                    emailSVTextBox.Enabled = true;
                    huyThaoTacSVButton.Enabled = true;
                    capNhatSVButton.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("Không tồn tại MSSV bạn vừa nhập trong hệ thống này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin MSSV !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void capNhatSVButton_Click(object sender, EventArgs e)
        {
            try
            {
                int studentId = int.Parse(traCuuSVTextBox.Text.ToString());
                string studentName = hoTenSVTextBox.Text;
                DateTime dateOfBirth = ngSinhSVDateTimePicker.Value;
                string gender = gioiTinhSVComboBox.Text.ToString();
                string address = diaChiSVTextBox.Text;
                string Class = lopSVTextBot.Text;
                string email = emailSVTextBox.Text;

                BLL_Student bll = new BLL_Student();
                bll.updateStudentInfomationByAdmin(studentId, studentName, dateOfBirth, gender, address, Class, email);
                MessageBox.Show("Đã cập nhật thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                huyThaoTacSVButton.Enabled = false;
                capNhatSVButton.Enabled = false;
                capNhatSVButton.Enabled = false;
                hoTenSVTextBox.Enabled = false;
                ngSinhSVDateTimePicker.Enabled = false;
                gioiTinhSVComboBox.Enabled = false;
                diaChiSVTextBox.Enabled = false;
                lopSVTextBot.Enabled = false;
                emailSVTextBox.Enabled = false;
            }
            catch
            {
                MessageBox.Show("MSSV này không tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void thayDoiMKSVButton_Click(object sender, EventArgs e)
        {
            if (traCuuSVTextBox.Text.Length != 0)
            {
                try
                {
                    int studentId = int.Parse(traCuuSVTextBox.Text.Trim().ToString());
                    BLL_Student student = new BLL_Student();
                    bool checkExitStudent = student.checkStudentIdInSystem(studentId);
                    if (checkExitStudent == true)
                    {
                        GUI_ChangePasswordByAdmin_Form form = new GUI_ChangePasswordByAdmin_Form(studentId, "studentObject");
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("MSSV này không tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
                catch
                {
                    MessageBox.Show("MSSV này không tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin MSSV !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void xoaSVButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (traCuuSVTextBox.Text.Length != 0)
                {
                    int studentId = int.Parse(traCuuSVTextBox.Text.Trim().ToString());
                    BLL_Student student = new BLL_Student();
                    bool checkExitStudent = student.checkStudentIdInSystem(studentId);
                    if (checkExitStudent == true)
                    {
                        DialogResult result;

                        result = MessageBox.Show("Bạn muốn xóa sinh viên này khỏi hệ thống ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (result == DialogResult.Yes)
                        {
                            BLL_Student bll = new BLL_Student();
                            bll.deleteStudent(studentId);
                            MessageBox.Show("Đã xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            traCuuSVTextBox.Text = "";
                            hoTenSVTextBox.Text = "";
                            gioiTinhSVComboBox.Text = "";
                            diaChiSVTextBox.Text = "";
                            lopSVTextBot.Text = "";
                            emailSVTextBox.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("MSSV này không tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
                else
                {
                    MessageBox.Show("Vui lòng điền thông tin MSSV !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }         
        }

        private void huyThaoTacSVButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                hoTenSVTextBox.Enabled = false;
                ngSinhSVDateTimePicker.Enabled = false;
                lopSVTextBot.Enabled = false;
                emailSVTextBox.Enabled = false;
                gioiTinhSVComboBox.Enabled = false;
                diaChiSVTextBox.Enabled = false;
                capNhatSVButton.Enabled = false;
                huyThaoTacSVButton.Enabled = false;
            }
        }

        private void themSVButton_Click(object sender, EventArgs e)
        {
            GUI_InsertStudent_Form form = new GUI_InsertStudent_Form();
            form.Show();
        }

        private void timKiemGVButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (timKiemGVTextBox.Text.Length != 0)
                {
                    int teacherId = int.Parse(timKiemGVTextBox.Text.ToString());
                    DTO_Teacher teacher = new DTO_Teacher();
                    BLL_Teacher bll = new BLL_Teacher();
                    teacher = bll.showInformationOfTeacher(teacherId);
                    hoVaTenGVTextBox.Text = teacher.TeacherName;
                    ngSinhGVDateTimePicker.Value = teacher.DateOfBirth.Value;
                    gioiTinhGVComboBox.Text = teacher.Gender;
                    diaChiGVTextBox.Text = teacher.Address;
                    emailGVTextBox.Text = teacher.Email;
                    sdtGVTextBox.Text = teacher.Phone.ToString();
                }
                else
                {
                    MessageBox.Show("Vui lòng điền thông tin mã số giảng viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Không tồn tại mã số giảng viên bạn vừa nhập trong hệ thống này !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void thayDoiThongTinGVButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự thay đổi thông tin của giáo viên này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (timKiemGVTextBox.Text.Length != 0)
                {
                    int teacherId = int.Parse(timKiemGVTextBox.Text);
                    BLL_Teacher bll = new BLL_Teacher();
                    if (bll.checkExistOfTeacher(teacherId))
                    {
                        DTO_Teacher teacher = new DTO_Teacher();
                        BLL_Teacher bll_1 = new BLL_Teacher();
                        teacher = bll_1.showInformationOfTeacher(teacherId);
                        hoVaTenGVTextBox.Text = teacher.TeacherName;
                        ngSinhGVDateTimePicker.Value = teacher.DateOfBirth.Value;
                        gioiTinhGVComboBox.Text = teacher.Gender;
                        diaChiGVTextBox.Text = teacher.Address;
                        emailGVTextBox.Text = teacher.Email;
                        sdtGVTextBox.Text = teacher.Phone.ToString();

                        hoVaTenGVTextBox.Enabled = true;
                        ngSinhGVDateTimePicker.Enabled = true;
                        gioiTinhGVComboBox.Enabled = true;
                        diaChiGVTextBox.Enabled = true;
                        emailGVTextBox.Enabled = true;
                        sdtGVTextBox.Enabled = true;
                        capNhatGVButton.Enabled = true;
                        huyThaoTacGVButton.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Mã số giảng viên này không tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập mã số giảng viên muốn tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void capNhatGVButton_Click(object sender, EventArgs e)
        {
            if (timKiemGVTextBox.Text.Length != 0)
            {
                int teacherId = int.Parse(timKiemGVTextBox.Text);
                BLL_Teacher bll = new BLL_Teacher();
                if (bll.checkExistOfTeacher(teacherId))
                {
                    string teacherName = hoVaTenGVTextBox.Text;
                    DateTime dateOfBirth = ngSinhGVDateTimePicker.Value;
                    string gender = gioiTinhGVComboBox.Text;
                    string address = diaChiGVTextBox.Text;
                    string email = emailGVTextBox.Text;
                    int phone = int.Parse(sdtGVTextBox.Text);
                    BLL_Teacher bll_1 = new BLL_Teacher();
                    bll_1.updateTeacherInfomationByAdmin(teacherId, dateOfBirth, address, gender, email, phone, teacherName);
                    MessageBox.Show("Đã cập nhật thông tin thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    hoVaTenGVTextBox.Enabled = false;
                    ngSinhGVDateTimePicker.Enabled = false;
                    gioiTinhGVComboBox.Enabled = false;
                    diaChiGVTextBox.Enabled = false;
                    emailGVTextBox.Enabled = false;
                    sdtGVTextBox.Enabled = false;
                    capNhatGVButton.Enabled = false;
                    huyThaoTacGVButton.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Mã số giảng viên này không tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập mã số giảng viên muốn tìm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void huyThaoTacGVButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                hoVaTenGVTextBox.Enabled = false;
                ngSinhGVDateTimePicker.Enabled = false;
                gioiTinhGVComboBox.Enabled = false;
                diaChiGVTextBox.Enabled = false;
                emailGVTextBox.Enabled = false;
                sdtGVTextBox.Enabled = false;
                capNhatGVButton.Enabled = false;
                huyThaoTacGVButton.Enabled = false;
            }
        }

        private void doiMKGVButton_Click(object sender, EventArgs e)
        {
            if (timKiemGVTextBox.Text.Length != 0)
            {
                try
                {
                    int teacherId = int.Parse(timKiemGVTextBox.Text.Trim().ToString());
                    BLL_Teacher teacher = new BLL_Teacher();
                    bool checkExitTeacher = teacher.checkExistOfTeacher(teacherId);
                    if (checkExitTeacher == true)
                    {
                        GUI_ChangePasswordByAdmin_Form form = new GUI_ChangePasswordByAdmin_Form(teacherId, "teacherObject");
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Mã số giảng viên này không tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Mã số giảng viên này không tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin mã số giảng viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void xoaGVButton_Click(object sender, EventArgs e)
        {
            if (timKiemGVTextBox.Text.Length != 0)
            {
                try
                {
                    int teacherId = int.Parse(timKiemGVTextBox.Text.Trim().ToString());
                    BLL_Teacher bll_1 = new BLL_Teacher();
                    bool checkExitTeacher = bll_1.checkExistOfTeacher(teacherId);
                    if (checkExitTeacher == true)
                    {
                        BLL_Teacher bll = new BLL_Teacher();
                        bll.deleteTeacher(teacherId);
                        MessageBox.Show("Đã xóa thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Mã số giảng viên này không tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch
                {
                    MessageBox.Show("Mã số giảng viên này không tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền thông tin mã số giảng viên !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void themGVButton_Click(object sender, EventArgs e)
        {
            GUI_InsertTeacher_Form form = new GUI_InsertTeacher_Form();
            form.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(maMHTextBox.Text.Length == 0 || tenLopHocTextBox.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin tìm kiếm !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string subjectId = maMHTextBox.Text.ToString();
                string studentClass = tenLopHocTextBox.Text.ToString();
                BLL_Classes bll_1 = new BLL_Classes();
                BLL_Subjects bll_2 = new BLL_Subjects();

                if (bll_1.checkExistOfClass(studentClass) == false || bll_2.checkExistOfSubject(subjectId) == false)
                {
                    MessageBox.Show("Mã môn học hoặc tên lớp không tồn tại trong hệ thống !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    GUI_ManagePoint_Form form = new GUI_ManagePoint_Form(subjectId, studentClass);
                    form.Show();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataGridView dtg = new DataGridView();
            dtg.DataSource = diemDataGridView.DataSource;
            try
            {
                string searchString = timKiemDSDTextBox.Text;
                BLL_Points bll = new BLL_Points();
                dynamic searchPoint = bll.searchPointListByTeacherId(searchString);
                diemDataGridView.DataSource = searchPoint;
            }
            catch
            {
                lopHocDataGridView.DataSource = dtg.DataSource;
            }
        }

        private void diemDataGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = diemDataGridView.CurrentCell.RowIndex;
            string studentClass = diemDataGridView.Rows[r].Cells[2].Value.ToString();
            string subjectID = diemDataGridView.Rows[r].Cells[0].Value.ToString();
            GUI_ManagePoint_Form form = new GUI_ManagePoint_Form(subjectID, studentClass);
            form.Show();
        }

        private void timKiemDSDTextBox_TextChanged(object sender, EventArgs e)
        {
            DataGridView dtg = new DataGridView();
            dtg.DataSource = diemDataGridView.DataSource;
            try
            {
                string searchString = timKiemDSDTextBox.Text.ToString();
                BLL_Points bll = new BLL_Points();
                dynamic searchPoint = bll.searchPointListByTeacherId(searchString);
                diemDataGridView.DataSource = searchPoint;
            }
            catch
            {
                lopHocDataGridView.DataSource = dtg.DataSource;
            }
        }

        private void huyThaoTacMHButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                maMonHocTextBox.Enabled = false;
                tenMonHocTextBox.Enabled = false;
                capNhatMHButton.Enabled = false;
                huyThaoTacMHButton.Enabled = false;
                themMonHocButton.Enabled = true;
                suaThongTinMHButton.Enabled = true;
                xoaMonHocButton.Enabled = true;
            }
        }

        private void suaThongTinMHButton_Click(object sender, EventArgs e)
        {
            if (maMonHocTextBox.Text.Length == 0 || tenMonHocTextBox.Text.Length == 0)
            {
                MessageBox.Show("Vui lòng chọn môn học muốn thay đổi thông tin !", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result;

                result = MessageBox.Show("Bạn thật sự muốn thay đổi thông tin của môn học này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    huyThaoTacMHButton.Enabled = true;
                    capNhatMHButton.Enabled = true;
                    maMonHocTextBox.Enabled = true;
                    tenMonHocTextBox.Enabled = true;
                }
            }    
        }

        private void capNhatMHButton_Click(object sender, EventArgs e)
        {
            string subjectId = maMHTextBox.Text.ToString();
            string subjectName = tenMonHocTextBox.Text.ToString();
            BLL_Subjects bll = new BLL_Subjects();
            bll.updateSubjectInfomation(subjectId, subjectName);
            MessageBox.Show("Đã cập nhật môn học thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            BLL_Subjects bll_1 = new BLL_Subjects();
            monHocDataGridView.DataSource = bll_1.showListOfSubject();
            
            huyThaoTacMHButton.Enabled = false;
            capNhatMHButton.Enabled = false;
            maMonHocTextBox.Enabled = false;
            tenMonHocTextBox.Enabled = false;
        }

        private void xoaMonHocButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn xóa mọi thông tin của môn học này khỏi hệ thống ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                string subjectId = maMonHocTextBox.Text.ToString();
                BLL_Subjects bll = new BLL_Subjects();
                bll.deleteSubject(subjectId);
                MessageBox.Show("Đã xóa môn học thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BLL_Subjects bll_1 = new BLL_Subjects();
                monHocDataGridView.DataSource = bll_1.showListOfSubject();
            }
        }

        private void themMonHocButton_Click(object sender, EventArgs e)
        {
            GUI_InsertSubject_Form form = new GUI_InsertSubject_Form();
            form.Show();
        }

        private void monHocDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = monHocDataGridView.CurrentCell.RowIndex;
            string subjectId = monHocDataGridView.Rows[r].Cells[0].Value.ToString();
            string subjectName = monHocDataGridView.Rows[r].Cells[1].Value.ToString();
            maMHTextBox.Text = subjectId;
            tenMonHocTextBox.Text = subjectName;
        }

        private void monHocDataGridView_Click(object sender, EventArgs e)
        {
            int r = monHocDataGridView.CurrentCell.RowIndex;
            string subjectId = monHocDataGridView.Rows[r].Cells[0].Value.ToString();
            string subjectName = monHocDataGridView.Rows[r].Cells[1].Value.ToString();
            maMonHocTextBox.Text = subjectId;
            tenMonHocTextBox.Text = subjectName;
        }

        private void tkMHButton_Click(object sender, EventArgs e)
        {
            DataGridView dtg = new DataGridView();
            dtg.DataSource = monHocDataGridView.DataSource;
            try
            {
                string searchString = tiemKiemMHTextBox.Text;
                BLL_Subjects bll = new BLL_Subjects();
                dynamic searchClass = bll.searchSubject(searchString);
                monHocDataGridView.DataSource = searchClass;
            }
            catch
            {
                monHocDataGridView.DataSource = dtg.DataSource;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataGridView dtg = new DataGridView();
            dtg.DataSource = monHocDataGridView.DataSource;
            try
            {
                string searchString = tiemKiemMHTextBox.Text;
                BLL_Subjects bll = new BLL_Subjects();
                dynamic searchClass = bll.searchSubject(searchString);
                monHocDataGridView.DataSource = searchClass;
            }
            catch
            {
                monHocDataGridView.DataSource = dtg.DataSource;
            }
        }

        private void thietLapLopDayHocButton_Click(object sender, EventArgs e)
        {
            GUI_CreateTeachClass_Form form = new GUI_CreateTeachClass_Form();
            form.Show();
        }
    }
}
