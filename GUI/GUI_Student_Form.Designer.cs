
namespace GUI
{
    partial class GUI_Student_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.gioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.ngaySinhTimePicker = new System.Windows.Forms.DateTimePicker();
            this.capNhatButton = new System.Windows.Forms.Button();
            this.huyButton = new System.Windows.Forms.Button();
            this.thayDoiButton = new System.Windows.Forms.Button();
            this.lopTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.hoVaTenTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.diemTBTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.danhSachDiemDataGridView = new System.Windows.Forms.DataGridView();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDiemDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(630, 396);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.gioiTinhComboBox);
            this.tabPage1.Controls.Add(this.ngaySinhTimePicker);
            this.tabPage1.Controls.Add(this.capNhatButton);
            this.tabPage1.Controls.Add(this.huyButton);
            this.tabPage1.Controls.Add(this.thayDoiButton);
            this.tabPage1.Controls.Add(this.lopTextBox);
            this.tabPage1.Controls.Add(this.emailTextBox);
            this.tabPage1.Controls.Add(this.diaChiTextBox);
            this.tabPage1.Controls.Add(this.hoVaTenTextBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(622, 370);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin sinh viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(287, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "label8";
            // 
            // gioiTinhComboBox
            // 
            this.gioiTinhComboBox.FormattingEnabled = true;
            this.gioiTinhComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.gioiTinhComboBox.Location = new System.Drawing.Point(173, 184);
            this.gioiTinhComboBox.Name = "gioiTinhComboBox";
            this.gioiTinhComboBox.Size = new System.Drawing.Size(121, 21);
            this.gioiTinhComboBox.TabIndex = 35;
            // 
            // ngaySinhTimePicker
            // 
            this.ngaySinhTimePicker.Location = new System.Drawing.Point(173, 135);
            this.ngaySinhTimePicker.Name = "ngaySinhTimePicker";
            this.ngaySinhTimePicker.Size = new System.Drawing.Size(240, 20);
            this.ngaySinhTimePicker.TabIndex = 34;
            // 
            // capNhatButton
            // 
            this.capNhatButton.Location = new System.Drawing.Point(468, 120);
            this.capNhatButton.Name = "capNhatButton";
            this.capNhatButton.Size = new System.Drawing.Size(119, 32);
            this.capNhatButton.TabIndex = 32;
            this.capNhatButton.Text = "Cập nhật";
            this.capNhatButton.UseVisualStyleBackColor = true;
            this.capNhatButton.Click += new System.EventHandler(this.capNhatButton_Click);
            // 
            // huyButton
            // 
            this.huyButton.Location = new System.Drawing.Point(468, 158);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(119, 32);
            this.huyButton.TabIndex = 31;
            this.huyButton.Text = "Hủy thao tác";
            this.huyButton.UseVisualStyleBackColor = true;
            this.huyButton.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // thayDoiButton
            // 
            this.thayDoiButton.Location = new System.Drawing.Point(468, 82);
            this.thayDoiButton.Name = "thayDoiButton";
            this.thayDoiButton.Size = new System.Drawing.Size(119, 32);
            this.thayDoiButton.TabIndex = 30;
            this.thayDoiButton.Text = "Thay đổi thông tin";
            this.thayDoiButton.UseVisualStyleBackColor = true;
            this.thayDoiButton.Click += new System.EventHandler(this.thayDoiButton_Click);
            // 
            // lopTextBox
            // 
            this.lopTextBox.Location = new System.Drawing.Point(173, 279);
            this.lopTextBox.Name = "lopTextBox";
            this.lopTextBox.Size = new System.Drawing.Size(73, 20);
            this.lopTextBox.TabIndex = 28;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(173, 323);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(240, 20);
            this.emailTextBox.TabIndex = 27;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Location = new System.Drawing.Point(173, 231);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(240, 20);
            this.diaChiTextBox.TabIndex = 26;
            // 
            // hoVaTenTextBox
            // 
            this.hoVaTenTextBox.Location = new System.Drawing.Point(173, 89);
            this.hoVaTenTextBox.Name = "hoVaTenTextBox";
            this.hoVaTenTextBox.Size = new System.Drawing.Size(240, 20);
            this.hoVaTenTextBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 323);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Email :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 277);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Lớp :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Thông tin địa chỉ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Giới tính  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ngày sinh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "Họ và tên :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã số sinh viên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(476, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "THÔNG TIN CÁ NHÂN CỦA SINH VIÊN ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.diemTBTextBox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.danhSachDiemDataGridView);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(622, 370);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Xem điểm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // diemTBTextBox
            // 
            this.diemTBTextBox.Enabled = false;
            this.diemTBTextBox.Location = new System.Drawing.Point(494, 338);
            this.diemTBTextBox.Name = "diemTBTextBox";
            this.diemTBTextBox.Size = new System.Drawing.Size(122, 20);
            this.diemTBTextBox.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(342, 336);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Điểm trung bình :";
            // 
            // danhSachDiemDataGridView
            // 
            this.danhSachDiemDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.danhSachDiemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachDiemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectName,
            this.SubjectID,
            this.Point});
            this.danhSachDiemDataGridView.Location = new System.Drawing.Point(6, 35);
            this.danhSachDiemDataGridView.Name = "danhSachDiemDataGridView";
            this.danhSachDiemDataGridView.Size = new System.Drawing.Size(610, 289);
            this.danhSachDiemDataGridView.TabIndex = 15;
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "Tên môn học";
            this.SubjectName.Name = "SubjectName";
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "SubjectID";
            this.SubjectID.HeaderText = "Mã môn học";
            this.SubjectID.Name = "SubjectID";
            // 
            // Point
            // 
            this.Point.DataPropertyName = "Point";
            this.Point.HeaderText = "Điểm trung bình";
            this.Point.Name = "Point";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(269, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "BẢNG ĐIỂM CHI TIẾT";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(622, 370);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Thông tin tài khoản";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.OIP;
            this.pictureBox1.Location = new System.Drawing.Point(209, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(162, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(300, 29);
            this.label12.TabIndex = 14;
            this.label12.Text = "THÔNG TIN TÀI KHOẢN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(163, 233);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Tên tài khoản :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(360, 238);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(163, 265);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 20);
            this.label15.TabIndex = 38;
            this.label15.Text = "Trạng thái :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(360, 270);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 39;
            this.label16.Text = "label16";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(243, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 53);
            this.button1.TabIndex = 40;
            this.button1.Text = "Thay đổi mật khẩu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_Student_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 420);
            this.Controls.Add(this.tabControl1);
            this.Name = "GUI_Student_Form";
            this.Text = "GUI_Student_Form";
            this.Load += new System.EventHandler(this.GUI_Student_Form_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachDiemDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hoVaTenTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lopTextBox;
        private System.Windows.Forms.Button thayDoiButton;
        private System.Windows.Forms.Button huyButton;
        private System.Windows.Forms.Button capNhatButton;
        private System.Windows.Forms.DateTimePicker ngaySinhTimePicker;
        private System.Windows.Forms.ComboBox gioiTinhComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox diemTBTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView danhSachDiemDataGridView;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
    }
}