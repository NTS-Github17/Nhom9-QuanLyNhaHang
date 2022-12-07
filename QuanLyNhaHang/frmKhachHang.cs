using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        public void LoadGrid()
        {
            string chuoiketnoi = @"Data Source=SYNGUYEN\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            string loadGrid = "select * from dbo.frmKhachHang";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            SqlDataAdapter da = new SqlDataAdapter(loadGrid, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            //string chuoiketnoi = @"Data Source=127.0.0.1;Initial Catalog=QuanLyNhaHang;Persist Security Info=True;User ID=sqlserver;Password=***********";
            string chuoiketnoi = @"Data Source=SYNGUYEN\SQLEXPRESS;Initial Catalog=QuanLyNhaHang;Integrated Security=True";
            SqlConnection conn = new SqlConnection(chuoiketnoi);
            string sqlThem = "insert into dbo.frmKhachHang values ('" + txt_MaKH.Text + "','" + txt_TenKH.Text + "','" + txt_DiaChiKH.Text + "','" + txt_Masothue.Text + "','" +  + "')";
            SqlCommand comm= new SqlCommand(sqlThem, conn);
            conn.Open();
            int kq=comm.ExecuteNonQuery();
            if (kq >= 1)
            {
                MessageBox.Show("Bạn đã thêm mới thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            conn.Close();
            LoadGrid();
        }
    }

}
