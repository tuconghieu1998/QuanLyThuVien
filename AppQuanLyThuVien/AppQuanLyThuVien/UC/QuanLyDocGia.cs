using LB.DAO;
using LB.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLyThuVien.UC
{
    public partial class QuanLyDocGia : UserControl
    {
        public QuanLyDocGia()
        {
            InitializeComponent();
            loadData();
            addBinding();
            setUpListComboBox();
        }
        void loadData()
        {
            string query = "SELECT * FROM DOC_GIA";

            DataTable tabel = new DataTable();
            tabel = DataPovider.Instance.ExcuteQuery(query);
            dataGridView.DataSource = tabel;

        }
        void setUpListComboBox()
        {
            List<SearchList> list = new List<SearchList>();
            list.Add(new SearchList() { id = 1, name = "Theo Tên" });
            list.Add(new SearchList() { id = 2, name = "Theo Mã Độc Giả" });
            list.Add(new SearchList() { id = 3, name = "Theo CMND" });
            comboBoxType.DataSource = list;
            comboBoxType.ValueMember = "id";
            comboBoxType.DisplayMember = "name";
        }
        void addBinding()
        {

            HoTen.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "ho_ten"));
            Cmnd.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "cmnd"));
            ngaySinh.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "ngay_sinh"));
            MaDocGia.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "ma_doc_gia"));
            gioiTinh.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "gioi_tinh"));
            Email.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "email"));
            diaChi.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "dia_chi"));
            ngayDangKy.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "ngay_dang_ky"));
            capDo.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "cap_do"));
        }
        void clearBinding()
        {
            HoTen.DataBindings.Clear();
            Cmnd.DataBindings.Clear();
            ngaySinh.DataBindings.Clear();
            MaDocGia.DataBindings.Clear();
            gioiTinh.DataBindings.Clear();
            Email.DataBindings.Clear();
            diaChi.DataBindings.Clear();
            ngayDangKy.DataBindings.Clear();
            capDo.DataBindings.Clear();

        }
        bool LaTextBoxRong()
        {
            if (HoTen.Text == "" || Cmnd.Text == "" || gioiTinh.Text == "" || Email.Text == "" || diaChi.Text == "" || capDo.Text == "")
                return true;
            return false;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            string ten = HoTen.Text;
            string cmnd = Cmnd.Text;
            string ngaysinh = ngaySinh.Value.ToString("yyyy-MM-dd");
            //  string ngaysinh = "1999-1-1";
            string gioitinh = gioiTinh.Text;
            string email = Email.Text;
            string diachi = diaChi.Text;
            string ngaydangky = DateTime.Now.ToString("yyyy-MM-dd");
            string capdo = capDo.Text;
            if (LaTextBoxRong())
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!");
                return;
            }
            int result = Data.InsertDataForDocGia(ten, cmnd, ngaysinh, gioitinh, email, diachi, ngaydangky, capdo);
            if (result >= 1)
            {
                MessageBox.Show("Them doc gia thanh cong");

                loadData();
                clearBinding();
                addBinding();
            }
        }

     

        

        private void CMNDTextChange(object sender, EventArgs e)
        {
            //      if (Cmnd.Text.i)
        }

        private void Edit_Click_1(object sender, EventArgs e)
        {
            string ten = HoTen.Text;
            string cmnd = Cmnd.Text;
            string ngaysinh = ngaySinh.Value.ToString("yyyy-MM-dd");
            //  string ngaysinh = "1999-1-1";
            string gioitinh = gioiTinh.Text;
            string email = Email.Text;
            string diachi = diaChi.Text;
            string ngaydangky = DateTime.Now.ToString("yyyy-MM-dd");
            string capdo = capDo.Text;
            string madocgia = MaDocGia.Text;

            int result = Data.EditDataForDocGia(ten, cmnd, ngaysinh, gioitinh, email, diachi, ngaydangky, capdo, madocgia);
            if (result >= 1)
            {
                MessageBox.Show("Sua Doc Gia Thanh Cong");

                loadData();
                clearBinding();
                addBinding();
            }
        }

        private void Search_Click_1(object sender, EventArgs e)
        {
            int id = (comboBoxType.SelectedItem as SearchList).id;
            if (id == 1)
            {
                string name = SearchKey.Text;
                dataGridView.DataSource = Data.SearchingByName(name);
                clearBinding();
                addBinding();
            }
            if (id == 2)
            {
             
                string madocgia = SearchKey.Text;
                dataGridView.DataSource = Data.SearchingByMa(madocgia);
                clearBinding();
                addBinding();
            }
            if (id == 3)
            {
                string cmnd = SearchKey.Text;
                dataGridView.DataSource = Data.SearchingByCMND(cmnd);
                clearBinding();
                addBinding();
            }
        }

        private void ChangeKeySearch(object sender, EventArgs e)
        {
            Search_Click_1(sender, e);
        }
    }
    

}
