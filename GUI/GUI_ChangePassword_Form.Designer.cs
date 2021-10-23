
namespace GUI
{
    partial class GUI_ChangePassword_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_ChangePassword_Form));
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mkHienTaiTextBox = new System.Windows.Forms.TextBox();
            this.mkMoiTextBox = new System.Windows.Forms.TextBox();
            this.nhapLaiMKTextBox = new System.Windows.Forms.TextBox();
            this.capNhatButton = new System.Windows.Forms.Button();
            this.huyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 29);
            this.label4.TabIndex = 13;
            this.label4.Text = "THAY ĐỔI THÔNG TIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Mật khẩu hiện tại :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Mật khẩu mới :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nhập lại mật khẩu :";
            // 
            // mkHienTaiTextBox
            // 
            this.mkHienTaiTextBox.Location = new System.Drawing.Point(171, 183);
            this.mkHienTaiTextBox.Name = "mkHienTaiTextBox";
            this.mkHienTaiTextBox.Size = new System.Drawing.Size(148, 20);
            this.mkHienTaiTextBox.TabIndex = 22;
            // 
            // mkMoiTextBox
            // 
            this.mkMoiTextBox.Location = new System.Drawing.Point(171, 218);
            this.mkMoiTextBox.Name = "mkMoiTextBox";
            this.mkMoiTextBox.Size = new System.Drawing.Size(148, 20);
            this.mkMoiTextBox.TabIndex = 23;
            // 
            // nhapLaiMKTextBox
            // 
            this.nhapLaiMKTextBox.Location = new System.Drawing.Point(171, 252);
            this.nhapLaiMKTextBox.Name = "nhapLaiMKTextBox";
            this.nhapLaiMKTextBox.Size = new System.Drawing.Size(148, 20);
            this.nhapLaiMKTextBox.TabIndex = 24;
            // 
            // capNhatButton
            // 
            this.capNhatButton.Location = new System.Drawing.Point(143, 298);
            this.capNhatButton.Name = "capNhatButton";
            this.capNhatButton.Size = new System.Drawing.Size(81, 25);
            this.capNhatButton.TabIndex = 29;
            this.capNhatButton.Text = "Cập nhật";
            this.capNhatButton.UseVisualStyleBackColor = true;
            this.capNhatButton.Click += new System.EventHandler(this.capNhatButton_Click);
            // 
            // huyButton
            // 
            this.huyButton.Location = new System.Drawing.Point(238, 298);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(81, 25);
            this.huyButton.TabIndex = 30;
            this.huyButton.Text = "Hủy thao tác";
            this.huyButton.UseVisualStyleBackColor = true;
            this.huyButton.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // GUI_ChangePassword_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 328);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.huyButton);
            this.Controls.Add(this.capNhatButton);
            this.Controls.Add(this.nhapLaiMKTextBox);
            this.Controls.Add(this.mkMoiTextBox);
            this.Controls.Add(this.mkHienTaiTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Name = "GUI_ChangePassword_Form";
            this.Text = "GUI_ChangePassword_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mkHienTaiTextBox;
        private System.Windows.Forms.TextBox mkMoiTextBox;
        private System.Windows.Forms.TextBox nhapLaiMKTextBox;
        private System.Windows.Forms.Button capNhatButton;
        private System.Windows.Forms.Button huyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}