using AppQuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyThuVien.DAO
{
    class TraSach_DAO
    {
        //lấy data hiển thị lên datagridview
        public static DataTable LoadData()
        {
            string query = string.Format("Select ma_doc_gia as N'Mã độc giả' , ma_sach as N'Mã sách' , ngay_muon as N'Ngày mượn' , ma_phieu_muon_sach as N'Mã phiếu mượn sách' , ngay_tra as N'Ngày trả' , tien_phat as N'Tiền phạt' , diem_danh_gia as N'Điểm đánh giá' from TRA_SACH");
            return DataProvider.Instance.ExcuteQuery(query);
        }

        public static int InsertData(string madg, string mapm, string masach, string ngaymuon, string ngaytra, string tienphat, string diem)
        {
            string query = string.Format("Insert TRA_SACH (ma_doc_gia , ma_phieu_muon_sach , ma_sach , ngay_muon , ngay_tra , tien_phat , diem_danh_gia) values ('{0}','{1}',N'{2}',N'{3}',N'{4}','{5}','{6}')", madg, mapm, masach, ngaymuon, ngaytra, tienphat, diem);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        //lấy danh sách các mã sách mà độc giả chưa trả
        public static DataTable bookIdUserKeep(string madg)
        {
            string query = string.Format("select distinct MS.ma_sach from MUON_SACH MS , TRA_SACH TS where (MS.ma_doc_gia != TS.ma_doc_gia OR MS.ma_sach != TS.ma_sach OR MS.ngay_muon != TS.ngay_muon OR MS.ma_phieu_muon_sach != TS.ma_phieu_muon_sach) AND MS.ma_doc_gia = '{0}'", madg);
            return DataProvider.Instance.ExcuteQuery(query);
        }
        //lấy danh sách người đã mượn
        public static bool CheckMemberID(string madg)
        {

            string query = string.Format("Select count(distinct MS.ma_doc_gia )from MUON_SACH MS , TRA_SACH TS where (MS.ma_doc_gia != TS.ma_doc_gia OR MS.ma_sach != TS.ma_sach OR MS.ngay_muon != TS.ngay_muon OR MS.ma_phieu_muon_sach != TS.ma_phieu_muon_sach) AND MS.ma_doc_gia = '{0}'", madg);
            if (DataProvider.Instance.ExcuteScalarInt(query) >= 1)
                return true;
            return false;
        }
        //lấy thời gian từ hạn trả đến lúc trả
        public static int getExp(string id, string memberid, string bookid)
        {
            string query = string.Format("Select DATEDIFF(day,ngay_du_dinh_tra,getdate()) from MUON_SACH where ma_doc_gia = '{0}' and ma_sach = '{1}' and ma_phieu_muon_sach = '{2}' ", memberid, bookid, id);
            return DataProvider.Instance.ExcuteScalarInt(query);
        }
        //lấy mã phiếu mượn
        public static string getID(string memberid, string bookid)
        {
            string query = string.Format("Select ma_phieu_muon_sach from MUON_SACH where ma_doc_gia = '{0}' and ma_sach = '{1}'", memberid, bookid);
            return DataProvider.Instance.ExcuteScalarString(query);
        }

        //lấy số lượng cuốn sách còn khi mượn
        public static string quantity(string masach)
        {
            string query = string.Format("Select so_sach_con_lai from SACH where ma_sach = '{0}'", masach);
            return DataProvider.Instance.ExcuteScalarString(query);
        }

        public static int increaseremainbook(string masach, int slcl)
        {
            string query = string.Format("Update SACH set so_sach_con_lai = '{0}' where ma_sach = N'{1}'", slcl + 1, masach);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }

    }
}
