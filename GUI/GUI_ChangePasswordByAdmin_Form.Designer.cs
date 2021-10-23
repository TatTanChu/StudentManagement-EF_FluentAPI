
namespace GUI
{
    partial class GUI_ChangePasswordByAdmin_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ChangePasswordByAdmin_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mkMoiTextBox = new System.Windows.Forms.TextBox();
            this.nhapLaiMKTextBox = new System.Windows.Forms.TextBox();
            this.capNhatButton = new System.Windows.Forms.Button();
            this.huyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(33, 231);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(394, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "THAY ĐỔI MẬT KHẨU NGƯỜI DÙNG";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mật khẩu mới :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nhập lại mật khẩu :";
            // 
            // mkMoiTextBox
            // 
            this.mkMoiTextBox.Location = new System.Drawing.Point(221, 275);
            this.mkMoiTextBox.Name = "mkMoiTextBox";
            this.mkMoiTextBox.Size = new System.Drawing.Size(187, 20);
            this.mkMoiTextBox.TabIndex = 24;
            // 
            // nhapLaiMKTextBox
            // 
            this.nhapLaiMKTextBox.Location = new System.Drawing.Point(221, 309);
            this.nhapLaiMKTextBox.Name = "nhapLaiMKTextBox";
            this.nhapLaiMKTextBox.Size = new System.Drawing.Size(187, 20);
            this.nhapLaiMKTextBox.TabIndex = 25;
            // 
            // capNhatButton
            // 
            this.capNhatButton.Location = new System.Drawing.Point(221, 350);
            this.capNhatButton.Name = "capNhatButton";
            this.capNhatButton.Size = new System.Drawing.Size(88, 25);
            this.capNhatButton.TabIndex = 30;
            this.capNhatButton.Text = "Cập nhật";
            this.capNhatButton.UseVisualStyleBackColor = true;
            this.capNhatButton.Click += new System.EventHandler(this.capNhatButton_Click);
            // 
            // huyButton
            // 
            this.huyButton.Location = new System.Drawing.Point(315, 350);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(93, 25);
            this.huyButton.TabIndex = 31;
            this.huyButton.Text = "Hủy thao tác";
            this.huyButton.UseVisualStyleBackColor = true;
            this.huyButton.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // GUI_ChangePasswordByAdmin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 398);
            this.Controls.Add(this.huyButton);
            this.Controls.Add(this.capNhatButton);
            this.Controls.Add(this.nhapLaiMKTextBox);
            this.Controls.Add(this.mkMoiTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GUI_ChangePasswordByAdmin_Form";
            this.Text = "GUI_ChangePasswordByAdmin_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mkMoiTextBox;
        private System.Windows.Forms.TextBox nhapLaiMKTextBox;
        private System.Windows.Forms.Button capNhatButton;
        private System.Windows.Forms.Button huyButton;
    }
}