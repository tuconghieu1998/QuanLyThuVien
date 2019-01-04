using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLyThuVien.DAO;

namespace AppQuanLyThuVien.UC
{
    public partial class ThongKe : UserControl
    {
        public ThongKe()
        {
            InitializeComponent();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            string ngayBatDau = datePickerNgayBatDau.Value.ToString("yyyy-MM-dd");
            string ngayKetThuc = datePickerNgayKetThuc.Value.ToString("yyyy-MM-dd");
            dtgThongKeHoatDongTheoNgay.DataSource = ThongKe_DAO.ThongKeHoatDongTheoNgay(ngayBatDau, ngayKetThuc);
        }
    }
}
