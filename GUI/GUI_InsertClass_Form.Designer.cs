
namespace GUI
{
    partial class GUI_InsertClass_Form
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
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tenLopTextBox = new System.Windows.Forms.TextBox();
            this.soLuongTextBox = new System.Windows.Forms.TextBox();
            this.themLopButton = new System.Windows.Forms.Button();
            this.huyThaoTacButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(458, 25);
            this.label12.TabIndex = 16;
            this.label12.Text = "NHẬP THÔNG TIN LỚP HỌC MUỐN THÊM";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(38, 64);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(117, 20);
            this.label17.TabIndex = 19;
            this.label17.Text = "Tên lớp học : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(38, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(95, 20);
            this.label18.TabIndex = 26;
            this.label18.Text = "Số lượng : ";
            // 
            // tenLopTextBox
            // 
            this.tenLopTextBox.Location = new System.Drawing.Point(189, 66);
            this.tenLopTextBox.Name = "tenLopTextBox";
            this.tenLopTextBox.Size = new System.Drawing.Size(196, 20);
            this.tenLopTextBox.TabIndex = 27;
            // 
            // soLuongTextBox
            // 
            this.soLuongTextBox.Location = new System.Drawing.Point(189, 101);
            this.soLuongTextBox.Name = "soLuongTextBox";
            this.soLuongTextBox.Size = new System.Drawing.Size(196, 20);
            this.soLuongTextBox.TabIndex = 28;
            // 
            // themLopButton
            // 
            this.themLopButton.Location = new System.Drawing.Point(222, 143);
            this.themLopButton.Name = "themLopButton";
            this.themLopButton.Size = new System.Drawing.Size(119, 32);
            this.themLopButton.TabIndex = 40;
            this.themLopButton.Text = "Thêm lớp học";
            this.themLopButton.UseVisualStyleBackColor = true;
            this.themLopButton.Click += new System.EventHandler(this.themLopButton_Click);
            // 
            // huyThaoTacButton
            // 
            this.huyThaoTacButton.Location = new System.Drawing.Point(347, 143);
            this.huyThaoTacButton.Name = "huyThaoTacButton";
            this.huyThaoTacButton.Size = new System.Drawing.Size(119, 32);
            this.huyThaoTacButton.TabIndex = 43;
            this.huyThaoTacButton.Text = "Hủy thao tác";
            this.huyThaoTacButton.UseVisualStyleBackColor = true;
            this.huyThaoTacButton.Click += new System.EventHandler(this.huyThaoTacButton_Click);
            // 
            // GUI_InsertClass_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 187);
            this.Controls.Add(this.huyThaoTacButton);
            this.Controls.Add(this.themLopButton);
            this.Controls.Add(this.soLuongTextBox);
            this.Controls.Add(this.tenLopTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Name = "GUI_InsertClass_Form";
            this.Text = "GUI_InsertClass_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tenLopTextBox;
        private System.Windows.Forms.TextBox soLuongTextBox;
        private System.Windows.Forms.Button themLopButton;
        private System.Windows.Forms.Button huyThaoTacButton;
    }
}