using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using AppQuanLyThuVien.DTO;

namespace AppQuanLyThuVien.DAO
{
    class ThongKe_DAO
    {
        public static List<ThongKeHoatDongTheoNgay> ThongKeHoatDongTheoNgay (string ngayBatDau, string NgayKetThuc)
        {
            List<ThongKeHoatDongTheoNgay> list = new List<ThongKeHoatDongTheoNgay>();
            string query = string.Format("Select CONVERT(date, ngay_muon) as ngayMuon, count(ma_sach) as soLuongSachMuon, sum(gia_muon) as DoanhThu " +
                "from MUON_SACH where ngay_muon between N'{0}' and N'{1}' group by ngay_muon", ngayBatDau, NgayKetThuc);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach(DataRow row in dt.Rows)
            {
                list.Add(new ThongKeHoatDongTheoNgay() { Ngay = DateTime.Parse(row["ngayMuon"].ToString()).ToString("dd-MM-yyyy"), SoLuongSachMuon = int.Parse(row["soLuongSachMuon"].ToString()), DoanhThu = float.Parse(row["DoanhThu"].ToString()) });
            }
            query = string.Format("Select CONVERT(date, ngay_tra) as ngayTra, count(ma_sach) as soLuongSachTra " +
                "from TRA_SACH where ngay_tra between N'{0}' and N'{1}' group by ngay_tra", ngayBatDau, NgayKetThuc);
            dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow row in dt.Rows)
            {
                bool check = false;
                foreach(ThongKeHoatDongTheoNgay item in list)
                {
                    if(item.Ngay == DateTime.Parse(row["ngayTra"].ToString()).ToString("dd-MM-yyyy"))
                    {
                        item.SoLuongSachTra = int.Parse(row["soLuongSachTra"].ToString());
                        check = true;
                        break;
                    }
                }
                if(check == false)
                    list.Add(new ThongKeHoatDongTheoNgay() { Ngay = DateTime.Parse(row["ngayTra"].ToString()).ToString("dd-MM-yyyy"), SoLuongSachTra = int.Parse(row["soLuongSachTra"].ToString()) });
            }
            return list;
        }
    }
}
