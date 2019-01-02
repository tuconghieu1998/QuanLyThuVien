namespace AppQuanLyThuVien.UC
{
    partial class CaiDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaiDat));
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChangeTienPhat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewDiscount = new System.Windows.Forms.DataGridView();
            this.tienPhatNgayText = new System.Windows.Forms.TextBox();
            this.tienPhatTuanText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CapDoText = new System.Windows.Forms.TextBox();
            this.ptKhuyenMaiText = new System.Windows.Forms.TextBox();
            this.ChangeDiscount = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.NgayMuonToiDaText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridViewTheLoai = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.tenTheLoaiText = new System.Windows.Forms.TextBox();
            this.AddTheLoai = new System.Windows.Forms.Button();
            this.ChangeNgayMuon = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.maSachTuongUngText = new System.Windows.Forms.TextBox();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel15.Controls.Add(this.pictureBox1);
            this.panel15.Controls.Add(this.label1);
            this.panel15.Location = new System.Drawing.Point(0, 0);
            this.panel15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1275, 71);
            this.panel15.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(195, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 71);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "CÀI ĐẶT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tiền phạt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mỗi ngày:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Trên một tuần:";
            // 
            // ChangeTienPhat
            // 
            this.ChangeTienPhat.Location = new System.Drawing.Point(91, 238);
            this.ChangeTienPhat.Name = "ChangeTienPhat";
            this.ChangeTienPhat.Size = new System.Drawing.Size(92, 35);
            this.ChangeTienPhat.TabIndex = 14;
            this.ChangeTienPhat.Text = "Thay đổi";
            this.ChangeTienPhat.UseVisualStyleBackColor = true;
            this.ChangeTienPhat.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(272, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(165, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "Khuyến mãi";
            // 
            // dataGridViewDiscount
            // 
            this.dataGridViewDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDiscount.Location = new System.Drawing.Point(278, 151);
            this.dataGridViewDiscount.Name = "dataGridViewDiscount";
            this.dataGridViewDiscount.RowTemplate.Height = 28;
            this.dataGridViewDiscount.Size = new System.Drawing.Size(396, 456);
            this.dataGridViewDiscount.TabIndex = 16;
            // 
            // tienPhatNgayText
            // 
            this.tienPhatNgayText.Location = new System.Drawing.Point(151, 145);
            this.tienPhatNgayText.Name = "tienPhatNgayText";
            this.tienPhatNgayText.Size = new System.Drawing.Size(100, 26);
            this.tienPhatNgayText.TabIndex = 17;
            // 
            // tienPhatTuanText
            // 
            this.tienPhatTuanText.Location = new System.Drawing.Point(151, 192);
            this.tienPhatTuanText.Name = "tienPhatTuanText";
            this.tienPhatTuanText.Size = new System.Drawing.Size(100, 26);
            this.tienPhatTuanText.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 631);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Cấp độ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 672);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Phần trăm khuyến mãi:";
            // 
            // CapDoText
            // 
            this.CapDoText.Location = new System.Drawing.Point(373, 625);
            this.CapDoText.Name = "CapDoText";
            this.CapDoText.ReadOnly = true;
            this.CapDoText.Size = new System.Drawing.Size(174, 26);
            this.CapDoText.TabIndex = 21;
            // 
            // ptKhuyenMaiText
            // 
            this.ptKhuyenMaiText.Location = new System.Drawing.Point(479, 666);
            this.ptKhuyenMaiText.Name = "ptKhuyenMaiText";
            this.ptKhuyenMaiText.Size = new System.Drawing.Size(54, 26);
            this.ptKhuyenMaiText.TabIndex = 22;
            // 
            // ChangeDiscount
            // 
            this.ChangeDiscount.Location = new System.Drawing.Point(373, 709);
            this.ChangeDiscount.Name = "ChangeDiscount";
            this.ChangeDiscount.Size = new System.Drawing.Size(92, 35);
            this.ChangeDiscount.TabIndex = 23;
            this.ChangeDiscount.Text = "Thay đổi";
            this.ChangeDiscount.UseVisualStyleBackColor = true;
            this.ChangeDiscount.Click += new System.EventHandler(this.ChangeDiscount_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(873, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(250, 32);
            this.label9.TabIndex = 24;
            this.label9.Text = "Số ngày cho mượn";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(884, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Số lượng:";
            // 
            // NgayMuonToiDaText
            // 
            this.NgayMuonToiDaText.Location = new System.Drawing.Point(967, 139);
            this.NgayMuonToiDaText.Name = "NgayMuonToiDaText";
            this.NgayMuonToiDaText.Size = new System.Drawing.Size(79, 26);
            this.NgayMuonToiDaText.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(716, 251);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 32);
            this.label11.TabIndex = 27;
            this.label11.Text = "Thể loại";
            // 
            // dataGridViewTheLoai
            // 
            this.dataGridViewTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTheLoai.Location = new System.Drawing.Point(723, 300);
            this.dataGridViewTheLoai.Name = "dataGridViewTheLoai";
            this.dataGridViewTheLoai.RowTemplate.Height = 28;
            this.dataGridViewTheLoai.Size = new System.Drawing.Size(549, 307);
            this.dataGridViewTheLoai.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(719, 631);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 20);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tên thể loại:";
            // 
            // tenTheLoaiText
            // 
            this.tenTheLoaiText.Location = new System.Drawing.Point(873, 625);
            this.tenTheLoaiText.Name = "tenTheLoaiText";
            this.tenTheLoaiText.Size = new System.Drawing.Size(143, 26);
            this.tenTheLoaiText.TabIndex = 30;
            // 
            // AddTheLoai
            // 
            this.AddTheLoai.Location = new System.Drawing.Point(824, 709);
            this.AddTheLoai.Name = "AddTheLoai";
            this.AddTheLoai.Size = new System.Drawing.Size(92, 35);
            this.AddTheLoai.TabIndex = 31;
            this.AddTheLoai.Text = "Thêm";
            this.AddTheLoai.UseVisualStyleBackColor = true;
            this.AddTheLoai.Click += new System.EventHandler(this.AddTheLoai_Click);
            // 
            // ChangeNgayMuon
            // 
            this.ChangeNgayMuon.Location = new System.Drawing.Point(945, 183);
            this.ChangeNgayMuon.Name = "ChangeNgayMuon";
            this.ChangeNgayMuon.Size = new System.Drawing.Size(92, 35);
            this.ChangeNgayMuon.TabIndex = 32;
            this.ChangeNgayMuon.Text = "Thay đổi";
            this.ChangeNgayMuon.UseVisualStyleBackColor = true;
            this.ChangeNgayMuon.Click += new System.EventHandler(this.ChangeNgayMuon_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1052, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "ngày";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(254, 148);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 20);
            this.label13.TabIndex = 34;
            this.label13.Text = "đ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(254, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 20);
            this.label14.TabIndex = 35;
            this.label14.Text = "đ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(536, 669);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 20);
            this.label15.TabIndex = 36;
            this.label15.Text = "%";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(718, 669);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 20);
            this.label16.TabIndex = 37;
            this.label16.Text = "Mã sách tương ứng:";
            // 
            // maSachTuongUngText
            // 
            this.maSachTuongUngText.Location = new System.Drawing.Point(873, 666);
            this.maSachTuongUngText.Name = "maSachTuongUngText";
            this.maSachTuongUngText.Size = new System.Drawing.Size(143, 26);
            this.maSachTuongUngText.TabIndex = 38;
            // 
            // CaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.maSachTuongUngText);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ChangeNgayMuon);
            this.Controls.Add(this.AddTheLoai);
            this.Controls.Add(this.tenTheLoaiText);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridViewTheLoai);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.NgayMuonToiDaText);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ChangeDiscount);
            this.Controls.Add(this.ptKhuyenMaiText);
            this.Controls.Add(this.CapDoText);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tienPhatTuanText);
            this.Controls.Add(this.tienPhatNgayText);
            this.Controls.Add(this.dataGridViewDiscount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ChangeTienPhat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel15);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CaiDat";
            this.Size = new System.Drawing.Size(1275, 769);
            this.Load += new System.EventHandler(this.CaiDat_Load);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ChangeTienPhat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridViewDiscount;
        private System.Windows.Forms.TextBox tienPhatNgayText;
        private System.Windows.Forms.TextBox tienPhatTuanText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox CapDoText;
        private System.Windows.Forms.TextBox ptKhuyenMaiText;
        private System.Windows.Forms.Button ChangeDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox NgayMuonToiDaText;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewTheLoai;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tenTheLoaiText;
        private System.Windows.Forms.Button AddTheLoai;
        private System.Windows.Forms.Button ChangeNgayMuon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox maSachTuongUngText;
    }
}
