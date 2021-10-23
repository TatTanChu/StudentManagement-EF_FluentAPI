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
    public partial class GUI_CreateTeachClass_Form : Form
    {
        public GUI_CreateTeachClass_Form()
        {
            InitializeComponent();
            Visible();
        }

        public void Visible()
        {
            tenGiangVienTextBox.Enabled = false;
            tenMonHocTextBox.Enabled = false;

            BLL_Classes bll = new BLL_Classes();
            dynamic list = bll.showNameOfClassList();
            maLopComboBox.DataSource = list;
            maLopComboBox.DisplayMember = "Class";
            maLopComboBox.ValueMember = "Class";

            BLL_Subjects bll_1 = new BLL_Subjects();
            dynamic list_1 = bll_1.showIdOfSubjectList();
            maMHComboBox.DataSource = list_1;
            maMHComboBox.DisplayMember = "Subject";
            maMHComboBox.ValueMember = "Subject";

            BLL_Teacher bll_2 = new BLL_Teacher();
            dynamic list_2 = bll_2.showIdOfTeacherList();
            maGVComboBox.DataSource = list_2;
            maGVComboBox.DisplayMember = "Teacher";
            maGVComboBox.ValueMember = "Teacher";
        }

        private void huyThapTacButton_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("Bạn thật sự muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                maMHComboBox.Text = "";
                maGVComboBox.Text = "";
                maLopComboBox.Text = "";
            }
        }

        private void thietLapButton_Click(object sender, EventArgs e)
        {
            string subjectId = maGVComboBox.Text.ToString();
            string studentClass = maGVComboBox.Text.ToString();
            int teacherId = int.Parse(maGVComboBox.Text.ToString());
            BLL_TeachClass bll = new BLL_TeachClass();
            bll.createTeachClass(subjectId, teacherId, studentClass);
            MessageBox.Show("Đã tạo lớp học thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void maMHComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string subjectId = maMHComboBox.Text.ToString();
            BLL_Subjects bll = new BLL_Subjects();
            string subjectName = bll.showNameOfSubjectById(subjectId);
            tenMonHocTextBox.Text = subjectName;
        }

        private void maGVComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //String TeacherId = maGVComboBox.Text.ToString();
            //int teacherId = int.Parse(TeacherId);
            //BLL_Teacher bll = new BLL_Teacher();
            //string teacherName = bll.showNameOfTeacherById(teacherId);
            //tenGiangVienTextBox.Text = teacherName;
        }
    }
}
