namespace QuanLyNhaHang
{
    partial class frmKhachHang
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
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rad_CaNhan = new System.Windows.Forms.RadioButton();
            this.rad_DoanhNghiep = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_MaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_DiaChiKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaSoThue = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(56, 35);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 28);
            this.label8.TabIndex = 0;
            this.label8.Text = "Mã KH:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(52, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 28);
            this.label9.TabIndex = 2;
            this.label9.Text = "Tên KH:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(52, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "Địa Chỉ KH:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(534, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 28);
            this.label12.TabIndex = 9;
            this.label12.Text = "Mã Số Thuế:";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(60, 312);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(97, 38);
            this.btn_Them.TabIndex = 13;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(271, 313);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(81, 39);
            this.btn_Sua.TabIndex = 14;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(479, 313);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(83, 39);
            this.btn_Xoa.TabIndex = 15;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 373);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1122, 288);
            this.dataGridView1.TabIndex = 17;
            // 
            // rad_CaNhan
            // 
            this.rad_CaNhan.AutoSize = true;
            this.rad_CaNhan.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rad_CaNhan.ForeColor = System.Drawing.Color.White;
            this.rad_CaNhan.Location = new System.Drawing.Point(754, 33);
            this.rad_CaNhan.Name = "rad_CaNhan";
            this.rad_CaNhan.Size = new System.Drawing.Size(107, 32);
            this.rad_CaNhan.TabIndex = 5;
            this.rad_CaNhan.TabStop = true;
            this.rad_CaNhan.Text = "Cá Nhân";
            this.rad_CaNhan.UseVisualStyleBackColor = true;
            // 
            // rad_DoanhNghiep
            // 
            this.rad_DoanhNghiep.AutoSize = true;
            this.rad_DoanhNghiep.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.rad_DoanhNghiep.ForeColor = System.Drawing.Color.White;
            this.rad_DoanhNghiep.Location = new System.Drawing.Point(887, 33);
            this.rad_DoanhNghiep.Name = "rad_DoanhNghiep";
            this.rad_DoanhNghiep.Size = new System.Drawing.Size(161, 32);
            this.rad_DoanhNghiep.TabIndex = 6;
            this.rad_DoanhNghiep.TabStop = true;
            this.rad_DoanhNghiep.Text = "Doanh Nghiệp";
            this.rad_DoanhNghiep.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(534, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 28);
            this.label11.TabIndex = 7;
            this.label11.Text = "Loại Khách Hàng";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_MaKH.BorderRadius = 6;
            this.txt_MaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaKH.DefaultText = "";
            this.txt_MaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaKH.DisabledState.Parent = this.txt_MaKH;
            this.txt_MaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.txt_MaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaKH.FocusedState.Parent = this.txt_MaKH;
            this.txt_MaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaKH.HoverState.Parent = this.txt_MaKH;
            this.txt_MaKH.Location = new System.Drawing.Point(181, 21);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.PasswordChar = '\0';
            this.txt_MaKH.PlaceholderText = "";
            this.txt_MaKH.SelectedText = "";
            this.txt_MaKH.ShadowDecoration.Parent = this.txt_MaKH;
            this.txt_MaKH.Size = new System.Drawing.Size(247, 44);
            this.txt_MaKH.TabIndex = 18;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_TenKH.BorderRadius = 6;
            this.txt_TenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenKH.DefaultText = "";
            this.txt_TenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenKH.DisabledState.Parent = this.txt_TenKH;
            this.txt_TenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.txt_TenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenKH.FocusedState.Parent = this.txt_TenKH;
            this.txt_TenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenKH.HoverState.Parent = this.txt_TenKH;
            this.txt_TenKH.Location = new System.Drawing.Point(181, 88);
            this.txt_TenKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.PasswordChar = '\0';
            this.txt_TenKH.PlaceholderText = "";
            this.txt_TenKH.SelectedText = "";
            this.txt_TenKH.ShadowDecoration.Parent = this.txt_TenKH;
            this.txt_TenKH.Size = new System.Drawing.Size(247, 44);
            this.txt_TenKH.TabIndex = 20;
            // 
            // txt_DiaChiKH
            // 
            this.txt_DiaChiKH.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_DiaChiKH.BorderRadius = 6;
            this.txt_DiaChiKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiaChiKH.DefaultText = "";
            this.txt_DiaChiKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DiaChiKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DiaChiKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChiKH.DisabledState.Parent = this.txt_DiaChiKH;
            this.txt_DiaChiKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChiKH.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.txt_DiaChiKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChiKH.FocusedState.Parent = this.txt_DiaChiKH;
            this.txt_DiaChiKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChiKH.HoverState.Parent = this.txt_DiaChiKH;
            this.txt_DiaChiKH.Location = new System.Drawing.Point(181, 156);
            this.txt_DiaChiKH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DiaChiKH.Name = "txt_DiaChiKH";
            this.txt_DiaChiKH.PasswordChar = '\0';
            this.txt_DiaChiKH.PlaceholderText = "";
            this.txt_DiaChiKH.SelectedText = "";
            this.txt_DiaChiKH.ShadowDecoration.Parent = this.txt_DiaChiKH;
            this.txt_DiaChiKH.Size = new System.Drawing.Size(247, 44);
            this.txt_DiaChiKH.TabIndex = 21;
            // 
            // txt_MaSoThue
            // 
            this.txt_MaSoThue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.txt_MaSoThue.BorderRadius = 6;
            this.txt_MaSoThue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaSoThue.DefaultText = "";
            this.txt_MaSoThue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaSoThue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaSoThue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaSoThue.DisabledState.Parent = this.txt_MaSoThue;
            this.txt_MaSoThue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaSoThue.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.txt_MaSoThue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaSoThue.FocusedState.Parent = this.txt_MaSoThue;
            this.txt_MaSoThue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaSoThue.HoverState.Parent = this.txt_MaSoThue;
            this.txt_MaSoThue.Location = new System.Drawing.Point(740, 117);
            this.txt_MaSoThue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MaSoThue.Name = "txt_MaSoThue";
            this.txt_MaSoThue.PasswordChar = '\0';
            this.txt_MaSoThue.PlaceholderText = "";
            this.txt_MaSoThue.SelectedText = "";
            this.txt_MaSoThue.ShadowDecoration.Parent = this.txt_MaSoThue;
            this.txt_MaSoThue.Size = new System.Drawing.Size(247, 44);
            this.txt_MaSoThue.TabIndex = 22;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(153)))), ((int)(((byte)(149)))));
            this.guna2TextBox1.BorderRadius = 6;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(754, 306);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(294, 44);
            this.guna2TextBox1.TabIndex = 23;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(353, 248);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(180, 45);
            this.guna2Button1.TabIndex = 24;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // frmKhachHang
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))));
            this.ClientSize = new System.Drawing.Size(1148, 674);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.txt_MaSoThue);
            this.Controls.Add(this.txt_DiaChiKH);
            this.Controls.Add(this.txt_TenKH);
            this.Controls.Add(this.txt_MaKH);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Sua);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.rad_DoanhNghiep);
            this.Controls.Add(this.rad_CaNhan);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Name = "frmKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rad_CaNhan;
        private System.Windows.Forms.RadioButton rad_DoanhNghiep;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaKH;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenKH;
        private Guna.UI2.WinForms.Guna2TextBox txt_DiaChiKH;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaSoThue;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

