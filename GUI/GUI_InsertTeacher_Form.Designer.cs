
namespace GUI
{
    partial class GUI_InsertTeacher_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_InsertTeacher_Form));
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.msgvTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hoVaTenTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ngaySinhTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.gioiTinhComboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.themGVButton = new System.Windows.Forms.Button();
            this.huyButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(499, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "ĐIỀN THÔNG TIN ĐỂ THÊM GIẢNG VIÊN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Mã số giảng viên :";
            // 
            // msgvTextBox
            // 
            this.msgvTextBox.Location = new System.Drawing.Point(195, 283);
            this.msgvTextBox.Name = "msgvTextBox";
            this.msgvTextBox.Size = new System.Drawing.Size(272, 20);
            this.msgvTextBox.TabIndex = 48;
            this.msgvTextBox.TextChanged += new System.EventHandler(this.msgvTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Họ và tên :";
            // 
            // hoVaTenTextBox
            // 
            this.hoVaTenTextBox.Location = new System.Drawing.Point(195, 318);
            this.hoVaTenTextBox.Name = "hoVaTenTextBox";
            this.hoVaTenTextBox.Size = new System.Drawing.Size(272, 20);
            this.hoVaTenTextBox.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 357);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Ngày sinh :";
            // 
            // ngaySinhTimePicker
            // 
            this.ngaySinhTimePicker.Location = new System.Drawing.Point(195, 357);
            this.ngaySinhTimePicker.Name = "ngaySinhTimePicker";
            this.ngaySinhTimePicker.Size = new System.Drawing.Size(272, 20);
            this.ngaySinhTimePicker.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 397);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 53;
            this.label6.Text = "Giới tính  :";
            // 
            // gioiTinhComboBox
            // 
            this.gioiTinhComboBox.FormattingEnabled = true;
            this.gioiTinhComboBox.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.gioiTinhComboBox.Location = new System.Drawing.Point(195, 397);
            this.gioiTinhComboBox.Name = "gioiTinhComboBox";
            this.gioiTinhComboBox.Size = new System.Drawing.Size(121, 21);
            this.gioiTinhComboBox.TabIndex = 54;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(117, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 20);
            this.label7.TabIndex = 55;
            this.label7.Text = "Thông tin địa chỉ :";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.Location = new System.Drawing.Point(195, 440);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(181, 20);
            this.diaChiTextBox.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Email :";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(195, 482);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(215, 20);
            this.emailTextBox.TabIndex = 58;
            // 
            // themGVButton
            // 
            this.themGVButton.Location = new System.Drawing.Point(308, 568);
            this.themGVButton.Name = "themGVButton";
            this.themGVButton.Size = new System.Drawing.Size(102, 41);
            this.themGVButton.TabIndex = 59;
            this.themGVButton.Text = "Thêm giảng viên";
            this.themGVButton.UseVisualStyleBackColor = true;
            this.themGVButton.Click += new System.EventHandler(this.themGVButton_Click);
            // 
            // huyButton
            // 
            this.huyButton.Location = new System.Drawing.Point(416, 568);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(105, 41);
            this.huyButton.TabIndex = 60;
            this.huyButton.Text = "Hủy thao tác";
            this.huyButton.UseVisualStyleBackColor = true;
            this.huyButton.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 20);
            this.label8.TabIndex = 61;
            this.label8.Text = "Phone :";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(195, 521);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(240, 20);
            this.phoneTextBox.TabIndex = 62;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(416, 479);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 25);
            this.button1.TabIndex = 63;
            this.button1.Text = "Sài email cá nhân";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GUI_InsertTeacher_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.huyButton);
            this.Controls.Add(this.themGVButton);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.diaChiTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gioiTinhComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ngaySinhTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hoVaTenTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msgvTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Name = "GUI_InsertTeacher_Form";
            this.Text = "GUI_InsertTeacher_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox msgvTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hoVaTenTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker ngaySinhTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox gioiTinhComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button themGVButton;
        private System.Windows.Forms.Button huyButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Button button1;
    }
}