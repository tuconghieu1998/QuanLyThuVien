using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyThuVien.DAO
{
    class CaiDat_DAO
    {
        public static int EditDataForKhuyenMai(string capdo, string phantram)
        {
            string query = string.Format("update KHUYEN_MAI set  phan_tram_khuyen_mai ='{0}' where cap_do = '{1}'", phantram, capdo);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        public static string LayTienPhatNgay()
        {
            string query = string.Format("SELECT tien_phat_moi_ngay FROM QUY_DINH where stt = '1'");
            return DataProvider.Instance.ExcuteScalarString(query);
        }
        public static string LayTienPhatTuan()
        {
            string query = string.Format("SELECT tien_phat_tren_mot_tuan FROM QUY_DINH where stt = '1'");
            return DataProvider.Instance.ExcuteScalarString(query);
        }
        public static string LayNgayMuonToiDa()
        {
            string query = string.Format("SELECT so_ngay_muon_toi_da FROM QUY_DINH where stt = '1'");
            return DataProvider.Instance.ExcuteScalarString(query);
        }
        public static int EditDataForTienPhat(string tienphatngay, string tienphattuan)
        {
            string query = string.Format("update QUY_DINH set  tien_phat_moi_ngay ='{0}', tien_phat_tren_mot_tuan = '{1}' where stt = '1'", tienphatngay, tienphattuan);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        public static int EditDataForNgayMuon(string ngaymuontoida)
        {
            string query = string.Format("update QUY_DINH set  so_ngay_muon_toi_da ='{0}' where stt = '1'", ngaymuontoida);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        public static int InsertDataForTheLoai(string ten_the_loai, string ma_sach_tuong_ung)
        {
            string query = string.Format("insert THE_LOAI (ten_the_loai,ma_sach_tuong_ung) values (N'{0}','{1}')", ten_the_loai, ma_sach_tuong_ung);
            return DataProvider.Instance.ExcuteNonQuery(query);
        }
        public static int LayPhanTramKhuyenMai(int capdo)
        {
            string capdos = string.Format("{0}", capdo);
            string query = string.Format("select phan_tram_khuyen_mai from KHUYEN_MAI where cap_do = '{0}'", capdos);
            return DataProvider.Instance.ExcuteScalarInt(query);
        }
    }
}
