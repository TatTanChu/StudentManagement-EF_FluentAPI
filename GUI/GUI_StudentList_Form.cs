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
    public partial class GUI_StudentList_Form : Form
    {
        public GUI_StudentList_Form(string StudentClass, string SubjectId)
        {
            this.StudentClass = StudentClass;
            this.SubjectId = SubjectId;
            InitializeComponent();
            Visible();
        }

        private string studentClass;

        private string subjectId;

        public string StudentClass
        {
            get
            {
                return studentClass;
            }
            set
            {
                studentClass = value;
            }
        }

        public string SubjectId
        {
            get
            {
                return subjectId;
            }
            set
            {
                subjectId = value;
            }
        }

        public void Visible()
        {
            BLL_Student bll = new BLL_Student();
            dynamic studentList = bll.showStudentList(studentClass, subjectId);
            danhSachSVDataGridView.DataSource = studentList;
            luaDiemButton.Enabled = false;
            huyButton.Enabled = false;
            khoaDiemButton.Enabled = false;

            BLL_Points bll_1 = new BLL_Points();
            if (bll_1.checkPoint(subjectId, studentClass))
            {
                khoaDiemButton.Enabled = false;
                luaDiemButton.Enabled = false;
                nhapDiemButton.Enabled = false;
            }
        }

        private void nhapDiemButton_Click(object sender, EventArgs e)
        {
            danhSachSVDataGridView.Enabled = true;
            danhSachSVDataGridView.Columns[0].ReadOnly = true;
            danhSachSVDataGridView.Columns[1].ReadOnly = true;
            danhSachSVDataGridView.Columns[2].ReadOnly = true;
            danhSachSVDataGridView.Columns[3].ReadOnly = true;
            luaDiemButton.Enabled = true;
            khoaDiemButton.Enabled = true;
            huyButton.Enabled = true;
        }

        private void luaDiemButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn thật sự cập điểm cho sinh viên ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                BLL_Points bll = new BLL_Points();
                for (int i = 0; i < danhSachSVDataGridView.Rows.Count; i++)
                {
                    bll.updatePoint(subjectId, int.Parse(danhSachSVDataGridView.Rows[i].Cells[0].Value.ToString()),
                        (float)Convert.ToDouble(danhSachSVDataGridView.Rows[i].Cells[4].Value.ToString()));
                }
                MessageBox.Show("Điểm của sinh viên đã được cập nhật !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                luaDiemButton.Enabled = false;
                huyButton.Enabled = false;
            }
        }

        private void khoaDiemButton_Click(object sender, EventArgs e)
        {
            BLL_Points bll = new BLL_Points();
            DialogResult result;
            result = MessageBox.Show("Sau khi khóa điểm sẽ không được sửa lại bạn chắc chắn muốn thực hiện thao tác này ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                bll.blockPoint(subjectId, studentClass);
                khoaDiemButton.Enabled = false;
                luaDiemButton.Enabled = false;
                nhapDiemButton.Enabled = false;
                huyButton.Enabled = false;
            }
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Bạn muốn hủy thao tác ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                khoaDiemButton.Enabled = false;
                luaDiemButton.Enabled = false;
                huyButton.Enabled = false;
            }
        }
    }
}
