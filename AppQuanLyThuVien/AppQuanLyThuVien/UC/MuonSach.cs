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
    public partial class MuonSach : UserControl
    {
        public MuonSach()
        {
            InitializeComponent();
        }

        bool isBinding = false;

        private void MuonSach_Load(object sender, EventArgs e)
        {
            dtgPhieuMuon.DataSource = MuonSach_DAO.LoadTable();
        }
        int totalcost = 0;
        void connectData()
        {
            if (isBinding == false)
            {
                txtBorrowID.DataBindings.Add(new Binding("Text", dtgPhieuMuon.DataSource, "Mã phiếu mượn sách"));
                txtMemberID.DataBindings.Add(new Binding("Text", dtgPhieuMuon.DataSource, "Mã độc giả"));
                txtBookID.DataBindings.Add(new Binding("Text", dtgPhieuMuon.DataSource, "Mã sách"));
                dtpBorrow.DataBindings.Add(new Binding("Text", dtgPhieuMuon.DataSource, "Ngày mượn"));
                dtpReturn.DataBindings.Add(new Binding("Text", dtgPhieuMuon.DataSource, "Hạn trả"));
                txtDiscount.DataBindings.Add(new Binding("Text", dtgPhieuMuon.DataSource, "Chiết khấu"));
                txtCost.DataBindings.Add(new Binding("Text", dtgPhieuMuon.DataSource, "Giá mượn"));
                txtState.DataBindings.Add(new Binding("Text", dtgPhieuMuon.DataSource, "Tình trạng"));
                isBinding = true;
            }
        }

        void clearData()
        {
            if (isBinding == true)
            {
                txtBorrowID.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                txtBookID.DataBindings.Clear();
                dtpBorrow.DataBindings.Clear();
                dtpReturn.DataBindings.Clear();
                txtDiscount.DataBindings.Clear();
                txtCost.DataBindings.Clear();
                txtState.DataBindings.Clear();
                foreach (var item in checkedListBox1.Items)
                    checkedListBox1.Items.Remove(item);
                isBinding = false;
            }
        }
        bool isNotText(string s)
        {
            string[] temps = s.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(token => token.Trim())
                .ToArray();
            if (temps.Count() > 0)
                return false;
            return true;
        }

        bool canConvertToInt(string s)
        {
            string str = s;
            try
            {
                int temp = int.Parse(str);
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if(txtMemberID.Text == "")
            {
                MessageBox.Show("Nhập mã độc giả trước khi thêm sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtBookID.Text == "")
            {
                MessageBox.Show("Mã sách rỗng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string temp = txtBookID.Text;
            string madg = txtMemberID.Text;
            int money = int.Parse(MuonSach_DAO.borrowmoney(temp));
            int discount = MuonSach_DAO.discount(madg);
            int state = int.Parse(MuonSach_DAO.State(temp));
            if (!isNotText(temp) && MuonSach_DAO.CheckTheSameBookID(temp))
            {
                checkedListBox1.Items.Add(txtBookID.Text);
                totalcost = totalcost + money;
                txtCost.Text = totalcost.ToString();
                dtpBorrow.Value = DateTime.Now;
                dtpReturn.Value = dtpBorrow.Value.AddDays(int.Parse(CaiDat_DAO.LayNgayMuonToiDa()));
                txtState.Text = state.ToString();
                txtDiscount.Text = ((float)totalcost * discount / 100).ToString();
                txtCost.Text = (totalcost - int.Parse(txtDiscount.Text)).ToString();
            }
            else
            {
                MessageBox.Show("Sai mã sách");
            }
        }

        private void dtgPhieuMuon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            connectData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = "";
            string memberID = "";
            string bookID;
            string ngaymuon = dtpBorrow.Value.ToString("yyyy-MM-dd");
            string hantra = dtpReturn.Value.ToString("yyyy-MM-dd");
            string tinhtrang = txtState.Text;
            string giamuon;
            string discount;

            if (isNotText(txtBorrowID.Text) || !canConvertToInt(txtBorrowID.Text))
                MessageBox.Show("Mã phiếu mượn không hợp lệ");
            else
            {

                id = id + txtBorrowID.Text;
                if (isNotText(txtMemberID.Text) || !canConvertToInt(txtMemberID.Text))
                    MessageBox.Show("Mã độc giả không hợp lệ");
                else
                {
                    memberID = memberID + txtMemberID.Text;
                    foreach (var item in checkedListBox1.Items)
                    {
                        id = "" + (int.Parse(id) + 1).ToString();
                        bookID = item.ToString();
                        giamuon = MuonSach_DAO.borrowmoney(bookID);
                        discount = (MuonSach_DAO.discount(memberID)).ToString();
                        int kq = MuonSach_DAO.InsertData(memberID, id, bookID, ngaymuon, hantra, tinhtrang, giamuon, discount);

                        if (kq >= 1)
                        {
                            int quan = int.Parse(MuonSach_DAO.quantity(bookID));
                            MessageBox.Show("Thêm phiếu mượn thành công");
                            kq = MuonSach_DAO.decreaseremainbook(bookID, quan);


                        }
                    }
                    clearData();
                    connectData();
                }
            }

        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            txtBorrowID.Text = "";
            txtMemberID.Text = "";
            txtBookID.Text = "";
            dtpBorrow.Value = DateTime.Now;
            dtpReturn.Value = dtpBorrow.Value.AddDays(int.Parse(CaiDat_DAO.LayNgayMuonToiDa()));
            txtDiscount.Text = "";
            txtCost.Text = "";
            txtState.Text = "";
            checkedListBox1.Items.Clear();
        }



    }
}
