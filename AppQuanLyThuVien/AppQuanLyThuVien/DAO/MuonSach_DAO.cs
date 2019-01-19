using AppQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyThuVien.DAO
{
    class MuonSach_DAO
    {
        //thêm phiếu mượn từ các dữ liệu cho trước
        public static int InsertData(string madg, string mapm, string masach, string ngaymuon, string hantra, string tinhtrang, string giamuon, string discount)
        {
            string query = string.Format("Insert MUON_SACH (ma_doc_gia , ma_phieu_muon_sach , ma_sach , ngay_muon , ngay_du_dinh_tra , tinh_trang , gia_muon , discount) values ('{0}','{1}',N'{2}',N'{3}',N'{4}','{5}','{6}','{7}')", madg, mapm, masach, ngaymuon, hantra, tinhtrang, giamuon, discount);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        //chỉnh sửa dữ liệu
        public static int EditData(string madg, string mapm, string masach, string ngaymuon, string hantra, string tinhtrang, string giamuon, string discount)
        {
            string query = string.Format("update MUON_SACH set ma_doc_gia = N'{0}' , ma_phieu_muon_sach = '{1}' , ma_sach = '{2}' , ngay_muon = '{3}' , ngay_du_dinh_tra = '{4}' , tinh_trang = '{5}' , gia_muon = '{6}' , discount = '{7}'", madg, mapm, masach, ngaymuon, hantra, tinhtrang, giamuon, discount);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        //giảm số sách còn lại trong kho khi thêm phiếu mượn
        public static int decreaseremainbook(string masach, int slcl)
        {
            string query = string.Format("Update SACH set so_sach_con_lai = '{0}' where ma_sach = N'{1}'", slcl - 1, masach);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        //lấy dữ liệu từ database lên datagridview
        public static DataTable LoadTable()
        {
            string query = string.Format("Select ma_doc_gia as N'Mã độc giả' , ma_sach as N'Mã sách' , ngay_muon as N'Ngày mượn' , ma_phieu_muon_sach as N'Mã phiếu mượn sách' , ngay_du_dinh_tra as N'Hạn trả' , tinh_trang as N'Tình trạng' , gia_muon as N'Giá mượn' , discount as N'Chiết khấu' from MUON_SACH");
            return DataProvider.Instance.ExcuteQuery(query);
        }
        //kiểm tra mã sách có trong bảng quản lý sách không
        public static bool CheckTheSameBookID(string masach)
        {
            string query = string.Format("Select COUNT(ma_sach) as count from SACH where ma_sach = '{0}' and so_luong > 0 ", masach);
            if (DataProvider.Instance.ExcuteScalarInt(query) >= 1)
                return true;
            return false;
        }
        //kiểm tra mã độc giả nhập vào có hợp lệ không
        public static bool CheckTheSameMemberID(string madocgia)
        {
            string query = string.Format("Select COUNT(ma_doc_gia) as count from DOC_GIA where ma_doc_gia = '{0}' and hoat_dong = N'Có'", madocgia);
            if (DataProvider.Instance.ExcuteScalarInt(query) >= 1)
                return true;
            return false;
        }
        //kiểm tra mã phiếu mượn có bị trùng
        public static bool CheckTheSameID(string id)
        {
            string query = string.Format("Select COUNT(ma_phieu_muon_sach) as count from MUON_SACH where ma_phieu_muon_sach = '{0}' ", id);
            if (DataProvider.Instance.ExcuteScalarInt(query) >= 1)
                return true;
            return false;
        }
        //lấy tiền mượn của cuốn sách khi biết mã sách
        public static string borrowmoney(string masach)
        {
            string query = string.Format("Select gia_muon from SACH where ma_sach = '{0}'", masach);
            return DataProvider.Instance.ExcuteScalarString(query);
        }
        //lấy số lượng cuốn sách còn khi mượn
        public static string quantity(string masach)
        {
            string query = string.Format("Select so_sach_con_lai from SACH where ma_sach = '{0}'", masach);
            return DataProvider.Instance.ExcuteScalarString(query);
        }

        //lấy chiết khấu cho độc giả
        public static int discount(string madg)
        {
            string query = string.Format("Select KM.phan_tram_khuyen_mai from DOC_GIA DG , KHUYEN_MAI KM where DG.ma_doc_gia = '{0}' AND DG.cap_do = KM.cap_do", madg);
            return DataProvider.Instance.ExcuteScalarInt(query);
        }
        //lấy tình trạng cho sách
        public static string State(string masach)
        {
            string query = string.Format("Select so_sach_con_lai from SACH where ma_sach = N'{0}'", masach);
            return DataProvider.Instance.ExcuteScalarString(query);
        }

    }
}
