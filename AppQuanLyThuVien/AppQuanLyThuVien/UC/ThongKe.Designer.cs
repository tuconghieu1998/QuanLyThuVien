namespace AppQuanLyThuVien.UC
{
    partial class ThongKe
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongKe));
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.datePickerNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgThongKeHoatDongTheoNgay = new System.Windows.Forms.DataGridView();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.Ngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSachMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongSachTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoanhThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongKeHoatDongTheoNgay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel15.Controls.Add(this.pictureBox1);
            this.panel15.Controls.Add(this.label1);
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(850, 46);
            this.panel15.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(173, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "THỐNG KÊ";
            // 
            // datePickerNgayBatDau
            // 
            this.datePickerNgayBatDau.Location = new System.Drawing.Point(128, 106);
            this.datePickerNgayBatDau.Name = "datePickerNgayBatDau";
            this.datePickerNgayBatDau.Size = new System.Drawing.Size(200, 20);
            this.datePickerNgayBatDau.TabIndex = 11;
            // 
            // datePickerNgayKetThuc
            // 
            this.datePickerNgayKetThuc.Location = new System.Drawing.Point(422, 106);
            this.datePickerNgayKetThuc.Name = "datePickerNgayKetThuc";
            this.datePickerNgayKetThuc.Size = new System.Drawing.Size(200, 20);
            this.datePickerNgayKetThuc.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Từ ngày:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Đến ngày:";
            // 
            // dtgThongKeHoatDongTheoNgay
            // 
            this.dtgThongKeHoatDongTheoNgay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgThongKeHoatDongTheoNgay.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ngay,
            this.SoLuongSachMuon,
            this.SoLuongSachTra,
            this.DoanhThu});
            this.dtgThongKeHoatDongTheoNgay.Location = new System.Drawing.Point(128, 158);
            this.dtgThongKeHoatDongTheoNgay.Name = "dtgThongKeHoatDongTheoNgay";
            this.dtgThongKeHoatDongTheoNgay.Size = new System.Drawing.Size(544, 325);
            this.dtgThongKeHoatDongTheoNgay.TabIndex = 16;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(652, 106);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(98, 23);
            this.btnThongKe.TabIndex = 17;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // Ngay
            // 
            this.Ngay.DataPropertyName = "ngay";
            this.Ngay.HeaderText = "Ngày";
            this.Ngay.Name = "Ngay";
            this.Ngay.Width = 150;
            // 
            // SoLuongSachMuon
            // 
            this.SoLuongSachMuon.DataPropertyName = "soLuongSachMuon";
            this.SoLuongSachMuon.HeaderText = "Số lượng sách mượn";
            this.SoLuongSachMuon.Name = "SoLuongSachMuon";
            this.SoLuongSachMuon.Width = 130;
            // 
            // SoLuongSachTra
            // 
            this.SoLuongSachTra.DataPropertyName = "soLuongSachTra";
            this.SoLuongSachTra.HeaderText = "Số lượng sách trả";
            this.SoLuongSachTra.Name = "SoLuongSachTra";
            this.SoLuongSachTra.Width = 120;
            // 
            // DoanhThu
            // 
            this.DoanhThu.DataPropertyName = "doanhThu";
            this.DoanhThu.HeaderText = "DoanhThu";
            this.DoanhThu.Name = "DoanhThu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(153, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(469, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Thống kê hoạt động của thư viện theo ngày";
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dtgThongKeHoatDongTheoNgay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datePickerNgayKetThuc);
            this.Controls.Add(this.datePickerNgayBatDau);
            this.Controls.Add(this.panel15);
            this.Name = "ThongKe";
            this.Size = new System.Drawing.Size(850, 500);
            this.Load += new System.EventHandler(this.ThongKe_Load);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgThongKeHoatDongTheoNgay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerNgayBatDau;
        private System.Windows.Forms.DateTimePicker datePickerNgayKetThuc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgThongKeHoatDongTheoNgay;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSachMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongSachTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn DoanhThu;
        private System.Windows.Forms.Label label4;
    }
}
