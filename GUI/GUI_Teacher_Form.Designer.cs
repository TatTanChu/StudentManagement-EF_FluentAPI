
namespace GUI
{
    partial class GUI_Teacher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_Teacher_Form));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.ngaySinhTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.thayDoiMKButton = new System.Windows.Forms.Button();
            this.thayDoiButton = new System.Windows.Forms.Button();
            this.capNhatButton = new System.Windows.Forms.Button();
            this.huyButton = new System.Windows.Forms.Button();
            this.sdtTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.hoVaTenTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timKiemDataGridView = new System.Windows.Forms.DataGridView();
            this.StudentClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timKiemButton = new System.Windows.Forms.Button();
            this.timKiemTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timKiemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(736, 458);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gioiTinhComboBox);
            this.tabPage1.Controls.Add(this.ngaySinhTimePicker);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.thayDoiMKButton);
            this.tabPage1.Controls.Add(this.thayDoiButton);
            this.tabPage1.Controls.Add(this.capNhatButton);
            this.tabPage1.Controls.Add(this.huyButton);
            this.tabPage1.Controls.Add(this.sdtTextBox);
            this.tabPage1.Controls.Add(this.emailTextBox);
            this.tabPage1.Controls.Add(this.diaChiTextBox);
            this.tabPage1.Controls.Add(this.hoVaTenTextBox);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(728, 432);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin giáo viên";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gioiTinhComboBox
            // 
            this.gioiTinhComboBox.FormattingEnabled = true;
            this.gioiTinhComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ ",
            "Khác"});
            this.gioiTinhComboBox.Location = new System.Drawing.Point(217, 174);
            this.gioiTinhComboBox.Name = "gioiTinhComboBox";
            this.gioiTinhComboBox.Size = new System.Drawing.Size(121, 21);
            this.gioiTinhComboBox.TabIndex = 33;
            // 
            // ngaySinhTimePicker
            // 
            this.ngaySinhTimePicker.Location = new System.Drawing.Point(217, 129);
            this.ngaySinhTimePicker.Name = "ngaySinhTimePicker";
            this.ngaySinhTimePicker.Size = new System.Drawing.Size(240, 20);
            this.ngaySinhTimePicker.TabIndex = 32;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(512, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 269);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // thayDoiMKButton
            // 
            this.thayDoiMKButton.Location = new System.Drawing.Point(385, 381);
            this.thayDoiMKButton.Name = "thayDoiMKButton";
            this.thayDoiMKButton.Size = new System.Drawing.Size(119, 32);
            this.thayDoiMKButton.TabIndex = 30;
            this.thayDoiMKButton.Text = "Thay đổi mật khẩu";
            this.thayDoiMKButton.UseVisualStyleBackColor = true;
            this.thayDoiMKButton.Click += new System.EventHandler(this.thayDoiMKButton_Click);
            // 
            // thayDoiButton
            // 
            this.thayDoiButton.Location = new System.Drawing.Point(9, 381);
            this.thayDoiButton.Name = "thayDoiButton";
            this.thayDoiButton.Size = new System.Drawing.Size(119, 32);
            this.thayDoiButton.TabIndex = 29;
            this.thayDoiButton.Text = "Thay đổi thông tin";
            this.thayDoiButton.UseVisualStyleBackColor = true;
            this.thayDoiButton.Click += new System.EventHandler(this.thayDoiButton_Click);
            // 
            // capNhatButton
            // 
            this.capNhatButton.Location = new System.Drawing.Point(259, 381);
            this.capNhatButton.Name = "capNhatButton";
            this.capNhatButton.Size = new System.Drawing.Size(119, 32);
            this.capNhatButton.TabIndex = 28;
            this.capNhatButton.Text = "Cập nhật";
            this.capNhatButton.UseVisualStyleBackColor = true;
            this.capNhatButton.Click += new System.EventHandler(this.capNhatButton_Click);
            // 
            // huyButton
            // 
            this.huyButton.Location = new System.Drawing.Point(134, 381);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(119, 32);
            this.huyButton.TabIndex = 27;
            this.huyButton.Text = "Hủy thao tác";
            this.huyButton.UseVisualStyleBackColor = true;
            this.huyButton.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // sdtTextBox
            // 
            this.sdtTextBox.Location = new System.Drawing.Point(217, 323);
            this.sdtTextBox.Name = "sdtTextBox";
            this.sdtTextBox.Size = new System.Drawing.Size(240, 20);
            this.sdtTextBox.TabIndex = 26;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(217, 271);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(240, 20);
            this.emailTextBox.TabIndex = 25;
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Location = new System.Drawing.Point(217, 225);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(240, 20);
            this.diaChiTextBox.TabIndex = 24;
            // 
            // hoVaTenTextBox
            // 
            this.hoVaTenTextBox.Location = new System.Drawing.Point(217, 87);
            this.hoVaTenTextBox.Name = "hoVaTenTextBox";
            this.hoVaTenTextBox.Size = new System.Drawing.Size(240, 20);
            this.hoVaTenTextBox.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Số điện thoại :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Email công việc :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Thông tin địa chỉ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Giới tính  :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Ngày sinh :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Họ và tên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(392, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "mã số";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(204, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Mã số giáo viên :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(477, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "THÔNG TIN CÁ NHÂN CỦA GIÁO VIÊN ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.timKiemDataGridView);
            this.tabPage2.Controls.Add(this.timKiemButton);
            this.tabPage2.Controls.Add(this.timKiemTextBox);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(728, 432);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý sinh viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timKiemDataGridView
            // 
            this.timKiemDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.timKiemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timKiemDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentClass,
            this.SubjectID,
            this.SubjectName,
            this.Quantity});
            this.timKiemDataGridView.Location = new System.Drawing.Point(18, 92);
            this.timKiemDataGridView.Name = "timKiemDataGridView";
            this.timKiemDataGridView.Size = new System.Drawing.Size(686, 334);
            this.timKiemDataGridView.TabIndex = 29;
            this.timKiemDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timKiemDataGridView_CellContentClick);
            this.timKiemDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.timKiemDataGridView_CellContentClick);
            // 
            // StudentClass
            // 
            this.StudentClass.DataPropertyName = "StudentClass";
            this.StudentClass.HeaderText = "LỚP";
            this.StudentClass.Name = "StudentClass";
            // 
            // SubjectID
            // 
            this.SubjectID.DataPropertyName = "SubjectID";
            this.SubjectID.HeaderText = "MÃ MÔN HỌC";
            this.SubjectID.Name = "SubjectID";
            // 
            // SubjectName
            // 
            this.SubjectName.DataPropertyName = "SubjectName";
            this.SubjectName.HeaderText = "TÊN MÔN HỌC";
            this.SubjectName.Name = "SubjectName";
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "SỐ LƯỢNG";
            this.Quantity.Name = "Quantity";
            // 
            // timKiemButton
            // 
            this.timKiemButton.Location = new System.Drawing.Point(532, 54);
            this.timKiemButton.Name = "timKiemButton";
            this.timKiemButton.Size = new System.Drawing.Size(119, 32);
            this.timKiemButton.TabIndex = 28;
            this.timKiemButton.Text = "Tìm kiếm";
            this.timKiemButton.UseVisualStyleBackColor = true;
            this.timKiemButton.Click += new System.EventHandler(this.timKiemButton_Click);
            // 
            // timKiemTextBox
            // 
            this.timKiemTextBox.Location = new System.Drawing.Point(149, 61);
            this.timKiemTextBox.Name = "timKiemTextBox";
            this.timKiemTextBox.Size = new System.Drawing.Size(364, 20);
            this.timKiemTextBox.TabIndex = 22;
            this.timKiemTextBox.TextChanged += new System.EventHandler(this.timKiemTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 20);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tìm kiếm :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(225, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(288, 29);
            this.label10.TabIndex = 13;
            this.label10.Text = "DANH SÁCH LỚP HỌC ";
            // 
            // GUI_Teacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 482);
            this.Controls.Add(this.tabControl1);
            this.Name = "GUI_Teacher_Form";
            this.Text = "GUI_Teacher_Form";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timKiemDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sdtTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.TextBox hoVaTenTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button thayDoiMKButton;
        private System.Windows.Forms.Button thayDoiButton;
        private System.Windows.Forms.Button capNhatButton;
        private System.Windows.Forms.Button huyButton;
        private System.Windows.Forms.DataGridView timKiemDataGridView;
        private System.Windows.Forms.Button timKiemButton;
        private System.Windows.Forms.TextBox timKiemTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox gioiTinhComboBox;
        private System.Windows.Forms.DateTimePicker ngaySinhTimePicker;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
    }
}