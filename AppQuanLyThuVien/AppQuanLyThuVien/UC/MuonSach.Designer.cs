namespace AppQuanLyThuVien.UC
{
    partial class MuonSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MuonSach));
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgPhieuMuon = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpReturn = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpBorrow = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBorrowID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuMuon)).BeginInit();
            this.panel3.SuspendLayout();
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
            this.pictureBox1.Location = new System.Drawing.Point(329, 0);
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
            this.label1.Size = new System.Drawing.Size(311, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO PHIẾU MƯỢN SÁCH";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnDestroy);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Location = new System.Drawing.Point(399, 433);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(448, 49);
            this.panel4.TabIndex = 12;
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(298, 13);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(80, 23);
            this.btnDestroy.TabIndex = 1;
            this.btnDestroy.Text = "Hủy";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 13);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgPhieuMuon);
            this.panel1.Location = new System.Drawing.Point(5, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 434);
            this.panel1.TabIndex = 13;
            // 
            // dtgPhieuMuon
            // 
            this.dtgPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPhieuMuon.Location = new System.Drawing.Point(4, -3);
            this.dtgPhieuMuon.Name = "dtgPhieuMuon";
            this.dtgPhieuMuon.Size = new System.Drawing.Size(381, 437);
            this.dtgPhieuMuon.TabIndex = 0;
            this.dtgPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgPhieuMuon_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtState);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtDiscount);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtCost);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dtpReturn);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.dtpBorrow);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.checkedListBox1);
            this.panel3.Controls.Add(this.btnAddBook);
            this.panel3.Controls.Add(this.txtBookID);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.txtMemberID);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtBorrowID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(399, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(448, 374);
            this.panel3.TabIndex = 11;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(277, 209);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(101, 20);
            this.txtState.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(210, 212);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Tình trạng:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(393, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "VND";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(277, 143);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(101, 20);
            this.txtDiscount.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 146);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Chiết khấu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(393, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "VND";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(277, 174);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(101, 20);
            this.txtCost.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(207, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tiền mượn:";
            // 
            // dtpReturn
            // 
            this.dtpReturn.CustomFormat = "yyyy/m/dd";
            this.dtpReturn.Location = new System.Drawing.Point(277, 109);
            this.dtpReturn.Name = "dtpReturn";
            this.dtpReturn.Size = new System.Drawing.Size(168, 20);
            this.dtpReturn.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Hạn trả:";
            // 
            // dtpBorrow
            // 
            this.dtpBorrow.CustomFormat = "yyyy/m/dd";
            this.dtpBorrow.Location = new System.Drawing.Point(277, 74);
            this.dtpBorrow.Name = "dtpBorrow";
            this.dtpBorrow.Size = new System.Drawing.Size(168, 20);
            this.dtpBorrow.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(207, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ngày mượn:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(18, 74);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(183, 289);
            this.checkedListBox1.TabIndex = 7;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(249, 42);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 6;
            this.btnAddBook.Text = "Thêm sách";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(101, 42);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(100, 20);
            this.txtBookID.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã cuốn sách:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(316, 9);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 20);
            this.txtMemberID.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã độc giả:";
            // 
            // txtBorrowID
            // 
            this.txtBorrowID.Location = new System.Drawing.Point(101, 9);
            this.txtBorrowID.Name = "txtBorrowID";
            this.txtBorrowID.Size = new System.Drawing.Size(100, 20);
            this.txtBorrowID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã phiếu mượn:";
            // 
            // MuonSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel15);
            this.Name = "MuonSach";
            this.Size = new System.Drawing.Size(850, 500);
            this.Load += new System.EventHandler(this.MuonSach_Load);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPhieuMuon)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgPhieuMuon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpReturn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpBorrow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBorrowID;
        private System.Windows.Forms.Label label2;
    }
}
