using CoffeeManagement.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Them_Loai_Mon : Form
    {
        CoffeeManagement.BLL.LoaiMonBLL _loaiMonBLL = new BLL.LoaiMonBLL();
        public Frm_Them_Loai_Mon()
        {
            InitializeComponent();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if (txt_TenLoaiMon.Text.Length == 0)
            {
                Notification.Error("Bạn chưa nhập tên loại món!");
                return;
            }
            if (_loaiMonBLL.KiemTraTenLoaiMonTonTai(txt_TenLoaiMon.Text))
            {
                Notification.Error("Tên loại món đã tồn tại! Vui lòng nhập tên loại món khác.");
                return;
            }
            _loaiMonBLL.ThemLoaiMonMoi(txt_TenLoaiMon.Text);
            txt_TenLoaiMon.Text = null;
            Notification.Success("Tạo loại món mới thành công.");
        }
    }
}
