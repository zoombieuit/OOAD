namespace CoffeeManagement
{
    partial class Frm_Mon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Mon));
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btn_Them_Moi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Xoa = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Luu_Lai = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Lam_Moi = new DevExpress.XtraBars.BarButtonItem();
            this.btn_In = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Loai_Mon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkup_LoaiMon = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.col_Ten_Mon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Hinh_Anh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.img_HinhAnh = new DevExpress.XtraEditors.Repository.RepositoryItemImageEdit();
            this.col_Don_Gia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.spin_Don_Gia = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkup_LoaiMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_HinhAnh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Don_Gia)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btn_Them_Moi,
            this.btn_Xoa,
            this.btn_Luu_Lai,
            this.btn_In,
            this.btn_Lam_Moi});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 5;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Them_Moi, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Xoa, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Luu_Lai, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_Lam_Moi, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.btn_In, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btn_Them_Moi
            // 
            this.btn_Them_Moi.Caption = "THÊM MỚI";
            this.btn_Them_Moi.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Them_Moi.Glyph")));
            this.btn_Them_Moi.Id = 0;
            this.btn_Them_Moi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Them_Moi.LargeGlyph")));
            this.btn_Them_Moi.Name = "btn_Them_Moi";
            this.btn_Them_Moi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Them_Moi_ItemClick);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Caption = "XÓA";
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.Glyph")));
            this.btn_Xoa.Id = 1;
            this.btn_Xoa.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Xoa.LargeGlyph")));
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick);
            // 
            // btn_Luu_Lai
            // 
            this.btn_Luu_Lai.Caption = "LƯU LẠI";
            this.btn_Luu_Lai.Enabled = false;
            this.btn_Luu_Lai.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Luu_Lai.Glyph")));
            this.btn_Luu_Lai.Id = 2;
            this.btn_Luu_Lai.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Luu_Lai.LargeGlyph")));
            this.btn_Luu_Lai.Name = "btn_Luu_Lai";
            this.btn_Luu_Lai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Xoa_ItemClick);
            // 
            // btn_Lam_Moi
            // 
            this.btn_Lam_Moi.Caption = "LÀM MỚI";
            this.btn_Lam_Moi.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_Lam_Moi.Glyph")));
            this.btn_Lam_Moi.Id = 4;
            this.btn_Lam_Moi.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_Lam_Moi.LargeGlyph")));
            this.btn_Lam_Moi.Name = "btn_Lam_Moi";
            this.btn_Lam_Moi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Lam_Moi_ItemClick);
            // 
            // btn_In
            // 
            this.btn_In.Caption = "IN ";
            this.btn_In.Glyph = ((System.Drawing.Image)(resources.GetObject("btn_In.Glyph")));
            this.btn_In.Id = 3;
            this.btn_In.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btn_In.LargeGlyph")));
            this.btn_In.Name = "btn_In";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(600, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 340);
            this.barDockControlBottom.Size = new System.Drawing.Size(600, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 316);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(600, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 316);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 24);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.MenuManager = this.barManager1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Padding = new System.Windows.Forms.Padding(5);
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.lkup_LoaiMon,
            this.img_HinhAnh,
            this.spin_Don_Gia});
            this.gridControl1.Size = new System.Drawing.Size(600, 316);
            this.gridControl1.TabIndex = 6;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ID,
            this.col_Loai_Mon,
            this.col_Ten_Mon,
            this.col_Hinh_Anh,
            this.col_Don_Gia});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm dòng mới tại đây...";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsPrint.ExpandAllDetails = true;
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.col_Loai_Mon, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // col_ID
            // 
            this.col_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.col_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_ID.Caption = "ID";
            this.col_ID.FieldName = "ID_Mon";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = true;
            this.col_ID.VisibleIndex = 1;
            this.col_ID.Width = 76;
            // 
            // col_Loai_Mon
            // 
            this.col_Loai_Mon.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Loai_Mon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Loai_Mon.Caption = "LOẠI MÓN";
            this.col_Loai_Mon.ColumnEdit = this.lkup_LoaiMon;
            this.col_Loai_Mon.FieldName = "ID_Loai_Mon";
            this.col_Loai_Mon.Name = "col_Loai_Mon";
            this.col_Loai_Mon.Visible = true;
            this.col_Loai_Mon.VisibleIndex = 4;
            this.col_Loai_Mon.Width = 514;
            // 
            // lkup_LoaiMon
            // 
            this.lkup_LoaiMon.AutoHeight = false;
            this.lkup_LoaiMon.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkup_LoaiMon.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_Loai_Mon", "LOẠI MÓN")});
            this.lkup_LoaiMon.Name = "lkup_LoaiMon";
            this.lkup_LoaiMon.NullText = "[Chọn loại món]";
            // 
            // col_Ten_Mon
            // 
            this.col_Ten_Mon.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Ten_Mon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Ten_Mon.Caption = "TÊN MÓN";
            this.col_Ten_Mon.FieldName = "Ten_Mon";
            this.col_Ten_Mon.Name = "col_Ten_Mon";
            this.col_Ten_Mon.Visible = true;
            this.col_Ten_Mon.VisibleIndex = 3;
            this.col_Ten_Mon.Width = 144;
            // 
            // col_Hinh_Anh
            // 
            this.col_Hinh_Anh.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Hinh_Anh.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Hinh_Anh.Caption = "HÌNH ẢNH";
            this.col_Hinh_Anh.ColumnEdit = this.img_HinhAnh;
            this.col_Hinh_Anh.FieldName = "Hinh_Anh";
            this.col_Hinh_Anh.Name = "col_Hinh_Anh";
            this.col_Hinh_Anh.Visible = true;
            this.col_Hinh_Anh.VisibleIndex = 2;
            this.col_Hinh_Anh.Width = 116;
            // 
            // img_HinhAnh
            // 
            this.img_HinhAnh.AutoHeight = false;
            this.img_HinhAnh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.img_HinhAnh.Name = "img_HinhAnh";
            // 
            // col_Don_Gia
            // 
            this.col_Don_Gia.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Don_Gia.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Don_Gia.Caption = "ĐƠN GIÁ";
            this.col_Don_Gia.ColumnEdit = this.spin_Don_Gia;
            this.col_Don_Gia.FieldName = "Don_Gia";
            this.col_Don_Gia.Name = "col_Don_Gia";
            this.col_Don_Gia.Visible = true;
            this.col_Don_Gia.VisibleIndex = 4;
            this.col_Don_Gia.Width = 171;
            // 
            // spin_Don_Gia
            // 
            this.spin_Don_Gia.AutoHeight = false;
            this.spin_Don_Gia.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spin_Don_Gia.Name = "spin_Don_Gia";
            // 
            // Frm_Mon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 340);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "Frm_Mon";
            this.Text = "QUẢN LÝ THỰC ĐƠN";
            this.Load += new System.EventHandler(this.Frm_Mon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkup_LoaiMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_HinhAnh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spin_Don_Gia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btn_Them_Moi;
        private DevExpress.XtraBars.BarButtonItem btn_Xoa;
        private DevExpress.XtraBars.BarButtonItem btn_Luu_Lai;
        private DevExpress.XtraBars.BarButtonItem btn_Lam_Moi;
        private DevExpress.XtraBars.BarButtonItem btn_In;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn col_ID;
        private DevExpress.XtraGrid.Columns.GridColumn col_Loai_Mon;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkup_LoaiMon;
        private DevExpress.XtraGrid.Columns.GridColumn col_Ten_Mon;
        private DevExpress.XtraGrid.Columns.GridColumn col_Hinh_Anh;
        private DevExpress.XtraEditors.Repository.RepositoryItemImageEdit img_HinhAnh;
        private DevExpress.XtraGrid.Columns.GridColumn col_Don_Gia;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit spin_Don_Gia;
    }
}