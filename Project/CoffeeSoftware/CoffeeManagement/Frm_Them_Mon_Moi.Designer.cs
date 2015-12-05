namespace CoffeeManagement
{
    partial class Frm_Them_Mon_Moi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Them_Mon_Moi));
            DevExpress.Utils.TrackBarContextButton trackBarContextButton1 = new DevExpress.Utils.TrackBarContextButton();
            this.lkup_Loai_Mon = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_Ten_Mon = new System.Windows.Forms.TextBox();
            this.spin_Gia_Ban = new DevExpress.XtraEditors.SpinEdit();
            this.pic_Hinh_Anh = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Them_Moi = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lkup_Loai_Mon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Gia_Ban.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hinh_Anh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lkup_Loai_Mon
            // 
            this.lkup_Loai_Mon.Location = new System.Drawing.Point(226, 14);
            this.lkup_Loai_Mon.Name = "lkup_Loai_Mon";
            this.lkup_Loai_Mon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkup_Loai_Mon.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_Loai_Mon", "LOẠI MÓN")});
            this.lkup_Loai_Mon.Properties.NullText = "[Chọn loại món]";
            this.lkup_Loai_Mon.Size = new System.Drawing.Size(222, 20);
            this.lkup_Loai_Mon.TabIndex = 0;
            // 
            // txt_Ten_Mon
            // 
            this.txt_Ten_Mon.Location = new System.Drawing.Point(226, 47);
            this.txt_Ten_Mon.Name = "txt_Ten_Mon";
            this.txt_Ten_Mon.Size = new System.Drawing.Size(222, 20);
            this.txt_Ten_Mon.TabIndex = 1;
            // 
            // spin_Gia_Ban
            // 
            this.spin_Gia_Ban.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spin_Gia_Ban.Location = new System.Drawing.Point(226, 81);
            this.spin_Gia_Ban.Name = "spin_Gia_Ban";
            this.spin_Gia_Ban.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_Gia_Ban.Size = new System.Drawing.Size(222, 20);
            this.spin_Gia_Ban.TabIndex = 2;
            // 
            // pic_Hinh_Anh
            // 
            this.pic_Hinh_Anh.EditValue = ((object)(resources.GetObject("pic_Hinh_Anh.EditValue")));
            this.pic_Hinh_Anh.Location = new System.Drawing.Point(12, 12);
            this.pic_Hinh_Anh.Name = "pic_Hinh_Anh";
            trackBarContextButton1.Id = new System.Guid("ef0fe37a-02b4-480b-a7a3-e3bf9a5f5e18");
            trackBarContextButton1.Maximum = 500;
            trackBarContextButton1.Middle = 100;
            trackBarContextButton1.Name = "TrackBarContextButton";
            trackBarContextButton1.Visibility = DevExpress.Utils.ContextItemVisibility.Visible;
            this.pic_Hinh_Anh.Properties.ContextButtons.Add(trackBarContextButton1);
            this.pic_Hinh_Anh.Properties.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureEdit1.Properties.InitialImage")));
            this.pic_Hinh_Anh.Properties.NullText = "Hình Ảnh";
            this.pic_Hinh_Anh.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pic_Hinh_Anh.Size = new System.Drawing.Size(119, 121);
            this.pic_Hinh_Anh.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(150, 17);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(42, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Loại Món";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(150, 50);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Tên Món";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(150, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Giá Bán";
            // 
            // btn_Them_Moi
            // 
            this.btn_Them_Moi.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them_Moi.Image")));
            this.btn_Them_Moi.Location = new System.Drawing.Point(360, 118);
            this.btn_Them_Moi.Name = "btn_Them_Moi";
            this.btn_Them_Moi.Size = new System.Drawing.Size(87, 23);
            this.btn_Them_Moi.TabIndex = 4;
            this.btn_Them_Moi.Text = "THÊM MỚI";
            this.btn_Them_Moi.Click += new System.EventHandler(this.btn_Them_Moi_Click);
            // 
            // Frm_Them_Mon_Moi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 150);
            this.Controls.Add(this.btn_Them_Moi);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pic_Hinh_Anh);
            this.Controls.Add(this.spin_Gia_Ban);
            this.Controls.Add(this.txt_Ten_Mon);
            this.Controls.Add(this.lkup_Loai_Mon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(488, 189);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(488, 189);
            this.Name = "Frm_Them_Mon_Moi";
            this.Text = "THÊM MÓN MỚI";
            this.Load += new System.EventHandler(this.Frm_Them_Mon_Moi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkup_Loai_Mon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Gia_Ban.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Hinh_Anh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lkup_Loai_Mon;
        private System.Windows.Forms.TextBox txt_Ten_Mon;
        private DevExpress.XtraEditors.SpinEdit spin_Gia_Ban;
        private DevExpress.XtraEditors.PictureEdit pic_Hinh_Anh;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Them_Moi;
    }
}