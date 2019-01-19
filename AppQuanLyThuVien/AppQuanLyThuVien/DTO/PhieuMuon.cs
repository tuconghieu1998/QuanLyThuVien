using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyThuVien.DTO
{
    public class PhieuMuon
    {
        private int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        private int userID;
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        private string bookID;
        public string BookID
        {
            get { return bookID; }
            set { bookID = value; }
        }

        private DateTime borrowDay;
        public DateTime BorrowDay
        {
            get { return borrowDay; }
            set { borrowDay = value; }
        }

        private DateTime returnDay;
        public DateTime ReturnDay
        {
            get { return returnDay; }
            set { returnDay = value; }
        }

        private int state;
        public int State
        {
            get { return state; }
            set { state = value; }
        }

        private int borrowCost;
        public int BorrowCost
        {
            get { return borrowCost; }
            set { borrowCost = value; }
        }

        private int disCount;
        public int DisCount
        {
            get { return disCount; }
            set { disCount = value; }
        }

        public PhieuMuon(int id, int userID, string bookID, DateTime borrowDay, DateTime returnDay, int state, int borrowCost, int disCount)
        {
            this.id = id;
            this.userID = userID;
            this.bookID = bookID;
            this.borrowDay = borrowDay;
            this.returnDay = returnDay;
            this.state = state;
            this.borrowCost = borrowCost;
            this.disCount = disCount;
        }

        public PhieuMuon(DataRow row)
        {
            this.id = int.Parse(row["ma_phieu_muon_sach"].ToString());
            this.userID = int.Parse(row["ma_doc_gia"].ToString());
            this.bookID = row["ma_sach"].ToString();
            this.borrowDay = (DateTime)row["ngay_muon"];    //dễ sai cần chú ý
            this.returnDay = (DateTime)row["ngay_du_dinh_tra"];    //dễ sai cần chú ý
            this.state = int.Parse(row["tinh_trang"].ToString());
            this.borrowCost = int.Parse(row["gia_muon"].ToString());
            this.disCount = int.Parse(row["discount"].ToString());
        }
    }
}
