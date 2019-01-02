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
            setUpListCMBLoaiTimKiem();
            setUpListCMBTheLoaiSach();
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

        void setUpListCMBLoaiTimKiem()
        {
            List<ListTimKiemSach> list = new List<ListTimKiemSach>();
            list.Add(new ListTimKiemSach() { Id = 1, Name = "Theo mã sách" });
            list.Add(new ListTimKiemSach() { Id = 2, Name = "Theo tên sách" });
            list.Add(new ListTimKiemSach() { Id = 3, Name = "Theo thể loại" });
            list.Add(new ListTimKiemSach() { Id = 4, Name = "Theo tác giả" });
            cmbSearchChoose.DataSource = list;
            cmbSearchChoose.ValueMember = "id";
            cmbSearchChoose.DisplayMember = "name";
        }

        void setUpListCMBTheLoaiSach()
        {
            List<TheLoaiSach> list = QuanLySach_DAO.LayDanhSachTheLoai();
            cmbTheLoai.DataSource = list;
            cmbTheLoai.ValueMember = "maTheLoai";
            cmbTheLoai.ValueMember = "maSachTuongUng";
            cmbTheLoai.DisplayMember = "tenTheLoai";
        }

        private void btnThemSach_Click(object sender, EventArgs e)
        {
            Sach sach = new Sach();
            sach.TenSach = txbTenSach.Text;
            sach.NhaXuatBan = txbNXB.Text;
            sach.TenTacGia = txbTacGia.Text;
            sach.GiaMuon = float.Parse(nGiaMuon.Value.ToString());
            sach.GiaSach = float.Parse(nGiaSach.Value.ToString());
            sach.NamXuatBan = int.Parse(nNamXB.Value.ToString());
            sach.SoLuong = int.Parse(nSoLuong.Value.ToString());
            sach.TheLoai = (cmbTheLoai.SelectedItem as TheLoaiSach).MaTheLoai;
            if (QuanLySach_DAO.KiemTraTrungSach(sach))
            {
                DialogResult close = new DialogResult();
                string str = "Sách " + sach.TenSach + " đã có trong dữ liệu.\n Bạn có muốn cập nhập thêm không?";
                close = MessageBox.Show(str, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (close == DialogResult.OK)
                {
                    return;
                }
                else if (close == DialogResult.Cancel)
                {
                    return;
                }
            }
            QuanLySach_DAO.TaoMaSach(sach, QuanLySach_DAO.LayDanhSachTheLoai());
            int result = QuanLySach_DAO.ThemSach(sach);
            if (result >= 1)
            {
                MessageBox.Show("Thêm sách thành công");
                dtgDanhSachSach.DataSource = QuanLySach_DAO.TimKiemSachTheoMaSach(sach.MaSach);

                clearBinding();
                addBinding();
            }
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

        private void cmbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void cmbTimKiem_TextChanged(object sender, EventArgs e)
        {
            int id = (cmbSearchChoose.SelectedItem as ListTimKiemSach).Id;
            if (id == 1)
            {
                List<string> list = QuanLySach_DAO.TimKiemSachTheoMaSach_LayMaSach(cmbTimKiem.Text);
                foreach (string item in list)
                    cmbTimKiem.AutoCompleteCustomSource.Add(item);
            }
            else if (id == 2)
            {
                List<string> list = QuanLySach_DAO.TimKiemSachTheoTen_LayTen(cmbTimKiem.Text);
                foreach (string item in list)
                    cmbTimKiem.AutoCompleteCustomSource.Add(item);
            }
            else if (id == 3)
            {
                List<string> list = QuanLySach_DAO.TimKiemSachTheoTheLoai_LayTheLoai(cmbTimKiem.Text);
                foreach (string item in list)
                    cmbTimKiem.AutoCompleteCustomSource.Add(item);
            }
            else
            {
                List<string> list = QuanLySach_DAO.TimKiemSachTheoTacGia_LayTacGia(cmbTimKiem.Text);
                foreach (string item in list)
                    cmbTimKiem.AutoCompleteCustomSource.Add(item);
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            int id = (cmbSearchChoose.SelectedItem as ListTimKiemSach).Id;
            if (id == 1)
            {
                string str = cmbTimKiem.Text;
                dtgDanhSachSach.DataSource = QuanLySach_DAO.TimKiemSachTheoMaSach(str);
            }
            else if (id == 2)
            {
                string str = cmbTimKiem.Text;
                dtgDanhSachSach.DataSource = QuanLySach_DAO.TimKiemSachTheoTen(str);
            }
            else if (id == 3)
            {
                string str = cmbTimKiem.Text;
                dtgDanhSachSach.DataSource = QuanLySach_DAO.TimKiemSachTheoTheLoai(str);
            }
            else
            {
                string str = cmbTimKiem.Text;
                dtgDanhSachSach.DataSource = QuanLySach_DAO.TimKiemSachTheoTacGia(str);
            }
            
            clearBinding();
            addBinding();
        }
        private void cmbTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem.PerformClick();
            }
        }
    }
}
