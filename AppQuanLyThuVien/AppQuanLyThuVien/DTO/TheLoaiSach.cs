using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppQuanLyThuVien.DTO
{
    class TheLoaiSach
    {
        int maTheLoai;
        string tenTheLoai;
        string maSachTuongUng;
        public int MaTheLoai { get => maTheLoai; set => maTheLoai = value; }
        public string TenTheLoai { get => tenTheLoai; set => tenTheLoai = value; }
        public string MaSachTuongUng { get => maSachTuongUng; set => maSachTuongUng = value; }

        public TheLoaiSach(DataRow row)
        {
            this.maTheLoai = int.Parse(row["ma_the_loai"].ToString());
            this.tenTheLoai = row["ten_the_loai"].ToString();
            this.MaSachTuongUng = row["ma_sach_tuong_ung"].ToString();
        }
    }
}
