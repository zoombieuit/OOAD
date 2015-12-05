using CoffeeManagement.BLL;
using CoffeeManagement.DAL;
using System;
using System.Windows.Forms;

namespace CoffeeManagement
{
    public partial class Frm_Them_Ban_Moi : Form
    {
        BanBLL _banBLL = new BanBLL();
        KhuVucBLL _khuVucBLL = new KhuVucBLL();
        public Frm_Them_Ban_Moi()
        {
            InitializeComponent();
        }

        private void LoadDataCombobox()
        {
            lkup_KhuVuc.Properties.DataSource = Utils.Util.ConvertToDataTable<KHU_VUC>(_khuVucBLL.LayDanhSachKhuVuc());
            lkup_KhuVuc.Properties.DisplayMember = "Ten_Khu_Vuc";
            lkup_KhuVuc.Properties.ValueMember = "ID_Khu_Vuc";
        }

        private void Frm_Them_Ban_Moi_Load(object sender, EventArgs e)
        {
            LoadDataCombobox();
        }

        private void btn_ThemMoi_Click(object sender, EventArgs e)
        {
            if(txt_SoBan.Text.Length == 0 && lkup_KhuVuc.Text == null)
            {
                Utils.Notification.Error("Vui lòng chọn khu vực và nhập số bàn.");
                return;
            }

            // Kiểm tra số bàn đã có chưa
            if(_banBLL.KiemTraTenBanTonTai(txt_SoBan.Text))
            {
                Utils.Notification.Error("Số bàn đã tồn tại.");
                return;
            }

            // Thêm bàn mới
            BAN b = new BAN();
            b.Ten_Ban = txt_SoBan.Text;
            b.ID_Khu_Vuc = int.Parse(lkup_KhuVuc.EditValue.ToString());
            b.Trang_Thai = 0;
            _banBLL.ThemBanMoi(b);
            Utils.Notification.Success("Thêm bàn mới thành công!");
            txt_SoBan.Text = null;
        }

        private void btn_Them_Khu_Vuc_Click(object sender, EventArgs e)
        {
            Frm_Them_Khu_Vuc f = new Frm_Them_Khu_Vuc();
            if(f.ShowDialog() == DialogResult.Cancel)
            {
                LoadDataCombobox();
            }
        }
    }
}
