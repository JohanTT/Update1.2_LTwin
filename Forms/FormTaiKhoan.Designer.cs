
namespace UITest.Forms
{
    partial class FormTaiKhoan
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
            this.label1 = new System.Windows.Forms.Label();
            this.MaKhachHangtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TenKhachHangtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SoDienThoaitxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DiaChitxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.NgaySinhtxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.GioiTinhtxt = new System.Windows.Forms.TextBox();
            this.TimTaiKhoanbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // MaKhachHangtxt
            // 
            this.MaKhachHangtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaKhachHangtxt.Location = new System.Drawing.Point(264, 12);
            this.MaKhachHangtxt.Name = "MaKhachHangtxt";
            this.MaKhachHangtxt.Size = new System.Drawing.Size(242, 26);
            this.MaKhachHangtxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // TenKhachHangtxt
            // 
            this.TenKhachHangtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TenKhachHangtxt.Location = new System.Drawing.Point(152, 76);
            this.TenKhachHangtxt.Name = "TenKhachHangtxt";
            this.TenKhachHangtxt.ReadOnly = true;
            this.TenKhachHangtxt.Size = new System.Drawing.Size(242, 26);
            this.TenKhachHangtxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Số Điện Thoại";
            // 
            // SoDienThoaitxt
            // 
            this.SoDienThoaitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoDienThoaitxt.Location = new System.Drawing.Point(152, 128);
            this.SoDienThoaitxt.Name = "SoDienThoaitxt";
            this.SoDienThoaitxt.ReadOnly = true;
            this.SoDienThoaitxt.Size = new System.Drawing.Size(242, 26);
            this.SoDienThoaitxt.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Địa Chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // DiaChitxt
            // 
            this.DiaChitxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiaChitxt.Location = new System.Drawing.Point(152, 185);
            this.DiaChitxt.Name = "DiaChitxt";
            this.DiaChitxt.ReadOnly = true;
            this.DiaChitxt.Size = new System.Drawing.Size(242, 26);
            this.DiaChitxt.TabIndex = 1;
            this.DiaChitxt.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ngày Sinh";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // NgaySinhtxt
            // 
            this.NgaySinhtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NgaySinhtxt.Location = new System.Drawing.Point(152, 240);
            this.NgaySinhtxt.Name = "NgaySinhtxt";
            this.NgaySinhtxt.ReadOnly = true;
            this.NgaySinhtxt.Size = new System.Drawing.Size(242, 26);
            this.NgaySinhtxt.TabIndex = 1;
            this.NgaySinhtxt.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giới Tính";
            // 
            // GioiTinhtxt
            // 
            this.GioiTinhtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GioiTinhtxt.Location = new System.Drawing.Point(152, 292);
            this.GioiTinhtxt.Name = "GioiTinhtxt";
            this.GioiTinhtxt.ReadOnly = true;
            this.GioiTinhtxt.Size = new System.Drawing.Size(242, 26);
            this.GioiTinhtxt.TabIndex = 1;
            // 
            // TimTaiKhoanbt
            // 
            this.TimTaiKhoanbt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimTaiKhoanbt.Location = new System.Drawing.Point(529, 44);
            this.TimTaiKhoanbt.Name = "TimTaiKhoanbt";
            this.TimTaiKhoanbt.Size = new System.Drawing.Size(71, 31);
            this.TimTaiKhoanbt.TabIndex = 2;
            this.TimTaiKhoanbt.Text = "Tìm";
            this.TimTaiKhoanbt.UseVisualStyleBackColor = true;
            this.TimTaiKhoanbt.Click += new System.EventHandler(this.TimTaiKhoanbt_Click);
            // 
            // FormTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TimTaiKhoanbt);
            this.Controls.Add(this.GioiTinhtxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NgaySinhtxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DiaChitxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SoDienThoaitxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TenKhachHangtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaKhachHangtxt);
            this.Controls.Add(this.label1);
            this.Name = "FormTaiKhoan";
            this.Text = "FormTaiKhoan";
            this.Load += new System.EventHandler(this.FormTaiKhoan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MaKhachHangtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TenKhachHangtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SoDienThoaitxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DiaChitxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NgaySinhtxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox GioiTinhtxt;
        private System.Windows.Forms.Button TimTaiKhoanbt;
    }
}