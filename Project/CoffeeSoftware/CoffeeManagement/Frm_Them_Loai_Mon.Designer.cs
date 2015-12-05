namespace CoffeeManagement
{
    partial class Frm_Them_Loai_Mon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Them_Loai_Mon));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.btn_ThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.txt_TenLoaiMon = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenLoaiMon.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Tên Loại Món";
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemMoi.Image")));
            this.btn_ThemMoi.Location = new System.Drawing.Point(300, 10);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(89, 23);
            this.btn_ThemMoi.TabIndex = 1;
            this.btn_ThemMoi.Text = "THÊM MỚI";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // txt_TenLoaiMon
            // 
            this.txt_TenLoaiMon.Location = new System.Drawing.Point(82, 12);
            this.txt_TenLoaiMon.Name = "txt_TenLoaiMon";
            this.txt_TenLoaiMon.Size = new System.Drawing.Size(194, 20);
            this.txt_TenLoaiMon.TabIndex = 0;
            // 
            // Frm_Them_Loai_Mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 53);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.txt_TenLoaiMon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(419, 92);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(419, 92);
            this.Name = "Frm_Them_Loai_Mon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM LOẠI MÓN MỚI";
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenLoaiMon.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btn_ThemMoi;
        private DevExpress.XtraEditors.TextEdit txt_TenLoaiMon;
    }
}