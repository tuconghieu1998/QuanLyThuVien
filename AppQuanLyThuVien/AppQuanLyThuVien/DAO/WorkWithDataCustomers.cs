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

        public static int InsertDataForDocGia(string ten, string cmnd, string ngaysinh, string gioitinh, string email, string diachi, string ngaydangky, string capdo)
        {
            string query = string.Format("insert DOC_GIA (ho_ten,cmnd,ngay_sinh,gioi_tinh,email,dia_chi,ngay_dang_ky,cap_do) values (N'{0}','{1}',N'{2}',N'{3}',N'{4}',N'{5}','{6}','{7}')", ten, cmnd, ngaysinh, gioitinh, email, diachi, ngaydangky, capdo);
            return DataProvider.Instance.ExcuteNonQuery(query);

        }
        public static int EditDataForDocGia(string ten, string cmnd, string ngaysinh, string gioitinh, string email, string diachi, string ngaydangky, string capdo, string madocgia)
        {
            string query = string.Format("update DOC_GIA set ho_ten = N'{0}',cmnd = '{1}', ngay_sinh ='{2}',gioi_tinh = N'{3}', email = '{4}', dia_chi = N'{5}',ngay_dang_ky = '{6}', cap_do ='{7}' where ma_doc_gia = '{8}'", ten, cmnd, ngaysinh, gioitinh, email, diachi, ngaydangky, capdo, madocgia);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        public static DataTable SearchingByName(string name)
        {
            string query = string.Format("select * from DOC_GIA where ho_ten like N'%{0}%'", name);
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public static DataTable SearchingByMa(string madocgia)
        {
            string query = string.Format("select * from DOC_GIA where ma_doc_gia = '{0}'", madocgia);
            return DataProvider.Instance.ExcuteQuery(query);
        }
        public static DataTable SearchingByCMND(string cmnd)
        {
            string query = string.Format("select * from DOC_GIA where cmnd = '{0}'", cmnd);
            return DataProvider.Instance.ExcuteQuery(query);
        }
    }
}
