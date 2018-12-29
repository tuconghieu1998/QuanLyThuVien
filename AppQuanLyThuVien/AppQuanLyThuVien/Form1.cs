using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppQuanLyThuVien.UC;

namespace AppQuanLyThuVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnQuanLySach_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            QuanLySach uc = new QuanLySach();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnQuanLyDocGia_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            QuanLyDocGia uc = new QuanLyDocGia();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnTaoPhieuMuonSach_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            MuonSach uc = new MuonSach();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnTaoPhieuTraSach_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            TraSach uc = new TraSach();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            ThongKe uc = new ThongKe();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            CaiDat uc = new CaiDat();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }
    }
}
