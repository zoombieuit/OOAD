using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.Utils;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Loai_Mon : Form
    {
        private LoaiMonBLL _loaiMonBLL = new LoaiMonBLL();
        private List<int> _listUpdate = new List<int>();      // Danh sách các đối tượng cần update
        DataTable dt = new DataTable();

        public Frm_Loai_Mon()
        {
            InitializeComponent();
        }

        private void LoadDataSource()
        {
            dt = Utils.Util.ConvertToDataTable<LOAI_MON>(_loaiMonBLL.LayDanhSachLoaiMon());
            gridControl1.DataSource = dt;
            btn_Luu_Lai.Enabled = false;

            _listUpdate.Clear();
        }

        private void Frm_Loai_Mon_Load(object sender, System.EventArgs e)
        {
            LoadDataSource();
        }

        // Thêm khu vực mới
        private void btn_Them_Moi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Them_Loai_Mon f = new Frm_Them_Loai_Mon();
            if (f.ShowDialog() == DialogResult.Cancel)
            {
                LoadDataSource();
            }
        }

        // Xóa thông tin khu vực
        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Notification.Answers("Bạn có thật sự muốn xóa dữ liệu?") == DialogResult.Cancel)
            {
                return;
            }
            for (int i = 0; i < gridView1.SelectedRowsCount; i++)
            {
                int _ID_Loai_Mon = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "ID_Loai_Mon").ToString());
                _loaiMonBLL.XoaLoaiMon(_ID_Loai_Mon);
            }
            Notification.Success("Xóa dữ liệu thành công!");
            LoadDataSource();
        }

        // Cập nhật thông tin khi người dùng chỉnh sửa
        private void btn_Luu_Lai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string error = "";
            bool isUpdate = false;
            foreach (int id in _listUpdate)
            {
                LOAI_MON _loaiMon = new LOAI_MON();
                _loaiMon.ID_Loai_Mon = int.Parse(gridView1.GetRowCellValue(id, "ID_Loai_Mon").ToString());
                _loaiMon.Ten_Loai_Mon = gridView1.GetRowCellValue(id, "Ten_Loai_Mon").ToString();
                if (!_loaiMonBLL.KiemTraTenLoaiMonTonTai(_loaiMon.Ten_Loai_Mon))
                {
                    _loaiMonBLL.CapNhatLoaiMon(_loaiMon);
                    isUpdate = true;
                }
                else
                {
                    if (error == "")
                    {
                        error += _loaiMon.ID_Loai_Mon;
                    }
                    else
                    {
                        error += " | " + _loaiMon.ID_Loai_Mon;
                    }
                }
            }
            if (isUpdate == true)
            {
                if (error.Length == 0)
                {
                    Notification.Success("Cập dữ liệu thành công.");
                }
                else
                {
                    Notification.Error("Có lỗi xảy ra khi cập nhật dữ liệu. Các ID chưa được cập nhật (" + error + "). Lỗi: Tên Khu Vực đã tồn tại.");
                }
            }
            else
            {
                Notification.Error("Có lỗi xảy ra khi cập nhật dữ liệu. Lỗi: Tên khu vực đã tồn tại.");
            }
            LoadDataSource();
        }

        // Tải lại dữ liệu lên gridView
        private void btn_Lam_Moi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            LoadDataSource();
        }

        // Nếu có chọn dòng để xóa thì bật button xóa, còn nếu không hide nó đi
        private void gridView1_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            btn_Xoa.Enabled = false;

            if (gridView1.SelectedRowsCount > 0)
            {
                btn_Xoa.Enabled = true;
            }
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btn_Luu_Lai.Enabled = true;
            _listUpdate.Add(e.RowHandle);
        }    

    }
}
