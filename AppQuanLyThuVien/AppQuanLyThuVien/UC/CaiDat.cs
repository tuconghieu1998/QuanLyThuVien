using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLyThuVien.DAO;

namespace AppQuanLyThuVien.UC
{
    public partial class CaiDat : UserControl
    {
        public CaiDat()
        {
            InitializeComponent();
            loadKhuyenMai();
            addBindingKhuyenMai();
            loadTienPhat();
            loadNgayMuonToiDa();
            loadTheLoai();
        }
        void loadKhuyenMai()
        {
            string query = "SELECT cap_do as N'Cấp độ', phan_tram_khuyen_mai as N'Phần trăm khuyến mãi' FROM KHUYEN_MAI";

            DataTable tabel = new DataTable();
            tabel = DAO.DataProvider.Instance.ExcuteQuery(query);
            dataGridViewDiscount.DataSource = tabel;
        }
        void loadTheLoai()
        {
            string query = "SELECT ma_the_loai as N'Mã thể loại', ten_the_loai as N'Tên thể loại', ma_sach_tuong_ung as N'Mã sách tương ứng' FROM THE_LOAI";

            DataTable tabel = new DataTable();
            tabel = DAO.DataProvider.Instance.ExcuteQuery(query);
            dataGridViewTheLoai.DataSource = tabel;
        }
        void loadTienPhat()
        {
            string tienPhatNgay = CaiDat_DAO.LayTienPhatNgay();
            tienPhatNgayText.Text = tienPhatNgay;
            string tienPhatTrenMotTuan = CaiDat_DAO.LayTienPhatTuan();
            tienPhatTuanText.Text = tienPhatTrenMotTuan;
        }
        void loadNgayMuonToiDa()
        {
            string ngayMuonToiDa = CaiDat_DAO.LayNgayMuonToiDa();
            NgayMuonToiDaText.Text = ngayMuonToiDa;
        }

        void addBindingKhuyenMai()
        {
           
            CapDoText.DataBindings.Add(new Binding("Text", dataGridViewDiscount.DataSource,"Cấp độ",true,DataSourceUpdateMode.Never));
            ptKhuyenMaiText.DataBindings.Add(new Binding("Text", dataGridViewDiscount.DataSource, "Phần trăm khuyến mãi", true, DataSourceUpdateMode.Never));
        }
        void clearBindingKhuyenMai()
        {
            CapDoText.DataBindings.Clear();
            ptKhuyenMaiText.DataBindings.Clear();
        }
        private void CaiDat_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = CaiDat_DAO.EditDataForTienPhat(tienPhatNgayText.Text, tienPhatTuanText.Text);
            if (result >= 1)
            {
                MessageBox.Show("Thay đổi tiền phạt thành công");
                loadTienPhat();
            }
        }

        private void ChangeDiscount_Click(object sender, EventArgs e)
        {
            int result = CaiDat_DAO.EditDataForKhuyenMai(CapDoText.Text, ptKhuyenMaiText.Text);
            if (result >= 1)
            {
                MessageBox.Show("Thay đổi khuyến mãi thành công");
                loadKhuyenMai();
                clearBindingKhuyenMai();
                addBindingKhuyenMai();
            }
        }

        private void ChangeNgayMuon_Click(object sender, EventArgs e)
        {
            int result = CaiDat_DAO.EditDataForNgayMuon(NgayMuonToiDaText.Text);
            if (result >= 1)
            {
                MessageBox.Show("Thay đổi ngày mượn tối đa thành công");
                loadNgayMuonToiDa();
        
            }
        }

        private void AddTheLoai_Click(object sender, EventArgs e)
        {
           int result = CaiDat_DAO.InsertDataForTheLoai(tenTheLoaiText.Text, maSachTuongUngText.Text);
            if (result >= 1)
            {
                MessageBox.Show("Thêm thể loại thành công");
                loadTheLoai();
            }
        }
    }
}
