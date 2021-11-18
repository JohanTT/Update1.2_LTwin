
namespace UITest.Forms
{
    partial class FormKiGui
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("Mã Giày");
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Mã khách hàng");
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("Mã nhân viên");
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("Tên khách hàng");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("Số điện thoại");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("Địa chỉ");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("Thời gian ký gửi");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("Đơn giá nhập");
            this.KyGuiList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // KyGuiList
            // 
            this.KyGuiList.HideSelection = false;
            this.KyGuiList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8});
            this.KyGuiList.Location = new System.Drawing.Point(0, 0);
            this.KyGuiList.Name = "KyGuiList";
            this.KyGuiList.Size = new System.Drawing.Size(1355, 432);
            this.KyGuiList.TabIndex = 1;
            this.KyGuiList.UseCompatibleStateImageBehavior = false;
            this.KyGuiList.View = System.Windows.Forms.View.Tile;
            this.KyGuiList.SelectedIndexChanged += new System.EventHandler(this.KyGuiList_SelectedIndexChanged);
            // 
            // FormKiGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 432);
            this.Controls.Add(this.KyGuiList);
            this.Name = "FormKiGui";
            this.Text = "FormKiGui";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView KyGuiList;
    }
}