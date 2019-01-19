namespace AppQuanLyThuVien.UC
{
    partial class TraSach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraSach));
            this.panel15 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCheck = new System.Windows.Forms.Button();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnDestroy = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtPoint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPunish = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpReturnday = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBorrowID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpBorrowday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lbBookID = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.panel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel15.Controls.Add(this.pictureBox1);
            this.panel15.Controls.Add(this.label1);
            this.panel15.Location = new System.Drawing.Point(0, -1);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(850, 46);
            this.panel15.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(297, 0);
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
            this.label1.Size = new System.Drawing.Size(284, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "TẠO PHIẾU TRẢ SÁCH";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCheck);
            this.panel2.Controls.Add(this.txtMemberID);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtPoint);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtPunish);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dtpReturnday);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBorrowID);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.dtpBorrowday);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbBookID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 313);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(832, 183);
            this.panel2.TabIndex = 13;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(226, 9);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 16;
            this.btnCheck.Text = "Kiểm tra";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(100, 9);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(100, 20);
            this.txtMemberID.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnDestroy);
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Location = new System.Drawing.Point(655, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(174, 167);
            this.panel3.TabIndex = 14;
            // 
            // btnDestroy
            // 
            this.btnDestroy.Location = new System.Drawing.Point(59, 101);
            this.btnDestroy.Name = "btnDestroy";
            this.btnDestroy.Size = new System.Drawing.Size(75, 50);
            this.btnDestroy.TabIndex = 2;
            this.btnDestroy.Text = "Hủy";
            this.btnDestroy.UseVisualStyleBackColor = true;
            this.btnDestroy.Click += new System.EventHandler(this.btnDestroy_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 50);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtPoint
            // 
            this.txtPoint.Location = new System.Drawing.Point(449, 146);
            this.txtPoint.Name = "txtPoint";
            this.txtPoint.Size = new System.Drawing.Size(112, 20);
            this.txtPoint.TabIndex = 13;
            this.txtPoint.TextChanged += new System.EventHandler(this.txtPoint_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Điểm đánh giá:";
            // 
            // txtPunish
            // 
            this.txtPunish.Location = new System.Drawing.Point(449, 109);
            this.txtPunish.Name = "txtPunish";
            this.txtPunish.Size = new System.Drawing.Size(112, 20);
            this.txtPunish.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(360, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tiền phạt:";
            // 
            // dtpReturnday
            // 
            this.dtpReturnday.Location = new System.Drawing.Point(448, 74);
            this.dtpReturnday.Name = "dtpReturnday";
            this.dtpReturnday.Size = new System.Drawing.Size(200, 20);
            this.dtpReturnday.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Ngày trả:";
            // 
            // txtBorrowID
            // 
            this.txtBorrowID.Location = new System.Drawing.Point(448, 15);
            this.txtBorrowID.Name = "txtBorrowID";
            this.txtBorrowID.Size = new System.Drawing.Size(112, 20);
            this.txtBorrowID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(359, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mã phiếu mượn:";
            // 
            // dtpBorrowday
            // 
            this.dtpBorrowday.Location = new System.Drawing.Point(449, 43);
            this.dtpBorrowday.Name = "dtpBorrowday";
            this.dtpBorrowday.Size = new System.Drawing.Size(200, 20);
            this.dtpBorrowday.TabIndex = 5;
            this.dtpBorrowday.ValueChanged += new System.EventHandler(this.dtpBorrowday_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ngày mượn:";
            // 
            // lbBookID
            // 
            this.lbBookID.FormattingEnabled = true;
            this.lbBookID.Location = new System.Drawing.Point(100, 37);
            this.lbBookID.Name = "lbBookID";
            this.lbBookID.Size = new System.Drawing.Size(201, 134);
            this.lbBookID.TabIndex = 3;
            this.lbBookID.SelectedValueChanged += new System.EventHandler(this.lbBookID_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã sách mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã độc giả";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgv);
            this.panel1.Location = new System.Drawing.Point(3, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 255);
            this.panel1.TabIndex = 12;
            // 
            // dtgv
            // 
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(3, 3);
            this.dtgv.Name = "dtgv";
            this.dtgv.ReadOnly = true;
            this.dtgv.Size = new System.Drawing.Size(826, 244);
            this.dtgv.TabIndex = 0;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            // 
            // TraSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel15);
            this.Name = "TraSach";
            this.Size = new System.Drawing.Size(850, 500);
            this.Load += new System.EventHandler(this.TraSach_Load);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDestroy;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtPoint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPunish;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpReturnday;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBorrowID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpBorrowday;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbBookID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgv;
    }
}
