namespace CoffeeManagement
{
    partial class Frm_Ban
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ban));
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
            this.col_Ban = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Khu_Vuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lkup_KhuVuc = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkup_KhuVuc)).BeginInit();
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
            this.btn_Luu_Lai.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Luu_Lai_ItemClick);
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
            this.barDockControlTop.Size = new System.Drawing.Size(744, 24);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 451);
            this.barDockControlBottom.Size = new System.Drawing.Size(744, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 24);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 427);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(744, 24);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 427);
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
            this.lkup_KhuVuc});
            this.gridControl1.Size = new System.Drawing.Size(744, 427);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_ID,
            this.col_Ban,
            this.col_Khu_Vuc});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.NewItemRowText = "Thêm dòng mới tại đây...";
            this.gridView1.OptionsSelection.MultiSelect = true;
            this.gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gridView1.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowDetailButtons = false;
            this.gridView1.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridView1.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gridView1_SelectionChanged);
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // col_ID
            // 
            this.col_ID.AppearanceHeader.Options.UseTextOptions = true;
            this.col_ID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_ID.Caption = "ID";
            this.col_ID.FieldName = "ID_Ban";
            this.col_ID.Name = "col_ID";
            this.col_ID.Visible = true;
            this.col_ID.VisibleIndex = 1;
            this.col_ID.Width = 97;
            // 
            // col_Ban
            // 
            this.col_Ban.AppearanceHeader.Options.UseTextOptions = true;
            this.col_Ban.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.col_Ban.Caption = "BÀN";
            this.col_Ban.FieldName = "Ten_Ban";
            this.col_Ban.Name = "col_Ban";
            this.col_Ban.Visible = true;
            this.col_Ban.VisibleIndex = 3;
            this.col_Ban.Width = 400;
            // 
            // col_Khu_Vuc
            // 
            this.col_Khu_Vuc.Caption = "KHU VỰC";
            this.col_Khu_Vuc.ColumnEdit = this.lkup_KhuVuc;
            this.col_Khu_Vuc.FieldName = "ID_Khu_Vuc";
            this.col_Khu_Vuc.Name = "col_Khu_Vuc";
            this.col_Khu_Vuc.Visible = true;
            this.col_Khu_Vuc.VisibleIndex = 2;
            this.col_Khu_Vuc.Width = 124;
            // 
            // lkup_KhuVuc
            // 
            this.lkup_KhuVuc.AutoHeight = false;
            this.lkup_KhuVuc.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkup_KhuVuc.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Ten_Khu_Vuc", "KHU VỰC")});
            this.lkup_KhuVuc.Name = "lkup_KhuVuc";
            this.lkup_KhuVuc.NullText = "[Chọn khu vực]";
            // 
            // Frm_Ban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 451);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_Ban";
            this.Text = "QUẢN LÝ KHU VỰC";
            this.Load += new System.EventHandler(this.Frm_Ban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lkup_KhuVuc)).EndInit();
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
        private DevExpress.XtraGrid.Columns.GridColumn col_Ban;
        private DevExpress.XtraGrid.Columns.GridColumn col_Khu_Vuc;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit lkup_KhuVuc;
    }
}