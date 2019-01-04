using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppQuanLyThuVien.DTO;
using System.Data;
using System.Data.SqlClient;

namespace AppQuanLyThuVien.DAO
{
    class QuanLySach_DAO
    {
        public static DataTable LoadData(int soLuongDong)
        {
            string query = string.Format("Select top 10 ma_sach, ten_sach," +
                " tac_gia, nha_xuat_ban, nam_xuat_ban, ten_the_loai, gia_sach," +
                " gia_muon, so_luong, so_sach_con_lai from SACH, THE_LOAI " +
                "where SACH.ma_the_loai = THE_LOAI.ma_the_loai");
            return DataProvider.Instance.ExcuteQuery(query);
        }
           
        public static int KiemTraDuLieuLienQuanKhiXoa(string maSach)
        {
            string query = string.Format("Select count(ma_sach) as soLuong from MUON_SACH where ma_sach = '{0}'", maSach);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            int soLuong = int.Parse(dt.Rows[0]["soLuong"].ToString());

            query = string.Format("Select count(ma_sach) as soLuong from TRA_SACH where ma_sach = '{0}'", maSach);
            dt = DataProvider.Instance.ExcuteQuery(query);
            soLuong += int.Parse(dt.Rows[0]["soLuong"].ToString());
            return soLuong;
        }

        public static string TaoMaSach(Sach sach, List<TheLoaiSach> list)
        {
            foreach (TheLoaiSach theLoai in list){
                if(theLoai.MaTheLoai == sach.TheLoai)
                {
                    sach.MaSach = theLoai.MaSachTuongUng;
                    break;
                }
            }
            DataTable dt = LayMaSachCaoNhat(sach.MaSach);
            string maSachMax;
            if(dt.Rows.Count > 0)
            {
                maSachMax = dt.Rows[0]["ma_sach"].ToString();
                maSachMax = maSachMax.Substring(3);
            }
            else
            {
                maSachMax = "00000";
            }
            int tmp = int.Parse(maSachMax) + 1;
            sach.MaSach = sach.MaSach + tmp.ToString().PadLeft(5, '0'); ;
            return sach.MaSach;
        }

