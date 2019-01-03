using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppQuanLyThuVien.DTO
{
    class ThongKeHoatDongTheoNgay
    {
        string ngay;
        int soLuongSachMuon;
        int soLuongSachTra;
        float doanhThu;

        public string Ngay { get => ngay; set => ngay = value; }
        public int SoLuongSachMuon { get => soLuongSachMuon; set => soLuongSachMuon = value; }
        public int SoLuongSachTra { get => soLuongSachTra; set => soLuongSachTra = value; }
        public float DoanhThu { get => doanhThu; set => doanhThu = value; }

        public ThongKeHoatDongTheoNgay(int soLuongSachMuon = 0, int soLuongSachTra = 0, float doanhThu = 0)
        {
            this.SoLuongSachMuon = soLuongSachMuon;
            this.SoLuongSachTra = soLuongSachTra;
            this.DoanhThu = doanhThu;
        }
    }
}
