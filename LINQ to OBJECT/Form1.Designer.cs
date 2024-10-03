namespace LINQ_to_OBJECT
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            this.label1 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtquantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtprice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtorigin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datetime = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtmaxprice = new System.Windows.Forms.TextBox();
            this.txtminprice = new System.Windows.Forms.TextBox();
            this.btnoutprice = new System.Windows.Forms.Button();
            this.btnoutdate = new System.Windows.Forms.Button();
            this.btnnhatban = new System.Windows.Forms.Button();
            this.btnmaprice = new System.Windows.Forms.Button();
            this.gvsearch = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btndeletedate = new System.Windows.Forms.Button();
            this.btndeleteall = new System.Windows.Forms.Button();
            this.btncheckdate = new System.Windows.Forms.Button();
            this.txtdeleteorigin = new System.Windows.Forms.TextBox();
            this.btndeleteid = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.gvproduct = new System.Windows.Forms.DataGridView();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvsearch)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvproduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(85, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(154, 16);
            label7.TabIndex = 12;
            label7.Text = "Nhập thông tin sản phẩm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(287, 0);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(154, 16);
            label8.TabIndex = 15;
            label8.Text = "Chọn chức năng tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SP";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(101, 31);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(200, 22);
            this.txtid.TabIndex = 1;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(101, 59);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(200, 22);
            this.txtname.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên SP";
            // 
            // txtquantity
            // 
            this.txtquantity.Location = new System.Drawing.Point(101, 87);
            this.txtquantity.Name = "txtquantity";
            this.txtquantity.Size = new System.Drawing.Size(200, 22);
            this.txtquantity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // txtprice
            // 
            this.txtprice.Location = new System.Drawing.Point(101, 118);
            this.txtprice.Name = "txtprice";
            this.txtprice.Size = new System.Drawing.Size(200, 22);
            this.txtprice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Đơn giá:";
            // 
            // txtorigin
            // 
            this.txtorigin.Location = new System.Drawing.Point(101, 146);
            this.txtorigin.Name = "txtorigin";
            this.txtorigin.Size = new System.Drawing.Size(200, 22);
            this.txtorigin.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Xuất xứ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Ngày hết hạn:";
            // 
            // datetime
            // 
            this.datetime.Location = new System.Drawing.Point(101, 177);
            this.datetime.Name = "datetime";
            this.datetime.Size = new System.Drawing.Size(200, 22);
            this.datetime.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.btndelete);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(label7);
            this.panel1.Controls.Add(this.datetime);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtorigin);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtprice);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtquantity);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 275);
            this.panel1.TabIndex = 12;
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(226, 219);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 23);
            this.btndelete.TabIndex = 14;
            this.btndelete.Text = "Xóa SP";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btnxoasp_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(101, 219);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(75, 23);
            this.btnsave.TabIndex = 13;
            this.btnsave.Text = "Lưu SP";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnluusp_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.txtmaxprice);
            this.panel2.Controls.Add(this.txtminprice);
            this.panel2.Controls.Add(this.btnoutprice);
            this.panel2.Controls.Add(this.btnoutdate);
            this.panel2.Controls.Add(this.btnnhatban);
            this.panel2.Controls.Add(this.btnmaprice);
            this.panel2.Controls.Add(this.gvsearch);
            this.panel2.Controls.Add(label8);
            this.panel2.Location = new System.Drawing.Point(352, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(692, 275);
            this.panel2.TabIndex = 13;
            // 
            // txtmaxprice
            // 
            this.txtmaxprice.Location = new System.Drawing.Point(616, 20);
            this.txtmaxprice.Multiline = true;
            this.txtmaxprice.Name = "txtmaxprice";
            this.txtmaxprice.Size = new System.Drawing.Size(52, 51);
            this.txtmaxprice.TabIndex = 22;
            // 
            // txtminprice
            // 
            this.txtminprice.Location = new System.Drawing.Point(543, 20);
            this.txtminprice.Multiline = true;
            this.txtminprice.Name = "txtminprice";
            this.txtminprice.Size = new System.Drawing.Size(52, 50);
            this.txtminprice.TabIndex = 21;
            // 
            // btnoutprice
            // 
            this.btnoutprice.Location = new System.Drawing.Point(415, 20);
            this.btnoutprice.Name = "btnoutprice";
            this.btnoutprice.Size = new System.Drawing.Size(89, 51);
            this.btnoutprice.TabIndex = 20;
            this.btnoutprice.Text = "Xuất các SP có ĐG [a..b]";
            this.btnoutprice.UseVisualStyleBackColor = true;
            this.btnoutprice.Click += new System.EventHandler(this.btnoutprice_Click);
            // 
            // btnoutdate
            // 
            this.btnoutdate.Location = new System.Drawing.Point(233, 20);
            this.btnoutdate.Name = "btnoutdate";
            this.btnoutdate.Size = new System.Drawing.Size(101, 51);
            this.btnoutdate.TabIndex = 19;
            this.btnoutdate.Text = "Xuất toàn bộ SP quá hạn";
            this.btnoutdate.UseVisualStyleBackColor = true;
            this.btnoutdate.Click += new System.EventHandler(this.btnoutdate_Click);
            // 
            // btnnhatban
            // 
            this.btnnhatban.Location = new System.Drawing.Point(130, 20);
            this.btnnhatban.Name = "btnnhatban";
            this.btnnhatban.Size = new System.Drawing.Size(88, 51);
            this.btnnhatban.TabIndex = 18;
            this.btnnhatban.Text = "1 SP từ Nhật Bản";
            this.btnnhatban.UseVisualStyleBackColor = true;
            this.btnnhatban.Click += new System.EventHandler(this.btnnhatban_Click);
            // 
            // btnmaprice
            // 
            this.btnmaprice.Location = new System.Drawing.Point(20, 20);
            this.btnmaprice.Name = "btnmaprice";
            this.btnmaprice.Size = new System.Drawing.Size(88, 51);
            this.btnmaprice.TabIndex = 17;
            this.btnmaprice.Text = "1 SP có ĐG cao nhất";
            this.btnmaprice.UseVisualStyleBackColor = true;
            this.btnmaprice.Click += new System.EventHandler(this.btnmaxgia_Click);
            // 
            // gvsearch
            // 
            this.gvsearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvsearch.Location = new System.Drawing.Point(3, 77);
            this.gvsearch.Name = "gvsearch";
            this.gvsearch.RowHeadersVisible = false;
            this.gvsearch.RowHeadersWidth = 51;
            this.gvsearch.RowTemplate.Height = 24;
            this.gvsearch.Size = new System.Drawing.Size(686, 195);
            this.gvsearch.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.btndeletedate);
            this.panel3.Controls.Add(this.btndeleteall);
            this.panel3.Controls.Add(this.btncheckdate);
            this.panel3.Controls.Add(this.txtdeleteorigin);
            this.panel3.Controls.Add(this.btndeleteid);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.gvproduct);
            this.panel3.Location = new System.Drawing.Point(12, 305);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1032, 334);
            this.panel3.TabIndex = 14;
            // 
            // btndeletedate
            // 
            this.btndeletedate.Location = new System.Drawing.Point(883, 220);
            this.btndeletedate.Name = "btndeletedate";
            this.btndeletedate.Size = new System.Drawing.Size(120, 51);
            this.btndeletedate.TabIndex = 26;
            this.btndeletedate.Text = "Xóa toàn bộ SP quá hạn";
            this.btndeletedate.UseVisualStyleBackColor = true;
            this.btndeletedate.Click += new System.EventHandler(this.btndeletedate_Click);
            // 
            // btndeleteall
            // 
            this.btndeleteall.Location = new System.Drawing.Point(743, 220);
            this.btndeleteall.Name = "btndeleteall";
            this.btndeleteall.Size = new System.Drawing.Size(120, 51);
            this.btndeleteall.TabIndex = 25;
            this.btndeleteall.Text = "Xóa toàn bộ SP trong kho";
            this.btndeleteall.UseVisualStyleBackColor = true;
            this.btndeleteall.Click += new System.EventHandler(this.btndeleteall_Click);
            // 
            // btncheckdate
            // 
            this.btncheckdate.Location = new System.Drawing.Point(743, 140);
            this.btncheckdate.Name = "btncheckdate";
            this.btncheckdate.Size = new System.Drawing.Size(265, 51);
            this.btncheckdate.TabIndex = 24;
            this.btncheckdate.Text = "Kiểm tra kho có SP quá hạn hay không ";
            this.btncheckdate.UseVisualStyleBackColor = true;
            this.btncheckdate.Click += new System.EventHandler(this.btncheckdate_Click);
            // 
            // txtdeleteorigin
            // 
            this.txtdeleteorigin.Location = new System.Drawing.Point(869, 68);
            this.txtdeleteorigin.Multiline = true;
            this.txtdeleteorigin.Name = "txtdeleteorigin";
            this.txtdeleteorigin.Size = new System.Drawing.Size(139, 51);
            this.txtdeleteorigin.TabIndex = 23;
            // 
            // btndeleteid
            // 
            this.btndeleteid.Location = new System.Drawing.Point(743, 68);
            this.btndeleteid.Name = "btndeleteid";
            this.btndeleteid.Size = new System.Drawing.Size(120, 51);
            this.btndeleteid.TabIndex = 23;
            this.btndeleteid.Text = "Xóa SP có xuất xứ bất kỳ:";
            this.btndeleteid.UseVisualStyleBackColor = true;
            this.btndeleteid.Click += new System.EventHandler(this.btndeleteid_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(835, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "Chọn thao tác";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(211, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Danh sách sản phẩm sau khi nhập";
            // 
            // gvproduct
            // 
            this.gvproduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvproduct.Location = new System.Drawing.Point(3, 21);
            this.gvproduct.Name = "gvproduct";
            this.gvproduct.RowHeadersVisible = false;
            this.gvproduct.RowHeadersWidth = 51;
            this.gvproduct.RowTemplate.Height = 24;
            this.gvproduct.Size = new System.Drawing.Size(686, 310);
            this.gvproduct.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1056, 651);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvsearch)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvproduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtquantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtprice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtorigin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datetime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnoutprice;
        private System.Windows.Forms.Button btnoutdate;
        private System.Windows.Forms.Button btnnhatban;
        private System.Windows.Forms.Button btnmaprice;
        private System.Windows.Forms.DataGridView gvsearch;
        private System.Windows.Forms.TextBox txtmaxprice;
        private System.Windows.Forms.TextBox txtminprice;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btncheckdate;
        private System.Windows.Forms.TextBox txtdeleteorigin;
        private System.Windows.Forms.Button btndeleteid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView gvproduct;
        private System.Windows.Forms.Button btndeletedate;
        private System.Windows.Forms.Button btndeleteall;
    }
}

