
namespace GUI
{
    partial class GUI_InsertSubject_Form
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
            this.maMHTextBox = new System.Windows.Forms.TextBox();
            this.tenMHTextBox = new System.Windows.Forms.TextBox();
            this.themMHButton = new System.Windows.Forms.Button();
            this.huyThaoTacButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(12, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(465, 25);
            this.label12.TabIndex = 17;
            this.label12.Text = "NHẬP THÔNG TIN MÔN HỌC MUỐN THÊM";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 51);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "Mã môn học : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 86);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(127, 20);
            this.label18.TabIndex = 27;
            this.label18.Text = "Tên môn học : ";
            // 
            // maMHTextBox
            // 
            this.maMHTextBox.Location = new System.Drawing.Point(149, 53);
            this.maMHTextBox.Name = "maMHTextBox";
            this.maMHTextBox.Size = new System.Drawing.Size(196, 20);
            this.maMHTextBox.TabIndex = 28;
            // 
            // tenMHTextBox
            // 
            this.tenMHTextBox.Location = new System.Drawing.Point(149, 88);
            this.tenMHTextBox.Name = "tenMHTextBox";
            this.tenMHTextBox.Size = new System.Drawing.Size(196, 20);
            this.tenMHTextBox.TabIndex = 29;
            // 
            // themMHButton
            // 
            this.themMHButton.Location = new System.Drawing.Point(226, 117);
            this.themMHButton.Name = "themMHButton";
            this.themMHButton.Size = new System.Drawing.Size(119, 32);
            this.themMHButton.TabIndex = 41;
            this.themMHButton.Text = "Thêm môn học";
            this.themMHButton.UseVisualStyleBackColor = true;
            this.themMHButton.Click += new System.EventHandler(this.themMHButton_Click);
            // 
            // huyThaoTacButton
            // 
            this.huyThaoTacButton.Location = new System.Drawing.Point(358, 117);
            this.huyThaoTacButton.Name = "huyThaoTacButton";
            this.huyThaoTacButton.Size = new System.Drawing.Size(119, 32);
            this.huyThaoTacButton.TabIndex = 44;
            this.huyThaoTacButton.Text = "Hủy thao tác";
            this.huyThaoTacButton.UseVisualStyleBackColor = true;
            this.huyThaoTacButton.Click += new System.EventHandler(this.huyThaoTacButton_Click);
            // 
            // GUI_InsertSubject_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 161);
            this.Controls.Add(this.huyThaoTacButton);
            this.Controls.Add(this.themMHButton);
            this.Controls.Add(this.tenMHTextBox);
            this.Controls.Add(this.maMHTextBox);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Name = "GUI_InsertSubject_Form";
            this.Text = "GUI_InsertSubject_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox maMHTextBox;
        private System.Windows.Forms.TextBox tenMHTextBox;
        private System.Windows.Forms.Button themMHButton;
        private System.Windows.Forms.Button huyThaoTacButton;
    }
}