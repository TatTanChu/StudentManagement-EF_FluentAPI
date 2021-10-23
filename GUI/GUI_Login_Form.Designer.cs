
namespace GUI
{
    partial class GUI_Login_Form
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
            this.matKhauTextBox = new System.Windows.Forms.TextBox();
            this.tenDangNhapTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sinhVienRadioButton = new System.Windows.Forms.RadioButton();
            this.giangVienRadioButton = new System.Windows.Forms.RadioButton();
            this.dangNhapButton = new System.Windows.Forms.Button();
            this.huyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // matKhauTextBox
            // 
            this.matKhauTextBox.Location = new System.Drawing.Point(227, 131);
            this.matKhauTextBox.Name = "matKhauTextBox";
            this.matKhauTextBox.PasswordChar = '*';
            this.matKhauTextBox.Size = new System.Drawing.Size(240, 20);
            this.matKhauTextBox.TabIndex = 1;
            // 
            // tenDangNhapTextBox
            // 
            this.tenDangNhapTextBox.Location = new System.Drawing.Point(227, 83);
            this.tenDangNhapTextBox.Name = "tenDangNhapTextBox";
            this.tenDangNhapTextBox.Size = new System.Drawing.Size(240, 20);
            this.tenDangNhapTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bạn đăng nhập với vai trò :";
            // 
            // sinhVienRadioButton
            // 
            this.sinhVienRadioButton.AutoSize = true;
            this.sinhVienRadioButton.Location = new System.Drawing.Point(241, 175);
            this.sinhVienRadioButton.Name = "sinhVienRadioButton";
            this.sinhVienRadioButton.Size = new System.Drawing.Size(69, 17);
            this.sinhVienRadioButton.TabIndex = 6;
            this.sinhVienRadioButton.TabStop = true;
            this.sinhVienRadioButton.Text = "Sinh viên";
            this.sinhVienRadioButton.UseVisualStyleBackColor = true;
            // 
            // giangVienRadioButton
            // 
            this.giangVienRadioButton.AutoSize = true;
            this.giangVienRadioButton.Location = new System.Drawing.Point(353, 175);
            this.giangVienRadioButton.Name = "giangVienRadioButton";
            this.giangVienRadioButton.Size = new System.Drawing.Size(76, 17);
            this.giangVienRadioButton.TabIndex = 7;
            this.giangVienRadioButton.TabStop = true;
            this.giangVienRadioButton.Text = "Giảng viên";
            this.giangVienRadioButton.UseVisualStyleBackColor = true;
            // 
            // dangNhapButton
            // 
            this.dangNhapButton.Location = new System.Drawing.Point(257, 230);
            this.dangNhapButton.Name = "dangNhapButton";
            this.dangNhapButton.Size = new System.Drawing.Size(94, 32);
            this.dangNhapButton.TabIndex = 8;
            this.dangNhapButton.Text = "Đăng nhập";
            this.dangNhapButton.UseVisualStyleBackColor = true;
            this.dangNhapButton.Click += new System.EventHandler(this.dangNhapButton_Click);
            // 
            // huyButton
            // 
            this.huyButton.Location = new System.Drawing.Point(373, 230);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(94, 32);
            this.huyButton.TabIndex = 9;
            this.huyButton.Text = "Hủy";
            this.huyButton.UseVisualStyleBackColor = true;
            this.huyButton.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(258, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "TRANG ĐĂNG NHẬP";
            // 
            // GUI_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 284);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.huyButton);
            this.Controls.Add(this.dangNhapButton);
            this.Controls.Add(this.giangVienRadioButton);
            this.Controls.Add(this.sinhVienRadioButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tenDangNhapTextBox);
            this.Controls.Add(this.matKhauTextBox);
            this.Name = "GUI_Login_Form";
            this.Text = "GUI_Login_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox matKhauTextBox;
        private System.Windows.Forms.TextBox tenDangNhapTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton sinhVienRadioButton;
        private System.Windows.Forms.RadioButton giangVienRadioButton;
        private System.Windows.Forms.Button dangNhapButton;
        private System.Windows.Forms.Button huyButton;
        private System.Windows.Forms.Label label4;
    }
}