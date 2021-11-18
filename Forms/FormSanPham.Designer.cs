
namespace UITest.Forms
{
    partial class FormSanPham
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
            this.MatHangList = new System.Windows.Forms.ListView();
            this.MaGiayCl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TenGiayCl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuongCl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MauSacCl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SizeCl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DonGiaCl = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MatHangList
            // 
            this.MatHangList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MaGiayCl,
            this.TenGiayCl,
            this.SoLuongCl,
            this.MauSacCl,
            this.SizeCl,
            this.DonGiaCl});
            this.MatHangList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MatHangList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MatHangList.HideSelection = false;
            this.MatHangList.Location = new System.Drawing.Point(0, 0);
            this.MatHangList.Name = "MatHangList";
            this.MatHangList.Size = new System.Drawing.Size(1334, 608);
            this.MatHangList.TabIndex = 0;
            this.MatHangList.UseCompatibleStateImageBehavior = false;
            this.MatHangList.View = System.Windows.Forms.View.Details;
            this.MatHangList.SelectedIndexChanged += new System.EventHandler(this.MatHangList_SelectedIndexChanged);
            // 
            // MaGiayCl
            // 
            this.MaGiayCl.Text = "Mã Giày";
            this.MaGiayCl.Width = 131;
            // 
            // TenGiayCl
            // 
            this.TenGiayCl.Text = "Tên Giày";
            this.TenGiayCl.Width = 298;
            // 
            // SoLuongCl
            // 
            this.SoLuongCl.Text = "Số Lượng";
            this.SoLuongCl.Width = 158;
            // 
            // MauSacCl
            // 
            this.MauSacCl.Text = "Màu Sắc";
            this.MauSacCl.Width = 245;
            // 
            // SizeCl
            // 
            this.SizeCl.Text = "Size";
            this.SizeCl.Width = 111;
            // 
            // DonGiaCl
            // 
            this.DonGiaCl.Text = "Đơn Giá Bán";
            this.DonGiaCl.Width = 150;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gray;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1334, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 608);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MatHangList);
            this.Name = "FormSanPham";
            this.Text = "FormSanPham";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView MatHangList;
        private System.Windows.Forms.ColumnHeader MaGiayCl;
        private System.Windows.Forms.ColumnHeader TenGiayCl;
        private System.Windows.Forms.ColumnHeader SoLuongCl;
        private System.Windows.Forms.ColumnHeader MauSacCl;
        private System.Windows.Forms.ColumnHeader SizeCl;
        private System.Windows.Forms.ColumnHeader DonGiaCl;
        private System.Windows.Forms.Button button1;
    }
}