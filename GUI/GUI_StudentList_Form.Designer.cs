
namespace GUI
{
    partial class GUI_StudentList_Form
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
            this.label10 = new System.Windows.Forms.Label();
            this.danhSachSVDataGridView = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhapDiemButton = new System.Windows.Forms.Button();
            this.luaDiemButton = new System.Windows.Forms.Button();
            this.khoaDiemButton = new System.Windows.Forms.Button();
            this.huyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSVDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(110, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(368, 29);
            this.label10.TabIndex = 14;
            this.label10.Text = "THÔNG TIN DANH SÁCH LỚP";
            // 
            // danhSachSVDataGridView
            // 
            this.danhSachSVDataGridView.AllowUserToOrderColumns = true;
            this.danhSachSVDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.danhSachSVDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.danhSachSVDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.StudentName,
            this.Gender,
            this.Email,
            this.Point});
            this.danhSachSVDataGridView.Location = new System.Drawing.Point(12, 57);
            this.danhSachSVDataGridView.Name = "danhSachSVDataGridView";
            this.danhSachSVDataGridView.Size = new System.Drawing.Size(522, 482);
            this.danhSachSVDataGridView.TabIndex = 15;
            // 
            // StudentID
            // 
            this.StudentID.DataPropertyName = "StudentID";
            this.StudentID.HeaderText = "MSSV";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            // 
            // StudentName
            // 
            this.StudentName.DataPropertyName = "StudentName";
            this.StudentName.HeaderText = "TênSV";
            this.StudentName.Name = "StudentName";
            this.StudentName.ReadOnly = true;
            // 
            // Gender
            // 
            this.Gender.DataPropertyName = "Gender";
            this.Gender.HeaderText = "Giới tính";
            this.Gender.Name = "Gender";
            this.Gender.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "Email";
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Point
            // 
            this.Point.DataPropertyName = "Point";
            this.Point.HeaderText = "Điểm";
            this.Point.Name = "Point";
            this.Point.ReadOnly = true;
            // 
            // nhapDiemButton
            // 
            this.nhapDiemButton.Location = new System.Drawing.Point(553, 57);
            this.nhapDiemButton.Name = "nhapDiemButton";
            this.nhapDiemButton.Size = new System.Drawing.Size(119, 32);
            this.nhapDiemButton.TabIndex = 32;
            this.nhapDiemButton.Text = "Nhập điểm";
            this.nhapDiemButton.UseVisualStyleBackColor = true;
            this.nhapDiemButton.Click += new System.EventHandler(this.nhapDiemButton_Click);
            // 
            // luaDiemButton
            // 
            this.luaDiemButton.Location = new System.Drawing.Point(553, 95);
            this.luaDiemButton.Name = "luaDiemButton";
            this.luaDiemButton.Size = new System.Drawing.Size(119, 32);
            this.luaDiemButton.TabIndex = 33;
            this.luaDiemButton.Text = "Lưu điểm";
            this.luaDiemButton.UseVisualStyleBackColor = true;
            this.luaDiemButton.Click += new System.EventHandler(this.luaDiemButton_Click);
            // 
            // khoaDiemButton
            // 
            this.khoaDiemButton.Location = new System.Drawing.Point(553, 133);
            this.khoaDiemButton.Name = "khoaDiemButton";
            this.khoaDiemButton.Size = new System.Drawing.Size(119, 32);
            this.khoaDiemButton.TabIndex = 34;
            this.khoaDiemButton.Text = "Khóa điểm";
            this.khoaDiemButton.UseVisualStyleBackColor = true;
            this.khoaDiemButton.Click += new System.EventHandler(this.khoaDiemButton_Click);
            // 
            // huyButton
            // 
            this.huyButton.Location = new System.Drawing.Point(553, 171);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(119, 32);
            this.huyButton.TabIndex = 35;
            this.huyButton.Text = "Hủy thao tác";
            this.huyButton.UseVisualStyleBackColor = true;
            this.huyButton.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // GUI_StudentList_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 551);
            this.Controls.Add(this.huyButton);
            this.Controls.Add(this.khoaDiemButton);
            this.Controls.Add(this.luaDiemButton);
            this.Controls.Add(this.nhapDiemButton);
            this.Controls.Add(this.danhSachSVDataGridView);
            this.Controls.Add(this.label10);
            this.Name = "GUI_StudentList_Form";
            this.Text = "GUI_StudentList_Form";
            ((System.ComponentModel.ISupportInitialize)(this.danhSachSVDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView danhSachSVDataGridView;
        private System.Windows.Forms.Button nhapDiemButton;
        private System.Windows.Forms.Button luaDiemButton;
        private System.Windows.Forms.Button khoaDiemButton;
        private System.Windows.Forms.Button huyButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Point;
    }
}