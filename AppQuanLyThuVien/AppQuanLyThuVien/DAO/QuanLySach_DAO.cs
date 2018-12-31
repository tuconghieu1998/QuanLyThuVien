﻿using System;
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
        public static string TaoMaSach(Sach sach, List<TheLoaiSach> list)
        {
            foreach (TheLoaiSach theLoai in list){
                if(theLoai.MaTheLoai == sach.TheLoai)
                {
                    sach.MaSach = theLoai.MaSachTuongUng;
                    break;
                }
            }
            string maSachMax = LayMaSachCaoNhat(sach.MaSach).Rows[0][0].ToString();
            maSachMax = maSachMax.Substring(3);
            int tmp = int.Parse(maSachMax) + 1;
            sach.MaSach = sach.MaSach + tmp.ToString();
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
                sach.TenSach, sach.TenTacGia, sach.NhaXuatBan, sach.NamXuatBan,
                sach.TheLoai, sach.GiaSach, sach.GiaMuon, sach.SoLuong, sach.SoLuong);
            return DataProvider.Instance.ExcuteNonQuery(query);

        }
        public static int SuaThongTinSach(Sach sach)
        {
            string query = string.Format("update SACH set ten_sach = N'{0}',tac_gia = N'{1}',nha_xuat_ban= N'{2}',nam_xuat_ban '{3}'," +
                " ma_the_loai = '{4}', gia_sach = '{5}', gia_muon = '{6}', so_sach_con_lai = '{7}', so_luong = '{8}' where ma_sach = '{9}'",
                sach.TenSach, sach.TenTacGia, sach.NhaXuatBan, sach.NamXuatBan,
                sach.TheLoai, sach.GiaSach, sach.GiaMuon, sach.SoLuong, sach.SoLuongConLai, sach.MaSach);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        public static DataTable TimKiemSachTheoTen(string name)
        {
            string query = string.Format("select * from SACH where ten_sach like N'%{0}%'", name);
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public static DataTable TimKiemSachTheoMaSach(string maSach)
        {
            string query = string.Format("select * from SACH where ma_sach like '%{0}%'", maSach);
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public static DataTable TimKiemSachTheoTacGia(string tacGia)
        {
            string query = string.Format("select * from SACH where tac_gia like N'%{0}%'", tacGia);
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public static DataTable TimKiemSachTheoTheLoai(string theLoai)
        {
            string query = string.Format("select * from SACH, THELOAI where SACH.ma_the_loai = THELOAI.ma_the_loai and THELOAI.ten_the_loai like N'%{0}%'", theLoai);
            return DataProvider.Instance.ExcuteQuery(query);
        }
    }
}