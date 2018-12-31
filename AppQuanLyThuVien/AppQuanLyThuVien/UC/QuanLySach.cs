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
using AppQuanLyThuVien.DTO;

namespace AppQuanLyThuVien.UC
{
    public partial class QuanLySach : UserControl
    {
        public QuanLySach()
        {
            InitializeComponent();
            
        }

        bool isBinding = false;

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            dtgDanhSachSach.DataSource = QuanLySach_DAO.LoadData(10);
            addBinding();
            setUpListComboBox();
        }

        void addBinding()
        {
            if (!isBinding)
            {
                txbTenSach.DataBindings.Add(new Binding("Text", dtgDanhSachSach.DataSource, "ten_sach"));
                txbTacGia.DataBindings.Add(new Binding("Text", dtgDanhSachSach.DataSource, "tac_gia"));
                txbNXB.DataBindings.Add(new Binding("Text", dtgDanhSachSach.DataSource, "nha_xuat_ban"));
                nGiaMuon.DataBindings.Add(new Binding("Text", dtgDanhSachSach.DataSource, "gia_muon"));
                nGiaSach.DataBindings.Add(new Binding("Text", dtgDanhSachSach.DataSource, "gia_sach"));
                nSoLuong.DataBindings.Add(new Binding("Text", dtgDanhSachSach.DataSource, "so_luong"));
                nNamXB.DataBindings.Add(new Binding("Text", dtgDanhSachSach.DataSource, "nam_xuat_ban"));
                cmbTheLoai.DataBindings.Add(new Binding("Text", dtgDanhSachSach.DataSource, "ten_the_loai"));
                txbMaSach.DataBindings.Add(new Binding("Text", dtgDanhSachSach.DataSource, "ma_sach"));
                isBinding = true;
            }
        }

        void clearBinding()
        {
            if (isBinding)
            {
                txbMaSach.DataBindings.Clear();
                txbTenSach.DataBindings.Clear();
                txbNXB.DataBindings.Clear();
                txbTacGia.DataBindings.Clear();
                nGiaMuon.DataBindings.Clear();
                nGiaSach.DataBindings.Clear();
                nNamXB.DataBindings.Clear();
                nSoLuong.DataBindings.Clear();
                cmbTheLoai.DataBindings.Clear();
                isBinding = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addBinding();
        }

        void setUpListComboBox()
        {
            List<ListTimKiemSach> list = new List<ListTimKiemSach>();
            list.Add(new ListTimKiemSach() { Id = 1, Name = "Theo mã sách" });
            list.Add(new ListTimKiemSach() { Id = 2, Name = "Theo tên sách" });
            list.Add(new ListTimKiemSach() { Id = 3, Name = "Theo thể loại" });
            list.Add(new ListTimKiemSach() { Id = 4, Name = "Theo tác giả" });
            cbSearchChoose.DataSource = list;
            cbSearchChoose.ValueMember = "id";
            cbSearchChoose.DisplayMember = "name";
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {

        }

        private void txbBookID_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDatLai_Click(object sender, EventArgs e)
        {
            clearBinding();
            txbMaSach.Clear();
            txbTenSach.Clear();
            txbNXB.Clear();
            txbTacGia.Clear();
            nGiaMuon.Value = 0;
            nGiaSach.Value = 0;
            nNamXB.Value = 2018;
            nSoLuong.Value = 1;
            cmbTheLoai.Text = "";
        }
    }
}
