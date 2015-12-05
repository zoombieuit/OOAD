using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using CoffeeManagement.Utils;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Khu_Vuc : Form
    {
        private KhuVucBLL _khuVucBLL = new KhuVucBLL();
        private List<int> _listUpdate = new List<int>();      // Danh sách các đối tượng cần update
        DataTable dt = new DataTable();

        public Frm_Khu_Vuc()
        {
            InitializeComponent();
        }


        private void LoadDataSource()
        {
            dt = Utils.Util.ConvertToDataTable<KHU_VUC>(_khuVucBLL.LayDanhSachKhuVuc());
            gridControl1.DataSource = dt;
            btn_Luu_Lai.Enabled = false;

            _listUpdate.Clear();
        }

        private void Frm_Khu_Vuc_Load(object sender, System.EventArgs e)
        {
            LoadDataSource();
        }

        // Thêm khu vực mới
        private void btn_Them_Moi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Frm_Them_Khu_Vuc f = new Frm_Them_Khu_Vuc();
            if(f.ShowDialog() == DialogResult.Cancel)
            {
                LoadDataSource();
            }
        }

        // Xóa thông tin khu vực
        private void btn_Xoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(Notification.Answers("Bạn có thật sự muốn xóa dữ liệu?")==DialogResult.Cancel)
            {
                return;
            }
            for(int i=0; i<gridView1.SelectedRowsCount; i++)
            {
                int _ID_Khu_Vuc = int.Parse(gridView1.GetRowCellValue(gridView1.GetSelectedRows()[i], "ID_Khu_Vuc").ToString());
                _khuVucBLL.XoaKhuVuc(_ID_Khu_Vuc);
            }
            Notification.Success("Xóa dữ liệu thành công!");
            LoadDataSource();
        }

        // Cập nhật thông tin khi người dùng chỉnh sửa
        private void btn_Luu_Lai_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string error = "";
            bool isUpdate = false;
            foreach(int id in _listUpdate)
            {
                KHU_VUC _khuVuc = new KHU_VUC();
                _khuVuc.ID_Khu_Vuc = int.Parse(gridView1.GetRowCellValue(id, "ID_Khu_Vuc").ToString());
                _khuVuc.Ten_Khu_Vuc = gridView1.GetRowCellValue(id, "Ten_Khu_Vuc").ToString();
                if (!_khuVucBLL.KiemTraTenKhuVucTonTai(_khuVuc.Ten_Khu_Vuc))
                {
                    _khuVucBLL.CapNhatKhuVuc(_khuVuc);
                    isUpdate = true;
                }
                else
                {
                    if (error == "")
                    {
                        error += _khuVuc.ID_Khu_Vuc;
                    }
                    else
                    {
                        error += " | " + _khuVuc.ID_Khu_Vuc;
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

            if(gridView1.SelectedRowsCount > 0)
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
