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
    public partial class TraSach : UserControl
    {
        public TraSach()
        {
            InitializeComponent();
        }

        bool isBinding = false;

        private void TraSach_Load(object sender, EventArgs e)
        {
            dtgv.DataSource = TraSach_DAO.LoadData();
        }

        void addBinding()
        {
            if (!isBinding)
            {

                txtMemberID.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Mã độc giả"));

                //lbBookID.Items.Add(new Binding("Text", dtgv.DataSource, "Mã độc giả"));

                txtBorrowID.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Mã phiếu mượn sách"));
                dtpBorrowday.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Ngày mượn"));

                dtpReturnday.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Ngày trả"));
                txtPunish.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Tiền phạt"));
                txtPoint.DataBindings.Add(new Binding("Text", dtgv.DataSource, "Điểm đánh giá"));
                isBinding = true;
            }
        }

        void clearBinding()
        {
            if (isBinding)
            {
                txtMemberID.DataBindings.Clear();
                lbBookID.DataBindings.Clear();
                txtBorrowID.DataBindings.Clear();
                dtpBorrowday.DataBindings.Clear();
                dtpReturnday.DataBindings.Clear();
                txtPunish.DataBindings.Clear();
                txtPoint.DataBindings.Clear();
                isBinding = false;
            }
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addBinding();
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

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (isNotText(txtMemberID.Text) || !TraSach_DAO.CheckMemberID(txtMemberID.Text))
                MessageBox.Show("Sai mã độc giả");
            else
            {
                DataTable dt = TraSach_DAO.bookIdUserKeep(txtMemberID.Text);

                foreach (DataRow item in dt.Rows)
                {
                    lbBookID.Items.Add(item["ma_sach"].ToString());
                }


            }
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

        private void lbBookID_SelectedValueChanged(object sender, EventArgs e)
        {
            string time = dtpBorrowday.Value.ToString();
            string bookID = lbBookID.SelectedItem.ToString();
            txtBorrowID.Text = TraSach_DAO.getID(txtMemberID.Text, bookID);
            string id = txtBorrowID.Text;

        }

        private void dtpBorrowday_ValueChanged(object sender, EventArgs e)
        {
            dtpReturnday.Value = DateTime.Now;
            if (txtBorrowID.Text == "" || txtMemberID.Text == "" || lbBookID.SelectedItem.ToString() == "")
                return;
            int d = TraSach_DAO.getExp(txtBorrowID.Text, txtMemberID.Text, lbBookID.SelectedItem.ToString());
            if (d < 0)
                txtPunish.Text = "0";
            if (d >= 0 && d <= 7)
            {
                txtPunish.Text = (int.Parse(CaiDat_DAO.LayTienPhatNgay()) * d).ToString();
            }
            if (d > 7)
            {
                txtPunish.Text = (int.Parse(CaiDat_DAO.LayTienPhatTuan()) * (float)d / 7).ToString();
            }
        }

        private void txtPoint_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = "";
            string memberID = "";
            string bookID;
            string ngaymuon = dtpBorrowday.Value.ToString("yyyy-MM-dd");
            string ngaytra = dtpReturnday.Value.ToString("yyyy-MM-dd");
            string tienphat;
            string point;
            if (isNotText(txtBorrowID.Text) || !canConvertToInt(txtBorrowID.Text))
            {
                MessageBox.Show("Mã độc giả không hợp lệ");
            }
            else
            {
                id = txtBorrowID.Text;
                memberID = txtMemberID.Text;
                bookID = lbBookID.SelectedItem.ToString();
                tienphat = txtPunish.Text;
                point = txtPoint.Text;
                int kq = TraSach_DAO.InsertData(memberID, id, bookID, ngaymuon, ngaytra, tienphat, point);
                if (kq >= 1)
                {
                    int quan = int.Parse(TraSach_DAO.quantity(bookID));
                    MessageBox.Show("Thêm phiếu trả thành công");
                    kq = TraSach_DAO.increaseremainbook(bookID, quan);


                }

            }


        }

        private void btnDestroy_Click(object sender, EventArgs e)
        {
            txtBorrowID.Text = "";
            txtMemberID.Text = "";
            lbBookID.Items.Clear();
            txtPoint.Text = "";
            txtPunish.Text = "";
            dtpReturnday.Value = DateTime.Now;
            dtpBorrowday.Refresh();
            clearBinding();



        }
    }
}
