using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppQuanLyThuVien.DTO
{
    class Sach
    {//Nhớ sửa lại chỗ năm xuất bản
        string maSach, tenSach, tenTacGia, nhaXuatBan;

        int namXuatBan, soLuong, theLoai, soLuongConLai;
        float giaSach, giaMuon;

        public string MaSach { get => maSach; set => maSach = value; }
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TenTacGia { get => tenTacGia; set => tenTacGia = value; }
        public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }
        public int NamXuatBan { get => namXuatBan; set => namXuatBan = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public float GiaSach { get => giaSach; set => giaSach = value; }
        public float GiaMuon { get => giaMuon; set => giaMuon = value; }
        public int TheLoai { get => theLoai; set => theLoai = value; }
        public int SoLuongConLai { get => soLuongConLai; set => soLuongConLai = value; }

        public Sach(string maSach, string tenSach, string tenTacGia, string nhaXuatBan, int theLoai, int namXuatBan, int soLuong, float giaSach,float giaMuon, int soLuongConLai)
        {
            this.maSach = maSach;
            this.tenSach = tenSach;
            this.tenTacGia = tenTacGia;
            this.nhaXuatBan = nhaXuatBan;
            this.TheLoai = theLoai;
            this.namXuatBan = namXuatBan;
            this.soLuong = soLuong;
            this.giaSach = giaSach;
            this.giaMuon = giaMuon;
            this.soLuongConLai = soLuongConLai;
        }

        public Sach()
        {

        }

        public Sach(DataRow row)
        {
            this.maSach = row["ma_sach"].ToString();
            this.tenSach = row["ten_sach"].ToString();
            this.tenTacGia = row["tac_gia"].ToString();
            this.nhaXuatBan = row["nha_xuat_ban"].ToString();
            this.TheLoai = int.Parse(row["ten_the_loai"].ToString());
            this.namXuatBan = int.Parse(row["nam_xuat_ban"].ToString());
            this.soLuong = int.Parse(row["so_luong"].ToString());
            this.giaSach = float.Parse(row["gia_sach"].ToString());
            this.giaMuon = float.Parse(row["gia_muon"].ToString());
            this.soLuongConLai = int.Parse(row["so_luong_con_lai"].ToString());
        }
    }
}
