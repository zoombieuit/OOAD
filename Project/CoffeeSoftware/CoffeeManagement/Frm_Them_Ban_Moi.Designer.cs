namespace CoffeeManagement
{
    partial class Frm_Them_Ban_Moi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Them_Ban_Moi));
            this.lkup_KhuVuc = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_SoBan = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btn_ThemMoi = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them_Khu_Vuc = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.lkup_KhuVuc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lkup_KhuVuc
            // 
            this.lkup_KhuVuc.Location = new System.Drawing.Point(76, 21);
            this.lkup_KhuVuc.Name = "lkup_KhuVuc";
            this.lkup_KhuVuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkup_KhuVuc.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_Khu_Vuc", "KHU VỰC")});
            this.lkup_KhuVuc.Properties.NullText = "[Chọn khu vực]";
            this.lkup_KhuVuc.Size = new System.Drawing.Size(180, 20);
            this.lkup_KhuVuc.TabIndex = 0;
            // 
            // txt_SoBan
            // 
            this.txt_SoBan.Location = new System.Drawing.Point(76, 52);
            this.txt_SoBan.Name = "txt_SoBan";
            this.txt_SoBan.Size = new System.Drawing.Size(293, 20);
            this.txt_SoBan.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Khu Vực";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Số Bàn";
            // 
            // btn_ThemMoi
            // 
            this.btn_ThemMoi.Image = ((System.Drawing.Image)(resources.GetObject("btn_ThemMoi.Image")));
            this.btn_ThemMoi.Location = new System.Drawing.Point(281, 81);
            this.btn_ThemMoi.Name = "btn_ThemMoi";
            this.btn_ThemMoi.Size = new System.Drawing.Size(88, 23);
            this.btn_ThemMoi.TabIndex = 3;
            this.btn_ThemMoi.Text = "THÊM MỚI";
            this.btn_ThemMoi.Click += new System.EventHandler(this.btn_ThemMoi_Click);
            // 
            // btn_Them_Khu_Vuc
            // 
            this.btn_Them_Khu_Vuc.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them_Khu_Vuc.Appearance.Options.UseFont = true;
            this.btn_Them_Khu_Vuc.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them_Khu_Vuc.Image")));
            this.btn_Them_Khu_Vuc.Location = new System.Drawing.Point(262, 18);
            this.btn_Them_Khu_Vuc.Name = "btn_Them_Khu_Vuc";
            this.btn_Them_Khu_Vuc.Size = new System.Drawing.Size(107, 23);
            this.btn_Them_Khu_Vuc.TabIndex = 1;
            this.btn_Them_Khu_Vuc.Text = "THÊM KHU VỰC";
            this.btn_Them_Khu_Vuc.Click += new System.EventHandler(this.btn_Them_Khu_Vuc_Click);
            // 
            // Frm_Them_Ban_Moi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 116);
            this.Controls.Add(this.btn_Them_Khu_Vuc);
            this.Controls.Add(this.btn_ThemMoi);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_SoBan);
            this.Controls.Add(this.lkup_KhuVuc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(409, 155);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(409, 155);
            this.Name = "Frm_Them_Ban_Moi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "THÊM BÀN MỚI";
            this.Load += new System.EventHandler(this.Frm_Them_Ban_Moi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lkup_KhuVuc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lkup_KhuVuc;
        private System.Windows.Forms.TextBox txt_SoBan;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btn_ThemMoi;
        private DevExpress.XtraEditors.SimpleButton btn_Them_Khu_Vuc;
    }
}