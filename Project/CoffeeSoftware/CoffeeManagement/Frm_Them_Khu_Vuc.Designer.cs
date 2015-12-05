namespace CoffeeManagement
{
    partial class Frm_Them_Khu_Vuc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Them_Khu_Vuc));
            this.txt_TenKhuVuc = new DevExpress.XtraEditors.TextEdit();
            this.btn_ThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKhuVuc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TenKhuVuc
            // 
            this.txt_TenKhuVuc.Location = new System.Drawing.Point(78, 28);
            this.txt_TenKhuVuc.Name = "txt_TenKhuVuc";
            this.txt_TenKhuVuc.Size = new System.Drawing.Size(194, 20);
            this.txt_TenKhuVuc.TabIndex = 0;
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemMoi.Image")));
            this.btn_ThemMoi.Location = new System.Drawing.Point(296, 26);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(89, 23);
            this.btn_ThemMoi.TabIndex = 1;
            this.btn_ThemMoi.Text = "THÊM MỚI";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Tên Khu Vực";
            // 
            // Frm_Them_Khu_Vuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 79);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.txt_TenKhuVuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 118);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(421, 118);
            this.Name = "Frm_Them_Khu_Vuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM KHU VỰC MỚI";
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKhuVuc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_TenKhuVuc;
        private DevExpress.XtraEditors.SimpleButton btn_ThemMoi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}