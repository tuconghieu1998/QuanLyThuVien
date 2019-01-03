using AppQuanLyThuVien.DAO;
using AppQuanLyThuVien.DTO;
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
            setUpListComboBoxGioiTinh();
            setUpListComboBoxActive();
        }
        void loadData()
        {
           
            dataGridView.DataSource = Data.loadData();

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
        void setUpListComboBoxGioiTinh()
        {
            List<SearchList> list = new List<SearchList>();
            list.Add(new SearchList() { id = 1, name = "Nam" });
            list.Add(new SearchList() { id = 2, name = "Nữ" });
            comboBoxGioiTinh.DataSource = list;
            comboBoxGioiTinh.ValueMember = "id";
            comboBoxGioiTinh.DisplayMember = "name";
        }
        void setUpListComboBoxActive()
        {
            List<SearchList> list = new List<SearchList>();
            list.Add(new SearchList() { id = 1, name = "Có" });
            list.Add(new SearchList() { id = 2, name = "Không" });
            comboBoxActive.DataSource = list;
            comboBoxActive.ValueMember = "id";
            comboBoxActive.DisplayMember = "name";
        }
        void addBinding()
        {

            HoTen.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Họ tên",true,DataSourceUpdateMode.Never));
            Cmnd.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "CMND", true, DataSourceUpdateMode.Never));
            ngaySinh.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never));
            MaDocGia.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Mã độc giả", true, DataSourceUpdateMode.Never));
            comboBoxGioiTinh.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Giới tính", true, DataSourceUpdateMode.Never));
            Email.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Email", true, DataSourceUpdateMode.Never));
            diaChi.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never));
            ngayDangKy.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Ngày đăng ký", true, DataSourceUpdateMode.Never));
            capDo.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Cấp độ", true, DataSourceUpdateMode.Never));
            comboBoxActive.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "Hoạt động", true, DataSourceUpdateMode.Never));
        }
        void clearBinding()
        {
            HoTen.DataBindings.Clear();
            Cmnd.DataBindings.Clear();
            ngaySinh.DataBindings.Clear();
            MaDocGia.DataBindings.Clear();
            comboBoxGioiTinh.DataBindings.Clear();
            Email.DataBindings.Clear();
            diaChi.DataBindings.Clear();
            ngayDangKy.DataBindings.Clear();
            capDo.DataBindings.Clear();
            comboBoxActive.DataBindings.Clear();
        }
        bool LaTextBoxRong()
        {
            if (HoTen.Text == "" || Cmnd.Text == "" ||  Email.Text == "" || diaChi.Text == "" || capDo.Text == "")
                return true;
            return false;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            string ten = HoTen.Text;
            string cmnd = Cmnd.Text;
            int parsedValue;
            if (Data.kiemTraTrungCMND(cmnd))
            {
                MessageBox.Show("CMND đã tồn tại");
                return;
            }
            if (!int.TryParse(Cmnd.Text, out parsedValue))
            {
                MessageBox.Show("CMND không nhập chữ");

                return;
            }
            if (!int.TryParse(capDo.Text, out parsedValue) || parsedValue > 10 || parsedValue < 0)
            {
                MessageBox.Show("Cấp độ không nhập chữ,không được lớn hơn 10 và không là số âm");

                return;
            }
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(Email.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Email ko hợp lệ, ko đúng định dạng");
                return;
            }

            string ngaysinh = ngaySinh.Value.ToString("yyyy-MM-dd");
            //  string ngaysinh = "1999-1-1";
            string gioitinh = comboBoxGioiTinh.Text;
            string email = Email.Text;
            string diachi = diaChi.Text;
            string ngaydangky = DateTime.Now.ToString("yyyy-MM-dd");
            string capdo = capDo.Text;
            string hoatdong = comboBoxActive.Text;
            if (LaTextBoxRong())
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!");
                return;
            }
            int result = Data.InsertDataForDocGia(ten, cmnd, ngaysinh, gioitinh, email, diachi, ngaydangky, capdo,hoatdong);
            if (result >= 1)
            {
                MessageBox.Show("Thêm độc giả thành công");

                loadData();
                clearBinding();
                addBinding();
            }
        }

     

        

        

        private void Edit_Click_1(object sender, EventArgs e)
        {
            string ten = HoTen.Text;
            string cmnd = Cmnd.Text;
            string madocgia = MaDocGia.Text;
            int parsedValue;
            if (!int.TryParse(Cmnd.Text, out parsedValue))
            {
                MessageBox.Show("CMND không nhập chữ");

                return;
            }
            if(Data.LayCMNDtuMaDocGia(madocgia)== cmnd)
            {

            }
            else if (Data.kiemTraTrungCMND(cmnd))
            {
                MessageBox.Show("CMND đã tồn tại");
                return;
            }
            if (!int.TryParse(capDo.Text, out parsedValue) || parsedValue > 10 || parsedValue < 0)
            {
                MessageBox.Show("Cấp độ không nhập chữ,không được lớn hơn 10 và không là số âm");

                return;
            }
            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(Email.Text);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Email ko hợp lệ, ko đúng định dạng");
                return;
            }
            if (LaTextBoxRong())
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!");
                return;
            }
            string ngaysinh = ngaySinh.Value.ToString("yyyy-MM-dd");
            //  string ngaysinh = "1999-1-1";
            string gioitinh = comboBoxGioiTinh.Text;
            string email = Email.Text;
            string diachi = diaChi.Text;
            string ngaydangky = DateTime.Now.ToString("yyyy-MM-dd");
            string capdo = capDo.Text;
           
            string hoatdong = comboBoxActive.Text;
            int result = Data.EditDataForDocGia(ten, cmnd, ngaysinh, gioitinh, email, diachi, ngaydangky, capdo, madocgia,hoatdong);
            if (result >= 1)
            {
                MessageBox.Show("Sửa độc giả thành công");

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

        private void WatchButton_Click(object sender, EventArgs e)
        {
            loadData();
            clearBinding();
            addBinding();
        }

        private void eraser_Click(object sender, EventArgs e)
        {
            HoTen.Text = "";
            Cmnd.Text = "";
            Email.Text = "";
            diaChi.Text = "";
            capDo.Text = "";
        }

        private void CMNDTextChange(object sender, EventArgs e)
        {
            

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string madocgia = MaDocGia.Text;
            int i = Data.CamDocGia(madocgia);
            if (i == 1)
            {
                MessageBox.Show("Cấm độc giả thành công");
                loadData();
                clearBinding();
                addBinding();
            }
            else
            {
                MessageBox.Show("Cấm độc giả không thành công");
                loadData();
                clearBinding();
                addBinding();
            }
        }
    }
    

}
