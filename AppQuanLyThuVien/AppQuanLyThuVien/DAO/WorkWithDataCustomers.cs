using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB.DAO
{
    class Data
    {

        public static int InsertDataForDocGia(string ten, string cmnd, string ngaysinh, string gioitinh, string email, string diachi, string ngaydangky, string capdo,string hoatdong)
        {
            string query = string.Format("insert DOC_GIA (ho_ten,cmnd,ngay_sinh,gioi_tinh,email,dia_chi,ngay_dang_ky,cap_do,hoat_dong) values (N'{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}','{6}','{7}','{8}')", ten, cmnd, ngaysinh, gioitinh, email, diachi, ngaydangky, capdo,hoatdong);
            return DataPovider.Instance.ExcuteNonQuery(query);

        }
        public static int EditDataForDocGia(string ten, string cmnd, string ngaysinh, string gioitinh, string email, string diachi, string ngaydangky, string capdo, string madocgia, string hoatdong)
        {
            string query = string.Format("update DOC_GIA set ho_ten = N'{0}',cmnd = '{1}', ngay_sinh ='{2}',gioi_tinh = N'{3}', email = '{4}', dia_chi = N'{5}',ngay_dang_ky = '{6}', cap_do ='{7}', hoat_dong ='{9}' where ma_doc_gia = '{8}'", ten, cmnd, ngaysinh, gioitinh, email, diachi, ngaydangky, capdo, madocgia, hoatdong);
            return DataPovider.Instance.ExcuteNonQuery(query);
        }
        public static DataTable SearchingByName(string name)
        {
            string query = string.Format("select ma_doc_gia as N'Mã độc giả', ho_ten as N'Họ tên', cmnd as 'CMND', ngay_sinh as N'Ngày sinh', gioi_tinh as N'Giới tính', email as 'Email', dia_chi as N'Địa chỉ', ngay_dang_ky as N'Ngày đăng ký', cap_do as N'Cấp độ', hoat_dong as N'Hoạt động' from DOC_GIA where ho_ten like N'%{0}%'", name);
            return DataPovider.Instance.ExcuteQuery(query);
        }
        public static DataTable SearchingByMa(string madocgia)
        {
            string query = string.Format("select ma_doc_gia as N'Mã độc giả', ho_ten as N'Họ tên', cmnd as 'CMND', ngay_sinh as N'Ngày sinh', gioi_tinh as N'Giới tính', email as 'Email', dia_chi as N'Địa chỉ', ngay_dang_ky as N'Ngày đăng ký', cap_do as N'Cấp độ', hoat_dong as N'Hoạt động' from DOC_GIA where ma_doc_gia = '{0}'", madocgia);
            return DataPovider.Instance.ExcuteQuery(query);
        }
        public static DataTable SearchingByCMND(string cmnd)
        {
            string query = string.Format("select ma_doc_gia as N'Mã độc giả', ho_ten as N'Họ tên', cmnd as 'CMND', ngay_sinh as N'Ngày sinh', gioi_tinh as N'Giới tính', email as 'Email', dia_chi as N'Địa chỉ', ngay_dang_ky as N'Ngày đăng ký', cap_do as N'Cấp độ', hoat_dong as N'Hoạt động' from DOC_GIA where cmnd = '{0}'", cmnd);
            return DataPovider.Instance.ExcuteQuery(query);
        }
        public static int CamDocGia(string madocgia)
        {
            string query = string.Format("update DOC_GIA set hoat_dong = '{0}' where ma_doc_gia = '{1}'", "Không", madocgia);
            return DataPovider.Instance.ExcuteNonQuery(query);
        }
        public static bool kiemTraTrungCMND (string cmnd)
        {
            string query = string.Format("SELECT COUNT(cmnd) as count FROM DOC_GIA where cmnd = '{0}'", cmnd);
            if (DataPovider.Instance.ExcuteScalarInt(query) >= 1)
                return true;
            return false;
        }
        public static string LayCMNDtuMaDocGia(string madocgia)
        {
            string query = string.Format("SELECT cmnd FROM DOC_GIA where ma_doc_gia = '{0}'", madocgia);
            return DataPovider.Instance.ExcuteScalarString(query);
        }
    }
}
