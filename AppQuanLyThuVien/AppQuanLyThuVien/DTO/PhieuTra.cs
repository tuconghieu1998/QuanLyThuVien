using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppQuanLyThuVien.DTO
{
    class PhieuTra
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

        private float punish;
        public float Punish
        {
            get { return punish; }
            set { punish = value; }
        }

        private int point;
        public int Point
        {
            get { return point; }
            set { point = value; }
        }

        public PhieuTra(int id, int userID, string bookID, DateTime borrowDay, DateTime returnDay, float punish, int point)
        {
            this.id = id;
            this.userID = userID;
            this.bookID = bookID;
            this.borrowDay = borrowDay;
            this.returnDay = returnDay;
            this.punish = punish;
            this.point = point;
        }

        public PhieuTra(DataRow row)
        {
            this.id = int.Parse(row["ma_phieu_muon_sach"].ToString());
            this.userID = int.Parse(row["ma_doc_gia"].ToString());
            this.bookID = row["ma_sach"].ToString();
            this.borrowDay = (DateTime)row["ngay_muon"];    //dễ sai cần chú ý
            this.returnDay = (DateTime)row["ngay_tra"];    //dễ sai cần chú ý

            this.punish = float.Parse(row["tien_phat"].ToString());
            this.point = int.Parse(row["diem_danh_gia"].ToString());
        }
    }
}
