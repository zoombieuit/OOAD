using CoffeeManagement.BLL;
using CoffeeManagement.Utils;
using System;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Them_Khu_Vuc : Form
    {
        KhuVucBLL _khuVucBLL = new KhuVucBLL();
        public Frm_Them_Khu_Vuc()
        {
            InitializeComponent();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (txt_TenKhuVuc.Text.Length == 0)
            {
                Notification.Error("Bạn chưa nhập tên khu vực!");
                return;
            }
            if (_khuVucBLL.KiemTraTenKhuVucTonTai(txt_TenKhuVuc.Text))
            {
                Notification.Error("Tên khu vực đã tồn tại! Vui lòng nhập tên khu vực khác.");
                return;
            }
            _khuVucBLL.ThemKhuVucMoi(txt_TenKhuVuc.Text);
            txt_TenKhuVuc.Text = null;
            Notification.Success("Tạo khu vực mới thành công.");           
        }
    }
}