        public static List<TheLoaiSach> LayDanhSachTheLoai()
        {
            List<TheLoaiSach> list = new List<TheLoaiSach>();
            string query = string.Format("Select * from THE_LOAI");
            DataTable dt =  DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                TheLoaiSach theLoai = new TheLoaiSach(item);
                list.Add(theLoai);
            }
            return list;
        }
        public static DataTable LayMaSachCaoNhat(string maSachTuongUng)
        {
            string query = string.Format("Select top 1 ma_sach from SACH where SACH.ma_sach like '{0}%' order by ma_sach DESC", maSachTuongUng);
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public static int ThemSach(Sach sach)
        {
            sach.MaSach = TaoMaSach(sach, LayDanhSachTheLoai());
            string query = string.Format("insert SACH (ma_sach,ten_sach,tac_gia,nha_xuat_ban,nam_xuat_ban," +
                " ma_the_loai, gia_sach, gia_muon, so_sach_con_lai, so_luong)" +
                " values ('{0}',N'{1}',N'{2}',N'{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                sach.MaSach, sach.TenSach, sach.TenTacGia, sach.NhaXuatBan, sach.NamXuatBan,
                sach.TheLoai, sach.GiaSach, sach.GiaMuon, sach.SoLuong, sach.SoLuong);
            return DataProvider.Instance.ExcuteNonQuery(query);

        }

        public static int XoaSach(string maSach)
        {

            string query = string.Format("delete from MUON_SACH where ma_sach = '{0}'", maSach);
            DataProvider.Instance.ExcuteNonQuery(query);
            query = string.Format("delete from TRA_SACH where ma_sach = '{0}'", maSach);
            DataProvider.Instance.ExcuteNonQuery(query);
            query = string.Format("delete from SACH where ma_sach = '{0}'", maSach);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

        public static string KiemTraTrungSach(Sach sach)
        {
            string query = string.Format("select ma_sach from SACH where ten_sach = N'{0}'" +
                " and tac_gia = N'{1}' and nha_xuat_ban = N'{2}' and nam_xuat_ban = '{3}' and ma_the_loai = '{4}' and gia_sach = {5}",
                sach.TenSach, sach.TenTacGia, sach.NhaXuatBan, sach.NamXuatBan,
                sach.TheLoai, sach.GiaSach);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            string maSach = "";
            if (dt.Rows.Count > 0)
            {
                maSach = dt.Rows[0]["ma_sach"].ToString();
            }
            return maSach;
        }
        public static int LaySoLuongSachConLai(string maSach)
        {
            string query = string.Format("Select so_sach_con_lai from SACH where ma_sach = '{0}'", maSach);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            
            return int.Parse(dt.Rows[0]["so_sach_con_lai"].ToString());

        }
        public static int LaySoLuongSach(string maSach)
        {
            string query = string.Format("Select so_luong from SACH where ma_sach = '{0}'", maSach);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            return int.Parse(dt.Rows[0]["so_luong"].ToString());

        }
        public static int SuaThongTinSach(Sach sach)
        {

            string query = string.Format("update SACH set ten_sach = N'{0}',tac_gia = N'{1}',nha_xuat_ban = N'{2}',nam_xuat_ban = '{3}'," +
                " ma_the_loai = '{4}', gia_sach = '{5}', gia_muon = '{6}', so_luong = '{7}', so_sach_con_lai = '{8}' where ma_sach = '{9}'",
                sach.TenSach, sach.TenTacGia, sach.NhaXuatBan, sach.NamXuatBan,
                sach.TheLoai, sach.GiaSach, sach.GiaMuon, sach.SoLuong, sach.SoLuongConLai, sach.MaSach);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        public static DataTable TimKiemSachTheoTen(string name)
        {
            string query = string.Format("Select ma_sach, ten_sach," +
                " tac_gia, nha_xuat_ban, nam_xuat_ban, ten_the_loai, gia_sach," +
                " gia_muon, so_luong, so_sach_con_lai from SACH, THE_LOAI " +
                "where SACH.ma_the_loai = THE_LOAI.ma_the_loai and ten_sach like N'%{0}%'", name);
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public static List<String> TimKiemSachTheoTen_LayTen(string name)
        {
            List<string> list = new List<string>();
            string query = string.Format("select distinct top 10 ten_sach from SACH where ten_sach like N'%{0}%'", name);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(item["ten_sach"].ToString());
            }
            return list;
        }
        public static DataTable TimKiemSachTheoMaSach(string maSach)
        {
            string query = string.Format("Select ma_sach, ten_sach," +
                " tac_gia, nha_xuat_ban, nam_xuat_ban, ten_the_loai, gia_sach," +
                " gia_muon, so_luong, so_sach_con_lai from SACH, THE_LOAI " +
                "where SACH.ma_the_loai = THE_LOAI.ma_the_loai and ma_sach like '%{0}%'", maSach);
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public static List<string> TimKiemSachTheoMaSach_LayMaSach(string maSach)
        {
            List<string> list = new List<string>();
            string query = string.Format("select top 10 ma_sach from SACH where ma_sach like '%{0}%'", maSach);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(item["ma_sach"].ToString());
            }
            return list;
            
            
        }
        public static DataTable TimKiemSachTheoTacGia(string tacGia)
        {
            string query = string.Format("Select ma_sach, ten_sach," +
                " tac_gia, nha_xuat_ban, nam_xuat_ban, ten_the_loai, gia_sach," +
                " gia_muon, so_luong, so_sach_con_lai from SACH, THE_LOAI " +
                "where SACH.ma_the_loai = THE_LOAI.ma_the_loai and like N'%{0}%'", tacGia);
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public static List<string> TimKiemSachTheoTacGia_LayTacGia(string tacGia)
        {
            List<string> list = new List<string>();
            string query = string.Format("select top 10 tac_gia from SACH where tac_gia like N'%{0}%'", tacGia);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(item["tac_gia"].ToString());
            }
            return list;
            
        }
        public static DataTable TimKiemSachTheoTheLoai(string theLoai)
        {
            string query = string.Format("Select ma_sach, ten_sach," +
                " tac_gia, nha_xuat_ban, nam_xuat_ban, ten_the_loai, gia_sach," +
                " gia_muon, so_luong, so_sach_con_lai from SACH, THE_LOAI " +
                "where SACH.ma_the_loai = THE_LOAI.ma_the_loai and THE_LOAI.ten_the_loai like N'%{0}%'", theLoai);
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public static List<string> TimKiemSachTheoTheLoai_LayTheLoai(string theLoai)
        {
            List<string> list = new List<string>();
            string query = string.Format("select ten_the_loai from THE_LOAI where THE_LOAI.ten_the_loai like N'%{0}%'", theLoai);
            DataTable dt = DataProvider.Instance.ExcuteQuery(query);
            foreach (DataRow item in dt.Rows)
            {
                list.Add(item["ten_the_loai"].ToString());
            }
            return list;
            
            
        }
    }
}
