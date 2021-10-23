
namespace GUI
{
    partial class GUI_CreateTeachClass_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_CreateTeachClass_Form));
            this.label27 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maMHComboBox = new System.Windows.Forms.ComboBox();
            this.maGVComboBox = new System.Windows.Forms.ComboBox();
            this.maLopComboBox = new System.Windows.Forms.ComboBox();
            this.tenMonHocTextBox = new System.Windows.Forms.TextBox();
            this.tenGiangVienTextBox = new System.Windows.Forms.TextBox();
            this.thietLapButton = new System.Windows.Forms.Button();
            this.huyThapTacButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(210, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(289, 25);
            this.label27.TabIndex = 17;
            this.label27.Text = "THIẾT LẬP LỚP DẠY HỌC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(190, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 217);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(32, 270);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(116, 20);
            this.label37.TabIndex = 51;
            this.label37.Text = "Mã môn học :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Mã giảng viên :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "Mã lớp học :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(399, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 54;
            this.label3.Text = "Tên môn học :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(399, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 55;
            this.label4.Text = "Tên giảng viên :";
            // 
            // maMHComboBox
            // 
            this.maMHComboBox.FormattingEnabled = true;
            this.maMHComboBox.Location = new System.Drawing.Point(170, 269);
            this.maMHComboBox.Name = "maMHComboBox";
            this.maMHComboBox.Size = new System.Drawing.Size(189, 21);
            this.maMHComboBox.TabIndex = 56;
            this.maMHComboBox.SelectedIndexChanged += new System.EventHandler(this.maMHComboBox_SelectedIndexChanged);
            // 
            // maGVComboBox
            // 
            this.maGVComboBox.FormattingEnabled = true;
            this.maGVComboBox.Location = new System.Drawing.Point(170, 305);
            this.maGVComboBox.Name = "maGVComboBox";
            this.maGVComboBox.Size = new System.Drawing.Size(189, 21);
            this.maGVComboBox.TabIndex = 57;
            this.maGVComboBox.SelectedIndexChanged += new System.EventHandler(this.maGVComboBox_SelectedIndexChanged);
            // 
            // maLopComboBox
            // 
            this.maLopComboBox.FormattingEnabled = true;
            this.maLopComboBox.Location = new System.Drawing.Point(170, 341);
            this.maLopComboBox.Name = "maLopComboBox";
            this.maLopComboBox.Size = new System.Drawing.Size(189, 21);
            this.maLopComboBox.TabIndex = 58;
            // 
            // tenMonHocTextBox
            // 
            this.tenMonHocTextBox.Location = new System.Drawing.Point(534, 267);
            this.tenMonHocTextBox.Name = "tenMonHocTextBox";
            this.tenMonHocTextBox.Size = new System.Drawing.Size(184, 20);
            this.tenMonHocTextBox.TabIndex = 59;
            // 
            // tenGiangVienTextBox
            // 
            this.tenGiangVienTextBox.Location = new System.Drawing.Point(534, 305);
            this.tenGiangVienTextBox.Name = "tenGiangVienTextBox";
            this.tenGiangVienTextBox.Size = new System.Drawing.Size(184, 20);
            this.tenGiangVienTextBox.TabIndex = 60;
            // 
            // thietLapButton
            // 
            this.thietLapButton.Location = new System.Drawing.Point(470, 379);
            this.thietLapButton.Name = "thietLapButton";
            this.thietLapButton.Size = new System.Drawing.Size(121, 44);
            this.thietLapButton.TabIndex = 61;
            this.thietLapButton.Text = "Thiết lập lớp học";
            this.thietLapButton.UseVisualStyleBackColor = true;
            this.thietLapButton.Click += new System.EventHandler(this.thietLapButton_Click);
            // 
            // huyThapTacButton
            // 
            this.huyThapTacButton.Location = new System.Drawing.Point(597, 379);
            this.huyThapTacButton.Name = "huyThapTacButton";
            this.huyThapTacButton.Size = new System.Drawing.Size(121, 44);
            this.huyThapTacButton.TabIndex = 62;
            this.huyThapTacButton.Text = "Hủy thao tác";
            this.huyThapTacButton.UseVisualStyleBackColor = true;
            this.huyThapTacButton.Click += new System.EventHandler(this.huyThapTacButton_Click);
            // 
            // GUI_CreateTeachClass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.huyThapTacButton);
            this.Controls.Add(this.thietLapButton);
            this.Controls.Add(this.tenGiangVienTextBox);
            this.Controls.Add(this.tenMonHocTextBox);
            this.Controls.Add(this.maLopComboBox);
            this.Controls.Add(this.maGVComboBox);
            this.Controls.Add(this.maMHComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label27);
            this.Name = "GUI_CreateTeachClass_Form";
            this.Text = "GUI_CreateTeachClass_Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox maMHComboBox;
        private System.Windows.Forms.ComboBox maGVComboBox;
        private System.Windows.Forms.ComboBox maLopComboBox;
        private System.Windows.Forms.TextBox tenMonHocTextBox;
        private System.Windows.Forms.TextBox tenGiangVienTextBox;
        private System.Windows.Forms.Button thietLapButton;
        private System.Windows.Forms.Button huyThapTacButton;
    }
}